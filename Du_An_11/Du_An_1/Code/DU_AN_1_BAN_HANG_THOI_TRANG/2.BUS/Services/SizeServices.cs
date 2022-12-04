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
    public class SizeServices : ISizeServices
    {
        private ISizeReps _ISizeReps;
        private List<Sizez> _lstSize;
        public SizeServices()
        {
            _ISizeReps = new SizeReps();
            _lstSize = new List<Sizez>();
        }

        public bool Add(Sizez sizez)
        {
            _ISizeReps.Add(sizez);
            return true;
        }

        public bool Delete(Sizez sizez)
        {
            _ISizeReps.Delete(sizez);
            return true;
        }

        public List<Sizez> getSizesFromDB()
        {
            _lstSize = _ISizeReps.getSizesFromDB();
            return _lstSize;
        }

        public bool Update(Sizez sizez)
        {
            _ISizeReps.Update(sizez);
            return true;
        }
    }
}
