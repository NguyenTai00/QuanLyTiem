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

        public List<MenuDTO> GetListMenuByTable(int id)
        {
            List<MenuDTO> listMenu = new List<MenuDTO>();
            string query = "SELECT f.name, bi.SoLuong as [count], f.price, f.price*bi.SoLuong AS totalPrice FROM BillInfo AS bi, Bill AS b, Food AS f WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.status = 0 AND b.idTable = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows) { listMenu.Add(new MenuDTO(item)); }
            return listMenu;
        }
    }
}
