using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IReposytorys
{
    public interface IKhachHangReps
    {
        bool addKhachHang(KhachHang khachHang);
        bool deleteKhachHang(KhachHang khachHang);
        bool updateKhachHang(KhachHang khachHang);

        List<KhachHang> GetKhachHangfromDB();
    }
}
