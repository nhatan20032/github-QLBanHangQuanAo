using _1.DAL.DomainModels;
using _1.DAL.IReposytorys;
using _1.DAL.Reposytorys;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class DongSPServices : IDongSPServices
    {
        IDongSPReps _IDongSpRp;
        public DongSPServices()
        {
            _IDongSpRp = new DongSPReps();
        }
        public bool Add(DongSP obj)
        {
            _IDongSpRp.Add(obj);
            return true;
        }

        public List<DongSP> GetAll()
        {
            return _IDongSpRp.GetAll();
        }

        public List<DongSP> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }
            return _IDongSpRp.GetAll().Where(c => c.Ten.ToLower().Contains(input.ToLower()) || c.Ma.ToLower().Contains(input.ToLower())).ToList();
        }

        public bool Remove(DongSP obj)
        {
            _IDongSpRp.Remove(obj);
            return true;
        }

        public bool Update(DongSP obj)
        {
            _IDongSpRp.Update(obj);
            return true;
        }
    }
}
