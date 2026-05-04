using QuanLyTiem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiem.Dao
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;
        public static CategoryDAO Instance { get { if (instance == null) instance = new CategoryDAO(); return instance; } }
        public List<CategoryDTO> GetListCategory()
        {
            List<CategoryDTO> list = new List<CategoryDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM FoodCategory");
            foreach (DataRow item in data.Rows) { list.Add(new CategoryDTO(item)); }
            return list;
        }

        // Thêm danh mục
        public bool InsertCategory(string name)
        {
            string query = string.Format("INSERT INTO FoodCategory (name) VALUES (N'{0}')", name);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        // Sửa danh mục
        public bool UpdateCategory(int id, string name)
        {
            string query = string.Format("UPDATE FoodCategory SET name = N'{0}' WHERE id = {1}", name, id);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        // Xóa danh mục (Lưu ý: Chỉ xóa được nếu danh mục đó chưa có món ăn nào)
        public bool DeleteCategory(int id)
        {
            string query = string.Format("DELETE FoodCategory WHERE id = {0}", id);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

    }
}
