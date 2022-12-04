namespace _3.PL.View
{
    partial class FrmThuongHieu
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
            this.dgrid_ThuongHieu = new System.Windows.Forms.DataGridView();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.rbtn_NgungCungCap = new System.Windows.Forms.RadioButton();
            this.rbtn_DangCungCap = new System.Windows.Forms.RadioButton();
            this.txt_MoTa = new System.Windows.Forms.RichTextBox();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reset = new _3.PL.Custom.AnButtons();
            this.btn_xoa = new _3.PL.Custom.AnButtons();
            this.btn_sua = new _3.PL.Custom.AnButtons();
            this.btn_them = new _3.PL.Custom.AnButtons();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ThuongHieu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid_ThuongHieu
            // 
            this.dgrid_ThuongHieu.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgrid_ThuongHieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_ThuongHieu.Location = new System.Drawing.Point(10, 211);
            this.dgrid_ThuongHieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrid_ThuongHieu.Name = "dgrid_ThuongHieu";
            this.dgrid_ThuongHieu.RowHeadersWidth = 51;
            this.dgrid_ThuongHieu.RowTemplate.Height = 29;
            this.dgrid_ThuongHieu.Size = new System.Drawing.Size(450, 162);
            this.dgrid_ThuongHieu.TabIndex = 41;
            this.dgrid_ThuongHieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_ThuongHieu_CellClick);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(12, 184);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(204, 23);
            this.txt_TimKiem.TabIndex = 40;
            this.txt_TimKiem.Text = "Tìm kiếm...";
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // rbtn_NgungCungCap
            // 
            this.rbtn_NgungCungCap.AutoSize = true;
            this.rbtn_NgungCungCap.Location = new System.Drawing.Point(183, 152);
            this.rbtn_NgungCungCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_NgungCungCap.Name = "rbtn_NgungCungCap";
            this.rbtn_NgungCungCap.Size = new System.Drawing.Size(114, 19);
            this.rbtn_NgungCungCap.TabIndex = 36;
            this.rbtn_NgungCungCap.TabStop = true;
            this.rbtn_NgungCungCap.Text = "Ngừng cung cấp";
            this.rbtn_NgungCungCap.UseVisualStyleBackColor = true;
            // 
            // rbtn_DangCungCap
            // 
            this.rbtn_DangCungCap.AutoSize = true;
            this.rbtn_DangCungCap.Location = new System.Drawing.Point(72, 151);
            this.rbtn_DangCungCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_DangCungCap.Name = "rbtn_DangCungCap";
            this.rbtn_DangCungCap.Size = new System.Drawing.Size(105, 19);
            this.rbtn_DangCungCap.TabIndex = 35;
            this.rbtn_DangCungCap.TabStop = true;
            this.rbtn_DangCungCap.Text = "Đang cung cấp";
            this.rbtn_DangCungCap.UseVisualStyleBackColor = true;
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Location = new System.Drawing.Point(72, 97);
            this.txt_MoTa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(232, 44);
            this.txt_MoTa.TabIndex = 34;
            this.txt_MoTa.Text = "";
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(72, 56);
            this.txt_Ten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(232, 23);
            this.txt_Ten.TabIndex = 33;
            // 
            // txt_Ma
            // 
            this.txt_Ma.Location = new System.Drawing.Point(72, 11);
            this.txt_Ma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(230, 23);
            this.txt_Ma.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Trạng thái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Mô tả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mã:";
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
            this.btn_reset.Location = new System.Drawing.Point(327, 152);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(133, 39);
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
            this.btn_xoa.Location = new System.Drawing.Point(327, 103);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(133, 39);
            this.btn_xoa.TabIndex = 45;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextColor = System.Drawing.Color.White;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
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
            this.btn_sua.Location = new System.Drawing.Point(327, 58);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(133, 39);
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
            this.btn_them.Location = new System.Drawing.Point(327, 11);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(133, 39);
            this.btn_them.TabIndex = 43;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextColor = System.Drawing.Color.White;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // FrmThuongHieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(479, 384);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgrid_ThuongHieu);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.rbtn_NgungCungCap);
            this.Controls.Add(this.rbtn_DangCungCap);
            this.Controls.Add(this.txt_MoTa);
            this.Controls.Add(this.txt_Ten);
            this.Controls.Add(this.txt_Ma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmThuongHieu";
            this.Text = "FrmThuongHieu";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ThuongHieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid_ThuongHieu;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.RadioButton rbtn_NgungCungCap;
        private System.Windows.Forms.RadioButton rbtn_DangCungCap;
        private System.Windows.Forms.RichTextBox txt_MoTa;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Custom.AnButtons btn_reset;
        private Custom.AnButtons btn_xoa;
        private Custom.AnButtons btn_sua;
        private Custom.AnButtons btn_them;
    }
}