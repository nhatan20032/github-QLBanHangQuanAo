using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IReposytorys
{
    public interface ISizeReps
    {
        bool Add(Sizez siZez);
        bool Update(Sizez siZez);
        bool Delete(Sizez siZez);
        List<Sizez> getSizesFromDB();
    }
}
