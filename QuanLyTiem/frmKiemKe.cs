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
    public partial class frmKiemKe : Form
    {
        private AccountDTO loginAccount;

        public frmKiemKe(AccountDTO acc)
        {
            InitializeComponent();
            this.loginAccount = acc;
            HienThiNhanVien();
        }

        // 3. Viết hàm dán tên nhân viên lên TextBox
        void HienThiNhanVien()
        {
            if (loginAccount != null)
            {
                txtStaffName.Text = loginAccount.DisplayName; // Dán tên hiển thị (Quản trị/Nhân viên A...)
                txtStaffName.ReadOnly = true; // Khóa lại không cho sửa để đảm bảo tính trung thực của báo cáo
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DateTime date = dtpDate.Value;

            // 1. Đổ dữ liệu vào bảng dựa trên Radio được chọn
            if (rdoByBill.Checked)
            {
                dgvReport.DataSource = BillDAO.Instance.GetReportByBill(date);
            }
            else
            {
                dgvReport.DataSource = BillDAO.Instance.GetReportByFood(date);
            }

            if (dgvReport.Columns.Contains("Giảm giá món"))
            {
                // Giúp hiện đầy đủ chuỗi "Pizza bò (10%), Coca (5%)" không bị che mất
                dgvReport.Columns["Giảm giá món"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                // Đổi màu chữ xanh cho nổi bật
                dgvReport.Columns["Giảm giá món"].DefaultCellStyle.ForeColor = Color.DarkGreen;
            }

            // 2. Lấy dữ liệu tổng hợp hiện lên các ô bên trái
            DataTable summary = BillDAO.Instance.GetDailySummary(date);
            if (summary.Rows.Count > 0)
            {
                DataRow r = summary.Rows[0];
                txtTotalBill.Text = r["TotalBill"].ToString();
                txtTotalRevenue.Text = Convert.ToDouble(r["TotalRevenue"]).ToString("N0") + "đ";
                txtFoodCount.Text = r["FoodCount"].ToString();
                txtBestSeller.Text = r["BestSeller"].ToString();
            }

            // Định dạng cột Thành tiền/Doanh thu
            if (dgvReport.Columns.Contains("Thành tiền"))
                dgvReport.Columns["Thành tiền"].DefaultCellStyle.Format = "N0";

            if (dgvReport.Columns.Contains("Doanh thu"))
                dgvReport.Columns["Doanh thu"].DefaultCellStyle.Format = "N0";

            if (dgvReport.Columns.Contains("Đơn giá"))
                dgvReport.Columns["Đơn giá"].DefaultCellStyle.Format = "N0";
        }

        private void frmKiemKe_Load(object sender, EventArgs e)
        {
            // Giả sử bạn đã có thông tin nhân viên đăng nhập từ Form chính truyền sang
            // txtStaffName.Text = loginAccount.DisplayName;
            dtpDate.Value = DateTime.Now;
            rdoByBill.Checked = true;
        }

        private void rdoByBill_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoByBill.Checked) btnView_Click(null, null);
        }

        private void rdoByFood_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoByBill.Checked) btnView_Click(null, null);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất báo cáo!", "Thông báo");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.csv)|*.csv";
            saveFileDialog.FileName = "BaoCao_Ngay_" + dtpDate.Value.ToString("dd_MM_yyyy") + ".csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                {
                    // Viết tiêu đề cột
                    for (int i = 0; i < dgvReport.Columns.Count; i++)
                    {
                        sw.Write(dgvReport.Columns[i].HeaderText + (i == dgvReport.Columns.Count - 1 ? "" : ","));
                    }
                    sw.WriteLine();

                    // Viết dữ liệu các dòng
                    foreach (DataGridViewRow row in dgvReport.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            for (int i = 0; i < dgvReport.Columns.Count; i++)
                            {
                                sw.Write(row.Cells[i].Value.ToString() + (i == dgvReport.Columns.Count - 1 ? "" : ","));
                            }
                            sw.WriteLine();
                        }
                    }
                }
                MessageBox.Show("Xuất báo cáo thành công!", "Thông báo");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
