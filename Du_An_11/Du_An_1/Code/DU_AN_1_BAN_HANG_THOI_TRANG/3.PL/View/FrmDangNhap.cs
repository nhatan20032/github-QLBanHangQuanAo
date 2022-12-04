using _1.DAL.DomainModels;
using _1.DAL.IReposytorys;
using _1.DAL.Reposytorys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.View
{
    public partial class FrmDangNhap : Form
    {
        INhanVienReps _INvRp;
        public FrmDangNhap()
        {
            InitializeComponent();
            _INvRp = new NhanVienReps();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            NhanVien nv = _INvRp.GetNhanVien(tb_taikhoan.Text, tb_matkhau.Text);
            if (nv == null)
            {
                MessageBox.Show("Tai khoan khong ton tai");
            }
            else
            {
                MessageBox.Show("Dang nhap thanh cong");
                FrmBanHang frmbh = new FrmBanHang();
                frmbh.ShowDialog();
            }
        }

        private void lb_quenmatkhau_Click(object sender, EventArgs e)
        {
            FrmTimKiem frmtk = new FrmTimKiem();
            frmtk.ShowDialog();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            tb_taikhoan.Text = Properties.Settings.Default.User;
            tb_matkhau.Text = Properties.Settings.Default.Pass;
            if (Properties.Settings.Default.User != "")
            {
                cb_nmk.Checked = true;
            }
        }

        private void cb_nmk_CheckedChanged(object sender, EventArgs e)
        {
            if (tb_taikhoan.Text != "" && tb_matkhau.Text != "")
            {
                if (cb_nmk.Checked == true)
                {
                    string use = tb_taikhoan.Text;
                    string pass = tb_matkhau.Text;
                    Properties.Settings.Default.User = use;
                    Properties.Settings.Default.Pass = pass;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Reset();
                }
            }
        }
    }
}
