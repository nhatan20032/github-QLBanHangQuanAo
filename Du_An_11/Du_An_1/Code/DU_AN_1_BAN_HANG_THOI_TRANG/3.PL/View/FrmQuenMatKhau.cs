using _1.DAL.DomainModels;
using _2.BUS.IServices;
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
    public partial class FrmQuenMatKhau : Form
    {
        private INhanVienServices _INhanVienServices;
        public NhanVien _nv;
        public FrmQuenMatKhau()
        {
            InitializeComponent();
            _nv = new NhanVien();
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            var a = _INhanVienServices.GetViewChiTietSps().FirstOrDefault(c => c.IdNv == _nv.ID);

            a.MatKhau = tb_pass.Text;
            _INhanVienServices.updateSanPhamChiTiet(a);
            MessageBox.Show("Thay doi mat khau thanh cong, Ban se duoc dua tro lai trang dang nhap");
            this.Hide();
            FrmDangNhap frmdn = new FrmDangNhap();
            frmdn.ShowDialog();
        }

        private void FrmQuenMatKhau_Load(object sender, EventArgs e)
        {
            lb_loichao.Text = "Xin chao:" + _nv.Ho + " " + _nv.TenDem + " " + _nv.Ten;
            tb_ma.Text = _nv.Ma;
            tb_ma.Enabled = false;
            tb_email.Text = _nv.Email;
            tb_email.Enabled = false;
        }
    }
}
