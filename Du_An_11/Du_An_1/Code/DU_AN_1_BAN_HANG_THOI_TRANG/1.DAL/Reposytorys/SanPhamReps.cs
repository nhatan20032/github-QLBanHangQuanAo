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
    public class SanPhamReps : ISanPhamReps
    {
        public DUAN1DBContext _dbContext;
        public SanPhamReps()
        {
            _dbContext = new DUAN1DBContext();
        }

        public bool Add(SanPham obj)
        {
            if (obj == null) return false;
            obj.ID = Guid.NewGuid();
            _dbContext.SanPhams.Add(obj);
            _dbContext.SaveChanges();
            return true;

        }

        public bool Delete(SanPham obj)
        {
            if (obj == null) return false;
            var tempoj = _dbContext.SanPhams.FirstOrDefault(c => c.ID == obj.ID);
            _dbContext.SanPhams.Remove(tempoj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<SanPham> GetAll()
        {
            return _dbContext.SanPhams.ToList();
        }

        //public SanPham GetById(Guid Id)
        //{

        //}

        public bool Update(SanPham obj)
        {
            if (obj == null) return false;
            var tempoj = _dbContext.SanPhams.FirstOrDefault(c => c.ID == obj.ID);
            tempoj.Ma = obj.Ma;
            tempoj.Ten = obj.Ten;
            tempoj.TrangThai = obj.TrangThai;
            _dbContext.SanPhams.Update(tempoj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
