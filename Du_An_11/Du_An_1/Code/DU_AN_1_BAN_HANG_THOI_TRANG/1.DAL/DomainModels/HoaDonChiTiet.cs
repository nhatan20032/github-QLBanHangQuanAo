using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.DomainModels
{
    public class HoaDonChiTiet
    {

        public Guid ID { get; set; }
        public Guid IDHD { get; set; }
        public Guid IDChiTietSP { get; set; }
        public int? SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public HoaDon HoaDon { get; set; }
        public ChiTietSP ChiTietSP { get; set; }
    }
}
