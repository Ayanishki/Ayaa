using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_NhanVien
    {
        DAO_NhanVien nhanvien = new DAO_NhanVien();
        public DataTable GetNhanVien()
        {
            return nhanvien.GetNhanVien();
        }
        public DataTable GetNhanVien(string query)
        {
            return nhanvien.GetNhanVien(query);
        }
        public bool themNhanVien(DTO_NhanVien NhanVien)
        {
            return nhanvien.themNhanVien(NhanVien);
        }
        public bool XoaNhanVien(DTO_NhanVien NhanVien)
        {
            return nhanvien.XoaNhanVien(NhanVien);
        }
        public bool SuaNhanVien(DTO_NhanVien NhanVien)
        {
            return nhanvien.SuaNhanVien(NhanVien) ;
        }
        public DataTable TimNhanVien(string keywords)
        {
            return nhanvien.TimNhanVien(keywords);
        }
    }
}
