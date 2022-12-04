using _1.DAL.ConText;
using _1.DAL.DomainModels;
using _1.DAL.IReposytorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Reposytorys
{
    public class KhachHangReps : IKhachHangReps
    {
        private DUAN1DBContext _DBContext;
        private List<KhachHang> _lstKhachHang;
        public KhachHangReps()
        {
            _DBContext = new DUAN1DBContext();
            _lstKhachHang = new List<KhachHang>();
            GetKhachHangfromDB();
        }
        public bool addKhachHang(KhachHang khachHang)
        {
            if (khachHang == null) return false;
            khachHang.ID = Guid.NewGuid();
            _DBContext.KhachHangs.Add(khachHang);
            _DBContext.SaveChanges();
            return true;
        }

        public bool deleteKhachHang(KhachHang khachHang)
        {
            if (khachHang == null) return false;
            var temp = _DBContext.KhachHangs.FirstOrDefault(c => c.ID == khachHang.ID);
            _DBContext.KhachHangs.Remove(temp);
            _DBContext.SaveChanges();
            return true;
        }

        public List<KhachHang> GetKhachHangfromDB()
        {
            _lstKhachHang = _DBContext.KhachHangs.ToList();
            return _lstKhachHang;
        }

        public bool updateKhachHang(KhachHang khachHang)
        {
            if (khachHang == null) return false;
            var temp = _DBContext.KhachHangs.FirstOrDefault(c => c.ID == khachHang.ID);
            temp.Ma = khachHang.Ma;
            temp.Ho = khachHang.Ho;
            temp.Ten = khachHang.Ten;
            temp.TenDem = khachHang.TenDem;
            temp.SDT = khachHang.SDT;
            temp.GioiTinh = khachHang.GioiTinh;
            temp.NgaySinh = khachHang.NgaySinh;
            temp.CMND = khachHang.CMND;
            temp.DiaChi = khachHang.DiaChi;
            temp.ThanhPho = khachHang.ThanhPho;
            temp.QuocGia = khachHang.QuocGia;
            temp.TrangThai = khachHang.TrangThai;
            _DBContext.KhachHangs.Update(temp);
            _DBContext.SaveChanges();
            return true;
        }
    }
}
