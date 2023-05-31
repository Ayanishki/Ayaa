using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietPhieuNhap
    {
        public int MaPhieuNhap { get; set; }
        public int MaSach { get; set; }
        public int SLnhap { get; set; }
        public int Gianhap { get; set; }
        public DTO_ChiTietPhieuNhap() { }
        public DTO_ChiTietPhieuNhap(int Maphieunhap, int Masach, int slnhap,int gianhap )
        {
            MaPhieuNhap = Maphieunhap;
            MaSach = Masach;
            SLnhap = slnhap;
            Gianhap = gianhap;
        }
    }
    
}
