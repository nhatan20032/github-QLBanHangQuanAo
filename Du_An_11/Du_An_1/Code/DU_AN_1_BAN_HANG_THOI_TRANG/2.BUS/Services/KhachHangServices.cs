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
    public class KhachHangServices : IKhachHangServices
    {
        private IKhachHangReps _khachHangRepositorys;
        public KhachHangServices()
        {
            _khachHangRepositorys = new KhachHangReps();
        }
        public string Add(ViewKhachHang obj)
        {
            if (obj == null)
            {
                return "Không thành công";
            }
            var KH = new KhachHang()
            {
                ID = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                Ho = obj.Ho,
                TenDem = obj.TenDem,
                NgaySinh = obj.NgaySinh,
                SDT = obj.Sdt,
                CMND = obj.CMND,
                GioiTinh = obj.GioiTinh,
                DiaChi = obj.DiaChi,
                ThanhPho = obj.ThanhPho,
                QuocGia = obj.QuocGia,
                TrangThai = obj.TrangThai,
            };
            if (_khachHangRepositorys.addKhachHang(KH)) return "Thêm thành công";
            return "không thành công";
        }


        public string Delete(ViewKhachHang obj)
        {
            if (obj == null)
            {
                return "Không thành công";
            }
            var KH = new KhachHang()
            {
                ID = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                Ho = obj.Ho,
                TenDem = obj.TenDem,
                NgaySinh = obj.NgaySinh,
                SDT = obj.Sdt,
                CMND = obj.CMND,
                GioiTinh = obj.GioiTinh,
                DiaChi = obj.DiaChi,
                ThanhPho = obj.ThanhPho,
                QuocGia = obj.QuocGia,
                TrangThai = obj.TrangThai,
            };
            if (_khachHangRepositorys.deleteKhachHang(KH)) return "Xóa thành công";
            return "không thành công";
        }

        public string Update(ViewKhachHang obj)
        {
            if (obj == null)
            {
                return "Không thành công";
            }
            var KH = new KhachHang()
            {
                ID = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                Ho = obj.Ho,
                TenDem = obj.TenDem,
                NgaySinh = obj.NgaySinh,
                SDT = obj.Sdt,
                CMND = obj.CMND,
                GioiTinh = obj.GioiTinh,
                DiaChi = obj.DiaChi,
                ThanhPho = obj.ThanhPho,
                QuocGia = obj.QuocGia,
                TrangThai = obj.TrangThai,
            };
            if (_khachHangRepositorys.updateKhachHang(KH)) return "Sửa thành công";
            return "không thành công";
        }

        List<ViewKhachHang> IKhachHangServices.GetAll()
        {
            List<ViewKhachHang> lstKH = new List<ViewKhachHang>();
            lstKH = (from n in _khachHangRepositorys.GetKhachHangfromDB()
                     select new ViewKhachHang
                     {
                         Id = n.ID,
                         Ma = n.Ma,
                         Ten = n.Ten,
                         Ho = n.Ho,
                         TenDem = n.TenDem,
                         NgaySinh = n.NgaySinh,
                         Sdt = n.SDT,
                         GioiTinh = n.GioiTinh,
                         CMND = n.CMND,
                         DiaChi = n.DiaChi,
                         ThanhPho = n.ThanhPho,
                         QuocGia = n.QuocGia,
                         TrangThai = n.TrangThai,
                     }).ToList();
            return lstKH;
        }

        List<ViewKhachHang> IKhachHangServices.GetAll(string input)
        {
            List<ViewKhachHang> lstKH = new List<ViewKhachHang>();
            lstKH = (from n in _khachHangRepositorys.GetKhachHangfromDB()
                     where n.Ten.Contains(input) || n.Ma.Contains(input) || n.SDT.StartsWith(input)
                     select new ViewKhachHang
                     {
                         Id = n.ID,
                         Ma = n.Ma,
                         Ten = n.Ten,
                         Ho = n.Ho,
                         TenDem = n.TenDem,
                         NgaySinh = n.NgaySinh,
                         Sdt = n.SDT,
                         GioiTinh = n.GioiTinh,
                         CMND = n.CMND,
                         DiaChi = n.DiaChi,
                         ThanhPho = n.ThanhPho,
                         QuocGia = n.QuocGia,
                         TrangThai = n.TrangThai,
                     }).ToList();
            return lstKH;
        }
    }
}
