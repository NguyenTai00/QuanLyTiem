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
    public partial class frmNhaCungCap : Form
    {

        int cheDo = 0; // 0: Xem, 1: Thêm, 2: Sửa

        public frmNhaCungCap()
        {
            InitializeComponent();
            TaiDuLieu();
            ChoPhepNhapLieu(false);
            ThietLapNut(true);
           
        }

        void TaiDuLieu()
        {
            dgvNCC.DataSource = NhaCungCapDAO.Instance.LayDanhSachNCC();
            // Đổi tên cột hiển thị cho đẹp
            if (dgvNCC.Columns.Count > 0)
            {
                dgvNCC.Columns["ID"].Visible = false; // Ẩn cột ID
                dgvNCC.Columns["TenNCC"].HeaderText = "Tên nhà cung cấp";
                dgvNCC.Columns["DiaChi"].HeaderText = "Địa chỉ";
                dgvNCC.Columns["DienThoai"].HeaderText = "Điện thoại";
                dgvNCC.Columns["Email"].HeaderText = "Email";
            }
        }

        void ChoPhepNhapLieu(bool b)
        {
            txtTenNCC.Enabled = txtDiaChi.Enabled = txtDienThoai.Enabled = txtEmail.Enabled = b;
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
            txtTenNCC.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            txtEmail.Clear();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            cheDo = 1;      
            XoaTrang();     
            ThietLapNut(false); 
            ChoPhepNhapLieu(true);
            txtTenNCC.Focus();  

        }

        private void btnHuyGhi_Click(object sender, EventArgs e)
        {
            cheDo = 0;
            ThietLapNut(true);
            dgvNCC_CellClick(null, null); 
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            string ten = txtTenNCC.Text.Trim();
            string dc = txtDiaChi.Text.Trim();
            string sdt = txtDienThoai.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Tên nhà cung cấp không được để trống!");
                return;
            }

            bool thanhCong = false;

            if (cheDo == 1) 
            {
                thanhCong = NhaCungCapDAO.Instance.ThemNCC(ten, dc, sdt, email);
            }
            else if (cheDo == 2) 
            {
                int id = int.Parse(dgvNCC.CurrentRow.Cells["ID"].Value.ToString());
                thanhCong = NhaCungCapDAO.Instance.SuaNCC(id, ten, dc, sdt, email);
            }

            if (thanhCong)
            {
                MessageBox.Show("Lưu dữ liệu thành công!");
                TaiDuLieu();
                ThietLapNut(true);
                cheDo = 0;
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi lưu dữ liệu!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNCC.CurrentRow == null) return;

            string ten = dgvNCC.CurrentRow.Cells["TenNCC"].Value.ToString();
            if (MessageBox.Show("Bạn có chắc muốn xóa [" + ten + "]?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = int.Parse(dgvNCC.CurrentRow.Cells["ID"].Value.ToString());
                if (NhaCungCapDAO.Instance.XoaNCC(id))
                {
                    TaiDuLieu();
                    XoaTrang();
                }
            }
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvNCC.CurrentRow != null && cheDo == 0)
            {
                txtTenNCC.Text = dgvNCC.CurrentRow.Cells["TenNCC"].Value.ToString();
                txtDiaChi.Text = dgvNCC.CurrentRow.Cells["DiaChi"].Value.ToString();
                txtDienThoai.Text = dgvNCC.CurrentRow.Cells["DienThoai"].Value.ToString();
                txtEmail.Text = dgvNCC.CurrentRow.Cells["Email"].Value.ToString();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string loai = rdoTenNCC.Checked ? "Ten" : "SDT";
            dgvNCC.DataSource = NhaCungCapDAO.Instance.TimKiemNCC(txtTimKiem.Text, loai);
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNCC.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần sửa!");
                return;
            }
            cheDo = 2;      
            ThietLapNut(false);
            ChoPhepNhapLieu(true);
            txtTenNCC.Focus();
        }
    }
}
