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
    public class CuaHangReps : ICuaHangReps
    {
        private DUAN1DBContext _dbContext;
        public CuaHangReps()
        {
            _dbContext = new DUAN1DBContext();
        }
        public bool Add(CuaHang obj)
        {
            if (obj == null) return false;
            _dbContext.CuaHangs.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(CuaHang obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.CuaHangs.FirstOrDefault(c => c.ID == obj.ID);
            tempobj.ID = obj.ID;
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            tempobj.TrangThai = obj.TrangThai;
            _dbContext.CuaHangs.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(CuaHang obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.CuaHangs.FirstOrDefault(c => c.ID == obj.ID);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
        public List<CuaHang> GetAll()
        {
            return _dbContext.CuaHangs.ToList();
        }
    }
}
