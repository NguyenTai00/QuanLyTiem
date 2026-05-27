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
            lblStaff.Text = "Nhân viên: " + staff.DisplayName; // Giả sử tên label là lblStaff

            // Lấy danh sách món ăn đã gọi
            List<MenuDTO> listMenu = MenuDAO.Instance.GetListMenuByTable(table.ID);
            dgvBillDetails.DataSource = listMenu;
            dgvBillDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Tính tiền
            float totalPrice = 0;
            foreach (MenuDTO item in listMenu) { totalPrice += item.TotalPrice; }
            finalPrice = totalPrice - (totalPrice / 100) * discount;

            lblTotalPrice.Text = totalPrice.ToString("N0") + "đ";
            lblDiscount.Text = discount.ToString() + "%";
            lblFinalPrice.Text = finalPrice.ToString("N0") + "đ";

            // Đổi tên tiêu đề cột cho đẹp
            dgvBillDetails.Columns["FoodName"].HeaderText = "Tên món";
            dgvBillDetails.Columns["Count"].HeaderText = "Số lượng";
            dgvBillDetails.Columns["Price"].HeaderText = "Đơn giá";
            dgvBillDetails.Columns["TotalPrice"].HeaderText = "Thành tiền";

            // Định dạng cột Thành tiền không hiện số E+07
            dgvBillDetails.Columns["TotalPrice"].DefaultCellStyle.Format = "N0";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // 1. Cập nhật dữ liệu vào CSDL trước khi in
            BillDAO.Instance.CheckOut(idBill, discount, finalPrice);
            TableDAO.Instance.UpdateTableStatus(table.ID, "Trống");

            // 2. Thực hiện lệnh in
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

            this.DialogResult = DialogResult.OK; // Báo cho Form Tiệm là đã xong
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Chụp ảnh cái Panel 'pnlBill' và vẽ nó vào trang giấy
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
