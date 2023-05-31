using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhieuNhap
    {
        public int MaPhieuNhap { get; set; }
        public int MaNV { get; set; }
        public DateTime NgayLapPN { get; set; }
        public int MaNCC { get; set; }
        public float TrietKhauNhap { get; set; }
        public DTO_PhieuNhap() { }
        public DTO_PhieuNhap(int MaPN,int manv,DateTime ngaylappn,int mancc,float trietkhaunhap)
        {
            MaPhieuNhap = MaPN;
            MaNV = manv;
            NgayLapPN = ngaylappn;
            MaNCC = mancc;
            TrietKhauNhap = trietkhaunhap;
        }
        public DTO_PhieuNhap(int manv,DateTime ngaylappn, int mancc, float trietkhaunhap)
        {
            MaNV = manv;
            NgayLapPN = ngaylappn;
            MaNCC = mancc;
            TrietKhauNhap = trietkhaunhap;
        }
    }
}
