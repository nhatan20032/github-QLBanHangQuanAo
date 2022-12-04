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
    public partial class FrmThanhToan : Form
    {
        private IHinhThucThanhToanServices _ihinhThucThanhToanServices;
        private Guid _id;
        private HinhThucThanhToan _httt;
        public FrmThanhToan()
        {
            InitializeComponent();
            _ihinhThucThanhToanServices = new HinhThucThanhToanServices();
            LoadDataFormDb();
        }
        public void LoadDataFormDb()
        {
            dgrid_ThanhToan.ColumnCount = 4;
            dgrid_ThanhToan.Columns[0].Name = "Id";
            dgrid_ThanhToan.Columns[0].Visible = false;
            dgrid_ThanhToan.Columns[1].Name = "Mã";
            dgrid_ThanhToan.Columns[2].Name = "Tên ";

            dgrid_ThanhToan.Columns[3].Name = "Trạng thái";
            dgrid_ThanhToan.Rows.Clear();
            foreach (var x in _ihinhThucThanhToanServices.GetAll())
            {
                dgrid_ThanhToan.Rows.Add(x.ID, x.Ma, x.Ten, x.TrangThai == 1 ? "Đã thanh toán" : "Chưa thanh toán");
            }
        }
        public void LoadDataFormDb(string input)
        {
            dgrid_ThanhToan.ColumnCount = 4;
            dgrid_ThanhToan.Columns[0].Name = "Id";
            dgrid_ThanhToan.Columns[0].Visible = false;
            dgrid_ThanhToan.Columns[1].Name = "Mã";
            dgrid_ThanhToan.Columns[2].Name = "Tên ";

            dgrid_ThanhToan.Columns[3].Name = "Trạng thái";
            dgrid_ThanhToan.Rows.Clear();
            foreach (var x in _ihinhThucThanhToanServices.GetAll(input))
            {
                dgrid_ThanhToan.Rows.Add(x.ID, x.Ma, x.Ten, x.TrangThai == 1 ? "Đã thanh toán" : "Chưa thanh toán");
            }
        }
        public void Reset()
        {
            LoadDataFormDb();
            _httt = null;
            txt_MA.Text = "";
            txt_Ten.Text = "";
            rbtn_Chua.Checked = false;
            rbtn_Da.Checked = false;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            var httt = new HinhThucThanhToan()
            {
                ID = new Guid(),
                Ma = txt_MA.Text,
                Ten = txt_Ten.Text,
                TrangThai = rbtn_Da.Checked ? 1 : 0,

            };
            _ihinhThucThanhToanServices.Add(httt);
            MessageBox.Show("Thêm thành công");
            Reset();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (_httt == null)
            {
                MessageBox.Show("Không tìm thấy");
            }
            else if (txt_MA.Text == null)
            {
                MessageBox.Show("Bạn phải nhập mã");
            }
            else
            {
                if (_httt.Ma == txt_MA.Text || _httt.Ma == txt_MA.Text && _ihinhThucThanhToanServices.GetAll().FirstOrDefault(c => c.Ma == txt_MA.Text) == null)
                {
                    _httt.Ma = txt_MA.Text;
                    _httt.Ten = txt_Ten.Text;
                    _httt.TrangThai = rbtn_Da.Checked ? 1 : 0;
                    _ihinhThucThanhToanServices.Update(_httt);
                    MessageBox.Show("Sửa thành công");
                    Reset();
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (_httt == null)
            {
                MessageBox.Show("Không tìm thấy");
            }
            else
            {
                _ihinhThucThanhToanServices.Delete(_httt);
                MessageBox.Show("Xóa thành công");
                Reset();
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDataFormDb(txt_TimKiem.Text);
        }

        private void dgrid_ThanhToan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                _id = Guid.Parse(dgrid_ThanhToan.Rows[row].Cells[0].Value.ToString());
                _httt = _ihinhThucThanhToanServices.GetAll().FirstOrDefault(c => c.ID == _id);
                txt_MA.Text = _httt.Ma;
                txt_Ten.Text = _httt.Ten;
                rbtn_Da.Checked = dgrid_ThanhToan.Rows[row].Cells[3].Value.ToString() == "Đã thanh toán";
                rbtn_Chua.Checked = dgrid_ThanhToan.Rows[row].Cells[3].Value.ToString() == "Chưa thanh toán";
            }
        }
    }
}
