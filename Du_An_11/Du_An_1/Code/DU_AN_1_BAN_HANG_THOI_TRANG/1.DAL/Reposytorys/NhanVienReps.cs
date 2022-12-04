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
    public class NhanVienReps : INhanVienReps
    {
        private DUAN1DBContext _context;
        private List<NhanVien> _nhanVienslst;
        public NhanVienReps()
        {
            _context = new DUAN1DBContext();
            _nhanVienslst = new List<NhanVien>();
        }
        public bool addNhanVien(NhanVien nhanVien)
        {
            _context.NhanViens.Add(nhanVien);
            _context.SaveChanges();
            return true;
        }

        public bool deleteNhanVien(NhanVien nhanVien)
        {
            _context.NhanViens.Remove(nhanVien);
            _context.SaveChanges();
            return true;
        }

        public List<NhanVien> GetNhanVien()
        {
            _nhanVienslst = _context.NhanViens.ToList();
            return _nhanVienslst;
        }

        public bool updateNhanVien(NhanVien nhanVien)
        {
            _context.NhanViens.Update(nhanVien);
            _context.SaveChanges();
            return true;
        }
        public NhanVien GetCheck(string Email)
        {
            NhanVien nv = _context.NhanViens.FirstOrDefault(p => p.Email == Email);
            return nv;
        }

        public NhanVien GetCheckPass(string Pass)
        {
            NhanVien nv = _context.NhanViens.FirstOrDefault(p => p.MatKhau == Pass);
            return nv;
        }
        public NhanVien GetNhanVien(string ma, string matkhau)
        {
            NhanVien nv = _context.NhanViens.FirstOrDefault(p => p.Ma == ma && p.MatKhau == matkhau);
            return nv;
        }
    }
}
