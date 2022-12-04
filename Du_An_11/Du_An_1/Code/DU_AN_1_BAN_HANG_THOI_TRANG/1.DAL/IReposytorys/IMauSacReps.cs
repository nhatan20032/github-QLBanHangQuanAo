using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IReposytorys
{
    public interface IMauSacReps
    {
        public bool Add(MauSac obj);
        public bool Remove(MauSac obj);
        public bool Update(MauSac obj);
        public List<MauSac> GetAll();
        public string Check(string input);
    }
}
