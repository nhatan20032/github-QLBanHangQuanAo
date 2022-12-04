using _2.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IKhachHangServices
    {
        string Add(ViewKhachHang obj);
        string Update(ViewKhachHang obj);
        string Delete(ViewKhachHang obj);
        List<ViewKhachHang> GetAll();
        List<ViewKhachHang> GetAll(string input);
    }
}
