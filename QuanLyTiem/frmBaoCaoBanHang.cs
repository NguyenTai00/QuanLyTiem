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
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyTiem
{
    public partial class frmBaoCaoBanHang : Form
    {

        private AccountDTO loginAccount;

        public frmBaoCaoBanHang(AccountDTO acc)
        {
            InitializeComponent();
            this.loginAccount = acc;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tblContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tlpLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tlp0Button_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tlpRoot_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tlpLeftTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tlpGrb1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlH_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmBaoCaoBanHang_Load(object sender, EventArgs e)
        {
            DataTable dt = AccountDAO.Instance.GetListAccount();

            DataRow dr = dt.NewRow();
            dr["UserName"] = "All";
            dr["DisplayName"] = "--- Tất cả nhân viên ---";

            // Nếu trong DataTable có cột Type, phải gán giá trị cho nó ở dòng mới này
            if (dt.Columns.Contains("Type"))
            {
                dr["Type"] = 0;
            }

            dt.Rows.InsertAt(dr, 0);

            cboStaff.DataSource = dt;
            cboStaff.DisplayMember = "DisplayName";
            cboStaff.ValueMember = "UserName";
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DateTime from = dtpFromDate.Value;
            DateTime to = dtpToDate.Value;
            string user = cboStaff.SelectedValue.ToString();

            // 1. Đổ dữ liệu vào bảng
            DataTable data = BillDAO.Instance.GetSalesReport(from, to, user);
            dgvSales.DataSource = data;

            // 2. Định dạng tiền tệ
            if (dgvSales.Columns.Contains("Tổng tiền"))
                dgvSales.Columns["Tổng tiền"].DefaultCellStyle.Format = "N0";

            // 3. Hiển thị tóm tắt bên trái
            DataTable summary = BillDAO.Instance.GetSalesSummary(from, to, user);
            if (summary.Rows.Count > 0)
            {
                DataRow r = summary.Rows[0];
                txtTotalBills.Text = r["TotalBill"].ToString();
                txtTotalRevenue.Text = r["TotalRevenue"] != DBNull.Value ?
                    Convert.ToDouble(r["TotalRevenue"]).ToString("N0") + "đ" : "0đ";
                txtDistinctFood.Text = r["FoodCount"].ToString();
                txtBestSeller.Text = r["BestSeller"].ToString();
            }
        }

        private void tlp0Button_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvSales.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất báo cáo!", "Thông báo");
                return;
            }

            try
            {
                // 1. Khởi tạo ứng dụng Excel
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel._Worksheet worksheet = null;

                worksheet = workbook.ActiveSheet;
                worksheet.Name = "BaoCaoBanHang";

                // 2. Vẽ Tiêu đề báo cáo trong file Excel
                worksheet.Cells[1, 1] = "BÁO CÁO CHI TIẾT BÁN HÀNG";
                Excel.Range titleRange = worksheet.get_Range("A1", "F1");
                titleRange.Merge();
                titleRange.Font.Size = 16;
                titleRange.Font.Bold = true;
                titleRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                worksheet.Cells[2, 1] = $"Từ ngày: {dtpFromDate.Value.ToString("dd/MM/yyyy")} - Đến ngày: {dtpToDate.Value.ToString("dd/MM/yyyy")}";
                worksheet.Cells[3, 1] = $"Người lập: {loginAccount.DisplayName}";

                // 3. Đưa tiêu đề cột từ DataGridView vào Excel
                for (int i = 1; i <= dgvSales.Columns.Count; i++)
                {
                    worksheet.Cells[5, i] = dgvSales.Columns[i - 1].HeaderText;
                    worksheet.Cells[5, i].Font.Bold = true;
                    worksheet.Cells[5, i].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                }

                // 4. Đưa dữ liệu các dòng vào Excel
                for (int i = 0; i < dgvSales.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvSales.Columns.Count; j++)
                    {
                        if (dgvSales.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 6, j + 1] = dgvSales.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }

                // 5. Đưa phần Tổng kết (bên trái form) vào cuối file Excel
                int lastRow = dgvSales.Rows.Count + 7;
                worksheet.Cells[lastRow, 1] = "TỔNG KẾT:";
                worksheet.Cells[lastRow, 1].Font.Bold = true;
                worksheet.Cells[lastRow + 1, 1] = "Tổng số hóa đơn:";
                worksheet.Cells[lastRow + 1, 2] = txtTotalBills.Text;
                worksheet.Cells[lastRow + 2, 1] = "Tổng doanh thu:";
                worksheet.Cells[lastRow + 2, 2] = txtTotalRevenue.Text;

                // 6. Định dạng cột tiền và tự động căn độ rộng cột
                worksheet.Columns.AutoFit();

                // 7. Hiển thị Excel lên để người dùng xem/lưu
                excelApp.Visible = true;

                MessageBox.Show("Đã xuất báo cáo ra Excel thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất Excel: " + ex.Message, "Lỗi");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
