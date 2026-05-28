using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyTiem.Dao
{
    public class NguyenLieuDAO
    {
        private static NguyenLieuDAO instance;
        public static NguyenLieuDAO Instance { get { if (instance == null) instance = new NguyenLieuDAO(); return instance; } }
        private NguyenLieuDAO() { }

        // Hàm cộng thêm vào kho khi nhập hàng
        public void CongKho(int idNL, float count)
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE NguyenLieu SET SoLuongTon = SoLuongTon + " + count + " WHERE ID = " + idNL);
        }

        // Hàm lấy danh sách nguyên liệu để nạp vào ComboBox
        public DataTable LayDanhSachNL()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM NguyenLieu");
        }

        public DataTable LayDanhSachLoaiNL()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT DISTINCT LoaiNL FROM NguyenLieu");
        }


        public DataTable LayBaoCaoTonKho(bool isAsc, string loai)
        {
            string query = "exec USP_GetIngredientInventoryReport @isAscending , @loai";

            return DataProvider.Instance.ExecuteQuery(query, new object[] { isAsc, loai });
        }
    }
}
