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
    public class HinhThucThanhToanServices : IHinhThucThanhToanServices
    {
        private IHinhThucThanhToanReps _ihinhThucThanhToanReps;
        private List<HinhThucThanhToan> _lsthinhThucThanhToans;
        public HinhThucThanhToanServices()
        {
            _ihinhThucThanhToanReps = new HinhThucThanhToanReps();
            _lsthinhThucThanhToans = new List<HinhThucThanhToan>();
        }

        public bool Add(HinhThucThanhToan obj)
        {
            _ihinhThucThanhToanReps.Add(obj);
            return true;
        }
        public bool Delete(HinhThucThanhToan obj)
        {
            _ihinhThucThanhToanReps.Delete(obj);
            return true;
        }

        public List<HinhThucThanhToan> GetAll()
        {
            _lsthinhThucThanhToans = _ihinhThucThanhToanReps.GetAll();
            return _lsthinhThucThanhToans;
        }

        public List<HinhThucThanhToan> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();

            }
            return _ihinhThucThanhToanReps.GetAll().Where(c => c.Ten.ToLower().Contains(input.ToLower()) || c.Ma.ToLower().Contains(input.ToLower())).ToList();
        }
        public bool Update(HinhThucThanhToan obj)
        {
            _ihinhThucThanhToanReps.Update(obj);
            return true;
        }
    }
}
