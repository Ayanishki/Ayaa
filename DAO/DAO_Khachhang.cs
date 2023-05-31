using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO 
{
    public class DAO_Khachhang : DBConnection
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //Hiển thị danh sách KhachHang ra ngoài màn hình
        public DataTable GetKhachhang()
        {
            con.Open();
            da = new SqlDataAdapter("select MaKH as [Mã Khách hàng], TenKH as [Tên khách hàng], SdtKH as [SDT khách hàng],Email as [Email], DiaChi as [Địa chỉ] from KhachHang", con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable GetKhachHang(string query)
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
        public bool themKhachHang(DTO_KhachHang KhachHang)
        {
            string sql = "insert into KhachHang values('" + KhachHang.TenKH + "','" + KhachHang.SdtKH + "','" + KhachHang.Email + "','" + KhachHang.DiaChi + "')";
            SQLExecutive(sql);
            return true;
        }
        public bool XoaKhachHang(DTO_KhachHang KhachHang)
        {
            string sql = "delete from KhachHang where MaKH = " + KhachHang.MaKH ;
            SQLExecutive(sql);
            return true;
        }
        public bool SuaKhachHang(DTO_KhachHang KhachHang)
        {
            string sql = "update KhachHang set TenKH = '" + KhachHang.TenKH + "', SdtKH='" + KhachHang.SdtKH + "',Email ='" + KhachHang.Email + "' where MaKH = " + KhachHang.MaKH;
            SQLExecutive(sql);
            return true;
        }
        public DataTable TimKhachHang(string keywords)
        {
            con.Open();
            string sql = "select MaKH as [Mã Khách hàng], TenKH as [Tên khách hàng], SdtKH as [SDT khách hàng],Email as [Email], DiaChi as [Địa chỉ] from KhachHang where MaKH like '%" + keywords + "%' or TenKH like '%" + keywords + "%' or SdtKh like N'%" + keywords + "%' or Email like '%" + keywords + "%' or Diachi like '%" + keywords + "%'";
            da = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
