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
    public class DAO_ChiTIetPhieuNhap : DBConnection
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable GetChiTietPhieuNhap(int maPhieuNhap)
        {
            con.Open();
            da = new SqlDataAdapter("select TenSach as [Tên sách], SLnhap as [Số lượng], Gianhap as [Giá bán],(SLnhap * Gianhap) as [Thành tiền] from ChiTietPhieuNhap inner join Sach on ChitietPhieuNhap.MaSach = Sach.MaSach inner join PhieuNhap on ChitietPhieuNhap.MaPhieuNhap = PhieuNhap.MaPhieuNhap and ChitietPhieuNhap.MaPhieuNhap = " + maPhieuNhap, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
        public DataTable GetChiTietPhieuNhap(string sql)
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
        public bool themChiTietPhieuNhap(DTO_ChiTietPhieuNhap ChiTietPhieuNhap)
        {
            string sql = string.Format("insert into ChiTietPhieuNhap values({0},{1},{2},{3})", ChiTietPhieuNhap.MaPhieuNhap, ChiTietPhieuNhap.MaSach, ChiTietPhieuNhap.SLnhap, ChiTietPhieuNhap.Gianhap);
            SQLExecutive(sql);
            return true;
        }
        public bool xoaChiTietPhieuNhap(DTO_ChiTietPhieuNhap ChiTietPhieuNhap)
        {
            string sql = "delete from ChiTietPhieuNhap where MaPhieuNhap =" + ChiTietPhieuNhap.MaPhieuNhap + "and MaSach =" + ChiTietPhieuNhap.MaSach;
            SQLExecutive(sql);
            return true;
        }
        public bool suaChiTietPhieuNhap(DTO_ChiTietPhieuNhap ChiTietPhieuNhap)
        {
            string sql = string.Format("update ChitietPhieuNhap set SLnhap = {0}, Gianhap = {1} where MaPhieuNhap = {2} and MaSach = {3}", ChiTietPhieuNhap.SLnhap, ChiTietPhieuNhap.Gianhap, ChiTietPhieuNhap.MaPhieuNhap, ChiTietPhieuNhap.MaSach);
            SQLExecutive(sql);
            return true;
        }
        public DataTable TimKiem(string keyword, int maPhieuNhap)
        {
            con.Open();
            string sql = string.Format("select TenSach as [Tên sách], SLnhap as [Số lượng], Gianhap as [Giá bán],SLnhap*Gianhap as [Thành tiền] from ChiTietPhieuNhap inner join Sach on ChitietPhieuNhap.MaSach = Sach.MaSach inner join PhieuNhap on ChitietPhieuNhap.MaPhieuNhap = PhieuNhap.MaPhieuNhap where ChitietPhieuNhap.MaPhieuNhap = {0} and Sach.TenSach like '%{1}%' or SLnhap like '%{2}%' or Gianhap like '%{3}%' or (SLnhap*Gianhap) like '%{4}%' ", maPhieuNhap, keyword, keyword, keyword, keyword);
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
