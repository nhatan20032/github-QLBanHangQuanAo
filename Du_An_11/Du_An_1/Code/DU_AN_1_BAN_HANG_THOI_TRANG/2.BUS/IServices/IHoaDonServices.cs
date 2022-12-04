using _2.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ICHoaDonServices
    {
        string Add(ViewHoaDon obj);
        string Update(ViewHoaDon obj);
        string Delete(ViewHoaDon obj);
        List<ViewHoaDon> GetAll(string input);
        List<ViewHoaDon> GetAll();
    }
}
