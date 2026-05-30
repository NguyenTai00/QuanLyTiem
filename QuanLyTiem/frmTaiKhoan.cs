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
    public partial class frmTaiKhoan : Form
    {

        BindingSource accountList = new BindingSource();

        public frmTaiKhoan()
        {
            InitializeComponent();
            dtgvAccount.DataSource = accountList;
           
        }


        void LoadAccount()
        {
            // Lấy danh sách từ Database thông qua DAO
            DataTable data = AccountDAO.Instance.GetListAccount();
            accountList.DataSource = data;
        }

        void AddAccountBinding()
        {
            // Clear bindings cũ trước khi add mới để tránh lỗi
            txtUserName.DataBindings.Clear();
            txtDisplayName.DataBindings.Clear();
            nmAccountType.DataBindings.Clear();
            cboNhanVien.DataBindings.Clear();

            txtUserName.DataBindings.Add(new Binding("Text", accountList, "UserName", true, DataSourceUpdateMode.Never));
            txtDisplayName.DataBindings.Add(new Binding("Text", accountList, "DisplayName", true, DataSourceUpdateMode.Never));
            nmAccountType.DataBindings.Add(new Binding("Value", accountList, "Type", true, DataSourceUpdateMode.Never));

            // THÊM DÒNG NÀY: Liên kết ComboBox với cột IDNhanVien trong bảng
            cboNhanVien.DataBindings.Add(new Binding("SelectedValue", accountList, "IDNhanVien", true, DataSourceUpdateMode.Never));
        }

        void LoadNhanVienVaoComboBox()
        {
            // Lấy những nhân viên CHƯA XUẤT HIỆN trong bảng Account
            string query = "SELECT * FROM NhanVien WHERE ID NOT IN (SELECT IDNhanVien FROM Account WHERE IDNhanVien IS NOT NULL)";

            // Nếu bạn đang sửa tài khoản, bạn cần hiện cả nhân viên hiện tại (nhưng bước này làm sau)
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            cboNhanVien.DataSource = dt;
            cboNhanVien.DisplayMember = "HoTen";
            cboNhanVien.ValueMember = "ID";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtUserName.Text;
                string displayName = txtDisplayName.Text;
                int type = (int)nmAccountType.Value;

                if (cboNhanVien.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên!");
                    return;
                }
                int idNV = (int)cboNhanVien.SelectedValue;

                if (AccountDAO.Instance.InsertAccount(userName, displayName, type, idNV))
                {
                    MessageBox.Show("Thêm tài khoản thành công!");
                    LoadAccount();
                    LoadNhanVienVaoComboBox(); // Nạp lại để ẩn nhân viên vừa thêm đi
                }
            }
            catch (Exception ex)
            {
                // Kiểm tra nếu lỗi do trùng nhân viên
                if (ex.Message.Contains("UC_Account_Employee"))
                {
                    MessageBox.Show("Lỗi: Nhân viên này đã có tài khoản rồi, không thể tạo thêm!");
                }
                else
                {
                    MessageBox.Show("Lỗi hệ thống: " + ex.Message);
                }
            }
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string displayName = txtDisplayName.Text;
            int type = (int)nmAccountType.Value;
            int idNV = (int)cboNhanVien.SelectedValue;

            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type, idNV))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadAccount();
            }
            else { MessageBox.Show("Cập nhật thất bại!"); }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            if (userName == "Admin") { MessageBox.Show("Không được xóa tài khoản Admin gốc!"); return; }

            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa thành công!");
                LoadAccount();
            }

        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            if (string.IsNullOrEmpty(userName)) return;

            if (MessageBox.Show($"Đặt lại mật khẩu cho {userName} về '0'?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (AccountDAO.Instance.ResetPassword(userName)) MessageBox.Show("Thành công!");
            }
        }
        

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            txtUserName.Clear();
            txtDisplayName.Clear();
            nmAccountType.Value = 0;
            txtUserName.ReadOnly = false;
        }

        private void dtgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserName.ReadOnly = true;
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadNhanVienVaoComboBox(); // 1. Nạp danh sách nhân viên vào ComboBox trước
            LoadAccount();             // 2. Nạp danh sách tài khoản vào bảng sau
            AddAccountBinding();       // 3. Cuối cùng mới liên kết (Binding) chúng lại với nhau
        }
    }
}
