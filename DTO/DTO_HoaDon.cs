using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DTO
{
    public class DTO_HoaDon
    {
        public int MaHoaDon { get; set; }
        public DateTime NgayLapHD { get; set; }
        public string TenKH { get; set; }
        public string SDTKH { get; set; }
        public string Email { get; set; }
        public string Diachi { get; set; }

        public DTO_HoaDon() { }
        public DTO_HoaDon(DateTime ngayLapHD, string tenKH, string sDTKH, string email, string diachi)
        {
            NgayLapHD = ngayLapHD;
            TenKH = tenKH;
            SDTKH = sDTKH;
            Email = email;
            Diachi = diachi;
        }
        public DTO_HoaDon(int maHoaDon, DateTime ngayLapHD, string tenKH, string sDTKH, string email, string diachi)
        {
            MaHoaDon = maHoaDon;
            NgayLapHD = ngayLapHD;
            TenKH = tenKH;
            SDTKH = sDTKH;
            Email = email;
            Diachi = diachi;
        }
    }
    
}
