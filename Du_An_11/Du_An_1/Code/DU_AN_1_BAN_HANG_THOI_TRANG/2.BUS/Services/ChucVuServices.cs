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
    public class ChucVuServices : IChucVuServices
    {
        private IChucVuReps _IChucVuServices;
        private List<ChucVu> _ChucVu;
        public ChucVuServices()
        {
            _IChucVuServices = new ChucVuReps();
            _ChucVu = new List<ChucVu>();
        }

        public string Add(ChucVu chucVu)
        {
            _IChucVuServices.Add(chucVu);
            return "Thành công";
        }

        public string Delete(ChucVu chucVu)
        {
            _IChucVuServices.Delete(chucVu);
            return "Thành công";
        }

        public List<ChucVu> GetAll()
        {
            _ChucVu = _IChucVuServices.GetAll();
            return _ChucVu;
        }

        public List<ChucVu> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }
            return _IChucVuServices.GetAll().Where(c => c.Ten.ToLower().Contains(input.ToLower()) || c.Ma.ToLower().Contains(input.ToLower())).ToList();
        }
        public string Update(ChucVu chucVu)
        {
            _IChucVuServices.Update(chucVu);
            return "Thành công";
        }
    }
}
