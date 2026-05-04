using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiem.DTO
{
    public class FoodDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public float Price { get; set; }
        public FoodDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.CategoryID = (int)row["idCategory"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }
    }
}
