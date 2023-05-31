using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ChiTietHoaDon
    {
        DAO_ChiTietHoaDon dao = new DAO_ChiTietHoaDon();

        public DataTable GetChiTietHoaDon(int mahoadon)
        {
            return dao.GetChiTietHoaDon( mahoadon);
        }
        public object SqlScalar(string sql)
        {
            return dao.SqlScalar(sql);
        }
        public DataTable GetChiTietHoaDon(string ChiTietHoaDon)
        {
            return dao.GetChiTietHoaDon(ChiTietHoaDon);
        }
        public bool themChiTietHoaDon(DTO_ChiTietHoaDon ChiTietHoaDon)
        {
            return dao.themChiTietHoaDon(ChiTietHoaDon);
        }
        public bool xoaChiTietHoaDon(DTO_ChiTietHoaDon ChiTietHoaDon)
        {
            return dao.xoaChiTietHoaDon(ChiTietHoaDon);
        }
        public bool suaChiTietHoaDon(DTO_ChiTietHoaDon ChiTietHoaDon)
        {
            return dao.suaChiTietHoaDon(ChiTietHoaDon);
        }
        public DataTable TimChiTietHoaDon(string keyword,int mahoadon)
        {
            return dao.TimKiem(keyword,mahoadon);
        }
    }
}
