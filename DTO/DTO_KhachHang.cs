using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        public int MaKH { get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public string SdtKH { get; set; }
        public string Email { get; set; }
        public DTO_KhachHang() { }
        public DTO_KhachHang(int maKH, string tenKH, string sdtKH, string email, string diaChi)
        {
            MaKH = maKH;
            TenKH = tenKH;
            DiaChi = diaChi;
            SdtKH = sdtKH;
            Email = email;
        }
        public DTO_KhachHang(string tenKH, string sdtKH, string email, string diaChi)
        {
            TenKH = tenKH;
            DiaChi = diaChi;
            SdtKH = sdtKH;
            Email = email;
        }
    }
}
