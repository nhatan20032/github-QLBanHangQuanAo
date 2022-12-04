using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IReposytorys
{
    public interface IChiTietSPReps
    {
        bool addChiTietSP(ChiTietSP chiTietSP);
        bool updateChiTietSP(ChiTietSP chiTietSP);
        bool deleteChiTietSP(ChiTietSP chiTietSP);
        List<ChiTietSP> GetChiTietSP();
    }
}
