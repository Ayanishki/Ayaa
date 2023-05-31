using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LoaiSach
    {
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }

        public string Mota { get; set; }
        public DTO_LoaiSach()
        {

        }
        public DTO_LoaiSach(int maLoai, string tenLoai, string mota)
        {
            MaLoai = maLoai;
            TenLoai = tenLoai;
            Mota = mota;
        }
        public DTO_LoaiSach(string tenLoai, string mota)
        {
            TenLoai = tenLoai;
            Mota = mota;
        }
    }
    
}
