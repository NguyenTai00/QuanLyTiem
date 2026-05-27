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
        public string Unit { get; set; }     // Bổ sung
        public int Quantity { get; set; }    // Bổ sung

        public FoodDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.CategoryID = (int)row["idCategory"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.Unit = row["unit"].ToString();      // Bổ sung
            this.Quantity = (int)row["quantity"];    // Bổ sung
        }
    }
}
