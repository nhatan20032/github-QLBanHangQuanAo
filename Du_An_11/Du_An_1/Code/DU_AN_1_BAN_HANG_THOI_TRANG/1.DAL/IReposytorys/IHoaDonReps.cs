using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IReposytorys
{
    public interface IHoaDonReps
    {
        bool addHoaDon(HoaDon hoadon);
        bool DeleteHoaDon(HoaDon hoadon);
        bool updateHoaDon(HoaDon hoadon);

        List<HoaDon> GetHoaDonFromDB();
    }
}
