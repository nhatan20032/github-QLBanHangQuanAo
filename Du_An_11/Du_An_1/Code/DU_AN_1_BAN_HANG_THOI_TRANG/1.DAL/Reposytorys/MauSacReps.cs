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
    public class MauSacReps : IMauSacReps
    {
        DUAN1DBContext _context;
        List<MauSac> _lst;
        public MauSacReps()
        {
            _context = new DUAN1DBContext();
        }
        public bool Add(MauSac obj)
        {
            _context.MauSacs.Add(obj);
            _context.SaveChanges();
            return true;
        }

        public string Check(string input)
        {
            throw new NotImplementedException();
        }

        public List<MauSac> GetAll()
        {
            _lst = _context.MauSacs.ToList();
            return _lst;
        }

        public bool Remove(MauSac obj)
        {
            _context.MauSacs.Remove(obj);
            _context.SaveChanges();
            return true;
        }

        public bool Update(MauSac obj)
        {
            _context.MauSacs.Update(obj);
            _context.SaveChanges();
            return true;
        }
    }
}
