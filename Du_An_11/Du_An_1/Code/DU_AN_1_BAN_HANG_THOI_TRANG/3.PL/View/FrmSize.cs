using _1.DAL.ConText;
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
    public partial class FrmSize : Form
    {
        public ISizeServices _sizeServices;
        public Sizez _sz;
        private DUAN1DBContext db_context = new DUAN1DBContext();
        public FrmSize()
        {
            InitializeComponent();
            _sizeServices = new SizeServices();
            loadData();
        }
        public void loadData()
        {
            dtgv_size.ColumnCount = 5;
            dtgv_size.Columns[0].Name = "Id";
            dtgv_size.Columns[0].Visible = false;
            dtgv_size.Columns[1].Name = "Mã";
            dtgv_size.Columns[2].Name = "Tên";
            dtgv_size.Columns[3].Name = "Mô tả";
            dtgv_size.Columns[4].Name = "Trạng thái";
            dtgv_size.Rows.Clear();
            var lstSizez = _sizeServices.getSizesFromDB();
            if (txt_timkiem.Text != "")
            {
                lstSizez = lstSizez.Where(c => c.Ma.ToLower().Contains(txt_timkiem.Text.ToLower()) || c.Ten.ToLower().Contains(txt_timkiem.Text.ToLower())).ToList();
            }
            foreach (var x in lstSizez)
            {
                dtgv_size.Rows.Add(x.ID, x.Ma, x.Ten, x.MoTa, x.TrangThai == 1 ? "Còn size" : "Hết size");
            }

        }
        public void resetForm()
        {
            loadData();
            _sz = null;
            txt_ma.Text = "";
            txt_ten.Text = "";
            txt_mota.Text = "";
            rbtn_consize.Checked = false;
            rbtn_hetsize.Checked = true;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thêm size này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (txt_ma.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã size");
                }
                else if (_sizeServices.getSizesFromDB().Any(c => c.Ma == txt_ma.Text))
                {
                    MessageBox.Show("Mã size này đã tồn tại");
                }
                else
                {
                    var sz = new Sizez()
                    {
                        ID = new Guid(),
                        Ma = txt_ma.Text,
                        Ten = txt_ten.Text,
                        MoTa = txt_mota.Text,
                        TrangThai = rbtn_consize.Checked ? 1 : 0
                    };
                    _sizeServices.Add(sz);
                    MessageBox.Show("Thêm size thành công");
                    resetForm();

                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa size này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (txt_ma.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã");
                }
                else if (_sz == null)
                {
                    MessageBox.Show("Vui lòng chọn size");
                }
                else
                {
                    if (_sz.Ma == txt_ma.Text || (_sz.Ma != txt_ma.Text && _sizeServices.getSizesFromDB().FirstOrDefault(c => c.Ma == txt_ma.Text) == null))
                    {
                        _sz.Ma = txt_ma.Text;
                        _sz.Ten = txt_ten.Text;
                        _sz.MoTa = txt_mota.Text;
                        _sz.TrangThai = rbtn_consize.Checked ? 1 : 0;
                        _sizeServices.Update(_sz);
                        MessageBox.Show("Sửa size thành công");
                        resetForm();
                    }
                    else
                    {
                        MessageBox.Show("Mã size đã tồn tại");
                    }
                }
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa size này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_sz == null)
                {
                    MessageBox.Show("Vui lòng chọn size");
                }
                else
                {
                    _sizeServices.Delete(_sz);
                    MessageBox.Show("Xóa size thành công");
                    resetForm();
                }
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void dtgv_size_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtgv_size.Rows[e.RowIndex];
                _sz = _sizeServices.getSizesFromDB().FirstOrDefault(c => c.ID == Guid.Parse(r.Cells[0].Value.ToString()));
                txt_ma.Text = r.Cells[1].Value.ToString();
                txt_ten.Text = r.Cells[2].Value.ToString();
                txt_mota.Text = r.Cells[3].Value.ToString();
                if (_sz.TrangThai == 1)
                {
                    rbtn_consize.Checked = true;
                    return;
                }
                rbtn_hetsize.Checked = true;


            }
        }
        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void dtgv_size_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            //Guid ID = Guid.Parse(dtgv_size.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            //string Ma = dtgv_size.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
            //string Ten = dtgv_size.Rows[e.RowIndex].Cells["Ten"].Value.ToString();
            //string MoTa = dtgv_size.Rows[e.RowIndex].Cells["MoTa"].Value.ToString();
            //int TrangThai = Convert.ToInt32(dtgv_size.Rows[e.RowIndex].Cells["MoTa"].Value);
            //var a = db_context.Sizes.SingleOrDefault(p=>p.ID == ID);
            //if (a != null)
            //{
            //    a.Ma = Ma;
            //    a.Ten = Ten;
            //    a.MoTa = MoTa;
            //    a.TrangThai = TrangThai;
            //}
            //else
            //{
            //    Sizez size = new Sizez();
            //    size.ID = ID;
            //    size.Ma = Ma;
            //    size.Ten = Ten;
            //    size.MoTa = MoTa;
            //    size.TrangThai = TrangThai;
            //    db_context.Sizes.Add(size);
            //}
            //db_context.SaveChanges();
        }

        private void dtgv_size_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            //dtgv_size.Rows[e.Row.Index - 1].Cells["ID"].Value = new Guid();
        }
    }
}
