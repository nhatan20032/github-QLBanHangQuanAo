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
    public partial class FrmChucVu : Form
    {
        private IChucVuServices _iChucVuservices;
        private Guid _chucVuId;
        private ChucVu _cv;
        public FrmChucVu()
        {
            _iChucVuservices = new ChucVuServices();
            InitializeComponent();
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            dgrid_ChucVu.ColumnCount = 4;
            dgrid_ChucVu.Columns[0].Name = " ID";
            dgrid_ChucVu.Columns[1].Name = " Mã";
            dgrid_ChucVu.Columns[2].Name = " Tên";
            dgrid_ChucVu.Columns[3].Name = " Trạng Thái";
            dgrid_ChucVu.Rows.Clear();
            foreach (var x in _iChucVuservices.GetAll())
            {
                dgrid_ChucVu.Rows.Add(x.ID, x.Ma, x.Ten, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        private void LoadDataGridView(string input)
        {
            dgrid_ChucVu.ColumnCount = 4;
            dgrid_ChucVu.Columns[0].Name = " ID";
            dgrid_ChucVu.Columns[1].Name = " Mã";
            dgrid_ChucVu.Columns[2].Name = " Tên";
            dgrid_ChucVu.Columns[3].Name = " Trạng Thái";
            dgrid_ChucVu.Rows.Clear();
            foreach (var x in _iChucVuservices.GetAll(input))
            {
                dgrid_ChucVu.Rows.Add(x.ID, x.Ma, x.Ten, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        public void Reset()
        {
            LoadDataGridView();
            _cv = null;
            txt_TimKiem.Text = "";
            tb_ma.Text = "";
            tb_ten.Text = "";
            rbtn_LamViec.Checked = false;
            rbtn_NghiViec.Checked = true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            var cv = new ChucVu()
            {
                ID = new Guid(),
                Ma = tb_ma.Text,
                Ten = tb_ten.Text,
                TrangThai = rbtn_LamViec.Checked ? 1 : 0,
            };
            _iChucVuservices.Add(cv);
            MessageBox.Show("Thêm thành công");
            Reset();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (tb_ma.Text == null)
            {
                MessageBox.Show("vui lòng nhập Mã");
            }
            else if (_cv == null)
            {
                MessageBox.Show("Không tìm thấy");
            }
            else
            {
                if (_cv.Ma == tb_ma.Text || _cv.Ma != tb_ma.Text && _iChucVuservices.GetAll().FirstOrDefault(c => c.Ma == tb_ma.Text) == null)
                {
                    _cv.Ma = tb_ma.Text;
                    _cv.Ten = tb_ten.Text;
                    _cv.TrangThai = rbtn_LamViec.Checked ? 1 : 0;
                    MessageBox.Show("Sửa thành công");
                    Reset();
                }
                else
                {
                    MessageBox.Show(" Sửa không thành công");
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (_cv == null)
            {
                MessageBox.Show("Không tìm thấy");
            }
            else
            {
                _iChucVuservices.Delete(_cv);
                MessageBox.Show("Xóa thành công");
                Reset();
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDataGridView(txt_TimKiem.Text);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void dgrid_ChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                _chucVuId = Guid.Parse(dgrid_ChucVu.Rows[rowindex].Cells[0].Value.ToString());
                _cv = _iChucVuservices.GetAll().FirstOrDefault(c => c.ID == _chucVuId);
                tb_ma.Text = _cv.Ma;
                tb_ten.Text = _cv.Ten;
                if (_cv.TrangThai == 1)
                {
                    rbtn_LamViec.Checked = true;
                }

                rbtn_NghiViec.Checked = true;
            }
        }
    }
}
