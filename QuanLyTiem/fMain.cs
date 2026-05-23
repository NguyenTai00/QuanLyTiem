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
    public partial class fMain : Form
    {
        private AccountDTO loginAccount;
        public enum ChildFormMode { Fill, Center }
        public fMain()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form child, ChildFormMode mode)
        {
            pnlMain.Controls.Clear(); // Xóa form cũ
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;

            if (mode == ChildFormMode.Fill)
                child.Dock = DockStyle.Fill;
            else
                child.Dock = DockStyle.None;

            pnlMain.Controls.Add(child);

            if (mode == ChildFormMode.Center)
            {
                child.Left = (pnlMain.Width - child.Width) / 2;
                child.Top = (pnlMain.Height - child.Height) / 2;
            }

            child.Show();
        }

        private void quảnLýTiệmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHangHoa f = new frmHangHoa();
            f.ShowDialog();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void quảnLýThứcĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThucAn f = new frmThucAn();
            f.InsertFood += f_InsertFood;
            f.UpdateFood += f_UpdateFood;
            OpenChildForm(f, ChildFormMode.Center);
        }

        void f_InsertFood(object sender, EventArgs e)
        {
            // Tại đây bạn có thể yêu cầu các form khác load lại dữ liệu
            // Ví dụ: Nếu bạn đang lưu biến frmTiem trong fMain, bạn gọi:
            // currentFrmTiem.LoadCategory();

            // Với cách code hiện tại của bạn, việc "new" lại form mỗi lần mở đã là 1 cách refresh rồi.
            // Nhưng Delegate sẽ giúp bạn xử lý các logic ngầm phức tạp hơn.
        }

        void f_UpdateFood(object sender, EventArgs e)
        {
            // Tương tự như InsertFood, bạn có thể yêu cầu các form khác load lại dữ liệu
        }
        void f_DeleteFood(object sender, EventArgs e)
        {
            // Tương tự như InsertFood, bạn có thể yêu cầu các form khác load lại dữ liệu
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaiKhoan f = new frmTaiKhoan();
            OpenChildForm(f, ChildFormMode.Center);
        }

        public fMain(AccountDTO acc)
        {
            InitializeComponent();

            // Lưu cái tài khoản được truyền từ fLogin vào biến của fMain
            this.loginAccount = acc;

            // Sau khi nhận xong, ta gọi hàm để phân quyền (ẩn/hiện menu)
            ChangeAccount(loginAccount.Type);
        }

        void ChangeAccount(int type)
        {
            // Giả sử cái Menu Admin của bạn tên là adminToolStripMenuItem
            // Nếu type == 1 (Admin) thì Enabled = true, ngược lại là false
            hệThốngToolStripMenuItem.Enabled = (type == 1);

            // Tiện thể hiện tên người dùng lên thanh tiêu đề cho chuyên nghiệp
            this.Text = "Phần mềm quản lý tiệm - Chào " + loginAccount.DisplayName;
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Truyền loginAccount (cái mà ta đã nhận từ fLogin) sang cho frmThongTinTaiKhoan
            frmThongTinTaiKhoan f = new frmThongTinTaiKhoan(loginAccount);

            // Mở dạng Fill hoặc Center tùy bạn chọn
            OpenChildForm(f, ChildFormMode.Center);
        }

        private void quảnLýDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhMuc f = new frmDanhMuc();
            OpenChildForm(f, ChildFormMode.Center);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form chính, trở về form đăng nhập
        }

        private void quảnLýBànĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBanAn f = new frmBanAn();
            OpenChildForm(f, ChildFormMode.Center);
        }

        private void doanhThuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDoanhThu f = new frmDoanhThu();
            // Gọi hàm mở form con vào Panel chính của bạn
            OpenChildForm(f, ChildFormMode.Fill);
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Truyền biến loginAccount (biến mà fMain đã nhận từ fLogin) vào đây
            frmTiem f = new frmTiem(loginAccount);
            OpenChildForm(f, ChildFormMode.Center);
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            OpenChildForm(f, ChildFormMode.Fill);
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap f = new frmNhaCungCap();
            OpenChildForm(f, ChildFormMode.Fill);
        }
    }
}
