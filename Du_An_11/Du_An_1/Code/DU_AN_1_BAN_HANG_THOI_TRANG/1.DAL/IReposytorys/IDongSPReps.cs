using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IReposytorys
{
    public interface IDongSPReps
    {
        public bool Add(DongSP obj);
        public bool Remove(DongSP obj);
        public bool Update(DongSP obj);
        public List<DongSP> GetAll();
    }
}
