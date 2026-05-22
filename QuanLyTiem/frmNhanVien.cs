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

        private int trangThaiHienTai = 0;

        public frmNhanVien()
        {
            InitializeComponent();
            LoadBangDuLieu();
            DieuChinhGiaoDien(0); 
        }


        private void DieuChinhGiaoDien(int mode)
        {
            trangThaiHienTai = mode;

           
            bool dangChinhSua = (mode != 0);

           
            txtHoTen.Enabled = dangChinhSua;
            dtpNgaySinh.Enabled = dangChinhSua;
            rdoNam.Enabled = rdoNu.Enabled = dangChinhSua;
            txtDienThoai.Enabled = dangChinhSua;
            txtEmail.Enabled = dangChinhSua;
            txtDiaChi.Enabled = dangChinhSua;
            dtpNgayVaoLam.Enabled = dangChinhSua;
            txtMoTa.Enabled = dangChinhSua;

           
            btnThemMoi.Enabled = !dangChinhSua;
            btnSua.Enabled = !dangChinhSua;
            btnXoa.Enabled = !dangChinhSua;
            btnKetThuc.Enabled = !dangChinhSua;

            btnGhi.Enabled = dangChinhSua;
            btnHuyGhi.Enabled = dangChinhSua;
        }

        private void LoadBangDuLieu()
        {
            dgvNhanVien.DataSource = NhanVienDAO.Instance.LayDanhSachNhanVien();
            if (dgvNhanVien.Columns.Count > 0)
            {
                dgvNhanVien.Columns["ID"].Visible = false; // Ẩn ID cho đẹp
                dgvNhanVien.Columns["HoTen"].HeaderText = "Họ và tên";
                dgvNhanVien.Columns["DienThoai"].HeaderText = "Số điện thoại";
            }
        }

        private void XoaTrangForm()
        {
            txtHoTen.Clear();
            txtDienThoai.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtMoTa.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            rdoNam.Checked = true;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvNhanVien.CurrentRow != null && trangThaiHienTai == 0)
            {
                DataGridViewRow dongHienTai = dgvNhanVien.CurrentRow;

                txtHoTen.Text = dongHienTai.Cells["HoTen"].Value.ToString();
                txtDienThoai.Text = dongHienTai.Cells["DienThoai"].Value.ToString();
                txtEmail.Text = dongHienTai.Cells["Email"].Value.ToString();
                txtDiaChi.Text = dongHienTai.Cells["DiaChi"].Value.ToString();
                txtMoTa.Text = dongHienTai.Cells["MoTa"].Value.ToString();

               
                var giaTriNgay = dongHienTai.Cells["NgaySinh"].Value;
                dtpNgaySinh.Value = (giaTriNgay == DBNull.Value) ? DateTime.Now : Convert.ToDateTime(giaTriNgay);

                if (dongHienTai.Cells["GioiTinh"].Value.ToString() == "Nam") rdoNam.Checked = true;
                else rdoNu.Checked = true;
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";

            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng không để trống họ tên!");
                return;
            }

            if (trangThaiHienTai == 1) 
            {
                NhanVienDAO.Instance.ThemNhanVien(hoTen, dtpNgaySinh.Value, gioiTinh, txtDienThoai.Text, txtEmail.Text, txtDiaChi.Text, dtpNgayVaoLam.Value, txtMoTa.Text);
            }
            else if (trangThaiHienTai == 2) 
            {
                int maSo = int.Parse(dgvNhanVien.CurrentRow.Cells["ID"].Value.ToString());
                NhanVienDAO.Instance.SuaNhanVien(maSo, hoTen, dtpNgaySinh.Value, gioiTinh, txtDienThoai.Text, txtEmail.Text, txtDiaChi.Text, dtpNgayVaoLam.Value, txtMoTa.Text);
            }

            LoadBangDuLieu();
            DieuChinhGiaoDien(0);
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            XoaTrangForm();
            DieuChinhGiaoDien(1); 
            txtHoTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null) return;
            DieuChinhGiaoDien(2); 
        }

        private void btnHuyGhi_Click(object sender, EventArgs e)
        {
            DieuChinhGiaoDien(0); 
            dgvNhanVien_CellClick(null, null); 
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string kieuTim = rdoTimTheoTen.Checked ? "Ten" : "SDT";
            dgvNhanVien.DataSource = NhanVienDAO.Instance.TimKiemNhanVien(txtTimKiem.Text, kieuTim);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (dgvNhanVien.CurrentRow == null) return;

            int maSo = int.Parse(dgvNhanVien.CurrentRow.Cells["ID"].Value.ToString());
            string ten = dgvNhanVien.CurrentRow.Cells["HoTen"].Value.ToString();

            if (MessageBox.Show($"Bạn có thực sự muốn xóa nhân viên {ten}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (NhanVienDAO.Instance.XoaNhanVien(maSo))
                {
                    LoadBangDuLieu();
                    XoaTrangForm();
                }
            }
        }
    }
}
