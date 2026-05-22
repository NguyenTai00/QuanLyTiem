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
    public partial class frmThongTinTaiKhoan : Form
    {

        private AccountDTO loginAccount; 

        public frmThongTinTaiKhoan(AccountDTO acc)
        {
            InitializeComponent();
            this.loginAccount = acc;
            ChangeAccount(loginAccount); 
        }

        void ChangeAccount(AccountDTO acc)
        {
            txtUserName.Text = acc.UserName;
            txtDisplayName.Text = acc.DisplayName;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string displayName = txtDisplayName.Text;
            string password = txtPassWord.Text;
            string newPass = txtNewPass.Text;
            string reEnterPass = txtReEnterPass.Text;

            
            if (!newPass.Equals(reEnterPass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu mới chính xác!");
                return;
            }

            if (AccountDAO.Instance.UpdateAccount(loginAccount.UserName, displayName, password, newPass))
            {
                MessageBox.Show("Cập nhật thành công!");

                
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại mật khẩu cũ!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            
            if (ckbShowPass.Checked)
            {
                
                txtPassWord.UseSystemPasswordChar = false;
                txtNewPass.UseSystemPasswordChar = false;
                txtReEnterPass.UseSystemPasswordChar = false;
            }
            else
            {
                
                txtPassWord.UseSystemPasswordChar = true;
                txtNewPass.UseSystemPasswordChar = true;
                txtReEnterPass.UseSystemPasswordChar = true;
            }
        }

        private void txtReEnterPass_TextChanged(object sender, EventArgs e)
        {
            if (txtReEnterPass.Text != txtNewPass.Text)
            {
               
                txtReEnterPass.ForeColor = Color.Red;
            }
            else
            {
               
                txtReEnterPass.ForeColor = Color.Black;
            }
        }
    }
}
