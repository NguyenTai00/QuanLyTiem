using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiem.DTO
{
    public class MenuDTO
    {
        public int IdFood { get; set; }
        public string FoodName { get; set; }
        public int Count { get; set; }
        public float Price { get; set; }
        public int Discount { get; set; }
        public float TotalPrice { get; set; } // Tổng tiền món này

        public MenuDTO(DataRow row)
        {
            // Lấy ID món (Dùng tên cột mặc định trong SQL)
            this.IdFood = row.Table.Columns.Contains("idFood") ? (int)row["idFood"] : 0;
            this.FoodName = row["name"].ToString();
            this.Count = (int)row["count"];
            this.Price = (float)Convert.ToDouble(row["price"]);

            // Lấy mức giảm giá
            this.Discount = row.Table.Columns.Contains("discount") ? (int)row["discount"] : 0;

            // TỰ TÍNH TIỀN TRONG C#: Đảm bảo chính xác 100%
            // Công thức: (Giá * Số lượng) - (Phần % giảm giá)
            this.TotalPrice = (this.Price * this.Count) * (100 - this.Discount) / 100;
        }
    }
}
