using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyTiem.Dao
{
    public class PhieuNhapDAO
    {
        private static PhieuNhapDAO instance;
        public static PhieuNhapDAO Instance { get { if (instance == null) instance = new PhieuNhapDAO(); return instance; } }
        private PhieuNhapDAO() { }

        // 1. Lưu phiếu nhập (Truyền thẳng giá trị vào chuỗi)
        public int InsertPhieuNhap(int idNCC, int idNV)
        {
            // Cách này không dùng @ nên không bao giờ bị lỗi "Must declare variable"
            string query = string.Format("INSERT INTO PhieuNhap (IDNhaCungCap, IDNhanVien, NgayNhap, TongTien) VALUES ({0}, {1}, GETDATE(), 0)", idNCC, idNV);
            DataProvider.Instance.ExecuteNonQuery(query);

            // Lấy ID vừa tạo
            return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(ID) FROM PhieuNhap");
        }

        // 2. Lưu chi tiết (Truyền thẳng giá trị)
        public void InsertChiTiet(int idPhieu, int idNL, float sl, float gia)
        {
            string query = string.Format("INSERT INTO ChiTietPhieuNhap (IDPhieuNhap, IDNguyenLieu, SoLuong, GiaNhap) VALUES ({0}, {1}, {2}, {3})", idPhieu, idNL, sl, gia);
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void CapNhatTongTien(int idPhieu, float tongTien)
        {
            string query = "UPDATE PhieuNhap SET TongTien = " + tongTien + " WHERE ID = " + idPhieu;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        // 3. Hàm lấy lịch sử chuẩn để không bị mất dữ liệu khi chạy lại
        public DataTable LayToanBoLichSuNhap()
        {
            string query = "SELECT pn.ID as [Mã Phiếu], pn.NgayNhap as [Ngày Nhập], ncc.TenNCC as [Nhà Cung Cấp], " +
                           "nl.TenNL as [Tên Nguyên Liệu], ct.SoLuong as [SL], ct.GiaNhap as [Đơn Giá], (ct.SoLuong * ct.GiaNhap) as [Thành Tiền] " +
                           "FROM PhieuNhap pn " +
                           "INNER JOIN ChiTietPhieuNhap ct ON pn.ID = ct.IDPhieuNhap " +
                           "INNER JOIN NhaCungCap ncc ON pn.IDNhaCungCap = ncc.ID " +
                           "INNER JOIN NguyenLieu nl ON ct.IDNguyenLieu = nl.ID";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void UpdateChiTiet(int idPhieu, int idNL, float sl, float gia)
        {
            string query = string.Format("exec USP_UpdateChiTietPhieu {0}, {1}, {2}, {3}", idPhieu, idNL, sl, gia);
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable GetImportReportList(DateTime from, DateTime to, int idNCC)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetImportReportList @fromDate , @toDate , @idNCC", new object[] { from, to, idNCC });
        }

        public DataTable GetImportSummary(DateTime from, DateTime to, int idNCC)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetImportSummary @fromDate , @toDate , @idNCC", new object[] { from, to, idNCC });
        }
    }
}
