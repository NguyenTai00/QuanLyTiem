using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyTiem.Dao;

namespace QuanLyTiem.Dao
{
    public class NhaCungCapDAO
    {
        private static NhaCungCapDAO instance;
        public static NhaCungCapDAO Instance
        {
            get { if (instance == null) instance = new NhaCungCapDAO(); return instance; }
        }

        private NhaCungCapDAO() { }

        public DataTable LayDanhSachNCC()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM NhaCungCap");
        }

        public bool ThemNCC(string ten, string diaChi, string sdt, string email)
        {
            string query = "INSERT INTO NhaCungCap (TenNCC, DiaChi, DienThoai, Email) VALUES ( @ten , @diaChi , @sdt , @email )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, diaChi, sdt, email }) > 0;
        }

        public bool SuaNCC(int id, string ten, string diaChi, string sdt, string email)
        {
            string query = "UPDATE NhaCungCap SET TenNCC = @ten , DiaChi = @diaChi , DienThoai = @sdt , Email = @email WHERE ID = @id";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ten, diaChi, sdt, email, id }) > 0;
        }

        public bool XoaNCC(int id)
        {
            return DataProvider.Instance.ExecuteNonQuery("DELETE NhaCungCap WHERE ID = " + id) > 0;
        }

        public DataTable TimKiemNCC(string tuKhoa, string loai)
        {
            string query = "";
            if (loai == "Ten")
                query = string.Format("SELECT * FROM NhaCungCap WHERE TenNCC LIKE N'%{0}%'", tuKhoa);
            else
                query = string.Format("SELECT * FROM NhaCungCap WHERE DienThoai LIKE N'%{0}%'", tuKhoa);
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
