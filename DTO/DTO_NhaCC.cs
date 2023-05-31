using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhaCC
    {
        public int MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string DiaChi { get; set; }
        public string SdtNCC { get; set; }
        public string Email { get; set; }
        public DTO_NhaCC() { }  
        public DTO_NhaCC(int maNCC, string tenNCC, string diaChi, string sdtNCC, string email)
        {
            MaNCC = maNCC;
            TenNCC = tenNCC;
            DiaChi = diaChi;
            SdtNCC = sdtNCC;
            Email = email;  
        }
        public DTO_NhaCC(string tenNCC, string diaChi, string sdtNCC, string email)
        {
            TenNCC = tenNCC;
            DiaChi = diaChi;
            SdtNCC = sdtNCC;
            Email = email;
        }
    }
}
