using _1.DAL.ConText;
using _1.DAL.DomainModels;
using _1.DAL.IReposytorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Reposytorys
{
    public class SizeReps : ISizeReps
    {
        public DUAN1DBContext _dbContext;
        private List<Sizez> _lstSize;
        public SizeReps()
        {
            _dbContext = new DUAN1DBContext();
            _lstSize = new List<Sizez>();
        }

        public bool Add(Sizez siZez)
        {
            _dbContext.Add(siZez);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Sizez siZez)
        {
            _dbContext.Remove(siZez);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Sizez> getSizesFromDB()
        {
            _lstSize = _dbContext.Sizes.ToList();
            return _lstSize;
        }

        public bool Update(Sizez siZez)
        {
            _dbContext.Update(siZez);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
