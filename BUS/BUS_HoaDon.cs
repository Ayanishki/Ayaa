using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_HoaDon
    {
        DAO_HoaDon dao = new DAO_HoaDon();

        public DataTable GetHoaDon()
        {
            return dao.GetHoaDon();
        }
        public DataTable GetHoaDon(string hoadon)
        {
            return dao.GetHoaDon(hoadon);
        }
        public bool themHoaDon(DTO_HoaDon hoadon) 
        { 
            return dao.themHoaDon(hoadon);
        }
        public bool xoaHoaDon(DTO_HoaDon hoaDon)
        {
            return dao.xoaHoaDon(hoaDon);
        }
        public bool suaHoaDon(DTO_HoaDon hoaDon)
        {
            return dao.suaHoaDon(hoaDon);
        }
        public DataTable TimHoaDon(string keyword)
        {
            return dao.TimKiem(keyword);
        }
    }
}
