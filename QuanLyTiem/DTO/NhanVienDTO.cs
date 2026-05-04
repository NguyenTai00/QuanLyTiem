using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyTiem.DTO
{
    public class NhanVienDTO
    {
        public int ID { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public DateTime? NgayVaoLam { get; set; }
        public string MoTa { get; set; }

        public NhanVienDTO(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.HoTen = row["HoTen"].ToString();
            this.NgaySinh = row["NgaySinh"] != DBNull.Value ? (DateTime?)row["NgaySinh"] : null;
            this.GioiTinh = row["GioiTinh"].ToString();
            this.DienThoai = row["DienThoai"].ToString();
            this.Email = row["Email"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.NgayVaoLam = row["NgayVaoLam"] != DBNull.Value ? (DateTime?)row["NgayVaoLam"] : null;
            this.MoTa = row["MoTa"].ToString();
        }
    }
}
