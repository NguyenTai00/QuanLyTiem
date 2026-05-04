using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyTiem.Dao
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;
        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
        }

        private NhanVienDAO() { }

        public DataTable TimKiemNhanVien(string tuKhoa, string loai)
        {
            string cot = (loai == "Ten") ? "HoTen" : "DienThoai";
            // Sử dụng LIKE để tìm kiếm gần đúng
            string query = string.Format("SELECT * FROM NhanVien WHERE {0} LIKE N'%{1}%'", cot, tuKhoa);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LayDanhSachNhanVien()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM NhanVien");
        }

        public bool ThemNhanVien(string hoTen, DateTime ngaySinh, string gioiTinh, string sdt, string email, string diaChi, DateTime ngayVao, string moTa)
        {
            string query = "INSERT INTO NhanVien (HoTen, NgaySinh, GioiTinh, DienThoai, Email, DiaChi, NgayVaoLam, MoTa) VALUES ( @hoTen , @ngaySinh , @gioiTinh , @sdt , @email , @diaChi , @ngayVao , @moTa )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { hoTen, ngaySinh, gioiTinh, sdt, email, diaChi, ngayVao, moTa }) > 0;
        }

        public bool SuaNhanVien(int id, string hoTen, DateTime ngaySinh, string gioiTinh, string sdt, string email, string diaChi, DateTime ngayVao, string moTa)
        {
            string query = "UPDATE NhanVien SET HoTen = @hoTen , NgaySinh = @ngaySinh , GioiTinh = @gioiTinh , DienThoai = @sdt , Email = @email , DiaChi = @diaChi , NgayVaoLam = @ngayVao , MoTa = @moTa WHERE ID = @id";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { hoTen, ngaySinh, gioiTinh, sdt, email, diaChi, ngayVao, moTa, id }) > 0;
        }

        public bool XoaNhanVien(int id)
        {
            // Câu lệnh SQL xóa dựa trên ID
            string query = "DELETE FROM NhanVien WHERE ID = " + id;
            int ketQua = DataProvider.Instance.ExecuteNonQuery(query);
            return ketQua > 0;
        }

      
    }
}
