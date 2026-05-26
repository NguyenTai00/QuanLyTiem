using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiem.Dao
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;
        public static BillInfoDAO Instance { get { if (instance == null) instance = new BillInfoDAO(); return instance; } }
        private BillInfoDAO() { }

        public void UpdateDiscount(
     int idBill,
     int idFood,
     int discount)
        {
            string query =
                "exec USP_UpdateDiscount @idBill , @idFood , @discount";

            DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[]
                {
            idBill,
            idFood,
            discount
                });
        }

        public void UpdateFoodDiscount(
    int idBill,
    int idFood,
    int discount)
        {
            string query =
                "exec USP_UpdateFoodDiscount @idBill , @idFood , @discount";

            DataProvider.Instance.ExecuteNonQuery(
                query,
                new object[]
                {
            idBill,
            idFood,
            discount
                });
        }
        public void InsertBillInfo(int idBill, int idFood, int count, int discount)
        {
            // Phải có đủ 4 tham số @discount ở đây
            string query = "exec USP_InsertBillInfo @idBill , @idFood , @count , @discount";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { idBill, idFood, count, discount });
        }
    }
}
