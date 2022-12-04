using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.DomainModels
{
    public class HoaDon
    {
        public Guid ID { get; set; }
        public string Ma { get; set; }
        public Guid IDNV { get; set; }
        public Guid IDKH { get; set; }
        public Guid? IDHTTT { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public decimal? ThanhTien { get; set; }
        public string GhiChu { get; set; }
        public int TrangThai { get; set; }
        public NhanVien NhanVien { get; set; }
        public KhachHang KhachHang { get; set; }
        public HinhThucThanhToan HinhThucThanhToan { get; set; }
        public List<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
