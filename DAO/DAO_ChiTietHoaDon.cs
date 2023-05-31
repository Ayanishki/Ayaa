using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DAO
{
    public class DAO_ChiTietHoaDon : DBConnection
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable GetChiTietHoaDon(int mahoadon)
        {
            con.Open();
            da = new SqlDataAdapter("select TenSach as [Tên sách], Slban as [Số lượng], Giaban as [Giá bán],(Slban * Giaban) as [Thành tiền] from ChiTietHoaDon inner join Sach on Chitiethoadon.MaSach = Sach.MaSach inner join HoaDon on Chitiethoadon.MaHoaDon = HoaDon.MaHoaDon and Chitiethoadon.MaHoaDon = " + mahoadon, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
        public DataTable GetChiTietHoaDon(string sql)
        {
            con.Open();
            da = new SqlDataAdapter(sql, con);
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
        public bool themChiTietHoaDon(DTO_ChiTietHoaDon ChiTietHoaDon)
        {
            string sql = string.Format("insert into ChiTietHoaDon values({0},{1},{2},{3})", ChiTietHoaDon.MaHoaDon, ChiTietHoaDon.MaSach, ChiTietHoaDon.Slban, ChiTietHoaDon.Giaban);
            SQLExecutive(sql);
            return true;
        }
        public bool xoaChiTietHoaDon(DTO_ChiTietHoaDon ChiTietHoaDon)
        {
            string sql = "delete from ChiTietHoaDon where MaHoaDon =" + ChiTietHoaDon.MaHoaDon + "and MaSach ="+ChiTietHoaDon.MaSach;
            SQLExecutive(sql);
            return true;
        }
        public bool suaChiTietHoaDon(DTO_ChiTietHoaDon ChiTietHoaDon)
        {
            string sql = string.Format("update Chitiethoadon set Slban = {0}, Giaban = {1} where MaHoaDon = {2} and MaSach = {3}", ChiTietHoaDon.Slban, ChiTietHoaDon.Giaban, ChiTietHoaDon.MaHoaDon, ChiTietHoaDon.MaSach);
            SQLExecutive(sql);
            return true;
        }
        public DataTable TimKiem(string keyword,int mahoadon)
        {
            con.Open();
            string sql = string.Format("select TenSach as [Tên sách], Slban as [Số lượng], Giaban as [Giá bán],Slban*Giaban as [Thành tiền] from ChiTietHoaDon inner join Sach on Chitiethoadon.MaSach = Sach.MaSach inner join HoaDon on Chitiethoadon.MaHoaDon = HoaDon.MaHoaDon where Chitiethoadon.MaHoaDon = {0} and Sach.TenSach like '%{1}%' or Slban like '%{2}%' or Giaban like '%{3}%' or (Slban*Giaban) like '%{4}%' ", mahoadon , keyword, keyword, keyword,keyword);
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
