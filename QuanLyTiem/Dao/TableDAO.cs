using QuanLyTiem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiem.Dao
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return instance; }
        }

        private TableDAO() { }

        public List<TableDTO> LoadTableList()
        {
            List<TableDTO> tableList = new List<TableDTO>();
            // Gọi Store Procedure bạn đã viết trong SQL
            System.Data.DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");

            foreach (System.Data.DataRow item in data.Rows)
            {
                TableDTO table = new TableDTO(item);
                tableList.Add(table);
            }
            return tableList;
        }

        public void UpdateTableStatus(int id, string status)
        {
            string query = string.Format("UPDATE TableFood SET status = N'{0}' WHERE id = {1}", status, id);

            DataProvider.Instance.ExecuteNonQuery(query);
        }

        // 1. Lấy danh sách bàn đầy đủ
        public List<TableDTO> GetListTable()
        {
            List<TableDTO> list = new List<TableDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM TableFood");
            foreach (DataRow item in data.Rows)
            {
                list.Add(new TableDTO(item));
            }
            return list;
        }

        // 2. Thêm bàn mới
        public bool InsertTable(string name)
        {
            string query = string.Format("INSERT INTO TableFood (name, status) VALUES (N'{0}', N'Trống')", name);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        // 3. Sửa tên bàn
        public bool UpdateTable(int id, string name)
        {
            string query = string.Format("UPDATE TableFood SET name = N'{0}' WHERE id = {1}", name, id);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        // 4. Xóa bàn
        public bool DeleteTable(int id)
        {
            // Lưu ý: Chỉ nên xóa nếu bàn đang Trống và không có hóa đơn chưa thanh toán
            string query = string.Format("DELETE TableFood WHERE id = {0}", id);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}
