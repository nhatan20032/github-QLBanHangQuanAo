using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IDongSPServices
    {
        public bool Add(DongSP obj);
        public bool Remove(DongSP obj);
        public bool Update(DongSP obj);
        public List<DongSP> GetAll();
        public List<DongSP> GetAll(string input);
    }
}
