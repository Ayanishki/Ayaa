using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace BUS
{
    public class BUS_Sach
    {
        DAO_Sach daosach = new DAO_Sach();
        public DataTable GetSach()
        {
            return daosach.GetSach();
        }
        public DataTable GetSach(string q)
        {
            return daosach.GetSach(q);
        }
        public bool themSach(DTO_Sach sach)
        {
            return daosach.themSach(sach);
        }
        //public int kiemtramatrung(int ma)
        //{
        //    return daosach.kiemtramatrung(ma);
        //}
        public bool SuaSach(DTO_Sach sach)
        {
            return daosach.SuaSach(sach);
        }
        public bool XoaSach(DTO_Sach sach)
        {
            return daosach.XoaSach(sach); 
        }
        public DataTable TimSach(string keywords)
        {
            return daosach.TimSach(keywords);
        }
    }
}
