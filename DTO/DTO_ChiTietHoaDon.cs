using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietHoaDon
    {
        public int MaHoaDon { get; set; }
        public int MaSach { get; set; }
        public int Slban { get; set; }
        public int Giaban { get; set; }
        public DTO_ChiTietHoaDon() { }
        public DTO_ChiTietHoaDon(int maHoaDon, int maSach, int slban, int giaban)
        {
            MaHoaDon = maHoaDon;
            MaSach = maSach;
            Slban = slban;
            Giaban = giaban;
        }
    }
}
