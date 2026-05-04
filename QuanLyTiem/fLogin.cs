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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassword.Text;

            if (AccountDAO.Instance.Login(userName, passWord))
            {
                // Lấy thông tin tài khoản vừa đăng nhập thành công
                AccountDTO loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);

                fMain f = new fMain(loginAccount); // Truyền tài khoản sang fMain
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Thông báo");
            }
        }

        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true; // Hủy việc đóng form
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
