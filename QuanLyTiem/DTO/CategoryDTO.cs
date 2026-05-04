using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiem.DTO
{
    public class CategoryDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public CategoryDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
        }
    }
}
