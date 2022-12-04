using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IReposytorys
{
    public interface IHoaDonChiTietReps
    {
        bool addHDCT(HoaDonChiTiet hoadonCT);
        bool DeleteHDCT(HoaDonChiTiet hoadonCT);
        bool updateHDCT(HoaDonChiTiet hoadonCT);

        List<HoaDonChiTiet> GetHDCTFromDB();
    }
}
