using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace BUS
{
    public class BUS_LoaiSach
    {
        DAO_LoaiSach daols = new DAO_LoaiSach();
        public DataTable GetLoaiSach()
        {
            return daols.GetLoaiSach();
        }
        public DataTable GetLoaiSach(string query)
        {
            return daols.GetLoaiSach(query);
        }
        public bool themLoaiSach(DTO_LoaiSach loaisach)
        {
            return daols.themLoaiSach(loaisach);
        }
        //public int kiemtramatrung(int ma)
        //{
        //    return daols.kiemtramatrung(ma);
        //}
        public bool SuaLoaiSach(DTO_LoaiSach loaisach)
        {
            return daols.SuaLoaiSach(loaisach);
        } 
        public bool XoaLoaiSach(DTO_LoaiSach loaisach)
        {
            return daols.XoaLoaiSach(loaisach);
        }
        public DataTable TimKiemLoaiSach(string keyword)
        {
            return daols.TimKiemLoaiSach(keyword);
        }
    }
}
