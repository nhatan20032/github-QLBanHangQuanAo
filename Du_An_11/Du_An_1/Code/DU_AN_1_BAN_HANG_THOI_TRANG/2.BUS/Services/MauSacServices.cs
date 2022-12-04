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
    public class MauSacServices : IMauSacServices
    {
        IMauSacReps _IMauSacRp;
        public MauSacServices()
        {
            _IMauSacRp = new MauSacReps();
        }
        public bool Add(MauSac obj)
        {
            _IMauSacRp.Add(obj);
            return true;
        }

        public List<MauSac> GetAll()
        {
            return _IMauSacRp.GetAll();
        }

        public List<MauSac> GetAll(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return GetAll();
            }
            return _IMauSacRp.GetAll().Where(c => c.Ten.ToLower().Contains(input.ToLower()) || c.Ma.ToLower().Contains(input.ToLower())).ToList();

        }

        public bool Remove(MauSac obj)
        {
            _IMauSacRp.Remove(obj);
            return true;
        }

        public bool Update(MauSac obj)
        {
            _IMauSacRp.Update(obj);
            return true;
        }
    }
}
