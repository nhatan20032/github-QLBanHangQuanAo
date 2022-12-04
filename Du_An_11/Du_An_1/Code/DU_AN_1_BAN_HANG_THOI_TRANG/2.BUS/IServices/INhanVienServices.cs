using _1.DAL.DomainModels;
using _2.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface INhanVienServices
    {
        bool addSanPhamChiTiet(ViewNhanVien nhanVien);
        bool updateSanPhamChiTiet(ViewNhanVien nhanVien);
        bool deleteSanPhamChiTiet(Guid idnv);
        List<NhanVien> GetNhanViens();
        List<ViewNhanVien> GetViewChiTietSps();
    }
}
