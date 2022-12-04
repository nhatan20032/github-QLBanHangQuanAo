using _1.DAL.DomainModels;
using _1.DAL.IReposytorys;
using _1.DAL.Reposytorys;
using _2.BUS.IServices;
using _2.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class NhanVienServices : INhanVienServices
    {
        private INhanVienReps _INhanVienReps;
        private ICuaHangReps _ICuaHangReps;
        private IChucVuReps _IChucVuReps;
        private List<ViewNhanVien> _viewNhanVienslst;
        private List<NhanVien> _lstNhanVien;
        public NhanVienServices()
        {
            _IChucVuReps = new ChucVuReps();
            _ICuaHangReps = new CuaHangReps();
            _INhanVienReps = new NhanVienReps();
            _viewNhanVienslst = new List<ViewNhanVien>();
        }
        public bool addSanPhamChiTiet(ViewNhanVien nhanVien)
        {
            NhanVien nv = new NhanVien()
            {
                ID = nhanVien.IdNv,
                Ma = nhanVien.MaNV,
                Ho = nhanVien.Ho,
                TenDem = nhanVien.TenDem,
                Ten = nhanVien.Ten,
                GioiTinh = nhanVien.GioiTinh,
                NgaySinh = nhanVien.NgaySinh,
                CMND = nhanVien.CMND,
                SDT = nhanVien.SDT,
                MatKhau = nhanVien.MatKhau,
                Email = nhanVien.Email,
                IDCH = nhanVien.IDCH,
                IDCV = nhanVien.IDCV,
                DiaChi = nhanVien.DiaChi,
                ThanhPho = nhanVien.ThanhPho,
                QuocGia = nhanVien.QuocGia,
                TrangThai = nhanVien.TrangThai
            };
            _INhanVienReps.addNhanVien(nv);
            return true;
        }

        public bool deleteSanPhamChiTiet(Guid idnv)
        {
            var x = _INhanVienReps.GetNhanVien().FirstOrDefault(p => p.ID == idnv);
            _INhanVienReps.deleteNhanVien(x);
            return true;
        }
        public List<NhanVien> GetNhanViens()
        {
            _lstNhanVien = _INhanVienReps.GetNhanVien().ToList();
            return _lstNhanVien;
        }
        public List<ViewNhanVien> GetViewChiTietSps()
        {
            _viewNhanVienslst = (from a in _INhanVienReps.GetNhanVien()
                                 join b in _ICuaHangReps.GetAll() on a.IDCH equals b.ID
                                 join c in _IChucVuReps.GetAll() on a.IDCV equals c.ID
                                 select new ViewNhanVien
                                 {
                                     IdNv = a.ID,
                                     MaNV = a.Ma,
                                     Ho = a.Ho,
                                     TenDem = a.TenDem,
                                     Ten = a.Ten,
                                     GioiTinh = a.GioiTinh,
                                     NgaySinh = a.NgaySinh,
                                     CMND = a.CMND,
                                     Email = a.Email,
                                     SDT = a.SDT,
                                     MatKhau = a.MatKhau,
                                     ChucVu = c.Ten,
                                     TenCuaHang = b.Ten,
                                     DiaChi = a.DiaChi,
                                     ThanhPho = a.ThanhPho,
                                     QuocGia = a.QuocGia,
                                     TrangThai = a.TrangThai
                                 }).ToList();
            return _viewNhanVienslst;
        }

        public bool updateSanPhamChiTiet(ViewNhanVien nhanVien)
        {
            var x = _INhanVienReps.GetNhanVien().FirstOrDefault(p => p.ID == nhanVien.IdNv);
            x.Ma = nhanVien.MaNV;
            x.Ho = nhanVien.Ho;
            x.TenDem = nhanVien.TenDem;
            x.Ten = nhanVien.Ten; 
            x.GioiTinh = nhanVien.GioiTinh;
            x.NgaySinh = nhanVien.NgaySinh;
            x.CMND = nhanVien.CMND;
            x.SDT = nhanVien.SDT;
            x.Email = nhanVien.Email;
            x.MatKhau = nhanVien.MatKhau;
            x.IDCH = nhanVien.IDCH;
            x.IDCV = nhanVien.IDCV;
            x.DiaChi = nhanVien.DiaChi;
            x.ThanhPho = nhanVien.ThanhPho;
            x.QuocGia = nhanVien.QuocGia;
            x.TrangThai = nhanVien.TrangThai;
            _INhanVienReps.updateNhanVien(x);
            return true;
        }
    }
}
