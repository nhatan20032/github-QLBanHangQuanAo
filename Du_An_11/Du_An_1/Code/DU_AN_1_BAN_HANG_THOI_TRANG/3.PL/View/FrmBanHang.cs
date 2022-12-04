using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModel;
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
    public partial class FrmBanHang : Form
    {
        private IHoaDonChiTietServices _hoaDonChiTietServices;
        private ICHoaDonServices _cHoaDonServices;
        private IChiTietSPServices _chiTietSPServices;
        private INhanVienServices _nhanVienServices;
        private IKhachHangServices _khachHangServices;
        private IHinhThucThanhToanServices _hinhThucThanhToanServices;
        public List<ViewHoaDonChiTiet> _lsthoaDonChiTiet;
        public Guid _Id1;
        public Guid _Id2;
        public ViewKhachHang c;
        public FrmBanHang()
        { 
            InitializeComponent();
            _chiTietSPServices = new ChiTietSPServices();
            _nhanVienServices = new NhanVienServices();
            _khachHangServices = new KhachHangServices();
            _cHoaDonServices = new HoaDonServices();
            _hinhThucThanhToanServices = new HinhThucThanhToanServices();
            _hoaDonChiTietServices = new HoaDonChiTietServices();
            _lsthoaDonChiTiet = new List<ViewHoaDonChiTiet>();
            c = new ViewKhachHang();
            loadSanPham();
        }
        public void loadSanPham()
        {
            dgrid_dssp.Rows.Clear();
            foreach (var item in _chiTietSPServices.GetViewChiTietSps().Where(x => x.TrangThai == 1 && x.SoLuongTon > 0))
            {
                dgrid_dssp.Rows.Add(item.ID, item.Ma, item.TenSP, item.TenMauSac, item.TenSize, item.TenChatLieu, item.TenDongSP, item.TenThuongHieu, item.GiaBan, item.SoLuongTon);
            }
        }
        public void TinhTong()
        {
            if (_lsthoaDonChiTiet != null)
            {
                decimal? total = 0;
                foreach (var item in _lsthoaDonChiTiet)
                {
                    total += Convert.ToInt32(item.DonGia) * item.SoLuong;
                }
                lbt_Tongtien.Text = total.ToString();
            }
            else
            {
                lbt_Tongtien.Text = "";
            }
        }
        public void loadGioHang()
        {
            dgrid_giohang.Rows.Clear();
            foreach (var item in _lsthoaDonChiTiet)
            {
                dgrid_giohang.Rows.Add(item.Ma, item.TenSP, item.SoLuong, item.DonGia);
            }
            dgrid_giohang.DefaultCellStyle.ForeColor = Color.Red;
            TinhTong();
        }
        //Hiện Hóa Đơn Chờ
        public void loadHDcho()
        {
            dgrid_HDC.Rows.Clear();
            var hdCho = (from a in _cHoaDonServices.GetAll()
                         join b in _khachHangServices.GetAll() on a.IdKh equals b.Id
                         where a.TrangThai != 1
                         select new { a, b });
            foreach (var item in hdCho)
            {
                dgrid_HDC.Rows.Add(item.a.Id, item.b.Ten, item.b.Sdt);
            }
        }
        public void addGioHang(Guid pID)
        {
            var p = _chiTietSPServices.GetChiTietSPs().FirstOrDefault(x => x.ID == pID);
            var data = _lsthoaDonChiTiet.FirstOrDefault(x => x.IdChiTietSp == p.ID);
            if (data == null)
            {
                ViewHoaDonChiTiet orderDetailVM = new ViewHoaDonChiTiet()
                {
                    IdChiTietSp = p.ID,
                    //TenSP = p.,
                    DonGia = p.GiaBan,
                    SoLuong = 1,
                    Ma = p.Ma,
                };
                _lsthoaDonChiTiet.Add(orderDetailVM);
            }
            else
            {
                if (data.SoLuong == p.SoLuongTon)
                {
                    MessageBox.Show("Sản phẩm trong giỏ hàng đã vượt quá số lượng cho phép");
                }
                else
                {
                    data.SoLuong++;
                }
            }
            loadGioHang();
        }
        private void dgrid_dssp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Guid guid;
                DataGridViewRow r = dgrid_dssp.Rows[e.RowIndex];
                guid = Guid.Parse(r.Cells[0].Value.ToString());
                _Id1 = _chiTietSPServices.GetViewChiTietSps().FirstOrDefault(x => x.ID == Guid.Parse(r.Cells[0].Value.ToString())).ID;
                addGioHang(_Id1);
            }
        }

        private void dgrid_giohang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgrid_giohang.Rows[e.RowIndex];
                if (int.TryParse(dgrid_giohang.Rows[r.Index].Cells[3].Value.ToString(), out int x))
                {
                    if (dgrid_giohang.Rows[r.Index].Cells[3].Value != _lsthoaDonChiTiet[r.Index].SoLuong.ToString())
                    {
                        if (Convert.ToInt32(dgrid_giohang.Rows[r.Index].Cells[3].Value) <= 0)
                        {
                            MessageBox.Show("Nhập sai số lượng");
                            dgrid_giohang.Rows[r.Index].Cells[3].Value = _lsthoaDonChiTiet[r.Index].SoLuong;
                        }
                        else
                        {
                            var p = _chiTietSPServices.GetChiTietSPs().FirstOrDefault(x => x.ID == _lsthoaDonChiTiet[r.Index].Id);
                            if (p.SoLuongTon < Convert.ToInt32(dgrid_giohang.Rows[r.Index].Cells[3].Value))
                            {
                                MessageBox.Show("Sản phẩm trong giỏ hàng đã vượt quá số lượng cho phép");
                                dgrid_giohang.Rows[r.Index].Cells[3].Value = _lsthoaDonChiTiet[r.Index].SoLuong;
                            }
                            else
                            {
                                _lsthoaDonChiTiet[r.Index].SoLuong = Convert.ToInt32(dgrid_giohang.Rows[r.Index].Cells[3].Value);
                                TinhTong();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nhập sai số lượng");
                    dgrid_giohang.Rows[r.Index].Cells[3].Value = _lsthoaDonChiTiet[r.Index].SoLuong;
                }
            }
        }
        public void loadTienThua()
        {
            if (!(txt_khachTra.Text == ""))
            {
                if (txt_Diem.Text == "")
                {
                    if (decimal.TryParse(txt_khachTra.Text, out decimal x))
                    {
                        txt_thua.Text = (Convert.ToDecimal(txt_khachTra.Text) - Convert.ToDecimal(lbl_tongtien.Text)).ToString();
                    }
                }
                else
                {
                    if (decimal.TryParse(txt_khachTra.Text, out decimal x) && decimal.TryParse(txt_Diem.Text, out decimal y))
                    {
                        txt_thua.Text = (Convert.ToDecimal(txt_khachTra.Text) - Convert.ToDecimal(lbl_tongtien.Text) + Convert.ToDecimal(txt_Diem.Text)).ToString();
                    }
                }
            }
        }
        private void txt_khachTra_TextChanged(object sender, EventArgs e)
        {
            loadTienThua();
        }
        //Bấm Thanh Toán
        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_maHD.Text, out int m) && txt_maHD.Text != "")
            {
                var HD = _cHoaDonServices.GetAll().FirstOrDefault(x => x.Ma == txt_maHD.Text && x.TrangThai != 1);
                var HTTT = _hinhThucThanhToanServices.GetAll().FirstOrDefault(x => x.Ten == cbx_HTTT.Text && x.TrangThai == 1);
                if (HD == null)
                {
                    MessageBox.Show("Đơn hàng không tồn tại hoặc đã thanh toán");
                    lbl_tongtien.Text = "0";
                }
                else
                {
                    var khachHang = _khachHangServices.GetAll().FirstOrDefault(x => x.Id == HD.IdKh);
                    int x;
                    if (txt_Diem.Text == "" || Convert.ToDecimal(txt_thua.Text) < 0 || txt_khachTra.Text == "" || (!int.TryParse(txt_Diem.Text, out x) && txt_Diem.Text != "") || !int.TryParse(txt_khachTra.Text, out int y) || x > khachHang.Point || x < 0 || Convert.ToDecimal(txt_Diem.Text) > Convert.ToDecimal(lbl_tongtien.Text) || x > khachHang.Point)
                    {
                        MessageBox.Show("Vui lòng nhập đúng số tiền");
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thanh toán không?", "Thanh toán", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            HD.TrangThai = 1;
                            HD.IdHTTT = HTTT.ID;
                            _cHoaDonServices.Update(HD);
                            if (txt_khachTra.Text == "0" && Convert.ToDecimal(txt_Diem.Text) > HD.ThanhTien)
                            {
                                txt_thua.Text = "0";
                                khachHang.Point -= Convert.ToInt32(HD.ThanhTien);
                            }
                            else
                            {
                                if (txt_Diem.Text != "")
                                {
                                    if (HD.ThanhTien < 1000000)
                                    {
                                        khachHang.Point = khachHang.Point + Convert.ToInt32(HD.ThanhTien / 1000) - Convert.ToInt32(txt_thua.Text);
                                    }
                                    else
                                    {
                                        khachHang.Point = khachHang.Point + Convert.ToInt32(HD.ThanhTien / 100) - Convert.ToInt32(txt_thua.Text);
                                    }
                                }
                                else
                                {
                                    if (HD.ThanhTien < 1000000)
                                    {
                                        khachHang.Point = khachHang.Point + Convert.ToInt32(HD.ThanhTien / 1000);
                                    }
                                    else
                                    {
                                        khachHang.Point = khachHang.Point + Convert.ToInt32(HD.ThanhTien / 100);
                                    }
                                }
                            }
                            _khachHangServices.Update(khachHang);
                            MessageBox.Show("Thanh toán thành công");
                            txt_thua.Text = "";
                            txt_Diem.Text = "";
                            txt_khachTra.Text = "0";
                            lbl_tongtien.Text = "0";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn");
            }
        }
        private void txt_maHD_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txt_maHD.Text, out int m))
            {
                var o = _cHoaDonServices.GetAll().FirstOrDefault(x => x.Ma == txt_maHD.Text && x.TrangThai != 1);
                if (o != null)
                {
                    lbl_tongtien.Text = o.ThanhTien.ToString();
                    var customer = _khachHangServices.GetAll().FirstOrDefault(x => x.Id == o.IdKh);
                    lb_Diem.Text = $"(Tối đa : {customer.Point})";
                }
                else
                {
                    lbl_tongtien.Text = "0";
                    lb_Diem.Text = "(Tối đa : 0)";
                }
            }
        }

        private void txt_Diem_TextChanged(object sender, EventArgs e)
        {
            loadTienThua();
        }

        private void dgrid_giohang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgrid_giohang.Rows[e.RowIndex];
                //pID = Convert.ToInt32(r.Cells[0].Value.ToString());
                _Id2 = _chiTietSPServices.GetViewChiTietSps().FirstOrDefault(x => x.Ma == r.Cells[0].Value.ToString()).ID;
                addGioHang(_Id2);
            }
        }
        //Xóa SP ở Giỏ Hàng 
        private void btn_XoaSP_Click(object sender, EventArgs e)
        {
            if (_lsthoaDonChiTiet.Any())
            {
                var item = _lsthoaDonChiTiet.FirstOrDefault(x => x.IdChiTietSp == _Id2);
                _lsthoaDonChiTiet.Remove(item);
                loadGioHang();
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
            }
        }
        private void btn_XoaGH_Click(object sender, EventArgs e)
        {
            if (_lsthoaDonChiTiet.Any())
            {
                _lsthoaDonChiTiet = new List<ViewHoaDonChiTiet>();
                loadGioHang();
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
            }
        }
        //Tạo HĐ
        private void btn_TaoHD_Click(object sender, EventArgs e)
        {
            if (_lsthoaDonChiTiet.Any())
            {
                decimal? total = 0;
                foreach (var item in _lsthoaDonChiTiet)
                {
                    total += item.DonGia * Convert.ToDecimal(item.SoLuong);
                }
                Guid eID = _nhanVienServices.GetViewChiTietSps().FirstOrDefault(x => x.Email == Properties.Settings.Default.TKdaLogin).IdNv;
                c = _khachHangServices.GetAll().FirstOrDefault(x => x.Sdt == txt_SDT.Text);
                if (c != null)
                {
                    ViewHoaDon o = new ViewHoaDon()
                    {
                        NgayTao = DateTime.Now,
                        NgayThanhToan = DateTime.Now,
                        IdKh = c.Id,
                        ThanhTien = total,
                        TrangThai = 0,
                        GhiChu = ""
                    };
                    _cHoaDonServices.Add(o);
                    foreach (var item in _lsthoaDonChiTiet)
                    {
                        ViewHoaDonChiTiet od = new ViewHoaDonChiTiet()
                        {
                            //Id = Guid.NewGuid(),
                            IdHoaDon = o.Id,
                            IdChiTietSp = item.IdChiTietSp,
                            DonGia = item.DonGia,
                            SoLuong = item.SoLuong,
                        };
                        _hoaDonChiTietServices.Add(od);
                        var p = _chiTietSPServices.GetChiTietSPs().FirstOrDefault(x => x.ID == item.IdChiTietSp);
                        ViewChiTietSP viewSP = new ViewChiTietSP()
                        {
                            ID = item.IdChiTietSp,
                            SoLuongTon = p.SoLuongTon - item.SoLuong,
                        };
                        _chiTietSPServices.updateSanPhamChiTiet(viewSP);
                    }

                    txt_maHD.Text = o.Ma.ToString();
                    lbl_tongtien.Text = o.ThanhTien.ToString();
                    txt_SDT.Text = "";
                    lbt_Tongtien.Text = "";
                    MessageBox.Show($"Tạo hóa đơn thành công. ID: {o.Id}");
                    loadSanPham();
                    loadHDcho();
                    _lsthoaDonChiTiet = new List<ViewHoaDonChiTiet>();
                    dgrid_giohang.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập khách hàng");
                }
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
            }
        }

        //Tìm Khách Hàng Theo Ma
        private void txt_SDT_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txt_SDT.Text, out int x))
            {
                c = _khachHangServices.GetAll().FirstOrDefault(x => x.Sdt == txt_SDT.Text);
                if (c != null)
                {
                    lbl_TenKH.Text = c.Ho + " " + c.TenDem + " " + c.Ten;
                    lbl_Diem.Text = c.Point.ToString();
                    lbl_DC.Text = c.DiaChi;
                }
                else
                {
                    lbl_TenKH.Text = "";
                    lbl_Diem.Text = "";
                    lbl_DC.Text = "";
                }
            }
            else
            {
                lbl_TenKH.Text = "";
                lbl_Diem.Text = "";
                lbl_DC.Text = "";
            }
        }
        private void dgrid_HDC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgrid_HDC.Rows[e.RowIndex];
                _Id1 = Guid.Parse(r.Cells[0].Value.ToString());
                //txt_maHD.Text = _Id1.ToString();
                var od = _hoaDonChiTietServices.GetAll().Where(x => x.IdHoaDon == _Id1);
                var cid = _cHoaDonServices.GetAll().FirstOrDefault(x => x.Id == _Id1).IdKh;
                var c = _khachHangServices.GetAll().FirstOrDefault(x => x.Id == cid);
                txt_SDT.Text = c.Sdt;
                lbl_TenKH.Text = c.Ho + " " + c.TenDem + " " + c.Ten;
                lbl_DC.Text = c.Ho + " " + c.TenDem + " " + c.Ten;
                _lsthoaDonChiTiet = new List<ViewHoaDonChiTiet>();
                foreach (var item in od)
                {
                    var p = _chiTietSPServices.GetViewChiTietSps().FirstOrDefault(x => x.ID == item.IdChiTietSp);

                    ViewHoaDonChiTiet orderDetailVM = new ViewHoaDonChiTiet()
                    {
                        IdChiTietSp = p.ID,
                        Ma = p.Ma,
                        TenSP = p.TenSP,
                        DonGia = p.GiaBan,
                        SoLuong = od.FirstOrDefault(x => x.Id == p.ID).SoLuong
                    };
                    _lsthoaDonChiTiet.Add(orderDetailVM);

                    loadGioHang();
                }
            }
        }

        private void btn_CNDH_Click(object sender, EventArgs e)
        {
            if (_Id1 != null)
            {
                if (_lsthoaDonChiTiet.Any())
                {
                    decimal? total = 0;
                    c = _khachHangServices.GetAll().FirstOrDefault(x => x.Sdt == txt_SDT.Text);
                    if (c != null)
                    {
                        var order = _cHoaDonServices.GetAll().FirstOrDefault(x => x.Id == _Id1);
                        var odd = _hoaDonChiTietServices.GetAll().Where(x => x.IdHoaDon == _Id1);
                        foreach (var item in odd)
                        {
                            _hoaDonChiTietServices.Delete(item);
                        }
                        foreach (var item in _lsthoaDonChiTiet)
                        {
                            ViewHoaDonChiTiet od = new ViewHoaDonChiTiet()
                            {
                                IdHoaDon = _Id1,
                                IdChiTietSp = item.IdChiTietSp,
                                SoLuong = item.SoLuong,
                                DonGia = item.DonGia,
                            };
                            total += item.SoLuong * item.DonGia;
                            _hoaDonChiTietServices.Add(od);
                            var p = _chiTietSPServices.GetChiTietSPs().FirstOrDefault(x => x.ID == item.IdChiTietSp);
                            ViewChiTietSP viewSP = new ViewChiTietSP()
                            {
                                ID = item.IdChiTietSp,
                                SoLuongTon = p.SoLuongTon - item.SoLuong,
                            };
                            _chiTietSPServices.updateSanPhamChiTiet(viewSP);
                        }

                        Guid eID = _nhanVienServices.GetNhanViens().FirstOrDefault(x => x.Email == Properties.Settings.Default.TKdaLogin).ID;
                        ViewHoaDon HD = new ViewHoaDon()
                        {
                            NgayTao = DateTime.Now,
                            IdNv = eID,
                            IdKh = c.Id,
                            ThanhTien = total,
                        };

                        _cHoaDonServices.Update(order);

                        txt_maHD.Text = order.Ma;
                        lbl_tongtien.Text = total.ToString();
                        txt_SDT.Text = "";
                        lbt_Tongtien.Text = "";
                        MessageBox.Show($"Cập nhật hóa đơn thành công. ID: {_Id1}");
                        loadSanPham();
                        loadHDcho();
                        dgrid_giohang.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập khách hàng");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn chưa thanh toán");
            }
        }

        private void btn_TK_Click(object sender, EventArgs e)
        {
            loadSanPham();
        }
    }
}
