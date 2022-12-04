using _1.DAL.DomainModels;
using _1.DAL.IReposytorys;
using _1.DAL.Reposytorys;
using _2.BUS.IServices;
using _2.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class ChiTietSPServices : IChiTietSPServices
    {
        private IChiTietSPReps _chiTietSPReps;
        private ISanPhamReps _sanPhamReps;
        private IDongSPReps _dongSPReps;
        private ISizeReps _sizeReps;
        private IMauSacReps _mauSacReps;
        private IThuongHieuReps _thuongHieuReps;
        private IChatLieuReps _chatLieuReps;
        private List<ViewChiTietSP> _viewChiTietSPs;
        private List<ChiTietSP> _lstchiTietSPs;
        public ChiTietSPServices()
        {
            _chiTietSPReps = new ChiTietSPReps();
            _mauSacReps = new MauSacReps();
            _sanPhamReps = new SanPhamReps();
            _sizeReps = new SizeReps();
            _thuongHieuReps = new ThuongHieuReps();
            _dongSPReps = new DongSPReps();
            _chatLieuReps = new ChatLieuReps();
        }

        public bool addSanPhamChiTiet(ViewChiTietSP chiTietSP)
        {
            var nv = new ChiTietSP()
            {
                ID = chiTietSP.ID,
                Ma = chiTietSP.Ma,
                IDDongSP = chiTietSP.IDDongSP,
                IDMauSac = chiTietSP.IDMauSac,
                IDSize = chiTietSP.IDSize,
                AnhMoTa = chiTietSP.AnhMoTa,
                IDSP = chiTietSP.IDSP,
                IDThuongHieu = chiTietSP.IDThuongHieu,
                IDChatLieu = chiTietSP.IDChatLieu,
                SoLuongTon = chiTietSP.SoLuongTon,
                GiaNhap = chiTietSP.GiaNhap,
                GiaBan = chiTietSP.GiaBan,
                MoTa = chiTietSP.MoTa,
                TrangThai = chiTietSP.TrangThai,
            };
            _chiTietSPReps.addChiTietSP(nv);
            return true;
        }

        public bool deleteSanPhamChiTiet(Guid idnv)
        {
            var x = _chiTietSPReps.GetChiTietSP().FirstOrDefault(p => p.ID == idnv);
            _chiTietSPReps.deleteChiTietSP(x);
            return true;
        }

        public List<ChiTietSP> GetChiTietSPs()
        {
            _lstchiTietSPs = _chiTietSPReps.GetChiTietSP().ToList();
            return _lstchiTietSPs;
        }

        public List<ViewChiTietSP> GetViewChiTietSps()
        {
            _viewChiTietSPs = (from a in _chiTietSPReps.GetChiTietSP()
                               join b in _mauSacReps.GetAll() on a.IDMauSac equals b.ID
                               join c in _sanPhamReps.GetAll() on a.IDSP equals c.ID
                               join d in _sizeReps.getSizesFromDB() on a.IDSize equals d.ID
                               join e in _thuongHieuReps.GetAll() on a.IDThuongHieu equals e.ID
                               join f in _dongSPReps.GetAll() on a.IDDongSP equals f.ID
                               join g in _chatLieuReps.getChatLieuFromDB() on a.IDChatLieu equals g.ID
                               select new ViewChiTietSP
                               {
                                   ID = a.ID,
                                   Ma = a.Ma,
                                   IDDongSP = a.IDDongSP,
                                   IDMauSac = a.IDMauSac,
                                   IDSize = a.IDSize,
                                   IDThuongHieu = a.IDThuongHieu,
                                   IDSP = a.IDSP,
                                   IDChatLieu = a.IDChatLieu,
                                   GiaBan = a.GiaBan,
                                   GiaNhap = a.GiaNhap,
                                   MoTa = a.MoTa,
                                   SoLuongTon = a.SoLuongTon,
                                   TenDongSP = f.Ten,
                                   TenMauSac = b.Ten,
                                   TenSP = c.Ten,
                                   TenSize = d.Ten,
                                   TenThuongHieu = e.Ten,
                                   TenChatLieu = g.Ten,
                                   AnhMoTa = a.AnhMoTa,
                                   TrangThai = a.TrangThai
                               }).ToList();
            return _viewChiTietSPs;
        }

        public bool updateSanPhamChiTiet(ViewChiTietSP chiTietSP)
        {
            var x = _chiTietSPReps.GetChiTietSP().FirstOrDefault(p => p.ID == chiTietSP.ID);
            x.IDDongSP = chiTietSP.IDDongSP;
            x.IDDongSP = chiTietSP.IDDongSP;
            x.Ma = chiTietSP.Ma;
            x.AnhMoTa = chiTietSP.AnhMoTa;
            x.IDSize = chiTietSP.IDSize;
            x.IDThuongHieu = chiTietSP.IDThuongHieu;
            x.IDChatLieu = chiTietSP.IDChatLieu;
            x.IDSP = chiTietSP.IDSP;
            x.GiaNhap = chiTietSP.GiaNhap;
            x.GiaBan = chiTietSP.GiaBan;
            x.MoTa = chiTietSP.MoTa;
            x.SoLuongTon = chiTietSP.SoLuongTon;
            x.TrangThai = chiTietSP.TrangThai;
            _chiTietSPReps.updateChiTietSP(x);
            return true;
        }
    }
}
