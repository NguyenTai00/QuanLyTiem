using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyTiem.DTO
{
    public class NhaCungCapDTO
    {
        public int ID { get; set; }
        public string TenNCC { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }

        public NhaCungCapDTO(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.TenNCC = row["TenNCC"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.DienThoai = row["DienThoai"].ToString();
            this.Email = row["Email"].ToString();
        }
    }
}
