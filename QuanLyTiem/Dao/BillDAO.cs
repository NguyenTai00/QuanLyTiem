using QuanLyTiem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiem.Dao
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance { get { if (instance == null) instance = new BillDAO(); return instance; } }
        private BillDAO() { }

        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill WHERE idTable = " + id + " AND status = 0");
            if (data.Rows.Count > 0) return (int)data.Rows[0]["id"];
            return -1;
        }

        public void InsertBill(int id)
        {
            // Sửa cảnh báo CS0219: Thực thi trực tiếp, không cần gán vào biến query rồi để đó
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[] { id });
        }

        public int GetMaxIDBill()
        {
            try { return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM Bill"); }
            catch { return 1; }
        }

        public void CheckOut(int id, int discount, float totalPrice, string paymentMethod)
        {
            // Lưu ý dấu phẩy trước PaymentMethod và dấu nháy đơn bao quanh giá trị chuỗi
            string query = "UPDATE Bill SET DateCheckOut = GETDATE(), status = 1, " +
                           "discount = " + discount + ", totalPrice = " + totalPrice +
                           ", PaymentMethod = N'" + paymentMethod + "' WHERE id = " + id;

            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            // Gọi Stored Procedure bạn đã viết: USP_GetListBillByDate @checkIn , @checkOut
            // Lưu ý: Ta dùng định dạng yyyyMMdd để SQL không bị nhầm lẫn ngày tháng
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }

        public DataTable GetReportByBill(DateTime date)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetReportByBill @date", new object[] { date });
        }

        public DataTable GetReportByFood(DateTime date)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetReportByFood @date", new object[] { date });
        }

        public DataTable GetDailySummary(DateTime date)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetDailySummary @date", new object[] { date });
        }
    }
}
