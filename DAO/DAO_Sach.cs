using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class DAO_Sach : DBConnection
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //Hiển thị danh sách Sach ra ngoài màn hình
        public DataTable GetSach()
        {
            con.Open();
            da = new SqlDataAdapter("select MaSach as [Mã Sách], Tenloai as [Loại Sách], TenSach as [Tiêu Đề],Gia as [Giá], Soluong as [Số lượng],tacgia as [Tác giả] from Sach inner join LoaiSach on Sach.MaLoai=LoaiSach.MaLoai", con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable GetSach(string query)
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
            con.Close() ;   
        }
        public bool themSach(DTO_Sach sach)
        {   
            string sql = "insert into Sach values("+sach.MaLoai + ",N'" + sach.TenSach + "'," + sach.Gia + "," + sach.SoLuong + ",N'" + sach.Tacgia + "')";
            SQLExecutive(sql);
            return true;
        }
        public bool XoaSach(DTO_Sach sach)
        {
            string sql = "delete from sach where MaSach = '" + sach.MaSach + "'";
            SQLExecutive(sql);
            return true;
        }
        public bool SuaSach(DTO_Sach sach)
        {
            string sql = "update Sach set TenSach = N'" + sach.TenSach + "', Gia =" + sach.Gia + ",SoLuong =" + sach.SoLuong +"Tacgia = N'"+sach.Tacgia+"', "+ "where MaSach = "+ sach.MaSach;
            SQLExecutive(sql);
            return true;
        }
        //public int kiemtramatrung(int ma)
        //{
        //    con.Open() ;
        //    int i;
        //    string sql = "Select count(*) from Sach where MaSach='" + ma.ToString() + "'";
        //    cmd  = new SqlCommand(sql, con);
        //    i = (int)cmd.ExecuteScalar();
        //    con.Close() ;   
        //    return i;
        //}
        public DataTable TimSach(string keywords)
        { 
            con.Open();
            string sql = "select MaSach as [Mã Sách], Tenloai as [Loại Sách], TenSach as [Tiêu Đề],Gia as [Giá], Soluong as [Số lượng], tacgia as [Tác giả] from Sach inner join LoaiSach on Sach.MaLoai=LoaiSach.MaLoai where MaSach like '%" + keywords + "%' or TenLoai like '%" + keywords + "%' or TenSach like N'%" + keywords + "%' or Gia like '%" + keywords + "%' or SoLuong like '%" + keywords + "%'";
            da = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
    
