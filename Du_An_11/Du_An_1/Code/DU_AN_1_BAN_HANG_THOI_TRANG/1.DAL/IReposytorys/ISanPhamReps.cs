using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IReposytorys
{
    public interface ISanPhamReps
    {
        bool Add(SanPham obj);
        bool Update(SanPham obj);
        bool Delete(SanPham obj);
        // SanPham GetById(Guid Id);

        List<SanPham> GetAll();
    }
}
