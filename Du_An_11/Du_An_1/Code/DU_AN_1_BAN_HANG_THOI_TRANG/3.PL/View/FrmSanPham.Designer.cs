namespace _3.PL.View
{
    partial class FrmSanPham
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
            this.rbtn_ConHang = new System.Windows.Forms.RadioButton();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbtn_HetHang = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.dgrid_SP = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_them = new _3.PL.Custom.AnButtons();
            this.btn_sua = new _3.PL.Custom.AnButtons();
            this.btn_xoa = new _3.PL.Custom.AnButtons();
            this.btn_reset = new _3.PL.Custom.AnButtons();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_SP)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtn_ConHang
            // 
            this.rbtn_ConHang.AutoSize = true;
            this.rbtn_ConHang.Location = new System.Drawing.Point(9, 28);
            this.rbtn_ConHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_ConHang.Name = "rbtn_ConHang";
            this.rbtn_ConHang.Size = new System.Drawing.Size(77, 19);
            this.rbtn_ConHang.TabIndex = 23;
            this.rbtn_ConHang.TabStop = true;
            this.rbtn_ConHang.Text = "Còn hàng";
            this.rbtn_ConHang.UseVisualStyleBackColor = true;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(12, 98);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(268, 23);
            this.txt_TimKiem.TabIndex = 25;
            this.txt_TimKiem.Text = "Tìm kiếm...";
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_reset);
            this.panel4.Controls.Add(this.btn_xoa);
            this.panel4.Controls.Add(this.btn_sua);
            this.panel4.Controls.Add(this.btn_them);
            this.panel4.Location = new System.Drawing.Point(111, 261);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(166, 189);
            this.panel4.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbtn_ConHang);
            this.panel3.Controls.Add(this.rbtn_HetHang);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 261);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(93, 189);
            this.panel3.TabIndex = 34;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // rbtn_HetHang
            // 
            this.rbtn_HetHang.AutoSize = true;
            this.rbtn_HetHang.Location = new System.Drawing.Point(9, 58);
            this.rbtn_HetHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_HetHang.Name = "rbtn_HetHang";
            this.rbtn_HetHang.Size = new System.Drawing.Size(74, 19);
            this.rbtn_HetHang.TabIndex = 24;
            this.rbtn_HetHang.TabStop = true;
            this.rbtn_HetHang.Text = "Hết hàng";
            this.rbtn_HetHang.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Trạng thái:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_Ma);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_Ten);
            this.panel2.Location = new System.Drawing.Point(12, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 96);
            this.panel2.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã:";
            // 
            // txt_Ma
            // 
            this.txt_Ma.Location = new System.Drawing.Point(77, 9);
            this.txt_Ma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(188, 23);
            this.txt_Ma.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên SP:";
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(78, 54);
            this.txt_Ten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(187, 23);
            this.txt_Ten.TabIndex = 19;
            // 
            // dgrid_SP
            // 
            this.dgrid_SP.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgrid_SP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_SP.Location = new System.Drawing.Point(286, 98);
            this.dgrid_SP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrid_SP.Name = "dgrid_SP";
            this.dgrid_SP.RowHeadersWidth = 51;
            this.dgrid_SP.RowTemplate.Height = 29;
            this.dgrid_SP.Size = new System.Drawing.Size(350, 352);
            this.dgrid_SP.TabIndex = 31;
            this.dgrid_SP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_SP_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::_3.PL.Properties.Resources.web_banhang_banner;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 65);
            this.panel1.TabIndex = 32;
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
            this.btn_them.Location = new System.Drawing.Point(3, 8);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(160, 39);
            this.btn_them.TabIndex = 40;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextColor = System.Drawing.Color.White;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_Them_Click);
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
            this.btn_sua.Location = new System.Drawing.Point(3, 48);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(160, 39);
            this.btn_sua.TabIndex = 41;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextColor = System.Drawing.Color.White;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_Sua_Click);
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
            this.btn_xoa.Location = new System.Drawing.Point(3, 93);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(160, 39);
            this.btn_xoa.TabIndex = 42;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextColor = System.Drawing.Color.White;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
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
            this.btn_reset.Location = new System.Drawing.Point(3, 138);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(160, 39);
            this.btn_reset.TabIndex = 43;
            this.btn_reset.Text = "Reset";
            this.btn_reset.TextColor = System.Drawing.Color.White;
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(644, 456);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgrid_SP);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSanPham";
            this.Text = "FrmSanPham";
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_SP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbtn_ConHang;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbtn_HetHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.DataGridView dgrid_SP;
        private System.Windows.Forms.Panel panel1;
        private Custom.AnButtons btn_them;
        private Custom.AnButtons btn_sua;
        private Custom.AnButtons btn_xoa;
        private Custom.AnButtons btn_reset;
    }
}