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
    public class BUS_NhaCC
    {
        DAO_NhaCC daoNCC = new DAO_NhaCC();
        public DataTable GetNCC()
        {
            return daoNCC.GetNCC();
        }
        public DataTable GetNCC(string q)
        {
            return daoNCC.GetNCC(q);
        }
        public bool themNCC(DTO_NhaCC NCC)
        {
            return daoNCC.themNCC(NCC);
        }
        public bool SuaNCC(DTO_NhaCC NCC)
        {
            return daoNCC.SuaNCC(NCC);
        }
        public bool XoaNCC(DTO_NhaCC NCC)
        {
            return daoNCC.XoaNCC(NCC);
        }
        public DataTable TimNCC(string keywords)
        {
            return daoNCC.TimNCC(keywords);
        }
    }
}
