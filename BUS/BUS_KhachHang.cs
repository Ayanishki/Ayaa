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
    public class BUS_KhachHang
    {
        DAO_Khachhang dao = new DAO_Khachhang();
        public DataTable GetKhachhang()
        {
            return dao.GetKhachhang();
        }
        public DataTable GetKhachHang(string query)
        {
            return dao.GetKhachHang(query);
        }
        public bool themKhachHang(DTO_KhachHang KhachHang)
        {
            return dao.themKhachHang(KhachHang);
        }
        public bool XoaKhachHang(DTO_KhachHang KhachHang)
        {
            return dao.XoaKhachHang(KhachHang);
        }
        public bool SuaKhachHang(DTO_KhachHang KhachHang)
        {
            return dao.SuaKhachHang(KhachHang);
        }
        public DataTable TimKhachHang(string keywords)
        {
            return dao.TimKhachHang(keywords);
        }
    }
}
