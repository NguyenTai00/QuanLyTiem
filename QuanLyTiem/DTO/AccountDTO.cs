using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiem.DTO
{
    public class AccountDTO
    {
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public int Type { get; set; }
        public int IDNhanVien { get; set; }

        public AccountDTO(System.Data.DataRow row)
        {
            this.UserName = row["UserName"].ToString();
            this.DisplayName = row["DisplayName"].ToString();
            this.Type = (int)row["Type"];
            // Lấy mã nhân viên thực tế từ Database
            this.IDNhanVien = (int)row["IDNhanVien"];
        }
    }
}
