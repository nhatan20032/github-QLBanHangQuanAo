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
    public class HoaDonChiTietServices : IHoaDonChiTietServices
    {
        private IHoaDonReps _hoaDonReps;
        private IHoaDonChiTietReps _hoaDonChiTietReps;
        private IChiTietSPReps _chiTietSPReps;
        private ISanPhamReps _sanPhamReps;
        public HoaDonChiTietServices()
        {
            _hoaDonReps = new HoaDonReps();
            _hoaDonChiTietReps = new HoaDonChiTietReps();
            _chiTietSPReps = new ChiTietSPReps();
            _sanPhamReps = new SanPhamReps();
        }

        public string Add(ViewHoaDonChiTiet obj)
        {
            if (obj == null)
            {
                return "Không thành công";
            }
            var HD = new HoaDonChiTiet()
            {
                ID = obj.Id,
                IDHD = obj.IdHoaDon,
                IDChiTietSP = obj.IdChiTietSp,
                DonGia = obj.DonGia,
                SoLuong = obj.SoLuong,
            };
            if (_hoaDonChiTietReps.addHDCT(HD)) return "Thêm thành công";
            return "không thành công";
        }

        public string Delete(ViewHoaDonChiTiet obj)
        {
            if (obj == null)
            {
                return "Không thành công";
            }
            var HD = new HoaDonChiTiet()
            {
                ID = obj.Id,
                IDHD = obj.IdHoaDon,
                IDChiTietSP = obj.IdChiTietSp,
                DonGia = obj.DonGia,
                SoLuong = obj.SoLuong,
            };
            if (_hoaDonChiTietReps.DeleteHDCT(HD)) return "Xóa thành công";
            return "không thành công";
        }

        public List<ViewHoaDonChiTiet> GetAll(Guid id)
        {
            List<ViewHoaDonChiTiet> lstHD = new List<ViewHoaDonChiTiet>();
            lstHD = (from a in _hoaDonChiTietReps.GetHDCTFromDB()
                     join b in _chiTietSPReps.GetChiTietSP() on a.IDChiTietSP equals b.ID
                     join c in _hoaDonReps.GetHoaDonFromDB() on a.IDHD equals c.ID
                     join d in _sanPhamReps.GetAll() on b.IDSP equals d.ID
                     where a.IDHD == id
                     select new ViewHoaDonChiTiet
                     {
                         Id = a.ID,
                         IdChiTietSp = a.IDChiTietSP,
                         IdHoaDon = a.IDHD,
                         SoLuong = a.SoLuong,
                         DonGia = a.DonGia,
                         TenSP = d.Ten,
                     }).ToList();
            return lstHD;
        }

        public List<ViewHoaDonChiTiet> GetAll()
        {
            List<ViewHoaDonChiTiet> lstHD = new List<ViewHoaDonChiTiet>();
            lstHD = (from a in _hoaDonChiTietReps.GetHDCTFromDB()
                     join b in _chiTietSPReps.GetChiTietSP() on a.IDChiTietSP equals b.ID
                     join c in _hoaDonReps.GetHoaDonFromDB() on a.IDHD equals c.ID
                     join d in _sanPhamReps.GetAll() on b.IDSP equals d.ID
                     select new ViewHoaDonChiTiet
                     {
                         Id = a.ID,
                         IdChiTietSp = a.IDChiTietSP,
                         IdHoaDon = a.IDHD,
                         SoLuong = a.SoLuong,
                         DonGia = a.DonGia,
                         TenSP = d.Ten,
                     }).ToList();
            return lstHD;
        }

        public string Update(ViewHoaDonChiTiet obj)
        {
            if (obj == null)
            {
                return "Không thành công";
            }
            var HD = new HoaDonChiTiet()
            {
                ID = obj.Id,
                IDHD = obj.IdHoaDon,
                IDChiTietSP = obj.IdChiTietSp,
                DonGia = obj.DonGia,
                SoLuong = obj.SoLuong,
            };
            if (_hoaDonChiTietReps.updateHDCT(HD)) return "Sửa thành công";
            return "không thành công";
        }
    }
}
