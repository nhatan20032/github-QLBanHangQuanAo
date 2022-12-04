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
    public class ChiTietSPReps : IChiTietSPReps
    {
        private DUAN1DBContext _context;
        private List<ChiTietSP> _lstchiTietSPs;
        public ChiTietSPReps()
        {
            _context = new DUAN1DBContext();
            _lstchiTietSPs = new List<ChiTietSP>();
        }

        public bool addChiTietSP(ChiTietSP chiTietSP)
        {
            _context.CTSanPhams.Add(chiTietSP);
            _context.SaveChanges();
            return true;
        }

        public bool deleteChiTietSP(ChiTietSP chiTietSP)
        {
            _context.CTSanPhams.Remove(chiTietSP);
            _context.SaveChanges();
            return true;
        }

        public List<ChiTietSP> GetChiTietSP()
        {
            _lstchiTietSPs = _context.CTSanPhams.ToList();
            return _lstchiTietSPs;
        }

        public bool updateChiTietSP(ChiTietSP chiTietSP)
        {
            _context.CTSanPhams.Update(chiTietSP);
            _context.SaveChanges();
            return true;
        }
    }
}
