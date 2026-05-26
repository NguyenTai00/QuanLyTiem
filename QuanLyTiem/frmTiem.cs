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
        private int currentFoodID = -1;
        public frmTiem(AccountDTO acc)
        {
            InitializeComponent();
            this.loginAccount = acc;

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
                btn.Click += TableButton_Click;
                btn.BackColor = item.Status == "Trống" ? Color.LightGreen : Color.LightPink;

                flpTable.Controls.Add(btn);


                if (selectedTable != null && item.ID == selectedTable.ID)
                {

                    selectedTable = item;
                    TableButton_Click(btn, new EventArgs());
                }
            }


            if (selectedTable == null && flpTable.Controls.Count > 0)
            {
                TableButton_Click(flpTable.Controls[0] as Button, new EventArgs());
            }
        }
        void LoadCategory()
        {
            cboCategory.DataSource = CategoryDAO.Instance.GetListCategory();
            cboCategory.DisplayMember = "Name";
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<FoodDTO> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cboFood.DataSource = listFood;
            cboFood.DisplayMember = "Name";
            if (listFood.Count > 0)
            {
                cboFood.SelectedIndex = 0;
            }
        }

        string FormatMoney(double money)
        {
            return money.ToString("N0") + "đ";
        }

        void ShowBill(int idTable)
        {
            // Lấy bảng dữ liệu từ SQL
            DataTable dt = MenuDAO.Instance.GetTableBill(idTable);
            dgvBillInfo.DataSource = dt;

            if (dgvBillInfo.Columns.Count > 0)
            {
                // Ẩn ID món ăn
                if (dgvBillInfo.Columns.Contains("idFood")) dgvBillInfo.Columns["idFood"].Visible = false;

                // Kiểm tra và đổi tên cột một cách an toàn
                if (dgvBillInfo.Columns.Contains("name")) dgvBillInfo.Columns["name"].HeaderText = "Tên món";
                if (dgvBillInfo.Columns.Contains("count")) dgvBillInfo.Columns["count"].HeaderText = "SL";
                if (dgvBillInfo.Columns.Contains("price")) dgvBillInfo.Columns["price"].HeaderText = "Đơn giá";
                if (dgvBillInfo.Columns.Contains("discount")) dgvBillInfo.Columns["discount"].HeaderText = "Giảm (%)";

                // Sửa dòng bị lỗi:
                if (dgvBillInfo.Columns.Contains("totalPrice"))
                {
                    dgvBillInfo.Columns["totalPrice"].HeaderText = "Thành tiền";
                    dgvBillInfo.Columns["totalPrice"].DefaultCellStyle.Format = "N0";
                }

                // Định dạng số tiền
                dgvBillInfo.Columns["price"].DefaultCellStyle.Format = "N0";
                dgvBillInfo.Columns["totalPrice"].DefaultCellStyle.Format = "N0";
            }

            // Tính tổng tiền hóa đơn
            double total = 0;
            foreach (DataRow row in dt.Rows)
            {
                total += Convert.ToDouble(row["totalPrice"]);
            }
            txtTotalPrice.Text = total.ToString("N0") + "đ";
        }


        void TableButton_Click(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            if (currentButton == null) return;
            TableDTO currentTable = currentButton.Tag as TableDTO;
            if (currentTable == null) return;

            selectedTable = currentTable;
            ResetTableButtonStyle();

            currentButton.FlatStyle = FlatStyle.Flat;
            currentButton.FlatAppearance.BorderColor = Color.DarkViolet;
            currentButton.FlatAppearance.BorderSize = 2;

            ShowBill(currentTable.ID);
        }
        void ResetTableButtonStyle()
        {
            foreach (Control control in flpTable.Controls)
            {
                Button btn = control as Button;

                if (btn != null)
                {
                    btn.FlatStyle = FlatStyle.Standard;
                    btn.FlatAppearance.BorderSize = 0;
                }
            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryDTO selected = cboCategory.SelectedItem as CategoryDTO;
            if (selected != null) LoadFoodListByCategoryID(selected.ID);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {

            TableDTO table = selectedTable;
            if (table == null) { MessageBox.Show("Hãy chọn bàn!"); return; }

            if (cboFood.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn món ăn!");
                return;
            }

            // 1. Lấy thông tin món và giảm giá
            FoodDTO selectedFood = cboFood.SelectedItem as FoodDTO;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = selectedFood.ID;
            int count = (int)nmFoodCount.Value;
            int foodDiscount = (int)nmFoodDiscount.Value; // Lấy % giảm giá người dùng nhập

            // 2. Thực hiện thêm/cập nhật vào Database
            if (idBill == -1)
            {
                // Tạo Bill mới nếu bàn trống
                BillDAO.Instance.InsertBill(table.ID);
                // Lấy ID của Bill vừa tạo để thêm món
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count, foodDiscount);
            }
            else
            {
                // Thêm món vào Bill đang có
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count, foodDiscount);
            }

            // 3. Cập nhật trạng thái bàn và hiển thị lại
            TableDAO.Instance.UpdateTableStatus(table.ID, "Có người");

            // LOAD LẠI DỮ LIỆU LÊN MÀN HÌNH
            ShowBill(table.ID);
            LoadTable();

            // 4. Dọn dẹp giao diện (Đưa dòng này xuống cuối cùng sau khi đã hiện xong danh sách)
            nmFoodCount.Value = 1;
            // nmFoodDiscount.Value = 0; // Tùy bạn, nếu muốn thêm món tiếp theo vẫn giữ % cũ thì xóa dòng này
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

            TableDTO table = selectedTable;

            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn cần thanh toán!");
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = 0;

            // Lấy hình thức thanh toán từ ComboBox
            string paymentMethod = "Tiền mặt"; // Mặc định
            if (cboPaymentMethod.SelectedItem != null)
            {
                paymentMethod = cboPaymentMethod.SelectedItem.ToString();
            }

            string totalText = txtTotalPrice.Text
                    .Replace("đ", "")
                    .Replace(".", "");

            double totalPrice = double.Parse(totalText);
            double finalTotalPrice = totalPrice;

            if (idBill != -1)
            {

                frmInHoaDon f = new frmInHoaDon(idBill, table, discount, loginAccount, paymentMethod);

                if (f.ShowDialog() == DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice, paymentMethod);

                    LoadTable();
                    ShowBill(table.ID);
                }
            }
        }

        private void btnDeletteFood_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn dòng nào trong bảng chưa
            if (dgvBillInfo.CurrentRow != null)
            {
                TableDTO table = selectedTable;
                int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);

                // Lấy ID món ăn từ cột "idFood" của dòng đang chọn
                int idFood = (int)dgvBillInfo.CurrentRow.Cells["idFood"].Value;

                // Gọi lệnh xóa (Truyền số lượng âm để xóa/giảm bớt món)
                // Hoặc nếu bạn có hàm Delete riêng thì gọi ở đây
                BillInfoDAO.Instance.InsertBillInfo(idBill, idFood, -100, 0);

                ShowBill(table.ID);
                LoadTable();
            }

        }



        private void nmFoodDiscount_ValueChanged(object sender, EventArgs e)
        {
           /* // 1. Kiểm tra xem có đang chọn bàn và chọn món trong bảng không
            if (selectedTable == null || dgvBillInfo.CurrentRow == null) return;

            // 2. Lấy ID hóa đơn hiện tại của bàn
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(selectedTable.ID);

            // 3. Lấy ID món ăn từ dòng đang chọn trong DataGridView (cột idFood đã ẩn)
            int idFood = (int)dgvBillInfo.CurrentRow.Cells["idFood"].Value;

            // 4. Lấy mức giảm giá mới
            int discount = (int)nmFoodDiscount.Value;

            // 5. Cập nhật vào SQL (truyền count = 0 để chỉ cập nhật giảm giá, không thêm số lượng)
            BillInfoDAO.Instance.InsertBillInfo(idBill, idFood, 0, discount);

            // 6. Tải lại bảng để thấy tiền thay đổi ngay lập tức
            ShowBill(selectedTable.ID);*/
        }

       

        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cboPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateDiscount_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra bàn và dòng được chọn
            if (selectedTable == null) return;
            if (dgvBillInfo.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn một món trong danh sách để giảm giá!");
                return;
            }

            // 2. Lấy thông tin chính xác của món đang chọn
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(selectedTable.ID);
            int foodID = (int)dgvBillInfo.CurrentRow.Cells["idFood"].Value;
            int discountVal = (int)nmFoodDiscount.Value;

            // 3. Thực hiện lệnh lưu vào SQL
            // Sử dụng hàm UpdateFoodDiscount mà bạn đã viết trong BillInfoDAO
            BillInfoDAO.Instance.UpdateFoodDiscount(idBill, foodID, discountVal);

            // 4. Thông báo và nạp lại bảng
            // MessageBox.Show("Đã cập nhật giảm giá cho món!"); 
            ShowBill(selectedTable.ID);
        }

        private void dgvBillInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBillInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu có dòng đang chọn
            if (dgvBillInfo.CurrentRow != null)
            {
                // Chỉ lấy giá trị hiển thị lên ô Numeric, KHÔNG gọi lệnh cập nhật ở đây
                int currentDiscount = Convert.ToInt32(dgvBillInfo.CurrentRow.Cells["discount"].Value);
                nmFoodDiscount.Value = currentDiscount;
            }
        }
    }
}