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
    public partial class frmBaoCaoTonKho : Form
    {
        public frmBaoCaoTonKho()
        {
            InitializeComponent();
        }

        private void frmBaoCaoTonKho_Load(object sender, EventArgs e)
        {
            DataTable dt = NguyenLieuDAO.Instance.LayDanhSachLoaiNL();

            // Thêm dòng "Tất cả" vào đầu danh sách
            DataRow dr = dt.NewRow();
            dr["LoaiNL"] = "Tất cả";
            dt.Rows.InsertAt(dr, 0);

            cboLoaiNL.DataSource = dt;
            cboLoaiNL.DisplayMember = "LoaiNL";
            cboLoaiNL.ValueMember = "LoaiNL"; // Gán giá trị ẩn là chính tên loại
        }

        private void tlpGrb1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Lấy điều kiện lọc từ giao diện
            bool kieuSapXep = rdoTangDan.Checked;
            string loaiChon = cboLoaiNL.Text;

            // 2. Gọi hàm DAO lấy bảng dữ liệu (Sau khi sửa Bước 1, dòng này sẽ hết lỗi đỏ)
            DataTable dt = NguyenLieuDAO.Instance.LayBaoCaoTonKho(kieuSapXep, loaiChon);
            dgvTonKho.DataSource = dt;

            // 3. TÍNH TOÁN TỔNG HỢP TRỰC TIẾP TẠI ĐÂY (Dòng 52 sẽ hết lỗi)
            double tongSL = 0;
            double tongTien = 0;

            foreach (DataRow row in dt.Rows)
            {
                tongSL += Convert.ToDouble(row["Số lượng tồn"]);
                tongTien += Convert.ToDouble(row["Giá trị tồn"]);
            }

            // 4. Hiển thị lên các ô kết quả bên trái
            txtTongSL.Text = tongSL.ToString("N0");
            txtTongGiaTri.Text = tongTien.ToString("N0") + "đ";

            // 5. Định dạng tiền tệ cho các cột trong bảng cho đẹp
            if (dgvTonKho.Columns.Count > 0)
            {
                if (dgvTonKho.Columns.Contains("Giá nhập gần nhất"))
                    dgvTonKho.Columns["Giá nhập gần nhất"].DefaultCellStyle.Format = "N0";

                if (dgvTonKho.Columns.Contains("Giá trị tồn"))
                    dgvTonKho.Columns["Giá trị tồn"].DefaultCellStyle.Format = "N0";

                dgvTonKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvTonKho.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo");
                return;
            }

            try
            {
                Excel.Application app = new Excel.Application();
                Excel.Workbook wb = app.Workbooks.Add(Type.Missing);
                Excel.Worksheet ws = wb.ActiveSheet;
                ws.Name = "TonKhoNguyenLieu";

                // Ghi tiêu đề
                ws.Cells[1, 1] = "BÁO CÁO TỒN KHO NGUYÊN LIỆU";
                ws.Cells[2, 1] = "Ngày lập: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                // Xuất tiêu đề cột từ DataGridView
                for (int i = 1; i <= dgvTonKho.Columns.Count; i++)
                {
                    ws.Cells[4, i] = dgvTonKho.Columns[i - 1].HeaderText;
                }

                // Xuất dữ liệu từ bảng
                for (int i = 0; i < dgvTonKho.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvTonKho.Columns.Count; j++)
                    {
                        if (dgvTonKho.Rows[i].Cells[j].Value != null)
                        {
                            ws.Cells[i + 5, j + 1] = dgvTonKho.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }

                app.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
