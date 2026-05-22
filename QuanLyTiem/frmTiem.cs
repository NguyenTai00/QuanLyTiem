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
            cboFood.DataSource = FoodDAO.Instance.GetFoodByCategoryID(id);
            cboFood.DisplayMember = "Name";
        }

        string FormatMoney(double money)
        {
            return money.ToString("N0") + "đ";
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
                lsvItem.SubItems.Add(FormatMoney(item.Price));
                lsvItem.SubItems.Add(FormatMoney(item.TotalPrice));
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            txtTotalPrice.Text = FormatMoney(totalPrice);
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

            lsvBill.Tag = currentTable;

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
            
            TableDTO table = lsvBill.Tag as TableDTO;
            
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
           
            TableDTO table = lsvBill.Tag as TableDTO;

            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn cần thanh toán!");
                return;
            }
            
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = (int)nmDiscount.Value;


            string totalText = txtTotalPrice.Text
                    .Replace("đ", "")
                    .Replace(".", "");

            double totalPrice = double.Parse(totalText);
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;

            if (idBill != -1)
            {
               
                frmInHoaDon f = new frmInHoaDon(idBill, table, discount, loginAccount);

                if (f.ShowDialog() == DialogResult.OK)
                {
                   
                    LoadTable();
                    ShowBill(table.ID);
                }
            }
        }

        private void btnDeletteFood_Click(object sender, EventArgs e)
        {
            if (lsvBill.SelectedItems.Count > 0)
            {
               
                ListViewItem item = lsvBill.SelectedItems[0];
                MenuDTO foodInfo = item.Tag as MenuDTO;
                TableDTO table = lsvBill.Tag as TableDTO;

                int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);


                 ShowBill(table.ID);
                 LoadTable();
            }

        }
    }
}