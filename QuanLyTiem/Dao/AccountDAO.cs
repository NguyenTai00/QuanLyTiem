using QuanLyTiem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiem.Dao
{
    public class AccountDAO
    {


        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            // Gọi Stored Procedure USP_Login mà bạn đã tạo trong SQL
            string query = "USP_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });

            return result.Rows.Count > 0;
        }

        public System.Data.DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT UserName, DisplayName, Type, IDNhanVien FROM Account");
        }

        // Thêm tài khoản mới (Mặc định mật khẩu là '0')
        public bool InsertAccount(string name, string display, int type, int idNV)
        {
            string query = string.Format("INSERT dbo.Account (UserName, DisplayName, Type, PassWord, IDNhanVien) VALUES ( N'{0}', N'{1}', {2}, N'0', {3})", name, display, type, idNV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        // Sửa tài khoản
        public bool UpdateAccount(string name, string display, int type, int idNV)
        {
            string query = string.Format("UPDATE dbo.Account SET DisplayName = N'{1}', Type = {2}, IDNhanVien = {3} WHERE UserName = N'{0}'", name, display, type, idNV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        // Xóa tài khoản
        public bool DeleteAccount(string name)
        {
            string query = string.Format("DELETE Account WHERE UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        // Hàm đặt lại mật khẩu về '0'
        public bool ResetPassword(string name)
        {
            // Câu lệnh SQL: UPDATE Account SET PassWord = N'0' WHERE UserName = N'tên_tài_khoản'
            string query = string.Format("UPDATE Account SET PassWord = N'0' WHERE UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public AccountDTO GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Account where userName = '" + userName + "'");
            foreach (DataRow item in data.Rows)
            {
                return new AccountDTO(item);
            }
            return null;
        }

        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            // Gọi đúng tên Store Procedure
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @userName , @displayName , @password , @newPassword", new object[] { userName, displayName, pass, newPass });
            return result > 0;
        }

        
    }
}
