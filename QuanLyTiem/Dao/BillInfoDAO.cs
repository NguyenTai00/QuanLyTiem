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

        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBillInfo @idBill , @idFood , @soLuong", new object[] { idBill, idFood, count });
        }
    }
}
