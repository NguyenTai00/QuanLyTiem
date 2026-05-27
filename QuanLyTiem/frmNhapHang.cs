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
            cheDo = 1; // QUAN TRỌNG: Thiết lập chế độ Thêm mới
            DieuKhienNhapLieu(true); // Mở khóa các ô nhập
            XoaTrangO(); // Xóa sạch dữ liệu cũ trong ô
            cboNhaCungCap.Focus();
        }

      
        private void btnGhiPhieu_Click(object sender, EventArgs e)
        {
            if (cboNhaCungCap.SelectedValue == null || cboNguyenLieu.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin!");
                return;
            }

            try
            {
                // 1. Lấy dữ liệu chung
                int idNCC = Convert.ToInt32(cboNhaCungCap.SelectedValue);
                int idNL = Convert.ToInt32(cboNguyenLieu.SelectedValue);
                float sl = (float)nmSoLuong.Value;
                string giaText = System.Text.RegularExpressions.Regex.Replace(txtGiaNhap.Text, @"[^0-9]", "");
                float gia = float.Parse(giaText);

                // 2. Kiểm tra chế độ
                if (cheDo == 1) // --- CHẾ ĐỘ THÊM MỚI ---
                {
                    // Bước A: Tạo phiếu mới
                    int idPhieuMoi = PhieuNhapDAO.Instance.InsertPhieuNhap(idNCC, loginAccount.IDNhanVien);
                    // Bước B: Lưu chi tiết
                    PhieuNhapDAO.Instance.InsertChiTiet(idPhieuMoi, idNL, sl, gia);
                    // Bước C: Cập nhật tổng tiền phiếu
                    PhieuNhapDAO.Instance.CapNhatTongTien(idPhieuMoi, sl * gia);
                    // Bước D: Cộng kho
                    NguyenLieuDAO.Instance.CongKho(idNL, sl);

                    MessageBox.Show("Đã thêm phiếu nhập mới thành công!");
                }
                else if (cheDo == 2) // --- CHẾ ĐỘ SỬA ---
                {
                    if (dgvChiTietNhap.CurrentRow != null)
                    {
                        int idPhieu = (int)dgvChiTietNhap.CurrentRow.Cells["Mã Phiếu"].Value;
                        // Hàm UpdateChiTiet này đã bao gồm: Sửa kho, Sửa tiền, Sửa chi tiết (như Bước 1 SQL tôi đã đưa)
                        PhieuNhapDAO.Instance.UpdateChiTiet(idPhieu, idNL, sl, gia);

                        MessageBox.Show("Đã cập nhật phiếu thành công!");
                    }
                }

                // 3. Sau khi Ghi xong (Dù Thêm hay Sửa)
                LoadLichSu(); // Tải lại bảng để thấy dữ liệu mới nhất
                DieuKhienNhapLieu(false); // Khóa các ô lại
                cheDo = 0; // Reset về trạng thái chờ
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
            if (dgvChiTietNhap.CurrentRow == null) return;

            cheDo = 2; // QUAN TRỌNG: Thiết lập chế độ Sửa
            DieuKhienNhapLieu(true); // Mở khóa các ô
            cboNguyenLieu.Enabled = false; // Thường không cho sửa nguyên liệu, chỉ cho sửa SL và Giá

            // Đưa dữ liệu lên ô nhập
            DataGridViewRow row = dgvChiTietNhap.CurrentRow;
            cboNhaCungCap.Text = row.Cells["Nhà Cung Cấp"].Value.ToString();
            cboNguyenLieu.Text = row.Cells["Tên Nguyên Liệu"].Value.ToString();
            nmSoLuong.Value = Convert.ToDecimal(row.Cells["SL"].Value);
            txtGiaNhap.Text = row.Cells["Đơn Giá"].Value.ToString();
        }
    }
}
