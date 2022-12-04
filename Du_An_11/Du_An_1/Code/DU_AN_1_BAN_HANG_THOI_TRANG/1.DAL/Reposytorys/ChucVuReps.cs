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
    public class ChucVuReps : IChucVuReps
    {
        private DUAN1DBContext _dbContext;
        public ChucVuReps()
        {
            _dbContext = new DUAN1DBContext();
        }
        public bool Add(ChucVu obj)
        {
            if (obj == null) return false;
            _dbContext.ChucVus.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(ChucVu obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.ChucVus.FirstOrDefault(c => c.ID == obj.ID);
            tempobj.ID = obj.ID;
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            tempobj.TrangThai = obj.TrangThai;
            _dbContext.ChucVus.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChucVu obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.ChucVus.FirstOrDefault(c => c.ID == obj.ID);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<ChucVu> GetAll()
        {
            return _dbContext.ChucVus.ToList();
        }
    }
}
