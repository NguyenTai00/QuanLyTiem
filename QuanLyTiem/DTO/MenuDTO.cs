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
        public string FoodName { get; set; }
        public int Count { get; set; }
        public float Price { get; set; }
        public float TotalPrice { get; set; }
        public MenuDTO(DataRow row)
        {
            this.FoodName = row["name"].ToString();
            this.Count = (int)row["count"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
        }
    }
}
