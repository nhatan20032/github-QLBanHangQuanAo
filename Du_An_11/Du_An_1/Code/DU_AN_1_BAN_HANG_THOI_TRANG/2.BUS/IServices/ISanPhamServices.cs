using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ISanPhamServices
    {
        string Add(SanPham obj);
        string Update(SanPham obj);
        string Delete(SanPham obj);
        List<SanPham> GetAll();
        List<SanPham> GetAll(string input);
    }
}
