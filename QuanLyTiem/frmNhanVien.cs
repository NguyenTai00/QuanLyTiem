using QuanLyTiem.Dao;
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
    public partial class frmNhanVien : Form
    {
        
        int cheDo = 0;

        public frmNhanVien()
        {
            InitializeComponent();
            TaiDuLieu();        
            TrangThaiBanDau();
        }

        void TrangThaiBanDau()
        {
            txtHoTen.Enabled = txtDienThoai.Enabled = txtDiaChi.Enabled = false; // Khóa các ô
            btnGhi.Enabled = btnHuyGhi.Enabled = false;
            btnThemMoi.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
        }

        void TrangThaiNhapLieu()
        {
            txtHoTen.Enabled = txtDienThoai.Enabled = txtDiaChi.Enabled = true; // Mở các ô
            btnGhi.Enabled = btnHuyGhi.Enabled = true;
            btnThemMoi.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
        }

        void TaiDuLieu()
        {
            dgvNhanVien.DataSource = NhanVienDAO.Instance.LayDanhSachNhanVien();
            // Chỉnh độ rộng cột cho đẹp
            if (dgvNhanVien.Columns.Count > 0)
            {
                dgvNhanVien.Columns["HoTen"].HeaderText = "Họ và tên";
                dgvNhanVien.Columns["DienThoai"].HeaderText = "Điện thoại";
               dgvNhanVien.Columns["DiaChi"].HeaderText = "Địa chỉ";
                dgvNhanVien.Columns["MoTa"].HeaderText = "Mô tả";
            }
        }

        // 1. Hàm bật/tắt các TextBox và RadioButton nhập liệu
        void ChoPhepNhapLieu(bool b)
        {
            txtHoTen.Enabled = b;
            dtpNgaySinh.Enabled = b;
            rdoNam.Enabled = rdoNu.Enabled = b;
            txtDienThoai.Enabled = b;
            txtEmail.Enabled = b;
            txtDiaChi.Enabled = b;
            dtpNgayVaoLam.Enabled = b;
            txtMoTa.Enabled = b;
        }

        // 2. Hàm xóa trắng các ô nhập liệu
        void XoaTrang()
        {
            txtHoTen.Clear();
            txtDienThoai.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtMoTa.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            rdoNam.Checked = true;
        }

        // 3. Hàm điều khiển trạng thái các nút bấm
        void ThietLapNut(bool b)
        {
            btnThemMoi.Enabled = b;
            btnSua.Enabled = b;
            btnXoa.Enabled = b;
            btnKetThuc.Enabled = b;

            btnGhi.Enabled = !b; // Nút Ghi ngược lại với nút Thêm
            btnHuyGhi.Enabled = !b;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhanVien.CurrentRow != null && cheDo == 0) // Chỉ hiện khi đang ở chế độ xem
            {
                DataGridViewRow row = dgvNhanVien.CurrentRow;
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtDienThoai.Text = row.Cells["DienThoai"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value.ToString();

                // Xử lý ngày tháng
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);

                // Xử lý giới tính
                if (row.Cells["GioiTinh"].Value.ToString() == "Nam") rdoNam.Checked = true;
                else rdoNu.Checked = true;
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            string ten = txtHoTen.Text;
            string gt = rdoNam.Checked ? "Nam" : "Nữ";

            if (cheDo == 1) // Lệnh Thêm
            {
                NhanVienDAO.Instance.ThemNhanVien(ten, dtpNgaySinh.Value, gt, txtDienThoai.Text, txtEmail.Text, txtDiaChi.Text, dtpNgayVaoLam.Value, txtMoTa.Text);
            }
            else if (cheDo == 2) // Lệnh Sửa
            {
                int id = int.Parse(dgvNhanVien.CurrentRow.Cells["ID"].Value.ToString());
                NhanVienDAO.Instance.SuaNhanVien(id, ten, dtpNgaySinh.Value, gt, txtDienThoai.Text, txtEmail.Text, txtDiaChi.Text, dtpNgayVaoLam.Value, txtMoTa.Text);
            }

            TaiDuLieu();
            ChoPhepNhapLieu(false);
            ThietLapNut(true);
            cheDo = 0;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            cheDo = 1; // Thiết lập đang ở chế độ Thêm
            XoaTrang(); // Xóa trắng các ô
            ChoPhepNhapLieu(true); // Mở khóa các ô cho nhập
            ThietLapNut(false); // Mờ nút Thêm/Sửa/Xóa, hiện nút Ghi/Hủy
            txtHoTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null) return;
            cheDo = 2; // Chế độ Sửa
            ChoPhepNhapLieu(true);
            ThietLapNut(false);
        }

        private void btnHuyGhi_Click(object sender, EventArgs e)
        {
            cheDo = 0;
            ChoPhepNhapLieu(false);
            ThietLapNut(true);
            // Load lại dữ liệu dòng hiện tại để xóa các ký tự đang nhập dở
            dgvNhanVien_CellClick(null, null);
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text;
            string loai = rdoTimTheoTen.Checked ? "Ten" : "SDT";

            // Gọi hàm tìm kiếm đã viết ở Bước 1
            dgvNhanVien.DataSource = NhanVienDAO.Instance.TimKiemNhanVien(tuKhoa, loai);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng đã chọn dòng nào trên bảng chưa
            if (dgvNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên muốn xóa trên bảng!", "Thông báo");
                return;
            }

            // 2. Lấy ID và Tên của nhân viên để hiển thị thông báo xác nhận
            int id = int.Parse(dgvNhanVien.CurrentRow.Cells["ID"].Value.ToString());
            string ten = dgvNhanVien.CurrentRow.Cells["HoTen"].Value.ToString();

            // 3. Hiển thị hộp thoại xác nhận (đúng quy chuẩn đồ án)
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa nhân viên [" + ten + "] không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // 4. Nếu người dùng chọn YES
            if (result == DialogResult.Yes)
            {
                if (NhanVienDAO.Instance.XoaNhanVien(id))
                {
                    MessageBox.Show("Đã xóa nhân viên thành công!", "Thông báo");
                    TaiDuLieu(); // Tải lại bảng để cập nhật danh sách mới
                    XoaTrang();  // Xóa trắng các ô nhập liệu sau khi xóa thành công
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, không thể xóa nhân viên này!", "Lỗi");
                }
            }
        }
    }
}
