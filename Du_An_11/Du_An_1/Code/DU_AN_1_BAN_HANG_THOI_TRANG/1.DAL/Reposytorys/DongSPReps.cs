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
    public class DongSPReps : IDongSPReps
    {
        DUAN1DBContext _context;
        List<DongSP> _lst;
        public DongSPReps()
        {
            _context = new DUAN1DBContext();
            _lst = new List<DongSP>();
        }
        public bool Add(DongSP obj)
        {
            _context.DongSPs.Add(obj);
            _context.SaveChanges();
            return true;
        }

        public List<DongSP> GetAll()
        {
            _lst = _context.DongSPs.ToList();
            return _lst;
        }

        public bool Remove(DongSP obj)
        {
            _context.DongSPs.Remove(obj);
            _context.SaveChanges();
            return true;
        }

        public bool Update(DongSP obj)
        {
            _context.DongSPs.Update(obj);
            _context.SaveChanges();
            return true;
        }
    }
}
