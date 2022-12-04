using _1.DAL.ConText;
using _1.DAL.DomainModels;
using _1.DAL.IReposytorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Reposytorys
{
    public class HoaDonReps : IHoaDonReps
    {
        private DUAN1DBContext _DBContext;
        private List<HoaDon> _lstHoaDon;
        public HoaDonReps()
        {
            _DBContext = new DUAN1DBContext();
            _lstHoaDon = new List<HoaDon>();
            GetHoaDonFromDB();
        }

        public bool addHoaDon(HoaDon hoadon)
        {
            if (hoadon == null) return false;
            hoadon.ID = Guid.NewGuid();
            _DBContext.HoaDons.Add(hoadon);
            _DBContext.SaveChanges();
            return true;
        }

        public bool DeleteHoaDon(HoaDon hoadon)
        {
            if (hoadon == null) return false;
            var temp = _DBContext.HoaDons.FirstOrDefault(c => c.ID == hoadon.ID);
            _DBContext.HoaDons.Remove(temp);
            _DBContext.SaveChanges();
            return true;
        }

        public List<HoaDon> GetHoaDonFromDB()
        {
            _lstHoaDon = _DBContext.HoaDons.ToList();
            return _lstHoaDon;
        }
        public bool updateHoaDon(HoaDon hoadon)
        {
            if (hoadon == null) return false;
            var temp = _DBContext.HoaDons.FirstOrDefault(c => c.ID == hoadon.ID);
            temp.IDHTTT = hoadon.IDHTTT;
            temp.IDNV = hoadon.IDNV;
            temp.IDKH = hoadon.IDKH;
            temp.Ma = hoadon.Ma;
            temp.NgayTao = hoadon.NgayTao;
            temp.NgayThanhToan = hoadon.NgayThanhToan;
            temp.ThanhTien = hoadon.ThanhTien;
            temp.TrangThai = hoadon.TrangThai;
            temp.GhiChu = hoadon.GhiChu;
            _DBContext.HoaDons.Update(temp);
            _DBContext.SaveChanges();
            return true;
        }
    }
}
