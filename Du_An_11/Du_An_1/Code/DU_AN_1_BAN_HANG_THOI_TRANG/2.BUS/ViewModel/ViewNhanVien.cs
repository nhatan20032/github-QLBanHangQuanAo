using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModel
{
    public class ViewNhanVien
    {
        public Guid IdNv { get; set; }
        public string MaNV { get; set; }
        public string Ho { get; set; }
        public string TenDem { get; set; }
        public string Ten { get; set; }
        public string Email { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string CMND { get; set; }
        public string SDT { get; set; }
        public string MatKhau { get; set; }
        public string TenCuaHang { get; set; }
        public string ChucVu { get; set; }
        public Guid? IDCH { get; set; }
        public Guid? IDCV { get; set; }
        public string DiaChi { get; set; }
        public string ThanhPho { get; set; }
        public string QuocGia { get; set; }
        public int TrangThai { get; set; }

    }
}
