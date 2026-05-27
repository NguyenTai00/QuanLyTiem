using QuanLyTiem.Dao;
using QuanLyTiem.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiem
{
    public partial class frmNhapHang : Form
    {
        int cheDo = 0; // 0: Xem, 1: Thêm, 2: Sửa
        private AccountDTO loginAccount;
        private DataTable dtItems = new DataTable(); // Bảng tạm lưu danh sách đang nhập
       
        public frmNhapHang(AccountDTO acc)
        {
            InitializeComponent();
            this.loginAccount = acc;

            // 2. PHẢI CÓ HÀM NÀY ĐỂ TẠO CÁC CỘT
            KhoiTaoForm();


        }

        // Hàm điều khiển trạng thái các nút và ô nhập
       

      

        void KhoiTaoForm()
        {
            txtNhanVien.Text = loginAccount.DisplayName;
            txtNhanVien.ReadOnly = true;

            // Nạp dữ liệu ComboBox
            cboNhaCungCap.DataSource = NhaCungCapDAO.Instance.LayDanhSachNCC();
            cboNhaCungCap.DisplayMember = "TenNCC";
            cboNhaCungCap.ValueMember = "ID";

            cboNguyenLieu.DataSource = NguyenLieuDAO.Instance.LayDanhSachNL();
            cboNguyenLieu.DisplayMember = "TenNL";
            cboNguyenLieu.ValueMember = "ID";

            // Khởi tạo bảng tạm
            dtItems.Columns.Add("ID", typeof(int));
            dtItems.Columns.Add("TenNL", typeof(string));
            dtItems.Columns.Add("SoLuong", typeof(float));
            dtItems.Columns.Add("GiaNhap", typeof(float));
            dtItems.Columns.Add("ThanhTien", typeof(float), "SoLuong * GiaNhap");

            dgvChiTietNhap.DataSource = dtItems;
            dgvChiTietNhap.Columns["ID"].Visible = false;

            SetState(false);
        }
        void SetState(bool editing)
        {
            // Nút Thêm luôn sáng. Nút Ghi/Hủy chỉ sáng khi có dữ liệu trong bảng tạm
            btnGhi.Enabled = (dtItems.Rows.Count > 0);
            btnHuy.Enabled = (dtItems.Rows.Count > 0);
        }

        void TinhTongTienPhieu()
        {
            double total = 0;
            foreach (DataRow row in dtItems.Rows)
                total += Convert.ToDouble(row["ThanhTien"]);
            txtTongTien.Text = total.ToString("N0") + "đ";
        }

        // Hàm điều khiển: b = true là đang nhập, b = false là trạng thái chờ
        void DieuKhienNhapLieu(bool b)
        {
            // Khóa/Mở các ô nhập
            cboNhaCungCap.Enabled = b;
            cboNguyenLieu.Enabled = b;
            nmSoLuong.Enabled = b;
            txtGiaNhap.Enabled = b;

            // Điều khiển nút bấm
            btnThem.Enabled = !b; // Đang nhập thì nút Thêm mờ đi
            btnGhi.Enabled = b;  // Đang nhập thì nút Ghi mới sáng
            btnHuy.Enabled = b;  // Nút Hủy sáng khi đang nhập
        }

        void XoaTrangO()
        {
            nmSoLuong.Value = 1;
            txtGiaNhap.Clear();
        }
        void LoadLichSu()
        {
            // Đảm bảo dgvChiTietNhap nhận dữ liệu từ DAO
            dgvChiTietNhap.DataSource = PhieuNhapDAO.Instance.LayToanBoLichSuNhap();
            if (dgvChiTietNhap.Columns.Count > 0)
            {
                dgvChiTietNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        void LoadNhaCungCap()
        {
            // Lấy dữ liệu từ DAO
            DataTable dt = NhaCungCapDAO.Instance.LayDanhSachNCC();
            cboNhaCungCap.DataSource = dt;
            cboNhaCungCap.DisplayMember = "TenNCC"; // Tên hiển thị trên ComboBox
            cboNhaCungCap.ValueMember = "ID";      // Giá trị mã số ẩn bên dưới
        }

        // 2. Hàm nạp danh sách Nguyên liệu vào ComboBox
        void LoadNguyenLieu()
        {
            // Lấy dữ liệu từ DAO
            DataTable dt = NguyenLieuDAO.Instance.LayDanhSachNL();
            cboNguyenLieu.DataSource = dt;
            cboNguyenLieu.DisplayMember = "TenNL"; // Tên hiển thị
            cboNguyenLieu.ValueMember = "ID";      // Giá trị mã số
        }


        private void btnThemMon_Click(object sender, EventArgs e)
        {
            DieuKhienNhapLieu(true); // Mở khóa các ô
            XoaTrangO();            // Xóa trắng dữ liệu cũ
            cboNhaCungCap.Focus();  // Đưa con trỏ vào ô đầu tiên
        }

      
        private void btnGhiPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Lấy mã số từ ComboBox
                int idNCC = Convert.ToInt32(cboNhaCungCap.SelectedValue);
                int idNL = Convert.ToInt32(cboNguyenLieu.SelectedValue);
                float sl = (float)nmSoLuong.Value;

                // Lấy giá và lọc bỏ ký tự lạ
                string giaText = System.Text.RegularExpressions.Regex.Replace(txtGiaNhap.Text, @"[^0-9]", "");
                float gia = float.Parse(giaText);

                // 2. Gọi DAO thực hiện lưu (Dùng ID thực của nhân viên)
                int idPhieuMoi = PhieuNhapDAO.Instance.InsertPhieuNhap(idNCC, loginAccount.IDNhanVien);

                PhieuNhapDAO.Instance.InsertChiTiet(idPhieuMoi, idNL, sl, gia);

                PhieuNhapDAO.Instance.CapNhatTongTien(idPhieuMoi, sl * gia);

                // 3. Cập nhật kho
                NguyenLieuDAO.Instance.CongKho(idNL, sl);

                MessageBox.Show("Ghi thành công phiếu số: " + idPhieuMoi);

                // 4. HIỂN THỊ LẠI BẢNG (Để không bị trống)
                LoadLichSu();
                DieuKhienNhapLieu(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DieuKhienNhapLieu(false); // Khóa lại hết
            XoaTrangO();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            LoadNhaCungCap();
            LoadNguyenLieu();
            LoadLichSu(); // Phải có dòng này để khi mở lên nó hiện lịch sử cũ
            DieuKhienNhapLieu(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
}
