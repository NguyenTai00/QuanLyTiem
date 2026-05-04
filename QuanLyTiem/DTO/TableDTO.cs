using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiem.DTO
{
    public class TableDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Status { get; set; } // "Trống" hoặc "Có người"

        public TableDTO(System.Data.DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Status = row["status"].ToString();
        }
    }
}
