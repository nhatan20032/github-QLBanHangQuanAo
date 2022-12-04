using _1.DAL.DomainModels;
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
    public partial class FrmDongSP : Form
    {
        IDongSPServices _IDongSpSv;
        DongSP _sp;
        public FrmDongSP()
        {
            InitializeComponent();
            _sp = new DongSP();
            _IDongSpSv = new DongSPServices();
            LoadData();
        }
        private void LoadData()
        {
            dtg_show.ColumnCount = 4;
            dtg_show.Rows.Clear();
            dtg_show.Columns[0].Name = "ID";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "Mã";
            dtg_show.Columns[2].Name = "Tên";
            dtg_show.Columns[3].Name = "Trạng thái";
            foreach (var a in _IDongSpSv.GetAll())
            {
                dtg_show.Rows.Add(a.ID, a.Ma, a.Ten, a.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }

        }
        private void Reset()
        {
            LoadData();
            _sp = null;
            tb_ma.Text = "";
            tb_ten.Text = "";
            rd_khonghoatdong.Checked = false;
            rd_hoatdong.Checked = false;
        }
        private void LoadDataCheck(string input)
        {
            dtg_show.ColumnCount = 4;
            dtg_show.Rows.Clear();
            dtg_show.Columns[0].Name = "ID";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name  = "Mã";
            dtg_show.Columns[2].Name = "Tên";
            dtg_show.Columns[3].Name = "Trạng thái";
            foreach (var a in _IDongSpSv.GetAll(input))
            {
                dtg_show.Rows.Add(a.ID, a.Ma, a.Ten, a.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (tb_ma.Text == "" || tb_ten.Text == "")
            {
                MessageBox.Show("Không được để thuộc tính trống");
            }
            else
            {
                var a = new DongSP()
                {
                    ID = new Guid(),
                    Ma = tb_ma.Text,
                    Ten = tb_ten.Text,
                    TrangThai = rd_hoatdong.Checked == true ? 1 : 0
                };
                _IDongSpSv.Add(a);
                MessageBox.Show("Thêm dòng sản phẩm thành công");
                Reset();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo);
            if (tb_ma.Text == "" || tb_ten.Text == "")
            {
                MessageBox.Show("Không được để thuộc tính trống");
            }
            else if (dg == DialogResult.Yes)
            {
                _sp.Ma = tb_ma.Text;
                _sp.Ten = tb_ten.Text;
                _sp.TrangThai = rd_hoatdong.Checked == true ? 1 : 0;
                _IDongSpSv.Update(_sp);
                MessageBox.Show("Sửa dòng sản phẩm thành công");
                Reset();
            }
            else
            {
                MessageBox.Show("Ok đã hủy thao tác sửa");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                _IDongSpSv.Remove(_sp);
                MessageBox.Show("Xóa dòng sản phẩm thành công");
                Reset();
            }
            else
            {
                MessageBox.Show("Ok đã hủy thao tác xóa");
            }
        }



        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            LoadDataCheck(tb_timkiem.Text);
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_show.Rows[e.RowIndex];
                _sp = _IDongSpSv.GetAll().FirstOrDefault(c => c.ID == Guid.Parse(r.Cells[0].Value.ToString()));
                tb_ma.Text = r.Cells[1].Value.ToString();
                tb_ten.Text = r.Cells[2].Value.ToString();
                rd_hoatdong.Checked = r.Cells[3].Value.ToString() == "Hoạt động";
                rd_khonghoatdong.Checked = r.Cells[3].Value.ToString() == "Không hoạt động";
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
