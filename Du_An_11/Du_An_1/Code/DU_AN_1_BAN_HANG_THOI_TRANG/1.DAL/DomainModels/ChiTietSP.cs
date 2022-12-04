using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.DomainModels
{
    public class ChiTietSP
    {
        public Guid ID { get; set; }
        public string Ma { get; set; }
        public Guid? IDSP { get; set; }
        public Guid? IDDongSP { get; set; }
        public Guid? IDMauSac { get; set; }
        public Guid? IDThuongHieu { get; set; }
        public Guid? IDSize { get; set; }
        public Guid? IDChatLieu { get; set; }
        public int? SoLuongTon { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public string MoTa { get; set; }
        public string AnhMoTa { get; set; }
        public int? TrangThai { get; set; }
        public SanPham SanPham { get; set; }
        public DongSP DongSP { get; set; }
        public ThuongHieu ThuongHieu { get; set; }
        public MauSac MauSac { get; set; }
        public Sizez Size { get; set; }
        //public ChatLieu ChatLieu { get; set; }
        public List<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public List<ChatLieu_SP> chatLieu_SPs { get; set; }

    }
}
