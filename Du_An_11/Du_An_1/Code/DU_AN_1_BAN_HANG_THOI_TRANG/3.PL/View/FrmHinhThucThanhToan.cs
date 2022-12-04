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
    public partial class FrmHinhThucThanhToan : Form
    {
        IHinhThucThanhToanServices hinhThucThanhToanServices;
        HinhThucThanhToan _HT;
        public FrmHinhThucThanhToan()
        {
            InitializeComponent();
            hinhThucThanhToanServices = new HinhThucThanhToanServices();
            loadData();
        }
        public void loadData()
        {
            dtg_show.ColumnCount = 5;
            dtg_show.Columns[0].Name = "Id";
            dtg_show.Columns[0].Visible = false;
            dtg_show.Columns[1].Name = "Mã";
            dtg_show.Columns[2].Name = "Tên";
            dtg_show.Columns[3].Name = "Mô tả";
            dtg_show.Columns[4].Name = "Trạng thái";
            dtg_show.Rows.Clear();
            var lsthinhthuc = hinhThucThanhToanServices.GetAll();

            //if (txt_timkiem.Text != "")
            //{
            //    lstChatLieu = lstChatLieu.Where(c => c.Ma.ToLower().Contains(txt_timkiem.Text.ToLower()) || c.Ten.ToLower().Contains(txt_timkiem.Text.ToLower())).ToList();
            //}

            foreach (var x in lsthinhthuc)
            {
                dtg_show.Rows.Add(x.ID, x.Ma, x.Ten, x.TrangThai == 1 ? "Còn HĐ" : "Dừng HĐ");
            }
        }
        public void resetForm()
        {
            loadData();
            _HT = null;
            tb_ma.Text = "";
            tb_ten.Text = "";
            rdb_nhd.Checked = false;
            rdb_hd.Checked = true;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thêm chất liệu này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (tb_ma.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã chất liệu");
                }
                else if (hinhThucThanhToanServices.GetAll().Any(c => c.Ma == tb_ma.Text))
                {
                    MessageBox.Show("Mã chất liệu này đã tồn tại");
                }
                else
                {
                    var cl = new HinhThucThanhToan()
                    {
                        ID = new Guid(),
                        Ma = tb_ma.Text,
                        Ten = tb_ten.Text,
                        TrangThai = rdb_hd.Checked ? 1 : 0

                    };

                    hinhThucThanhToanServices.Add(cl);
                    MessageBox.Show("Thêm thành công");

                    resetForm();
                }
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa chất liệu này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (tb_ma.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã");
                }
                else if (_HT == null)
                {
                    MessageBox.Show("Vui lòng chọn chất liệu");
                }
                else
                {
                    if (_HT.Ma == tb_ma.Text || (_HT.Ma != tb_ma.Text && hinhThucThanhToanServices.GetAll().FirstOrDefault(c => c.Ma == tb_ma.Text) == null))
                    {
                        _HT.Ma = tb_ma.Text;
                        _HT.Ten = tb_ma.Text;
                        _HT.TrangThai = rdb_hd.Checked ? 1 : 0;
                        hinhThucThanhToanServices.Update(_HT);
                        MessageBox.Show("Sửa cửa hàng thành công");
                        resetForm();
                    }
                    else
                    {
                        MessageBox.Show("Mã chất liệu đã tồn tại");
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
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa chất liệu này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (_HT == null)
                {
                    MessageBox.Show("Vui lòng chọn chất liệu");
                }
                else
                {
                    hinhThucThanhToanServices.Delete(_HT);
                    MessageBox.Show("Xóa chất liệu thành công");
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

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_show.Rows[e.RowIndex];
                _HT = hinhThucThanhToanServices.GetAll().FirstOrDefault(c => c.ID == Guid.Parse(r.Cells[0].Value.ToString()));
                tb_ma.Text = r.Cells[1].Value.ToString();
                tb_ten.Text = r.Cells[2].Value.ToString();
                if (_HT.TrangThai == 1)
                {
                    rdb_hd.Checked = true;
                    return;
                }
                rdb_nhd.Checked = true;


            }
        }
    }
}
