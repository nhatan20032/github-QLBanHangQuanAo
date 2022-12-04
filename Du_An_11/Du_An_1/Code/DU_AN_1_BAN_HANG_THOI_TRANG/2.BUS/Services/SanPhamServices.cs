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
    public class SanPhamServices : ISanPhamServices
    {
        private ISanPhamReps _isanPhamReps;
        private List<SanPham> _lstsanPhams;
        public SanPhamServices()
        {
            _isanPhamReps = new SanPhamReps();
            _lstsanPhams = new List<SanPham>();

        }
        public string Add(SanPham obj)
        {
            _isanPhamReps.Add(obj);
            return "Thành công";

        }

        public string Delete(SanPham obj)
        {
            _isanPhamReps.Delete(obj);
            return "Thành công";
        }

        public List<SanPham> GetAll()
        {
            _lstsanPhams = _isanPhamReps.GetAll();
            return _lstsanPhams;
        }

        public List<SanPham> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }
            return _isanPhamReps.GetAll().Where(c => c.Ten.ToLower().Contains(input.ToLower()) || c.Ma.ToLower().Contains(input.ToLower())).ToList();
        }

        public string Update(SanPham obj)
        {
            _isanPhamReps.Update(obj);
            return "Thành công";
        }
    }
}
