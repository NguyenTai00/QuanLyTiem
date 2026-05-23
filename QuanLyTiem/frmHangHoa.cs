using QuanLyTiem.Dao;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyTiem
{
    public partial class frmHangHoa : Form
    {
        int cheDo = 0; // 0: Xem, 1: Thêm, 2: Sửa

        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
            ChoPhepNhapLieu(false);
            ThietLapNut(true);
        }

        void TaiDuLieu()
        {
            // Gọi hàm từ lớp DAO của bạn
            dgvHangHoa.DataSource = HangHoaDAO.Instance.LayDanhSachHangHoa();

            // Đổi tên cột hiển thị an toàn chống lỗi NullReference
            if (dgvHangHoa.Columns.Count > 0)
            {
                if (dgvHangHoa.Columns["ID"] != null) dgvHangHoa.Columns["ID"].Visible = false;
                if (dgvHangHoa.Columns["TenHang"] != null) dgvHangHoa.Columns["TenHang"].HeaderText = "Tên mặt hàng";
                if (dgvHangHoa.Columns["DonViTinh"] != null) dgvHangHoa.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
                if (dgvHangHoa.Columns["GiaBan"] != null) dgvHangHoa.Columns["GiaBan"].HeaderText = "Giá bán";
                if (dgvHangHoa.Columns["SoLuongTon"] != null) dgvHangHoa.Columns["SoLuongTon"].HeaderText = "Số lượng tồn";
            }
        }

        void ChoPhepNhapLieu(bool b)
        {
            txtTenHang.Enabled = txtDonViTinh.Enabled = txtGiaBan.Enabled = txtSoLuongTon.Enabled = b;
        }

        void ThietLapNut(bool b)
        {
            btnThemMoi.Enabled = b;
            btnSua.Enabled = b;
            btnXoa.Enabled = b;
            btnKetThuc.Enabled = b;

            btnGhi.Enabled = !b;
            btnHuyGhi.Enabled = !b;
        }

        void XoaTrang()
        {
            txtTenHang.Clear();
            txtDonViTinh.Clear();
            txtGiaBan.Text = "0";
            txtSoLuongTon.Text = "0";
        }

        void HienThiDongHienTai()
        {
            if (dgvHangHoa.CurrentRow != null)
            {
                txtTenHang.Text = dgvHangHoa.CurrentRow.Cells["TenHang"].Value?.ToString() ?? "";
                txtDonViTinh.Text = dgvHangHoa.CurrentRow.Cells["DonViTinh"].Value?.ToString() ?? "";
                txtGiaBan.Text = dgvHangHoa.CurrentRow.Cells["GiaBan"].Value?.ToString() ?? "0";
                txtSoLuongTon.Text = dgvHangHoa.CurrentRow.Cells["SoLuongTon"].Value?.ToString() ?? "0";
            }
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cheDo == 0)
            {
                HienThiDongHienTai();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            cheDo = 1;
            XoaTrang();
            ThietLapNut(false);
            ChoPhepNhapLieu(true);
            txtTenHang.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvHangHoa.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hàng hóa cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cheDo = 2;
            ThietLapNut(false);
            ChoPhepNhapLieu(true);
            txtTenHang.Focus();
        }

        private void btnHuyGhi_Click(object sender, EventArgs e)
        {
            cheDo = 0;
            ThietLapNut(true);
            ChoPhepNhapLieu(false);
            HienThiDongHienTai();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            string ten = txtTenHang.Text.Trim();
            string dvt = txtDonViTinh.Text.Trim();

            double gia = 0;
            double.TryParse(txtGiaBan.Text.Trim(), out gia);

            int soLuong = 0;
            int.TryParse(txtSoLuongTon.Text.Trim(), out soLuong);

            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Tên hàng hóa không được để trống!", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHang.Focus();
                return;
            }

            bool thanhCong = false;

            if (cheDo == 1)
            {
                thanhCong = HangHoaDAO.Instance.ThemHangHoa(ten, dvt, gia, soLuong);
            }
            else if (cheDo == 2)
            {
                if (dgvHangHoa.CurrentRow == null || !dgvHangHoa.Columns.Contains("ID")) return;
                int id = int.Parse(dgvHangHoa.CurrentRow.Cells["ID"].Value.ToString());
                thanhCong = HangHoaDAO.Instance.SuaHangHoa(id, ten, dvt, gia, soLuong);
            }

            if (thanhCong)
            {
                MessageBox.Show("Lưu thông tin hàng hóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiDuLieu();
                ChoPhepNhapLieu(false);
                ThietLapNut(true);
                cheDo = 0;
            }
            else
            {
                MessageBox.Show("Lỗi hệ thống! Không thể lưu dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHangHoa.CurrentRow == null || !dgvHangHoa.Columns.Contains("ID")) return;

            string ten = dgvHangHoa.CurrentRow.Cells["TenHang"].Value?.ToString() ?? "";
            if (MessageBox.Show("Bạn chắc chắn muốn xóa mặt hàng [" + ten + "] không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = int.Parse(dgvHangHoa.CurrentRow.Cells["ID"].Value.ToString());
                if (HangHoaDAO.Instance.XoaHangHoa(id))
                {
                    TaiDuLieu();
                    XoaTrang();
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string loai = rdoTenHang.Checked ? "Ten" : "DVT";
            dgvHangHoa.DataSource = HangHoaDAO.Instance.TimKiemHangHoa(txtTimKiem.Text.Trim(), loai);
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}