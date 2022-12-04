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
    public class HoaDonChiTietReps : IHoaDonChiTietReps
    {
        private DUAN1DBContext _DBContext;
        private List<HoaDonChiTiet> _lstHDCT;
        public HoaDonChiTietReps()
        {
            _DBContext = new DUAN1DBContext();
            _lstHDCT = new List<HoaDonChiTiet>();
            GetHDCTFromDB();
        }
        public bool addHDCT(HoaDonChiTiet hoadonCT)
        {
            if (hoadonCT == null) return false;
            _DBContext.HoaDonChiTiets.Add(hoadonCT);
            _DBContext.SaveChanges();
            return true;
        }

        public bool DeleteHDCT(HoaDonChiTiet hoadonCT)
        {
            if (hoadonCT == null) return false;
            var temp = _DBContext.HoaDonChiTiets.FirstOrDefault(c => c.ID == hoadonCT.ID);
            _DBContext.HoaDonChiTiets.Remove(temp);
            _DBContext.SaveChanges();
            return true;
        }

        public List<HoaDonChiTiet> GetHDCTFromDB()
        {
            _lstHDCT = _DBContext.HoaDonChiTiets.ToList();
            return _lstHDCT;
        }

        public bool updateHDCT(HoaDonChiTiet hoadonCT)
        {
            if (hoadonCT == null) return false;
            var temp = _DBContext.HoaDonChiTiets.FirstOrDefault(c => c.ID == hoadonCT.ID);
            temp.IDHD = hoadonCT.IDHD;
            temp.IDChiTietSP = hoadonCT.IDChiTietSP;
            temp.SoLuong = hoadonCT.SoLuong;
            temp.DonGia = hoadonCT.DonGia;
            _DBContext.HoaDonChiTiets.Update(temp);
            _DBContext.SaveChanges();
            return true;
        }
    }
}
