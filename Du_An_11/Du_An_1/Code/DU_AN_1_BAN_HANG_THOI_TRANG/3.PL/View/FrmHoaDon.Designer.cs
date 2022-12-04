namespace _3.PL.View
{
    partial class FrmHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_XoaHD = new System.Windows.Forms.Button();
            this.btn_TIMKIEM = new System.Windows.Forms.Button();
            this.txt_TK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrid_hdct = new System.Windows.Forms.DataGridView();
            this.dgrid_hoadon = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCTSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hdct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_XoaHD
            // 
            this.btn_XoaHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_XoaHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_XoaHD.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_XoaHD.Location = new System.Drawing.Point(700, 58);
            this.btn_XoaHD.Margin = new System.Windows.Forms.Padding(2);
            this.btn_XoaHD.Name = "btn_XoaHD";
            this.btn_XoaHD.Size = new System.Drawing.Size(90, 33);
            this.btn_XoaHD.TabIndex = 20;
            this.btn_XoaHD.Text = "Xóa HD";
            this.btn_XoaHD.UseVisualStyleBackColor = false;
            this.btn_XoaHD.Click += new System.EventHandler(this.btn_XoaHD_Click);
            // 
            // btn_TIMKIEM
            // 
            this.btn_TIMKIEM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_TIMKIEM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_TIMKIEM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_TIMKIEM.Location = new System.Drawing.Point(321, 58);
            this.btn_TIMKIEM.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TIMKIEM.Name = "btn_TIMKIEM";
            this.btn_TIMKIEM.Size = new System.Drawing.Size(90, 33);
            this.btn_TIMKIEM.TabIndex = 19;
            this.btn_TIMKIEM.Text = "Tìm kiếm";
            this.btn_TIMKIEM.UseVisualStyleBackColor = false;
            this.btn_TIMKIEM.Click += new System.EventHandler(this.btn_TIMKIEM_Click);
            // 
            // txt_TK
            // 
            this.txt_TK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TK.Location = new System.Drawing.Point(11, 61);
            this.txt_TK.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TK.Name = "txt_TK";
            this.txt_TK.Size = new System.Drawing.Size(288, 29);
            this.txt_TK.TabIndex = 18;
            this.txt_TK.Text = "Tìm kiếm hóa đơn...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(8, 253);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Hóa đơn chi tiết";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hóa đơn";
            // 
            // dgrid_hdct
            // 
            this.dgrid_hdct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_hdct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCTSP,
            this.TenSP,
            this.SoLuong,
            this.DonGia});
            this.dgrid_hdct.Location = new System.Drawing.Point(8, 287);
            this.dgrid_hdct.Margin = new System.Windows.Forms.Padding(2);
            this.dgrid_hdct.Name = "dgrid_hdct";
            this.dgrid_hdct.RowHeadersWidth = 62;
            this.dgrid_hdct.RowTemplate.Height = 33;
            this.dgrid_hdct.Size = new System.Drawing.Size(797, 139);
            this.dgrid_hdct.TabIndex = 15;
            // 
            // dgrid_hoadon
            // 
            this.dgrid_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_hoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ma,
            this.NgayTao,
            this.TenNhanVien,
            this.TenKhachHang,
            this.SDT,
            this.ThanhTien,
            this.TrangThai,
            this.GhiChu});
            this.dgrid_hoadon.Location = new System.Drawing.Point(11, 101);
            this.dgrid_hoadon.Margin = new System.Windows.Forms.Padding(2);
            this.dgrid_hoadon.Name = "dgrid_hoadon";
            this.dgrid_hoadon.RowHeadersWidth = 62;
            this.dgrid_hoadon.RowTemplate.Height = 33;
            this.dgrid_hoadon.Size = new System.Drawing.Size(797, 150);
            this.dgrid_hoadon.TabIndex = 14;
            this.dgrid_hoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_hoadon_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Ma
            // 
            this.Ma.HeaderText = "Ma";
            this.Ma.Name = "Ma";
            // 
            // NgayTao
            // 
            this.NgayTao.HeaderText = "NgayTao";
            this.NgayTao.Name = "NgayTao";
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.HeaderText = "TenNhanVien";
            this.TenNhanVien.Name = "TenNhanVien";
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.HeaderText = "TenKhachHang";
            this.TenKhachHang.Name = "TenKhachHang";
            // 
            // SDT
            // 
            this.SDT.HeaderText = "SDT";
            this.SDT.Name = "SDT";
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "ThanhTien";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "TrangThai";
            this.TrangThai.Name = "TrangThai";
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "GhiChu";
            this.GhiChu.Name = "GhiChu";
            // 
            // IDCTSP
            // 
            this.IDCTSP.HeaderText = "ID";
            this.IDCTSP.Name = "IDCTSP";
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "TenSP";
            this.TenSP.Name = "TenSP";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "DonGia";
            this.DonGia.Name = "DonGia";
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.btn_XoaHD);
            this.Controls.Add(this.btn_TIMKIEM);
            this.Controls.Add(this.txt_TK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrid_hdct);
            this.Controls.Add(this.dgrid_hoadon);
            this.Name = "FrmHoaDon";
            this.Text = "FrmHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hdct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_hoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_XoaHD;
        private System.Windows.Forms.Button btn_TIMKIEM;
        private System.Windows.Forms.TextBox txt_TK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgrid_hdct;
        private System.Windows.Forms.DataGridView dgrid_hoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCTSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}