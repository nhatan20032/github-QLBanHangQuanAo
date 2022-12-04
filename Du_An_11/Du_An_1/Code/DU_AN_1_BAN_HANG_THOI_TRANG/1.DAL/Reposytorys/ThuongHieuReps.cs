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
    public class ThuongHieuReps : IThuongHieuReps
    {
        public DUAN1DBContext _dbContext;
        public ThuongHieuReps()
        {
            _dbContext = new DUAN1DBContext();
        }
        public bool Add(ThuongHieu obj)
        {
            if (obj == null) return false;
            obj.ID = Guid.NewGuid();
            _dbContext.ThuongHieus.Add(obj);
            _dbContext.SaveChanges();
            return true;

        }

        public bool Delete(ThuongHieu obj)
        {
            if (obj == null) return false;
            var tempoj = _dbContext.ThuongHieus.FirstOrDefault(c => c.ID == obj.ID);
            _dbContext.ThuongHieus.Remove(tempoj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<ThuongHieu> GetAll()
        {
            return _dbContext.ThuongHieus.ToList();
        }

        public bool Update(ThuongHieu obj)
        {
            if (obj == null) return false;
            var tempoj = _dbContext.ThuongHieus.FirstOrDefault(c => c.ID == obj.ID);
            tempoj.Ma = obj.Ma;
            tempoj.Ten = obj.Ten;
            tempoj.MoTa = obj.MoTa;
            tempoj.TrangThai = obj.TrangThai;
            _dbContext.ThuongHieus.Update(tempoj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
