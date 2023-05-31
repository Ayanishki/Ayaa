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
    public class DAO_HoaDon : DBConnection
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public DataTable GetHoaDon()
        {
            con.Open();
            da = new SqlDataAdapter("select MaHoaDon as [Mã hoá đơn], NgayLapHD as [Ngày lập hoá đơn], TenKH as [Tên Khách hàng], SdtKH as[SDT Khách hàng],Email, Diachi as [Địa chỉ] from Hoadon", con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
            
        }
        public DataTable GetHoaDon(string sql)
        {
            con.Open();
            da = new SqlDataAdapter (sql, con);
            dt = new DataTable ();
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
        public bool themHoaDon(DTO_HoaDon hoadon)
        {
            string sql = string.Format("insert into HoaDon values('{0}',N'{1}','{2}','{3}','{4}')",hoadon.NgayLapHD, hoadon.TenKH, hoadon.SDTKH, hoadon.Email, hoadon.Diachi);
            SQLExecutive(sql);  
            return true;
        }
        public bool xoaHoaDon(DTO_HoaDon hoaDon)
        {
            string sql = "delete from HoaDon where MaHoaDon =" + hoaDon.MaHoaDon;
            SQLExecutive(sql);
            return true;
        }
        public bool suaHoaDon(DTO_HoaDon hoadon)
        {
            string sql = string.Format("update HoaDon set NgayLapHD ='{0}',TenKH = '{1}', SdtKH = '{2}',Email = '{3}',Diachi ='{4}' where MaHoaDon = {5}", hoadon.NgayLapHD, hoadon.TenKH, hoadon.SDTKH, hoadon.Email, hoadon.Diachi,hoadon.MaHoaDon);
            SQLExecutive (sql);
            return true;
        }
        public DataTable TimKiem(string keyword)
        {
            con.Open();
            string sql = string.Format("select MaHoaDon as [Mã hoá đơn], NgayLapHD as [Ngày lập hoá đơn], TenKH as [Tên Khách hàng], SdtKH as [SDT Khách hàng],Email , Diachi as [Địa chỉ] from Hoadon where MaHoaDon like '%{0}%' or NgayLapHD like '%{1}%' or TenKH like '%{2}%' or SdtKH like '%{3}%' or Email like '%{4}%' or Diachi like '%{5}%'", keyword, keyword, keyword, keyword, keyword, keyword);
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
