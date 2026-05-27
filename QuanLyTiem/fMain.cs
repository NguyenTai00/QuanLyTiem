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
            pnlMain.Controls.Clear(); 
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
            OpenChildForm(f, ChildFormMode.Fill);
        }

        void f_InsertFood(object sender, EventArgs e)
        {
           
        }

        void f_UpdateFood(object sender, EventArgs e)
        {
           
        }
        void f_DeleteFood(object sender, EventArgs e)
        {
            
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaiKhoan f = new frmTaiKhoan();
            OpenChildForm(f, ChildFormMode.Fill);
        }

        public fMain(AccountDTO acc)
        {
            InitializeComponent();

            this.loginAccount = acc;

            
            ChangeAccount(loginAccount.Type);
        }

        void ChangeAccount(int type)
        {
            
            hệThốngToolStripMenuItem.Enabled = (type == 1);

           
            this.Text = "Phần mềm quản lý tiệm - Chào " + loginAccount.DisplayName;
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmThongTinTaiKhoan f = new frmThongTinTaiKhoan(loginAccount);

            OpenChildForm(f, ChildFormMode.Fill);
        }

        private void quảnLýDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhMuc f = new frmDanhMuc();
            OpenChildForm(f, ChildFormMode.Fill);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýBànĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBanAn f = new frmBanAn();
            OpenChildForm(f, ChildFormMode.Fill);
        }

        private void doanhThuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDoanhThu f = new frmDoanhThu();
            
            OpenChildForm(f, ChildFormMode.Fill);
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmTiem f = new frmTiem(loginAccount);
            OpenChildForm(f, ChildFormMode.Fill);
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

        private void báoCáoKiểmKêHàngNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKiemKe f = new frmKiemKe(loginAccount);
            OpenChildForm(f, ChildFormMode.Fill);
        }

        private void báoCáoBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoBanHang f = new frmBaoCaoBanHang(loginAccount);
            OpenChildForm(f, ChildFormMode.Fill);
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapHang f = new frmNhapHang(loginAccount);
            OpenChildForm(f, ChildFormMode.Fill);
        }
    }
}
