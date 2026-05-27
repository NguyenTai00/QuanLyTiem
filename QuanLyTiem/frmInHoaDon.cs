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
using System.Drawing.Printing;

namespace QuanLyTiem
{
    public partial class frmInHoaDon : Form
    {
        private int idBill;
        private TableDTO table;
        private int discount;
        private float finalPrice;
        private AccountDTO staff;
        private string paymentMethod;


        public frmInHoaDon(int idBill, TableDTO table, int discount, AccountDTO acc, string payMethod)
        {
            InitializeComponent();
            this.idBill = idBill;
            this.table = table;
            this.discount = discount;
            this.staff = acc;
            this.paymentMethod = payMethod;
            LoadBillData();
            
        }

        void LoadBillData()
        {
            lblMaHD.Text = "Mã hóa đơn: " + idBill.ToString();
            lblTable.Text = "Bàn: " + table.Name;
            lblDate.Text = "Ngày: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            lblStaff.Text = "Nhân viên: " + staff.DisplayName;
            lblPaymentMethod.Text = "Hình thức TT: " + paymentMethod;

            List<MenuDTO> listMenu = MenuDAO.Instance.GetListMenuByTable(table.ID);
            dgvBillDetails.DataSource = listMenu;
            dgvBillDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

          
            float totalPrice = 0;
            foreach (MenuDTO item in listMenu) { totalPrice += item.TotalPrice; }
            lblTotalPrice.Text = totalPrice.ToString("N0") + "đ";
            lblFinalPrice.Text = totalPrice.ToString("N0") + "đ";

            // Đổi tên cột dgvBillDetails cho rõ ràng
            dgvBillDetails.Columns["Discount"].HeaderText = "Giảm (%)";
            dgvBillDetails.Columns["TotalPrice"].HeaderText = "Thành tiền";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           
            BillDAO.Instance.CheckOut(idBill, discount, finalPrice, this.paymentMethod);
            TableDAO.Instance.UpdateTableStatus(table.ID, "Trống");

            // 2. Thực hiện lệnh in
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            
            Bitmap bmp = new Bitmap(pnlBill.Width, pnlBill.Height);
            pnlBill.DrawToBitmap(bmp, new Rectangle(0, 0, pnlBill.Width, pnlBill.Height));
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblTable_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void lblStaff_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void pnlBill_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
