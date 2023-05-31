using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public  class DAO_LoaiSach : DBConnection
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DataTable GetLoaiSach()
        {
            con.Open();
            da = new SqlDataAdapter("Select * from LoaiSach", con);
            dt = new DataTable();   
            da.Fill(dt);
            con.Close();
            return dt;  
        }
        public DataTable GetLoaiSach(string query)
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
        public bool themLoaiSach(DTO_LoaiSach loaisach)
        {
            string sql = "insert into LoaiSach values(N'" + loaisach.TenLoai + "',N'" + loaisach.Mota + "')";
            SQLExecutive(sql);
            return true;
        }
        public bool XoaLoaiSach(DTO_LoaiSach loaisach)
        {
            string sql = "delete from LoaiSach where MaLoai = " + loaisach.MaLoai ;
            SQLExecutive(sql);
            return true;
        }
        public bool SuaLoaiSach(DTO_LoaiSach loaisach)
        {
            string sql = "update LoaiSach set TenLoai = N'" + loaisach.TenLoai + "', Mota =N'" + loaisach.Mota +"'"+ "where MaLoai = " + loaisach.MaLoai ;
            SQLExecutive(sql);
            return true;
        }

        //public int kiemtramatrung(int ma)
        //{

        //    con.Open();
        //    int i;
        //    string sql = "select count (*) from LoaiSach where loaisach = '" + ma.ToString() + "'";
        //    cmd = new SqlCommand(sql, con);
        //    i = (int)cmd.ExecuteScalar();
        //    con.Close();
        //    return i;
        //}
        public DataTable TimKiemLoaiSach(string keywords)
        {
            con.Open();
            string sql = "select MaLoai as [Mã Loại sách], TenLoai as [Tên Loại Sách],Mota as [Mô tả] from LoaiSach where MaLoai like '%" + keywords + "%' or TenLoai like N'%" + keywords + "%' or Mota like N'%" + keywords + "%'";

            da = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

    }
}
