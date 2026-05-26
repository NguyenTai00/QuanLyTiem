using QuanLyTiem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiem.Dao
{
    public class MenuDAO
    {
        private static MenuDAO instance;
        public static MenuDAO Instance { get { if (instance == null) instance = new MenuDAO(); return instance; } }
        private MenuDAO() { }

        public DataTable GetTableBill(int idTable)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListMenuByTable @idTable", new object[] { idTable });
        }

        public List<MenuDTO> GetListMenuByTable(int id)
        {
            List<MenuDTO> listMenu = new List<MenuDTO>();

            // Sử dụng chung Stored Procedure mà chúng ta đã sửa ở SQL
            string query = "exec USP_GetListMenuByTable @idTable";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });

            foreach (DataRow item in data.Rows)
            {
                // Chuyển từng dòng dữ liệu từ SQL thành đối tượng MenuDTO
                MenuDTO menu = new MenuDTO(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
