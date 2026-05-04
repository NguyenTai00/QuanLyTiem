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
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[] { id });
        }

        public int GetMaxIDBill()
        {
            try { return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM Bill"); }
            catch { return 1; }
        }

        public void CheckOut(int id, int discount, float totalPrice)
        {
            // Cập nhật trạng thái status = 1 (đã thanh toán), ngày ra, giảm giá và tổng tiền
            string query = "UPDATE Bill SET DateCheckOut = GETDATE(), status = 1, " +
                           "discount = " + discount + ", totalPrice = " + totalPrice +
                           " WHERE id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            // Gọi Stored Procedure bạn đã viết: USP_GetListBillByDate @checkIn , @checkOut
            // Lưu ý: Ta dùng định dạng yyyyMMdd để SQL không bị nhầm lẫn ngày tháng
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }
    }
}
