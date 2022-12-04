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
    public partial class FrmChatLieu : Form
    {
        public IChatLieuServices _chatLieuServices;
        public ChatLieu _cl;
        public FrmChatLieu()
        {
            InitializeComponent();
            _chatLieuServices = new ChatLieuServices();
            loadData();
        }
        public void loadData()
        {
            dtgv_chatlieu.ColumnCount = 5;
            dtgv_chatlieu.Columns[0].Name = "Id";
            dtgv_chatlieu.Columns[0].Visible = false;
            dtgv_chatlieu.Columns[1].Name = "Mã";
            dtgv_chatlieu.Columns[2].Name = "Tên";
            dtgv_chatlieu.Columns[3].Name = "Mô tả";
            dtgv_chatlieu.Columns[4].Name = "Trạng thái";
            dtgv_chatlieu.Rows.Clear();
            var lstChatLieu = _chatLieuServices.getChatLieuFromDB();

            if (txt_timkiem.Text != "")
            {
                lstChatLieu = lstChatLieu.Where(c => c.Ma.ToLower().Contains(txt_timkiem.Text.ToLower()) || c.Ten.ToLower().Contains(txt_timkiem.Text.ToLower())).ToList();
            }

            foreach (var x in lstChatLieu)
            {
                dtgv_chatlieu.Rows.Add(x.ID, x.Ma, x.Ten, x.MoTa, x.TrangThai == 1 ? "Còn hàng" : "Hết hàng");
            }
        }
        public void resetForm()
        {
            loadData();
            _cl = null;
            txt_ma.Text = "";
            txt_ten.Text = "";
            txt_mota.Text = "";
            rbtn_conhang.Checked = false;
            rbtn_hethang.Checked = true;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thêm chất liệu này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (txt_ma.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã chất liệu");
                }
                else if (_chatLieuServices.getChatLieuFromDB().Any(c => c.Ma == txt_ma.Text))
                {
                    MessageBox.Show("Mã chất liệu này đã tồn tại");
                }
                else
                {
                    var cl = new ChatLieu()
                    {
                        ID = new Guid(),
                        Ma = txt_ma.Text,
                        Ten = txt_ten.Text,
                        MoTa = txt_mota.Text,
                        TrangThai = rbtn_conhang.Checked ? 1 : 0

                    };

                    _chatLieuServices.Add(cl);
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
                if (txt_ma.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã");
                }
                else if (_cl == null)
                {
                    MessageBox.Show("Vui lòng chọn chất liệu");
                }
                else
                {
                    if (_cl.Ma == txt_ma.Text || (_cl.Ma != txt_ma.Text && _chatLieuServices.getChatLieuFromDB().FirstOrDefault(c => c.Ma == txt_ma.Text) == null))
                    {
                        _cl.Ma = txt_ma.Text;
                        _cl.Ten = txt_ten.Text;
                        _cl.MoTa = txt_mota.Text;
                        _cl.TrangThai = rbtn_conhang.Checked ? 1 : 0;
                        _chatLieuServices.Update(_cl);
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
                if (_cl == null)
                {
                    MessageBox.Show("Vui lòng chọn chất liệu");
                }
                else
                {
                    _chatLieuServices.Delete(_cl);
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

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void dtgv_chatlieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtgv_chatlieu.Rows[e.RowIndex];
                _cl = _chatLieuServices.getChatLieuFromDB().FirstOrDefault(c => c.ID == Guid.Parse(r.Cells[0].Value.ToString()));
                txt_ma.Text = r.Cells[1].Value.ToString();
                txt_ten.Text = r.Cells[2].Value.ToString();
                txt_mota.Text = r.Cells[3].Value.ToString();
                if (_cl.TrangThai == 1)
                {
                    rbtn_conhang.Checked = true;
                    return;
                }
                rbtn_hethang.Checked = true;


            }
        }
    }
}
