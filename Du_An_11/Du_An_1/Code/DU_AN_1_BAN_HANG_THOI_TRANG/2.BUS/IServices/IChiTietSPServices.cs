using _1.DAL.DomainModels;
using _2.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IChiTietSPServices
    {
        bool addSanPhamChiTiet(ViewChiTietSP chiTietSP);
        bool updateSanPhamChiTiet(ViewChiTietSP chiTietSP);
        bool deleteSanPhamChiTiet(Guid idnv);
        List<ChiTietSP> GetChiTietSPs();
        List<ViewChiTietSP> GetViewChiTietSps();
    }
}
