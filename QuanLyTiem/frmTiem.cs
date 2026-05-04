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
    

    public partial class frmTiem : Form
    {
        private AccountDTO loginAccount;
        TableDTO selectedTable = null;

        public frmTiem(AccountDTO acc)
        {
            InitializeComponent();
            this.loginAccount = acc; // Lưu lại
            // Biến dùng để ghi nhớ bàn khách đang chọn
            

            LoadTable();
            LoadCategory();
        }

        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<TableDTO> tableList = TableDAO.Instance.LoadTableList();

            foreach (TableDTO item in tableList)
            {
                Button btn = new Button() { Width = 100, Height = 100 };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Tag = item;
                btn.Click += btn_Click;
                btn.BackColor = item.Status == "Trống" ? Color.LightGreen : Color.LightPink;

                flpTable.Controls.Add(btn);

                // NẾU BÀN NÀY TRÙNG VỚI BÀN ĐANG CHỌN TRƯỚC ĐÓ -> TỰ CLICK LẠI
                if (selectedTable != null && item.ID == selectedTable.ID)
                {
                    // Cập nhật lại dữ liệu mới cho biến ghi nhớ (vì status có thể đã đổi)
                    selectedTable = item;
                    btn_Click(btn, new EventArgs());
                }
            }

            // Nếu lần đầu mở form (chưa có selectedTable) thì mới chọn bàn đầu tiên
            if (selectedTable == null && flpTable.Controls.Count > 0)
            {
                btn_Click(flpTable.Controls[0] as Button, new EventArgs());
            }
        }
        void LoadCategory()
        {
            cboCategory.DataSource = CategoryDAO.Instance.GetListCategory();
            cboCategory.DisplayMember = "Name";
        }

        void LoadFoodListByCategoryID(int id)
        {
            cboFood.DataSource = FoodDAO.Instance.GetFoodByCategoryID(id);
            cboFood.DisplayMember = "Name";
        }

        void ShowBill(int idTable)
        {
            lsvBill.Items.Clear();
            List<MenuDTO> listBillInfo = MenuDAO.Instance.GetListMenuByTable(idTable);
            float totalPrice = 0;
            foreach (MenuDTO item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName);
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString("N0"));
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            txtTotalPrice.Text = totalPrice.ToString("N0");
        }

        // Khi click chọn bàn
        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            // Ghi nhớ bàn vừa click vào biến toàn cục
            selectedTable = btn.Tag as TableDTO;

            // Reset màu hoặc viền của tất cả các nút về bình thường trước khi chọn nút mới
            foreach (Button item in flpTable.Controls)
            {
                item.FlatAppearance.BorderSize = 0;
                item.FlatStyle = FlatStyle.Standard;
            }
            Button clickedButton = sender as Button;
            TableDTO table = clickedButton.Tag as TableDTO;

            // Làm nổi bật nút đang chọn
            clickedButton.FlatStyle = FlatStyle.Flat;
            clickedButton.FlatAppearance.BorderColor = Color.Purple;
            clickedButton.FlatAppearance.BorderSize = 2;

            int tableID = ((sender as Button).Tag as TableDTO).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(selectedTable.ID);
            ShowBill(tableID);
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryDTO selected = cboCategory.SelectedItem as CategoryDTO;
            if (selected != null) LoadFoodListByCategoryID(selected.ID);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            
            TableDTO table = lsvBill.Tag as TableDTO;
            //
            if (table == null) { MessageBox.Show("Hãy chọn bàn!"); return; }

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (cboFood.SelectedItem as FoodDTO).ID;
            int count = (int)nmFoodCount.Value;
            TableDAO.Instance.UpdateTableStatus(table.ID, "Có người");

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
               
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }
            ShowBill(table.ID);
            LoadTable();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            // Lấy thông tin bàn đang chọn từ Tag của ListView
            TableDTO table = lsvBill.Tag as TableDTO;

            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn cần thanh toán!");
                return;
            }
            //List<MenuDTO> listMenu = MenuDAO.Instance.GetListMenuByTable(table.ID);
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = (int)nmDiscount.Value; // nmDiscount là tên NumericUpDown giảm giá

            // Lấy tổng tiền từ textbox, loại bỏ chữ "VNĐ" và dấu phân cách để chuyển về số
            // Nếu bạn để txbTotalPrice chỉ chứa số thì dùng:
            double totalPrice = double.Parse(txtTotalPrice.Text, System.Globalization.NumberStyles.Number);
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;

            if (idBill != -1)
            {
                // Hiện Form Hóa Đơn để nhân viên check
                frmInHoaDon f = new frmInHoaDon(idBill, table, discount, loginAccount);

                if (f.ShowDialog() == DialogResult.OK)
                {
                    // Nếu đã bấm In/Xác nhận thành công thì load lại bàn
                    LoadTable();
                    ShowBill(table.ID);
                }
            }
        }

        private void btnDeletteFood_Click(object sender, EventArgs e)
        {
            if (lsvBill.SelectedItems.Count > 0)
            {
                // 2. Lấy thông tin món và bàn đang chọn
                ListViewItem item = lsvBill.SelectedItems[0];
                MenuDTO foodInfo = item.Tag as MenuDTO;
                TableDTO table = lsvBill.Tag as TableDTO;

                int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);

                // 3. Tìm mã món (Food ID) dựa trên tên món hoặc bạn có thể bổ sung ID vào MenuDTO
                // Ở đây tôi dùng một mẹo nhỏ: Truyền số lượng âm thật lớn để Procedure tự xóa
                // Bạn cần viết thêm 1 hàm lấy FoodID từ Name hoặc chỉnh MenuDTO có thêm ID.

                /* Giả sử bạn đã có FoodID */
                 //BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, -999); 

                 ShowBill(table.ID);
                 LoadTable();
            }

        }
    }
}