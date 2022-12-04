using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ISizeServices
    {
        bool Add(Sizez sizez);
        bool Update(Sizez sizez);
        bool Delete(Sizez sizez);
        List<Sizez> getSizesFromDB();
    }
}
