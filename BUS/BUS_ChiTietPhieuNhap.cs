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
    public class BUS_ChiTietPhieuNhap
    {
        DAO_ChiTIetPhieuNhap dao = new DAO_ChiTIetPhieuNhap();

        public DataTable GetChiTietPhieuNhap(int maPhieuNhap)
        {
            return dao.GetChiTietPhieuNhap(maPhieuNhap);
        }
        public object SqlScalar(string sql)
        {
            return dao.SqlScalar(sql);
        }
        public DataTable GetChiTietPhieuNhap(string ChiTietPhieuNhap)
        {
            return dao.GetChiTietPhieuNhap(ChiTietPhieuNhap);
        }
        public bool themChiTietPhieuNhap(DTO_ChiTietPhieuNhap ChiTietPhieuNhap)
        {
            return dao.themChiTietPhieuNhap(ChiTietPhieuNhap);
        }
        public bool xoaChiTietPhieuNhap(DTO_ChiTietPhieuNhap ChiTietPhieuNhap)
        {
            return dao.xoaChiTietPhieuNhap(ChiTietPhieuNhap);
        }
        public bool suaChiTietPhieuNhap(DTO_ChiTietPhieuNhap ChiTietPhieuNhap)
        {
            return dao.suaChiTietPhieuNhap(ChiTietPhieuNhap);
        }
        public DataTable TimChiTietPhieuNhap(string keyword, int maPhieuNhap)
        {
            return dao.TimKiem(keyword, maPhieuNhap);
        }
    }
}
