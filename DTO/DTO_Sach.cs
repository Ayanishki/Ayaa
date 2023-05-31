using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Sach
    {
        public int MaSach { get; set; }
        public int MaLoai { get; set; }
        public string TenSach { get; set; }
        public int Gia { get; set; }
        public int SoLuong { get; set; }
        public string Tacgia { get; set; }
        public DTO_Sach() { }
        public DTO_Sach(int masach, int maLoai, string tenSach, int gia, int soLuong,string tacgia) 
        { 
        
            MaSach = masach;
            MaLoai = maLoai;
            TenSach = tenSach;
            Gia = gia;
            SoLuong = soLuong;
            Tacgia = tacgia;
        }
        public DTO_Sach( int maLoai, string tenSach, int gia, int soLuong,string tacgia)
        {
            MaLoai = maLoai;
            TenSach = tenSach;
            Gia = gia;
            SoLuong = soLuong;
            Tacgia = tacgia;
        }
    }
}
