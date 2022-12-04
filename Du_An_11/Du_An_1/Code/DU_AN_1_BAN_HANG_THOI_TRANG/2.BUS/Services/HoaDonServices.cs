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
    public class HoaDonServices : ICHoaDonServices
    {
        private IHoaDonReps _hoaDonReps;
        private INhanVienReps _nhanVienReps;
        private IKhachHangReps _khachHangReps;
        private IHinhThucThanhToanReps _hinhThucThanhToanReps;
        public HoaDonServices()
        {
            _hinhThucThanhToanReps = new HinhThucThanhToanReps();
            _hoaDonReps = new HoaDonReps();
            _khachHangReps = new KhachHangReps();
            _nhanVienReps = new NhanVienReps();
        }
        public string Add(ViewHoaDon obj)
        {
            if (obj == null)
            {
                return "Không thành công";
            }
            var HD = new HoaDon()
            {
                ID = obj.Id,
                IDHTTT = obj.IdHTTT,
                IDNV = obj.IdNv,
                Ma = obj.Ma,
                NgayTao = obj.NgayTao,
                NgayThanhToan = obj.NgayThanhToan,
                GhiChu = obj.GhiChu,
                TrangThai = obj.TrangThai,
                ThanhTien = obj.ThanhTien,
            };
            if (_hoaDonReps.addHoaDon(HD)) return "Thêm thành công";
            return "không thành công";
        }

        public string Delete(ViewHoaDon obj)
        {

            if (obj == null)
            {
                return "Không thành công";
            }
            var HD = new HoaDon()
            {
                ID = obj.Id,
                IDHTTT = obj.IdHTTT,
                IDNV = obj.IdNv,
                Ma = obj.Ma,
                NgayTao = obj.NgayTao,
                NgayThanhToan = obj.NgayThanhToan,
                GhiChu = obj.GhiChu,
                TrangThai = obj.TrangThai,
                ThanhTien = obj.ThanhTien,
            };
            if (_hoaDonReps.DeleteHoaDon(HD)) return "Xóa thành công";
            return "không thành công";
        }

        public List<ViewHoaDon> GetAll(string input)
        {
            List<ViewHoaDon> lstHD = new List<ViewHoaDon>();
            lstHD = (from a in _hoaDonReps.GetHoaDonFromDB()
                     join b in _khachHangReps.GetKhachHangfromDB() on a.IDKH equals b.ID
                     join c in _nhanVienReps.GetNhanVien() on a.IDNV equals c.ID
                     join d in _hinhThucThanhToanReps.GetAll() on a.IDHTTT equals d.ID
                     where a.Ma == input
                     select new ViewHoaDon
                     {
                         Id = a.ID,
                         IdKh = a.IDKH,
                         IdNv = a.IDNV,
                         IdHTTT = a.IDHTTT,
                         NgayTao = a.NgayTao,
                         NgayThanhToan = a.NgayThanhToan,
                         GhiChu = a.GhiChu,
                         TenHTTT = d.Ten,
                         TenKH = b.Ten,
                         TenNV = c.Ten,
                         SDT = b.SDT,
                         ThanhTien = a.ThanhTien,
                         TrangThai = a.TrangThai,
                     }).ToList();
            return lstHD;
        }

        public List<ViewHoaDon> GetAll()
        {
            List<ViewHoaDon> lstHD = new List<ViewHoaDon>();
            lstHD = (from a in _hoaDonReps.GetHoaDonFromDB()
                     join b in _khachHangReps.GetKhachHangfromDB() on a.IDKH equals b.ID
                     join c in _nhanVienReps.GetNhanVien() on a.IDNV equals c.ID
                     join d in _hinhThucThanhToanReps.GetAll() on a.IDHTTT equals d.ID
                     select new ViewHoaDon
                     {
                         Id = a.ID,
                         IdKh = a.IDKH,
                         IdNv = a.IDNV,
                         IdHTTT = a.IDHTTT,
                         NgayTao = a.NgayTao,
                         NgayThanhToan = a.NgayThanhToan,
                         GhiChu = a.GhiChu,
                         TenHTTT = d.Ten,
                         TenKH = b.Ten,
                         TenNV = c.Ten,
                         SDT = b.SDT,
                         ThanhTien = a.ThanhTien,
                         TrangThai = a.TrangThai,
                     }).ToList();
            return lstHD;
        }

        public string Update(ViewHoaDon obj)
        {
            if (obj == null)
            {
                return "Không thành công";
            }
            var HD = new HoaDon()
            {
                ID = obj.Id,
                IDHTTT = obj.IdHTTT,
                IDNV = obj.IdNv,
                Ma = obj.Ma,
                NgayTao = obj.NgayTao,
                NgayThanhToan = obj.NgayThanhToan,
                GhiChu = obj.GhiChu,
                TrangThai = obj.TrangThai,
                ThanhTien = obj.ThanhTien,
            };
            if (_hoaDonReps.updateHoaDon(HD)) return "Sửa thành công";
            return "không thành công";
        }
    }
}
