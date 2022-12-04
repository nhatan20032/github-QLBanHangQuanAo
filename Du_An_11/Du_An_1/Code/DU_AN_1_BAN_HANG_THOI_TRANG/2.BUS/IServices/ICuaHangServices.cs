using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ICuaHangServices
    {
        string Add(CuaHang obj);
        string Update(CuaHang obj);
        string Delete(CuaHang obj);
        List<CuaHang> GetAll();
        List<CuaHang> GetAll(string input);
    }
}
