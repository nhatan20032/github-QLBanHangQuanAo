using _1.DAL.DomainModels;
using _2.BUS.IServices;
using _2.BUS.Services;
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
    public partial class FrmCuaHang : Form
    {
        private ICuaHangServices _iCuaHangservices;
        private CuaHang _ch;
        private Guid _id;

        public FrmCuaHang()
        {
            _iCuaHangservices = new CuaHangServices();
            InitializeComponent();
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            dgrid_CuaHang.ColumnCount = 7;
            dgrid_CuaHang.Columns[0].Name = " ID";
            dgrid_CuaHang.Columns[1].Name = " Mã";
            dgrid_CuaHang.Columns[2].Name = " Tên";
            dgrid_CuaHang.Columns[3].Name = " Địa chỉ";
            dgrid_CuaHang.Columns[4].Name = " Thành Phố";
            dgrid_CuaHang.Columns[5].Name = " Quốc Gia ";
            dgrid_CuaHang.Columns[6].Name = " Trạng Thái ";
            dgrid_CuaHang.Rows.Clear();

            foreach (var x in _iCuaHangservices.GetAll())
            {
                dgrid_CuaHang.Rows.Add(x.ID, x.Ma, x.Ten, x.DiaChi, x.ThanhPho, x.QuocGia, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        public void LoadDataGridView(string input)
        {
            dgrid_CuaHang.ColumnCount = 7;
            dgrid_CuaHang.Columns[0].Name = " ID";
            dgrid_CuaHang.Columns[1].Name = " Mã";
            dgrid_CuaHang.Columns[2].Name = " Tên";
            dgrid_CuaHang.Columns[3].Name = " Địa chỉ";
            dgrid_CuaHang.Columns[4].Name = " Thành Phố";
            dgrid_CuaHang.Columns[5].Name = " Quốc Gia ";
            dgrid_CuaHang.Columns[6].Name = " Trạng Thái";

            foreach (var x in _iCuaHangservices.GetAll(input))
            {
                dgrid_CuaHang.Rows.Add(x.ID, x.Ma, x.Ten, x.DiaChi, x.ThanhPho, x.QuocGia, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        public void Reset()
        {
            LoadDataGridView();
            _ch = null;
            tb_TimKiem.Text = "";
            tb_ma.Text = "";
            tb_ten.Text = "";
            tb_thanhpho.Text = "";
            tb_diachi.Text = "";
            rbtn_HoatDong.Checked = false;
            rbtn_KhongHoatDong.Checked = true;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            var cv = new CuaHang()
            {
                ID = new Guid(),
                Ma = tb_ma.Text,
                Ten = tb_ten.Text,
                DiaChi = tb_diachi.Text,
                ThanhPho = tb_thanhpho.Text,
                QuocGia = textBox5.Text,
                TrangThai = rbtn_HoatDong.Checked ? 1 : 0,
            };
            _iCuaHangservices.Add(cv);
            MessageBox.Show("Thêm thành công");
            Reset();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (tb_ma.Text == null)
            {
                MessageBox.Show("vui lòng nhập Mã");
            }
            else if (_ch == null)
            {
                MessageBox.Show("Không tìm thấy");
            }
            else
            {
                if (_ch.Ma == tb_TimKiem.Text || _ch.Ma != tb_TimKiem.Text && _iCuaHangservices.GetAll().FirstOrDefault(c => c.Ma == tb_TimKiem.Text) == null)
                {
                    _ch.Ma = tb_TimKiem.Text;
                    _ch.Ten = tb_TimKiem.Text;
                    _ch.QuocGia = tb_TimKiem.Text;
                    _ch.ThanhPho = tb_TimKiem.Text;
                    _ch.TrangThai = rbtn_HoatDong.Checked ? 1 : 0;
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
            if (_ch == null)
            {
                MessageBox.Show("Không tìm thấy");
            }
            else
            {
                _iCuaHangservices.Delete(_ch);
                MessageBox.Show("Xóa thành công");
                Reset();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Utilities.ResetControlValues(this);
            textBox5.Text = "Việt Nam";
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDataGridView(tb_TimKiem.Text);
        }

        private void dgrid_CuaHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= 0)
            {
                _id = Guid.Parse(dgrid_CuaHang.Rows[rowindex].Cells[0].Value.ToString());
                _ch = _iCuaHangservices.GetAll().FirstOrDefault(c => c.ID == _id);
                tb_ma.Text = _ch.Ma;
                tb_ten.Text = _ch.Ten;
                tb_diachi.Text = _ch.DiaChi;
                tb_thanhpho.Text = _ch.ThanhPho;
                if (_ch.TrangThai == 1)
                {
                    rbtn_HoatDong.Checked = true;
                }

                rbtn_KhongHoatDong.Checked = true;
            }
        }
    }
}
