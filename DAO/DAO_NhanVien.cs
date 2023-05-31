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
    public class DAO_NhanVien : DBConnection
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //Hiển thị danh sách NhanVien ra ngoài màn hình
        public DataTable GetNhanVien()
        {
            con.Open();
            da = new SqlDataAdapter("select MaNV as [Mã Nhân viên], TenNV as [Tên nhân viên], Diachi as [Địa chỉ], SdtNV as [Số điện thoại Nhân Viên], Email, Ngayvao as [Ngày vào] from NhanVien ", con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable GetNhanVien(string query)
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
        public bool themNhanVien(DTO_NhanVien NhanVien)
        {
            string sql = "insert into NhanVien values('" + NhanVien.TenNV + "','" + NhanVien.SdtNV + "','" + NhanVien.Email + "','" + NhanVien.DiaChi + "','" + NhanVien.Ngayvao + "')";
            SQLExecutive(sql);
            return true;
        }
        public bool XoaNhanVien(DTO_NhanVien NhanVien)
        {
            string sql = "delete from NhanVien where MaNV = " + NhanVien.MaNV;
            SQLExecutive(sql);
            return true;
        }
        public bool SuaNhanVien(DTO_NhanVien NhanVien)
        {
            string sql = "update NhanVien set TenNV = '" + NhanVien.TenNV + "', SdtNV ='" + NhanVien.SdtNV + "',DiaChi ='" + NhanVien.DiaChi + "',Email ='" + NhanVien.Email + "',Ngayvao ='" + NhanVien.Ngayvao + "' where MaNV = " + NhanVien.MaNV;
            SQLExecutive(sql);
            return true;
        }
        public DataTable TimNhanVien(string keywords)
        {
            con.Open();
            string sql = "select MaNV as [Mã nhà cung cấp], TenNV as [Tên nhà cung cấp], Diachi as [Địa chỉ], SdtNV as [Số điện thoại Nhân Viên], Email, Ngayvao as [Ngày vào] from NhanVien where MaNV like '%" + keywords + "%' or TenNV like '%" + keywords + "%' or DiaChi like N'%" + keywords + "%' or SdtNV like '%" + keywords + "%' or Email like '%" + keywords + "%' or Email like '%" + keywords + "%'";
            da = new SqlDataAdapter(sql, con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
