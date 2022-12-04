using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IThuongHieuServices
    {
        bool Add(ThuongHieu obj);
        bool Update(ThuongHieu obj);
        bool Delete(ThuongHieu obj);
        List<ThuongHieu> GetAll();
        List<ThuongHieu> GetAll(string input);
    }
}
