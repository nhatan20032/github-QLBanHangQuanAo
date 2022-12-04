using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModel
{
    public class ViewHoaDonChiTiet
    {
        public Guid Id { get; set; }
        public Guid IdHoaDon { get; set; }
        public Guid IdChiTietSp { get; set; }
        public string Ma { get; set; }
        public string TenSP { get; set; }
        public int? SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public decimal thanhTien { get; set; }
    }
}
