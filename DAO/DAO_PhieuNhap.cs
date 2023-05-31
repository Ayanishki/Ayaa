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
    public class DAO_PhieuNhap : DBConnection
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public DataTable GetPhieuNhap()
        {
            con.Open();
            da = new SqlDataAdapter("select MaPhieuNhap as [Mã phiếu nhập], NgayLapPN as [Ngày lập phiêu nhập], NhanVien.TenNV as [Tên Nhân viên], NhaCC.TenNCC as [Tên nhà cung cấp], TrietKhaunhap as [Triết khấu nhập] from PhieuNhap inner join Nhanvien on PhieuNhap.MaNV = NhanVien.MaNV inner join NhaCC on PhieuNhap.MaNCC = NhaCC.MaNCC", con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
        public DataTable GetPhieuNhap(string sql)
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
        public bool themPhieuNhap(DTO_PhieuNhap PhieuNhap)
        {
            string sql = string.Format("insert into PhieuNhap values({0},'{1}','{2}','{3}')", PhieuNhap.MaNV, PhieuNhap.NgayLapPN, PhieuNhap.MaNCC, PhieuNhap.TrietKhauNhap);
            SQLExecutive(sql);
            return true;
        }
        public bool xoaPhieuNhap(DTO_PhieuNhap PhieuNhap)
        {
            string sql = "delete from PhieuNhap where MaPhieuNhap =" + PhieuNhap.MaPhieuNhap;
            SQLExecutive(sql);
            return true;
        }
        public bool suaPhieuNhap(DTO_PhieuNhap PhieuNhap)
        {
            string sql = string.Format("update PhieuNhap set NgayLapPN='{0}',MaNV = '{1}', MaNCC = '{2}',TrietKhauNhap = '{3}' where MaPhieuNhap = {4}", PhieuNhap.NgayLapPN, PhieuNhap.MaNV, PhieuNhap.MaNCC, PhieuNhap.TrietKhauNhap, PhieuNhap.MaPhieuNhap);
            SQLExecutive(sql);
            return true;
        }
        public DataTable TimKiem(string keyword)
        {
            con.Open();
            string sql = string.Format("select MaPhieuNhap as [Mã phiêu nhập], NgayLapPN as [Ngày lập phiêu nhập], TenNV as [Tên Nhân viên], TenNCC as [Tên nhà cung cấp], TrietKhaunhap as [Triết khấu nhập] from PhieuNhap inner join Nhanvien on PhieuNhap.MaNV = NhanVien.MaNV inner join NhaCC on PhieuNhap.MaNCC = NhaCC.MaNCC where MaPhieuNhap like '%{0}%' or NgayLapPN like '%{1}%' or Nhanvien.TenNV like '%{2}%' or NhaCC.TenNCC like '%{3}%' or TrietKhaunhap like '%{4}%'", keyword, keyword, keyword, keyword, keyword);
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
