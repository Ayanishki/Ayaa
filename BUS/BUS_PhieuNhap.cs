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
    public class BUS_PhieuNhap
    {
        DAO_PhieuNhap dao = new DAO_PhieuNhap();
        public DataTable GetPhieuNhap()
        {
            return dao.GetPhieuNhap();
        }
        public DataTable GetPhieuNhap(string PhieuNhap)
        {
            return dao.GetPhieuNhap(PhieuNhap);
        }
        public bool themPhieuNhap(DTO_PhieuNhap PhieuNhap)
        {
            return dao.themPhieuNhap(PhieuNhap);
        }
        public bool xoaPhieuNhap(DTO_PhieuNhap PhieuNhap)
        {
            return dao.xoaPhieuNhap(PhieuNhap);
        }
        public bool suaPhieuNhap(DTO_PhieuNhap PhieuNhap)
        {
            return dao.suaPhieuNhap(PhieuNhap);
        }
        public DataTable TimPhieuNhap(string keyword)
        {
            return dao.TimKiem(keyword);
        }
    }
}
