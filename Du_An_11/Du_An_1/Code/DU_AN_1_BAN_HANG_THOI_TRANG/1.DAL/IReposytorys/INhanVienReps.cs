using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IReposytorys
{
    public interface INhanVienReps
    {
        bool addNhanVien(NhanVien nhanVien);
        bool updateNhanVien(NhanVien nhanVien);
        bool deleteNhanVien(NhanVien nhanVien);
        List<NhanVien> GetNhanVien();
        NhanVien GetNhanVien(string ma, string matkhau);
        NhanVien GetCheck(string Email);
        NhanVien GetCheckPass(string Pass);
    }
}
