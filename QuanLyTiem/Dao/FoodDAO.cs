using QuanLyTiem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiem.Dao
{
    public class FoodDAO
    {
        private static FoodDAO instance;
        public static FoodDAO Instance { get { if (instance == null) instance = new FoodDAO(); return instance; } }
        public List<FoodDTO> GetFoodByCategoryID(int id)
        {
            List<FoodDTO> list = new List<FoodDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Food WHERE idCategory = " + id);
            foreach (DataRow item in data.Rows) { list.Add(new FoodDTO(item)); }
            return list;
        }

        // 1. Lấy danh sách toàn bộ món ăn
        public List<FoodDTO> GetListFood()
        {
            List<FoodDTO> list = new List<FoodDTO>();
            string query = "SELECT * FROM Food WHERE status = 1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new FoodDTO(item));
            }
            return list;
        }

        // 2. Thêm món mới
        public bool InsertFood(string name, int idCategory, float price)
        {
            string query = string.Format("INSERT INTO Food (name, idCategory, price) VALUES (N'{0}', {1}, {2})", name, idCategory, price);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        // 3. Sửa món
        public bool UpdateFood(int idFood, string name, int idCategory, float price)
        {
            string query = string.Format("UPDATE Food SET name = N'{0}', idCategory = {1}, price = {2} WHERE id = {3}", name, idCategory, price, idFood);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        // 4. Xóa món
        public bool DeleteFood(int idFood)
        {
            // Lưu ý: Nếu món này đang nằm trong hóa đơn (BillInfo) thì xóa sẽ bị lỗi khóa ngoại. 
            // Tạm thời ta làm cơ bản:
            string query = string.Format("UPDATE Food SET status = 0 WHERE id = {0}", idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        // 5. Tìm kiếm món theo tên
        public List<FoodDTO> SearchFoodByName(string name)
        {
            List<FoodDTO> list = new List<FoodDTO>();
            string query = string.Format("SELECT * FROM Food WHERE name LIKE N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new FoodDTO(item));
            }
            return list;
        }

        // Thêm 2 tham số unit và quantity vào hàm
        public bool InsertFood(string name, int idCategory, float price, string unit, int quantity)
        {
            string query = string.Format("INSERT INTO Food (name, idCategory, price, unit, quantity) VALUES (N'{0}', {1}, {2}, N'{3}', {4})",
                name, idCategory, price, unit, quantity);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }


    }


    }

}
