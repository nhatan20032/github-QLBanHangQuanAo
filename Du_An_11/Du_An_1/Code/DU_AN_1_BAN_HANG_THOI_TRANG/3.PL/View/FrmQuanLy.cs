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
    public partial class FrmQuanLy : Form
    {
        public FrmQuanLy()
        {
            InitializeComponent();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            FrmQuanLySanPham frmQuanLySanPham = new FrmQuanLySanPham() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(frmQuanLySanPham);
            frmQuanLySanPham.Show();
        }

        private void sảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            FrmSanPham frmQuanLySanPham = new FrmSanPham() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(frmQuanLySanPham);
            frmQuanLySanPham.Show();
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            FrmSize frmQuanLySanPham = new FrmSize() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(frmQuanLySanPham);
            frmQuanLySanPham.Show();
        }

        private void chấtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            FrmChatLieu frmQuanLySanPham = new FrmChatLieu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(frmQuanLySanPham);
            frmQuanLySanPham.Show();
        }

        private void dòngSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            FrmDongSP frmQuanLySanPham = new FrmDongSP() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(frmQuanLySanPham);
            frmQuanLySanPham.Show();
        }

        private void thươngHiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            FrmThuongHieu frmQuanLySanPham = new FrmThuongHieu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(frmQuanLySanPham);
            frmQuanLySanPham.Show();
        }

        private void màuSắcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            FrmMauSac frmQuanLySanPham = new FrmMauSac() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(frmQuanLySanPham);
            frmQuanLySanPham.Show();
        }
    }
}
