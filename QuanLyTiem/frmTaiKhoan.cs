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
            LoadAccount();
            AddAccountBinding();
        }


        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }

        void AddAccountBinding()
        {
            txtUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txtDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            nmAccountType.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string displayName = txtDisplayName.Text;
            int type = (int)nmAccountType.Value;

            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công! Mật khẩu mặc định là 0.");
                LoadAccount();
            }
            else { MessageBox.Show("Thêm tài khoản thất bại!"); }
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string displayName = txtDisplayName.Text;
            int type = (int)nmAccountType.Value;

            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công!");
                LoadAccount();
            }
            else { MessageBox.Show("Cập nhật tài khoản thất bại!"); }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công!");
                LoadAccount();
            }
            else { MessageBox.Show("Xóa tài khoản thất bại!"); }
        
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;

            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Hãy chọn tài khoản cần đặt lại mật khẩu!");
                return;
            }

            if (MessageBox.Show(string.Format("Bạn có chắc chắn muốn đặt lại mật khẩu cho tài khoản {0} về '0' không?", userName),
                "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (AccountDAO.Instance.ResetPassword(userName))
                {
                    MessageBox.Show("Đặt lại mật khẩu thành công!");
                }
                else
                {
                    MessageBox.Show("Đặt lại mật khẩu thất bại!");
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Xóa trắng các ô để người dùng nhập mới từ đầu
            txtUserName.Text = "";
            txtDisplayName.Text = "";
            nmAccountType.Value = 0;

            // Cho phép nhập vào ô UserName khi muốn thêm mới
            txtUserName.ReadOnly = false;
        }

        private void dtgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserName.ReadOnly = true;
        }
    }
}
