using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public string DiaChi { get; set; }
        public string SdtNV { get; set; }
        public string Email { get; set; }
        public DateTime Ngayvao { get; set; }
        public DTO_NhanVien() { }
        public DTO_NhanVien(int maNV, string tenNV, string sdtNV, string email,string diaChi, DateTime ngayvao)
        {
            MaNV = maNV;
            TenNV = tenNV;
            DiaChi = diaChi;
            SdtNV = sdtNV;
            Email = email;
            Ngayvao = ngayvao;
        }
        public DTO_NhanVien(string tenNV, string sdtNV, string email, string diaChi, DateTime ngayvao)
        {
            TenNV = tenNV;
            DiaChi = diaChi;
            SdtNV = sdtNV;
            Email = email;
            Ngayvao = ngayvao;
        }
    }
}
