using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.View
{
    public partial class FrmHoaDon : Form
    {
        private IHoaDonChiTietServices _hoaDonChiTietServices;
        private ICHoaDonServices _cHoaDonServices;
        private IChiTietSPServices _chiTietSPServices;
        private Guid _ID;
        public FrmHoaDon()
        {
            InitializeComponent();
            _chiTietSPServices = new ChiTietSPServices();
            _hoaDonChiTietServices = new HoaDonChiTietServices();
            _cHoaDonServices = new HoaDonServices();
            loadHD();
        }
        public void loadHD()
        {
            dgrid_hoadon.Rows.Clear();
            dgrid_hoadon.Rows.Clear();
            foreach (var item in _cHoaDonServices.GetAll())
            {
                dgrid_hoadon.Rows.Add(item.Id, item.Ma, item.NgayTao, item.TenNV, item.TenKH, item.SDT, item.ThanhTien, item.TrangThai == 1 ? "Đã thanh toán" : "Chờ thanh toán", item.GhiChu);
            }
        }
        public void loadHDCT(Guid id)
        {
            _ID = id;
            dgrid_hdct.Rows.Clear();
            foreach (var item in _hoaDonChiTietServices.GetAll(id))
            {
                dgrid_hdct.Rows.Add(item.IdChiTietSp, item.TenSP, item.SoLuong, item.DonGia);
            }
        }
        private void btn_TIMKIEM_Click(object sender, EventArgs e)
        {
            dgrid_hoadon.Rows.Clear();
            dgrid_hoadon.Rows.Clear();
            var items = _cHoaDonServices.GetAll().Where(x => x.Ma == Text);
            if (items.Any())
            {
                foreach (var item in _cHoaDonServices.GetAll(txt_TK.Text))
                {
                    dgrid_hoadon.Rows.Add(item.Id, item.Ma, item.NgayTao, item.TenNV, item.TenKH, item.SDT, item.ThanhTien, item.TrangThai == 1 ? "Đã thanh toán" : "Chờ thanh toán", item.GhiChu);
                }
            }
            else
            {
                MessageBox.Show("Không có hóa đơn nào có Mã hóa đơn tương ứng");
            }
        }

        private void btn_XoaHD_Click(object sender, EventArgs e)
        {
            if (_ID == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn");
            }
            else
            {
                var o = _cHoaDonServices.GetAll().FirstOrDefault(x => x.Id == _ID);
                if (o.TrangThai != 1)
                {
                    MessageBox.Show("Chỉ được xóa các hóa đơn chưa thanh toán");
                }
                else
                {
                    var _lstOd = _hoaDonChiTietServices.GetAll().Where(x => x.IdHoaDon == _ID);
                    foreach (var item in _lstOd)
                    {
                        var p = _chiTietSPServices.GetViewChiTietSps().FirstOrDefault(x => x.ID == item.IdChiTietSp);
                        p.SoLuongTon += item.SoLuong;
                        _chiTietSPServices.updateSanPhamChiTiet(p);
                        _hoaDonChiTietServices.Delete(item);
                    }
                    _cHoaDonServices.Delete(o);
                    MessageBox.Show("Xóa thành công");
                    loadHD();
                    dgrid_hdct.Rows.Clear();
                }
            }
        }

        private void dgrid_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _ID = Guid.Parse(dgrid_hoadon.Rows[e.RowIndex].Cells[0].Value.ToString());
                loadHDCT(_ID);
            }
        }
    }
}
