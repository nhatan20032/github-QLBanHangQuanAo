using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IReposytorys
{
    public interface IHinhThucThanhToanReps
    {
        bool Add(HinhThucThanhToan obj);
        bool Update(HinhThucThanhToan obj);
        bool Delete(HinhThucThanhToan obj);
        // HinhThucThanhToan GetById(Guid Id);

        List<HinhThucThanhToan> GetAll();
    }
}
