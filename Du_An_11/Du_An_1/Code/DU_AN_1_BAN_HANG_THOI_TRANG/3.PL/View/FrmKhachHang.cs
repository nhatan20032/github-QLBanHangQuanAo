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
    public partial class FrmKhachHang : Form
    {
        private IKhachHangServices _khachHangServices;
        private Guid _ID;
        public FrmKhachHang()
        {
            InitializeComponent();
            _khachHangServices = new KhachHangServices();
            rbtn_Nam.Checked = true;
            cbx_HD.Checked = true;
            LoadData();
        }
        public void LoadData()
        {
            int stt = 1;
            Dgrid_KH.ColumnCount = 10;
            Dgrid_KH.Columns[1].Name = "STT";
            Dgrid_KH.Columns[2].Name = "Mã";
            Dgrid_KH.Columns[3].Name = "Họ Và Tên";
            Dgrid_KH.Columns[4].Name = "Giới Tính";
            Dgrid_KH.Columns[5].Name = "Ngày Sinh";
            Dgrid_KH.Columns[6].Name = "CMND";
            Dgrid_KH.Columns[7].Name = "SĐT";
            Dgrid_KH.Columns[8].Name = "Địa Chỉ";
            Dgrid_KH.Columns[9].Name = "Trạng Thái";
            Dgrid_KH.Rows.Clear();
            foreach (var x in _khachHangServices.GetAll())
            {
                Dgrid_KH.Rows.Add(stt++, x.Id, x.Ma, x.Ho + " " + x.TenDem + " " + x.Ten, x.GioiTinh, x.NgaySinh, x.CMND, x.Sdt, x.DiaChi + "," + x.ThanhPho + "," + x.QuocGia, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        public ViewKhachHang GetData()
        {
            ViewKhachHang kh = new ViewKhachHang()
            {
                Id = Guid.Empty,
                Ma = txt_Ma.Text,
                Ten = txt_ten.Text,
                Ho = txt_Ho.Text,
                TenDem = txt_Tendem.Text,
                GioiTinh = rbtn_Nam.Checked == true ? "Nam" : "Nữ",
                NgaySinh = date_ngaySinh.Value,
                CMND = txt_Cmnd.Text,
                Sdt = txt_sdt.Text,
                DiaChi = txt_diaChi.Text,
                ThanhPho = txt_thanhPho.Text,
                QuocGia = txt_quocGia.Text,
                TrangThai = cbx_HD.Checked == true ? 1 : 0,
            };
            return kh;
        }
        private void btn_THEM_Click(object sender, EventArgs e)
        {
            DialogResult di = MessageBox.Show("Bạn có chắc chắn muốn thêm ko?", "Thông báo", MessageBoxButtons.YesNo);
            if (di == DialogResult.Yes)
            {
                MessageBox.Show(_khachHangServices.Add(GetData()));
                LoadData();
            }
            if (di == DialogResult.No)
            {
                return;
            }
        }

        private void btn_SUA_Click(object sender, EventArgs e)
        {
            DialogResult di = MessageBox.Show("Bạn có chắc chắn muốn sửa ko?", "Thông báo", MessageBoxButtons.YesNo);
            if (di == DialogResult.Yes)
            {
                var temp = GetData();
                temp.Id = _ID;
                MessageBox.Show(_khachHangServices.Update(temp));
                LoadData();
            }
            if (di == DialogResult.No)
            {
                return;
            }
        }

        private void btn_XOA_Click(object sender, EventArgs e)
        {
            DialogResult di = MessageBox.Show("Bạn có chắc chắn muốn xóa ko?", "Thông báo", MessageBoxButtons.YesNo);
            if (di == DialogResult.Yes)
            {
                var temp = GetData();
                temp.Id = _ID;
                MessageBox.Show(_khachHangServices.Delete(temp));
                LoadData();
            }
            if (di == DialogResult.No)
            {
                return;
            }
        }

        private void btn_CLEAR_Click(object sender, EventArgs e)
        {
            Utilities.ResetControlValues(this);
            txt_quocGia.Text = "Việt Nam";
            txt_TK.Text = "Tìm Kiếm...";
        }

        private void btn_tk_Click(object sender, EventArgs e)
        {
            int stt = 1;
            Dgrid_KH.ColumnCount = 10;
            Dgrid_KH.Columns[1].Name = "STT";
            Dgrid_KH.Columns[2].Name = "Mã";
            Dgrid_KH.Columns[3].Name = "Họ Và Tên";
            Dgrid_KH.Columns[4].Name = "Giới Tính";
            Dgrid_KH.Columns[5].Name = "Ngày Sinh";
            Dgrid_KH.Columns[6].Name = "CMND";
            Dgrid_KH.Columns[7].Name = "SĐT";
            Dgrid_KH.Columns[8].Name = "Địa Chỉ";
            Dgrid_KH.Columns[9].Name = "Trạng Thái";
            Dgrid_KH.Rows.Clear();
            foreach (var x in _khachHangServices.GetAll(txt_TK.Text))
            {
                Dgrid_KH.Rows.Add(stt++, x.Id, x.Ma, x.Ho + " " + x.TenDem + " " + x.Ten, x.GioiTinh, x.NgaySinh, x.CMND, x.Sdt, x.DiaChi + "," + x.ThanhPho + "," + x.QuocGia, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }

        private void Dgrid_KH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _ID = Guid.Parse(Dgrid_KH.CurrentRow.Cells[1].Value.ToString());
            var KH = _khachHangServices.GetAll().FirstOrDefault(c => c.Id == _ID);
            txt_Ma.Text = KH.Ma;
            txt_Ho.Text = KH.Ho;
            txt_Ho.Text = KH.TenDem;
            txt_ten.Text = KH.Ten;
            txt_sdt.Text = KH.Sdt;
            txt_thanhPho.Text = KH.ThanhPho;
            txt_quocGia.Text = KH.QuocGia;
            txt_diaChi.Text = KH.DiaChi;
            txt_Cmnd.Text = KH.CMND;
            date_ngaySinh.Value = KH.NgaySinh;
            if (KH.GioiTinh == "Nam")
            {
                rbtn_Nam.Checked = true;
            }
            rbtn_nu.Checked = true;
            if (KH.TrangThai == 1)
            {
                cbx_HD.Checked = true;
                cbx_NHD.Checked = false;
            }
            cbx_HD.Checked = false;
            cbx_NHD.Checked = true;
        }

        private void txt_Ho_TextChanged(object sender, EventArgs e)
        {
            txt_Ma.Text = Utilities.GetMaTuSinh(txt_Ho.Text + " " + txt_Tendem.Text + " " + txt_ten.Text) + (_khachHangServices.GetAll().Count + 1);
        }

        private void txt_ten_TextChanged(object sender, EventArgs e)
        {
            txt_Ma.Text = Utilities.GetMaTuSinh(txt_Ho.Text + " " + txt_Tendem.Text + " " + txt_ten.Text) + (_khachHangServices.GetAll().Count + 1);
        }

        private void txt_Tendem_TextChanged(object sender, EventArgs e)
        {
            txt_Ma.Text = Utilities.GetMaTuSinh(txt_Ho.Text + " " + txt_Tendem.Text + " " + txt_ten.Text) + (_khachHangServices.GetAll().Count + 1);
        }

        private void txt_Ho_Leave(object sender, EventArgs e)
        {
            txt_Ho.Text = Utilities.VietHoaChuCaiDau(txt_Ho.Text);
        }

        private void txt_ten_Leave(object sender, EventArgs e)
        {
            txt_ten.Text = Utilities.VietHoaChuCaiDau(txt_ten.Text);
        }

        private void txt_Tendem_Leave(object sender, EventArgs e)
        {
            txt_Tendem.Text = Utilities.VietHoaChuCaiDau(txt_Tendem.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
