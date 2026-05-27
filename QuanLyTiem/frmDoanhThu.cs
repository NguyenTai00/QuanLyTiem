using QuanLyTiem.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyTiem
{
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu()
        {
            InitializeComponent();
            LoadDateTimePickerBill();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }

       
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (dtgvBill.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!");
                return;
            }

           
            Excel.Application excelApp = new Excel.Application();
            excelApp.Application.Workbooks.Add(Type.Missing);

            
            for (int i = 1; i < dtgvBill.Columns.Count + 1; i++)
            {
                excelApp.Cells[1, i] = dtgvBill.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dtgvBill.Rows.Count; i++)
            {
                for (int j = 0; j < dtgvBill.Columns.Count; j++)
                {
                    if (dtgvBill.Rows[i].Cells[j].Value != null)
                    {
                        excelApp.Cells[i + 2, j + 1] = dtgvBill.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }

            excelApp.Columns.AutoFit();
            excelApp.Visible = true;

            MessageBox.Show("Xuất file Excel thành công!");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtpkFromDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void dtgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}