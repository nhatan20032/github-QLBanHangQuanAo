using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.DomainModels
{
    public class NhanVien
    {
        public Guid ID { get; set; }
        public string Ma { get; set; }
        public string Ho { get; set; }
        public string TenDem { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string CMND { get; set; }
        public string SDT { get; set; }
        public string MatKhau { get; set; }
        public string Email { get; set; }
        public Guid? IDCH { get; set; }
        public Guid? IDCV { get; set; }
        //public Guid IDGBC { get; set; }
        public string DiaChi { get; set; }
        public string ThanhPho { get; set; }
        public string QuocGia { get; set; }
        public int TrangThai { get; set; }
        public ChucVu ChucVu { get; set; }
        public CuaHang CuaHang { get; set; }
        //public NhanVien NhanVienS { get; set; }
        public List<HoaDon> HoaDons { get; set; }
        //public List<NhanVien> NhanViens { get; set; }
    }
}
