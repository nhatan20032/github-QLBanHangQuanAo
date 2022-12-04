using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModel;
using _3.PL.Utilitis;
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
    public partial class FrmQuanLySanPham : Form
    {
        IChiTietSPServices _chiTietSPServices;
        IDongSPServices _DongSPServices;
        ISanPhamServices _sanPhamServices;
        ISizeServices _sizeServices;
        IThuongHieuServices _thuongHieuServices;
        IMauSacServices _smacServices;
        IChatLieuServices _chatLieuServices;
        List<ViewChiTietSP> _lstviewChiTietSPs;
        private Guid _id;
        public FrmQuanLySanPham()
        {
            InitializeComponent();
            _chiTietSPServices = new ChiTietSPServices();
            _DongSPServices = new DongSPServices();
            _sanPhamServices = new SanPhamServices();
            _sizeServices = new SizeServices();
            _smacServices = new MauSacServices();
            _thuongHieuServices = new ThuongHieuServices();
            _chatLieuServices = new ChatLieuServices();
            _lstviewChiTietSPs = new List<ViewChiTietSP>();
            cbx_Con.Checked = true;
            LoadChatLieu();
            LoadDongSP();
            LoadMauSac();
            LoadSanPham();
            LoadSize();
            LoadThuongHieu();
            LoadDataChiTietSP();
        }
        private void LoadSanPham()
        {
            foreach (var x in _sanPhamServices.GetAll())
            {
                cmb_TENSP.Items.Add(x.Ten);
            }
        }
        private void LoadThuongHieu()
        {
            foreach (var x in _thuongHieuServices.GetAll())
            {
                cmb_ThuongHieu.Items.Add(x.Ten);
            }
        }
        private void LoadChatLieu()
        {
            foreach (var x in _chatLieuServices.getChatLieuFromDB())
            {
                cbx_chatlieu.Items.Add(x.Ten);
            }
        }
        private void LoadDongSP()
        {
            foreach (var x in _DongSPServices.GetAll())
            {
                cmb_DONGSP.Items.Add(x.Ten);
            }
        }
        private void LoadMauSac()
        {
            foreach (var x in _smacServices.GetAll())
            {
                cmb_MAUSAC.Items.Add(x.Ten);
            }
        }
        private void LoadSize()
        {
            foreach (var x in _sizeServices.getSizesFromDB())
            {
                cmb_Size.Items.Add(x.Ten);
            }
        }
        private void LoadDataChiTietSP()
        {
            int stt = 1;
            dgrid_Data.ColumnCount = 12;
            dgrid_Data.Columns[0].Name = "STT";
            dgrid_Data.Columns[1].Name = "ID";
            dgrid_Data.Columns[2].Name = "Tên Sản Phẩm";
            dgrid_Data.Columns[3].Name = "NSX";
            dgrid_Data.Columns[4].Name = "Thương Hiệu";
            dgrid_Data.Columns[5].Name = "Dòng SP";
            dgrid_Data.Columns[6].Name = "Chất Liệu";
            dgrid_Data.Columns[7].Name = "Số Lượng Tồn";
            dgrid_Data.Columns[8].Name = "Size";
            dgrid_Data.Columns[9].Name = "Gía Nhập";
            dgrid_Data.Columns[10].Name = "Gía Bán";
            dgrid_Data.Columns[11].Name = "Mô Tả";
            dgrid_Data.Rows.Clear();
            _lstviewChiTietSPs = _chiTietSPServices.GetViewChiTietSps();
            if (textBox1.Text != "")
            {
                _lstviewChiTietSPs = _lstviewChiTietSPs.Where(p => p.TenSP.Contains(textBox1.Text) || p.TenDongSP.Contains(textBox1.Text) || p.TenMauSac.Contains(textBox1.Text) || p.TenSize.Contains(textBox1.Text) || p.TenThuongHieu.Contains(textBox1.Text) || p.TenChatLieu.Contains(textBox1.Text)).ToList();
            }
            foreach (var x in _lstviewChiTietSPs)
            {     
                dgrid_Data.Rows.Add(stt++, x.ID, x.TenSP, x.TenThuongHieu, x.TenMauSac, x.TenDongSP, x.TenChatLieu, x.SoLuongTon, x.TenSize,x.GiaNhap, x.GiaBan, x.MoTa, x.TrangThai);
            }
        }
        private ViewChiTietSP GetData()
        {
            var Sp = _sanPhamServices.GetAll().FirstOrDefault(c => c.Ten == cmb_TENSP.Text);
            var Ms = _smacServices.GetAll().FirstOrDefault(c => c.Ten == cmb_MAUSAC.Text);
            var Dsp = _DongSPServices.GetAll().FirstOrDefault(c => c.Ten == cmb_DONGSP.Text);
            var thuongHieu = _thuongHieuServices.GetAll().FirstOrDefault(c => c.Ten == cmb_ThuongHieu.Text);
            var size = _sizeServices.getSizesFromDB().FirstOrDefault(c => c.Ten == cmb_Size.Text);
            var ChatLieu = _chatLieuServices.getChatLieuFromDB().FirstOrDefault(c => c.Ten == cbx_chatlieu.Text);
            ViewChiTietSP CTSP = new ViewChiTietSP()
            {
                ID = Guid.Empty,
                IDDongSP = Dsp.ID,
                IDSP = Sp.ID,
                IDThuongHieu = thuongHieu.ID,
                IDMauSac = Ms.ID,
                IDChatLieu = ChatLieu.ID,
                IDSize = size.ID,
                SoLuongTon = Convert.ToInt32(txt_SLT.Text),
                GiaBan = Convert.ToDecimal(txt_GIABAN.Text),
                GiaNhap = Convert.ToDecimal(txt_GIANHAP.Text),
                MoTa = rtb_mota.Text,
                TrangThai = cbx_Het.Checked ? 0 : 1,
            };
            return CTSP;
        }

        private void FrmQuanLySanPham_Load(object sender, EventArgs e)
        {
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            _chiTietSPServices.addSanPhamChiTiet(GetData());
            LoadDataChiTietSP();
            Utilities.ResetControlValues(this);

        }

        private void btn_SUA_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.ID = _id;
            _chiTietSPServices.updateSanPhamChiTiet(temp);
            LoadDataChiTietSP();
            Utilities.ResetControlValues(this);
        }

        private void btn_XOA_Click(object sender, EventArgs e)
        {
            _chiTietSPServices.deleteSanPhamChiTiet(_id);
            LoadDataChiTietSP();
            Utilities.ResetControlValues(this);
        }

        private void btn_CLEAR_Click(object sender, EventArgs e)
        {
            Utilities.ResetControlValues(this);
            cbx_chatlieu.Text = "";
            cmb_DONGSP.Text = "";
            cmb_MAUSAC.Text = "";
            cmb_Size.Text = "";
            cmb_TENSP.Text = "";
            cmb_ThuongHieu.Text = "";
        }

        private void btn_TK_Click(object sender, EventArgs e)
        {
            LoadDataChiTietSP();
        }

        private void dgrid_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgrid_Data.Rows[e.RowIndex];
                _id = Guid.Parse(dgrid_Data.Rows[e.RowIndex].Cells[1].Value.ToString());
                var CTSP = _chiTietSPServices.GetChiTietSPs().FirstOrDefault(p => p.ID == _id);

                cmb_DONGSP.Text = _DongSPServices.GetAll().FirstOrDefault(p => p.ID == CTSP.IDDongSP).Ten;
                cmb_MAUSAC.Text = _smacServices.GetAll().FirstOrDefault(p => p.ID == CTSP.IDMauSac).Ten;
                cmb_Size.Text = _sizeServices.getSizesFromDB().FirstOrDefault(p => p.ID == CTSP.IDSize).Ten;
                cmb_TENSP.Text = _sanPhamServices.GetAll().FirstOrDefault(p => p.ID == CTSP.IDSP).Ten;
                cbx_chatlieu.Text = _chatLieuServices.getChatLieuFromDB().FirstOrDefault(p => p.ID == CTSP.IDChatLieu).Ten;
                cmb_ThuongHieu.Text = _thuongHieuServices.GetAll().FirstOrDefault(p => p.ID == CTSP.IDThuongHieu).Ten;
                txt_GIABAN.Text = CTSP.GiaBan.ToString();
                txt_GIANHAP.Text = CTSP.GiaNhap.ToString();
                rtb_mota.Text = CTSP.MoTa;
                txt_SLT.Text = CTSP.SoLuongTon.ToString();
                if (CTSP.TrangThai == 1)
                {
                    cbx_Con.Checked = true;
                    cbx_Het.Checked = false;
                }
                else
                {
                    cbx_Het.Checked = true;
                    cbx_Con.Checked = false;
                }
            }
        }
    }
}
