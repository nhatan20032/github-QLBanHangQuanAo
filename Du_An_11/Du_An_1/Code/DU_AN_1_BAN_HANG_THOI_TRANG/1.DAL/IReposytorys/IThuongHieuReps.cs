using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IReposytorys
{
    public interface IThuongHieuReps
    {
        bool Add(ThuongHieu obj);
        bool Update(ThuongHieu obj);
        bool Delete(ThuongHieu obj);
        // ThuongHieu GetById(Guid Id);
        List<ThuongHieu> GetAll();
    }
}
