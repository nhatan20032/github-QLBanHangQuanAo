using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModel
{
    public class ViewHoaDon
    {
        public Guid Id { get; set; }
        public Guid IdKh { get; set; }
        public string TenKH { get; set; }
        public Guid IdNv { get; set; }
        public string TenNV { get; set; }
        public Guid? IdHTTT { get; set; }
        public string TenHTTT { get; set; }
        public string SDT { get; set; }
        public string Ma { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public string? GhiChu { get; set; }
        public decimal? ThanhTien { get; set; }
        public int TrangThai { get; set; }
    }
}
