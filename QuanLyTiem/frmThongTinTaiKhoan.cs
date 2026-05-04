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

        private AccountDTO loginAccount; // Lưu thông tin người đang dùng

        public frmThongTinTaiKhoan(AccountDTO acc)
        {
            InitializeComponent();
            this.loginAccount = acc;
            ChangeAccount(loginAccount); // Hiện thông tin lên các ô khi mở form
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

            // 1. Kiểm tra mật khẩu mới có khớp nhau không
            if (!newPass.Equals(reEnterPass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu mới chính xác!");
                return;
            }

            // 2. Gọi hàm cập nhật
            if (AccountDAO.Instance.UpdateAccount(loginAccount.UserName, displayName, password, newPass))
            {
                MessageBox.Show("Cập nhật thành công!");

                // Nếu bạn muốn báo cho form chính biết tên đã đổi, ta có thể dùng Delegate (nhưng tạm thời làm đơn giản thế này đã)
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
            // Nếu CheckBox được tích (Checked = true)
            if (ckbShowPass.Checked)
            {
                // Tắt chế độ ẩn mật khẩu để hiện chữ bình thường
                txtPassWord.UseSystemPasswordChar = false;
                txtNewPass.UseSystemPasswordChar = false;
                txtReEnterPass.UseSystemPasswordChar = false;
            }
            else
            {
                // Bật lại chế độ ẩn mật khẩu (hiện dấu * hoặc dấu chấm đen)
                txtPassWord.UseSystemPasswordChar = true;
                txtNewPass.UseSystemPasswordChar = true;
                txtReEnterPass.UseSystemPasswordChar = true;
            }
        }

        private void txtReEnterPass_TextChanged(object sender, EventArgs e)
        {
            if (txtReEnterPass.Text != txtNewPass.Text)
            {
                // Bạn có thể đổi màu chữ ô này thành màu đỏ để cảnh báo
                txtReEnterPass.ForeColor = Color.Red;
            }
            else
            {
                // Nếu khớp thì trả về màu đen bình thường
                txtReEnterPass.ForeColor = Color.Black;
            }
        }
    }
}
