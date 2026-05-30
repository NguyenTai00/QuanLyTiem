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
    public partial class frmBaoCaoNhapHang : Form
    {
        private AccountDTO loginAccount;

        public frmBaoCaoNhapHang(AccountDTO acc)
        {
            InitializeComponent();
            this.loginAccount = acc;
        }

        private void frmBaoCaoNhapHang_Load(object sender, EventArgs e)
        {
            DataTable dt = NhaCungCapDAO.Instance.LayDanhSachNCC();

            // Thêm dòng "Tất cả nhà cung cấp"
            DataRow dr = dt.NewRow();
            dr["ID"] = 0;
            dr["TenNCC"] = "--- Tất cả NCC ---";
            dt.Rows.InsertAt(dr, 0);

            cboSupplier.DataSource = dt;
            cboSupplier.DisplayMember = "TenNCC";
            cboSupplier.ValueMember = "ID";
        }

        private void tlpRoot_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DateTime from = dtpFromDate.Value;
            DateTime to = dtpToDate.Value;
            int idNCC = (int)cboSupplier.SelectedValue;

            // 1. Hiển thị danh sách lên bảng
            DataTable data = PhieuNhapDAO.Instance.GetImportReportList(from, to, idNCC);
            dgvImportReport.DataSource = data;

            // Định dạng tiền cho đẹp
            if (dgvImportReport.Columns.Contains("Tổng Tiền"))
                dgvImportReport.Columns["Tổng Tiền"].DefaultCellStyle.Format = "N0";

            // 2. Hiển thị thông tin tóm tắt bên trái
            DataTable summary = PhieuNhapDAO.Instance.GetImportSummary(from, to, idNCC);
            if (summary.Rows.Count > 0)
            {
                DataRow r = summary.Rows[0];
                txtTotalReceipts.Text = r["TotalReceipts"].ToString();
                txtTotalAmount.Text = r["TotalAmount"] != DBNull.Value ?
                    Convert.ToDouble(r["TotalAmount"]).ToString("N0") + "đ" : "0đ";
                txtIngredientCount.Text = r["TotalIngredients"].ToString();
                txtMostImported.Text = r["MostImported"].ToString();
            }
        }

        private void btnPrintExcel_Click(object sender, EventArgs e)
        {
            if (dgvImportReport.Rows.Count == 0)
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
                worksheet.Name = "BaoCaoNhapHang"; // Sửa lại tên sheet cho đúng

                // 2. Vẽ Tiêu đề báo cáo trong file Excel
                worksheet.Cells[1, 1] = "BÁO CÁO CHI TIẾT NHẬP HÀNG";
                Excel.Range titleRange = worksheet.get_Range("A1", "F1");
                titleRange.Merge();
                titleRange.Font.Size = 16;
                titleRange.Font.Bold = true;
                titleRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                worksheet.Cells[2, 1] = $"Từ ngày: {dtpFromDate.Value.ToString("dd/MM/yyyy")} - Đến ngày: {dtpToDate.Value.ToString("dd/MM/yyyy")}";

                // Sửa lỗi loginAccount tại đây
                worksheet.Cells[3, 1] = $"Người lập: {loginAccount.DisplayName}";

                // 3. Đưa tiêu đề cột từ DataGridView vào Excel
                for (int i = 1; i <= dgvImportReport.Columns.Count; i++)
                {
                    worksheet.Cells[5, i] = dgvImportReport.Columns[i - 1].HeaderText;
                    worksheet.Cells[5, i].Font.Bold = true;
                    worksheet.Cells[5, i].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                }

                // 4. Đưa dữ liệu các dòng vào Excel
                for (int i = 0; i < dgvImportReport.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvImportReport.Columns.Count; j++)
                    {
                        if (dgvImportReport.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 6, j + 1] = dgvImportReport.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }

                // 5. Đưa phần Tổng kết vào cuối file Excel
                // SỬA LỖI TÊN CONTROL TẠI ĐÂY (Sử dụng đúng tên txtTotalReceipts và txtTotalAmount)
                int lastRow = dgvImportReport.Rows.Count + 7;
                worksheet.Cells[lastRow, 1] = "TỔNG KẾT:";
                worksheet.Cells[lastRow, 1].Font.Bold = true;
                worksheet.Cells[lastRow + 1, 1] = "Tổng số lần nhập:";
                worksheet.Cells[lastRow + 1, 2] = txtTotalReceipts.Text;
                worksheet.Cells[lastRow + 2, 1] = "Tổng tiền nhập hàng:";
                worksheet.Cells[lastRow + 2, 2] = txtTotalAmount.Text;

                // 6. Định dạng
                worksheet.Columns.AutoFit();
                excelApp.Visible = true;

                MessageBox.Show("Đã xuất báo cáo ra Excel thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất Excel: " + ex.Message, "Lỗi");
            }
        }
    }
}
