using _2.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IHoaDonChiTietServices
    {
        string Add(ViewHoaDonChiTiet obj);
        string Update(ViewHoaDonChiTiet obj);
        string Delete(ViewHoaDonChiTiet obj);
        List<ViewHoaDonChiTiet> GetAll(Guid id);
        List<ViewHoaDonChiTiet> GetAll();
    }
}
