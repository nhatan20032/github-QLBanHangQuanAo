using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModel
{
    public class ViewChiTietSP
    {
        public Guid ID { get; set; }
        public string Ma { get; set; }
        public string AnhMoTa { get; set; }
        public Guid? IDSP { get; set; }
        public string TenSP { get; set; }
        public Guid? IDDongSP { get; set; }
        public string TenDongSP { get; set; }
        public Guid? IDMauSac { get; set; }
        public string TenMauSac { get; set; }
        public Guid? IDThuongHieu { get; set; }
        public string TenThuongHieu { get; set; }
        public Guid? IDChatLieu { get; set; }
        public string TenChatLieu { get; set; }
        public Guid? IDSize { get; set; }
        public string TenSize { get; set; }
        public int? SoLuongTon { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public string MoTa { get; set; }
        public int? TrangThai { get; set; }
    }
}
