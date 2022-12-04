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
    public class HinhThucThanhToanReps : IHinhThucThanhToanReps
    {
        public DUAN1DBContext _dbContext;
        public HinhThucThanhToanReps()
        {
            _dbContext = new DUAN1DBContext();
        }

        public bool Add(HinhThucThanhToan obj)
        {
            if (obj == null) return false;
            obj.ID = Guid.NewGuid();
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;

        }

        public bool Delete(HinhThucThanhToan obj)
        {
            if (obj == null) return false;
            var tempoj = _dbContext.ThanhToans.FirstOrDefault(c => c.ID == obj.ID);
            _dbContext.Remove(tempoj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<HinhThucThanhToan> GetAll()
        {
            return _dbContext.ThanhToans.ToList();

        }

        public bool Update(HinhThucThanhToan obj)
        {

            if (obj == null) return false;
            var tempoj = _dbContext.ThanhToans.FirstOrDefault(c => c.ID == obj.ID);
            tempoj.Ma = obj.Ma;
            tempoj.TrangThai = obj.TrangThai;
            tempoj.Ten = obj.Ten;

            _dbContext.Update(tempoj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
