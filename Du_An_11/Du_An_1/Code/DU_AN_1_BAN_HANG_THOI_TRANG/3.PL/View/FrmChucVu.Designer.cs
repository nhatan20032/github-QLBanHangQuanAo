namespace _3.PL.View
{
    partial class FrmChucVu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgrid_ChucVu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.rbtn_NghiViec = new System.Windows.Forms.RadioButton();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.rbtn_LamViec = new System.Windows.Forms.RadioButton();
            this.lbl_TrangThai = new System.Windows.Forms.Label();
            this.btn_reset = new _3.PL.Custom.AnButtons();
            this.btn_xoa = new _3.PL.Custom.AnButtons();
            this.btn_sua = new _3.PL.Custom.AnButtons();
            this.btn_them = new _3.PL.Custom.AnButtons();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::_3.PL.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(601, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 130);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(309, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tên:";
            // 
            // dgrid_ChucVu
            // 
            this.dgrid_ChucVu.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgrid_ChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_ChucVu.Location = new System.Drawing.Point(12, 216);
            this.dgrid_ChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrid_ChucVu.Name = "dgrid_ChucVu";
            this.dgrid_ChucVu.RowHeadersWidth = 51;
            this.dgrid_ChucVu.RowTemplate.Height = 29;
            this.dgrid_ChucVu.Size = new System.Drawing.Size(761, 254);
            this.dgrid_ChucVu.TabIndex = 15;
            this.dgrid_ChucVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_ChucVu_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(29, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã:";
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(352, 16);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(205, 23);
            this.tb_ten.TabIndex = 26;
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(86, 14);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(205, 23);
            this.tb_ma.TabIndex = 25;
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TimKiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_TimKiem.Location = new System.Drawing.Point(12, 184);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(74, 19);
            this.lbl_TimKiem.TabIndex = 19;
            this.lbl_TimKiem.Text = "Tìm kiếm: ";
            // 
            // rbtn_NghiViec
            // 
            this.rbtn_NghiViec.AutoSize = true;
            this.rbtn_NghiViec.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtn_NghiViec.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtn_NghiViec.Location = new System.Drawing.Point(320, 61);
            this.rbtn_NghiViec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_NghiViec.Name = "rbtn_NghiViec";
            this.rbtn_NghiViec.Size = new System.Drawing.Size(87, 23);
            this.rbtn_NghiViec.TabIndex = 24;
            this.rbtn_NghiViec.TabStop = true;
            this.rbtn_NghiViec.Text = "Nghỉ việc";
            this.rbtn_NghiViec.UseVisualStyleBackColor = true;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(92, 184);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(288, 23);
            this.txt_TimKiem.TabIndex = 20;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // rbtn_LamViec
            // 
            this.rbtn_LamViec.AutoSize = true;
            this.rbtn_LamViec.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtn_LamViec.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtn_LamViec.Location = new System.Drawing.Point(143, 61);
            this.rbtn_LamViec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_LamViec.Name = "rbtn_LamViec";
            this.rbtn_LamViec.Size = new System.Drawing.Size(82, 23);
            this.rbtn_LamViec.TabIndex = 23;
            this.rbtn_LamViec.TabStop = true;
            this.rbtn_LamViec.Text = "Làm việc";
            this.rbtn_LamViec.UseVisualStyleBackColor = true;
            // 
            // lbl_TrangThai
            // 
            this.lbl_TrangThai.AutoSize = true;
            this.lbl_TrangThai.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TrangThai.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TrangThai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_TrangThai.Location = new System.Drawing.Point(29, 61);
            this.lbl_TrangThai.Name = "lbl_TrangThai";
            this.lbl_TrangThai.Size = new System.Drawing.Size(78, 19);
            this.lbl_TrangThai.TabIndex = 22;
            this.lbl_TrangThai.Text = "Trạng Thái:";
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_reset.BackgroundColor = System.Drawing.Color.OrangeRed;
            this.btn_reset.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_reset.BorderRadius = 20;
            this.btn_reset.BorderSize = 0;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Image = global::_3.PL.Properties.Resources.reset;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(428, 129);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(113, 39);
            this.btn_reset.TabIndex = 46;
            this.btn_reset.Text = "Reset";
            this.btn_reset.TextColor = System.Drawing.Color.White;
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_xoa.BackgroundColor = System.Drawing.Color.OrangeRed;
            this.btn_xoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_xoa.BorderRadius = 20;
            this.btn_xoa.BorderSize = 0;
            this.btn_xoa.FlatAppearance.BorderSize = 0;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Image = global::_3.PL.Properties.Resources.delete;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(287, 129);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(108, 39);
            this.btn_xoa.TabIndex = 45;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextColor = System.Drawing.Color.White;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_sua.BackgroundColor = System.Drawing.Color.OrangeRed;
            this.btn_sua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_sua.BorderRadius = 20;
            this.btn_sua.BorderSize = 0;
            this.btn_sua.FlatAppearance.BorderSize = 0;
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Image = global::_3.PL.Properties.Resources.updated;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(152, 129);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(110, 39);
            this.btn_sua.TabIndex = 44;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextColor = System.Drawing.Color.White;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_them.BackgroundColor = System.Drawing.Color.OrangeRed;
            this.btn_them.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_them.BorderRadius = 20;
            this.btn_them.BorderSize = 0;
            this.btn_them.FlatAppearance.BorderSize = 0;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Image = global::_3.PL.Properties.Resources.plus;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(12, 129);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(114, 39);
            this.btn_them.TabIndex = 43;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextColor = System.Drawing.Color.White;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // FrmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(784, 481);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgrid_ChucVu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ten);
            this.Controls.Add(this.tb_ma);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.rbtn_NghiViec);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.rbtn_LamViec);
            this.Controls.Add(this.lbl_TrangThai);
            this.Name = "FrmChucVu";
            this.Text = "FrmChucVu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ChucVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgrid_ChucVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.RadioButton rbtn_NghiViec;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.RadioButton rbtn_LamViec;
        private System.Windows.Forms.Label lbl_TrangThai;
        private Custom.AnButtons btn_reset;
        private Custom.AnButtons btn_xoa;
        private Custom.AnButtons btn_sua;
        private Custom.AnButtons btn_them;
    }
}