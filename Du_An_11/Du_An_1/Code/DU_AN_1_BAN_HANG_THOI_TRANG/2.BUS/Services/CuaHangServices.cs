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
    public class CuaHangServices : ICuaHangServices
    {
        private ICuaHangReps _icuaHangReps;
        private List<CuaHang> _cuaHangs;
        public CuaHangServices()
        {
            _icuaHangReps = new CuaHangReps();
            _cuaHangs = new List<CuaHang>();
        }

        public string Add(CuaHang obj)
        {
            _icuaHangReps.Add(obj);
            return "Thành công";
        }

        public string Delete(CuaHang obj)
        {
            _icuaHangReps.Delete(obj);
            return "Thành công";
        }

        public List<CuaHang> GetAll()
        {
            _cuaHangs = _icuaHangReps.GetAll();
            return _cuaHangs;
        }

        public List<CuaHang> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }
            return _icuaHangReps.GetAll().Where(c => c.Ten.ToLower().Contains(input.ToLower()) || c.Ma.ToLower().Contains(input.ToLower())).ToList();
        }
        public string Update(CuaHang obj)
        {
            _icuaHangReps.Update(obj);
            return "Thành công";
        }
    }
}
