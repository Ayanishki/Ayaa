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
    public class DAO_NhaCC : DBConnection
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //Hiển thị danh sách NCC ra ngoài màn hình
        public DataTable GetNCC()
        {
            con.Open();
            da = new SqlDataAdapter("select MaNCC as [Mã nhà cung cấp], TenNCC as [Tên nhà cung cấp], Diachi as [Địa chỉ], SdtNCC as [Số điện thoại NCC], Email from NhaCC ", con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable GetNCC(string query)
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
        public bool themNCC(DTO_NhaCC NCC)
        {
            string sql = "insert into NhaCC values('" + NCC.TenNCC + "','" + NCC.DiaChi + "','" + NCC.SdtNCC + "','" + NCC.Email + "')";
            SQLExecutive(sql);
            return true;
        }
        public bool XoaNCC(DTO_NhaCC NCC)
        {
            string sql = "delete from NhaCC where MaNCC = " + NCC.MaNCC ;
            SQLExecutive(sql);
            return true;
        }
        public bool SuaNCC(DTO_NhaCC NCC)
        {
            string sql = "update NhaCC set TenNCC = '" + NCC.TenNCC + "', SdtNCC ='" + NCC.SdtNCC + "',DiaChi ='" + NCC.DiaChi + "',Email ='" + NCC.Email + "' where MaNCC = " + NCC.MaNCC ;
            SQLExecutive(sql);
            return true;
        }
        public DataTable TimNCC(string keywords)
        {
            con.Open();
            string sql = "select MaNCC as [Mã nhà cung cấp], TenNCC as [Tên nhà cung cấp], Diachi as [Địa chỉ], SdtNCC as [Số điện thoại NCC], Email from NhaCC where MaNCC like '%" + keywords + "%' or TenNCC like '%" + keywords + "%' or DiaChi like N'%" + keywords + "%' or SdtNCC like '%" + keywords + "%' or Email like '%" + keywords + "%'";
            da = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
