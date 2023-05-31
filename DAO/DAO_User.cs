using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAO
{
    public class DAO_User : DBConnection
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable GetUser()
        {
            con.Open();
            da = new SqlDataAdapter("select AccountID as [Mã tài khoản], Displayname as [Tên hiển thị], Username as [Tên đăng nhập], Passwords as [Mật khẩu],Email, Sdt as [Số điện thoại], Roles as [Vai trò] from Users", con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable GetUser(string query)
        {
            con.Open();
            da = new SqlDataAdapter(query, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        void SQLExecutive(string sql)
        {
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public bool Login(DTO_Users user)
        {
            if (GetUser("select * from Users where Username = '" + user.UserName + "'" + " and Passwords ='" + user.Passwords + "'").Rows.Count > 0)
                return true;
            return false;
        }
        public bool Add(DTO_Users user)
        {
            if (GetUser("select * from users where username = '" + user.UserName + "'").Rows.Count > 0)
                return false;
            string sql = string.Format("insert into Users values (N'{0}','{1}','{2}','{3}','{4}',{5})",user.DisplayName,user.UserName,user.Passwords,user.Email,user.Sdt,user.Roles);
            SQLExecutive(sql);
            return true;

        }
        public bool Update(DTO_Users user)
        {
            string sql = string.Format("update Users set DisplayName = N'{0}', Username ='{1}', Passwords='{2}', Email  = '{3}', Sdt = '{4}', Roles = {5} where AccountID = {6}",user.DisplayName,user.UserName,user.Passwords,user.Email,user.Sdt,user.Roles,user.AccountID);
            SQLExecutive(sql);
            return true;
        }
        public bool Delete(DTO_Users user)
        {
            string sql = string.Format("delete from Users where AccountID = " + user.AccountID);
            SQLExecutive(sql);
            return true;
        }
        public bool Loginadmin(DTO_Users user)
        {
            if (GetUser("select * from Users where Username = '" + user.UserName + "'" + " and Passwords ='" + user.Passwords + "' and Roles = 1").Rows.Count > 0)
                return true;
            return false;
        }
        public DataTable Timkiemtaikhoan(string keyword)
        {
            con.Open();
            string sql = string.Format("select AccountId as [Mã tài khoản], Displayname as [Tên hiển thị], Username as [Tên đăng nhập], Passwords as [Mật khẩu],Email , Sdt as [Số điện thoại] , Roles as [Vai trò] from Users where Displayname like '%{0}%' or Username like '%{0}%' or Passwords like '%{0}%'or Email like '%{0}%' or Sdt like '%{0}%' or Roles like '%{0}%'", keyword);
            da = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
