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
        private AccountDTO staff; // Khai báo biến lưu nhân viên


        public frmInHoaDon(int idBill, TableDTO table, int discount, AccountDTO acc)
        {
            InitializeComponent();
            this.idBill = idBill;
            this.table = table;
            this.discount = discount;
            this.staff = acc;
            LoadBillData();
            
        }

        void LoadBillData()
        {
            lblTable.Text = "Bàn: " + table.Name;
            lblDate.Text = "Ngày: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            lblStaff.Text = "Nhân viên: " + staff.DisplayName; 

            List<MenuDTO> listMenu = MenuDAO.Instance.GetListMenuByTable(table.ID);
            dgvBillDetails.DataSource = listMenu;
            dgvBillDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

          
            float totalPrice = 0;
            foreach (MenuDTO item in listMenu) { totalPrice += item.TotalPrice; }
            finalPrice = totalPrice - (totalPrice / 100) * discount;

            lblTotalPrice.Text = totalPrice.ToString("N0") + "đ";
            lblDiscount.Text = discount.ToString() + "%";
            lblFinalPrice.Text = finalPrice.ToString("N0") + "đ";

            dgvBillDetails.Columns["FoodName"].HeaderText = "Tên món";
            dgvBillDetails.Columns["Count"].HeaderText = "Số lượng";
            dgvBillDetails.Columns["Price"].HeaderText = "Đơn giá";
            dgvBillDetails.Columns["TotalPrice"].HeaderText = "Thành tiền";

            
            dgvBillDetails.Columns["TotalPrice"].DefaultCellStyle.Format = "N0";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           
            BillDAO.Instance.CheckOut(idBill, discount, finalPrice);
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
    }
}
