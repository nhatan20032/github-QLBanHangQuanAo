namespace _3.PL.View
{
    partial class FrmSize
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rbtn_hetsize = new System.Windows.Forms.RadioButton();
            this.rbtn_consize = new System.Windows.Forms.RadioButton();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgv_size = new System.Windows.Forms.DataGridView();
            this.btn_reset = new _3.PL.Custom.AnButtons();
            this.btn_xoa = new _3.PL.Custom.AnButtons();
            this.btn_sua = new _3.PL.Custom.AnButtons();
            this.btn_them = new _3.PL.Custom.AnButtons();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_size)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtn_hetsize
            // 
            this.rbtn_hetsize.AutoSize = true;
            this.rbtn_hetsize.Location = new System.Drawing.Point(186, 136);
            this.rbtn_hetsize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_hetsize.Name = "rbtn_hetsize";
            this.rbtn_hetsize.Size = new System.Drawing.Size(66, 19);
            this.rbtn_hetsize.TabIndex = 35;
            this.rbtn_hetsize.TabStop = true;
            this.rbtn_hetsize.Text = "Hết size";
            this.rbtn_hetsize.UseVisualStyleBackColor = true;
            // 
            // rbtn_consize
            // 
            this.rbtn_consize.AutoSize = true;
            this.rbtn_consize.Location = new System.Drawing.Point(88, 136);
            this.rbtn_consize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_consize.Name = "rbtn_consize";
            this.rbtn_consize.Size = new System.Drawing.Size(69, 19);
            this.rbtn_consize.TabIndex = 36;
            this.rbtn_consize.TabStop = true;
            this.rbtn_consize.Text = "Còn size";
            this.rbtn_consize.UseVisualStyleBackColor = true;
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(88, 27);
            this.txt_ma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(110, 23);
            this.txt_ma.TabIndex = 27;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(88, 168);
            this.txt_timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(217, 23);
            this.txt_timkiem.TabIndex = 28;
            this.txt_timkiem.Click += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // txt_mota
            // 
            this.txt_mota.Location = new System.Drawing.Point(88, 99);
            this.txt_mota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(110, 23);
            this.txt_mota.TabIndex = 29;
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(88, 64);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(110, 23);
            this.txt_ten.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Trạng thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mã";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Mô tả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tìm kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tên";
            // 
            // dtgv_size
            // 
            this.dtgv_size.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_size.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dtgv_size.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_size.Location = new System.Drawing.Point(12, 196);
            this.dtgv_size.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv_size.Name = "dtgv_size";
            this.dtgv_size.RowHeadersWidth = 51;
            this.dtgv_size.RowTemplate.Height = 29;
            this.dtgv_size.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_size.Size = new System.Drawing.Size(506, 106);
            this.dtgv_size.TabIndex = 21;
            this.dtgv_size.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_size_CellClick);
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
            this.btn_reset.Location = new System.Drawing.Point(370, 147);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(133, 39);
            this.btn_reset.TabIndex = 50;
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
            this.btn_xoa.Location = new System.Drawing.Point(370, 98);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(133, 39);
            this.btn_xoa.TabIndex = 49;
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
            this.btn_sua.Location = new System.Drawing.Point(370, 53);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(133, 39);
            this.btn_sua.TabIndex = 48;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextColor = System.Drawing.Color.White;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
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
            this.btn_them.Location = new System.Drawing.Point(370, 6);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(133, 39);
            this.btn_them.TabIndex = 47;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextColor = System.Drawing.Color.White;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // FrmSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(527, 313);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.rbtn_hetsize);
            this.Controls.Add(this.rbtn_consize);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.txt_mota);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgv_size);
            this.Name = "FrmSize";
            this.Text = "FrmSize";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rbtn_hetsize;
        private System.Windows.Forms.RadioButton rbtn_consize;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgv_size;
        private Custom.AnButtons btn_reset;
        private Custom.AnButtons btn_xoa;
        private Custom.AnButtons btn_sua;
        private Custom.AnButtons btn_them;
    }
}