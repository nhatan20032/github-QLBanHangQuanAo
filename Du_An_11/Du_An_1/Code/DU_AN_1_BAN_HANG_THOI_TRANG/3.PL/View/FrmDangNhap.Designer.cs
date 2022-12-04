namespace _3.PL.View
{
    partial class FrmDangNhap
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
            this.cb_nmk = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_quenmatkhau = new System.Windows.Forms.Label();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.tb_taikhoan = new System.Windows.Forms.TextBox();
            this.btn_dangnhap = new _3.PL.Custom.AnButtons();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_nmk
            // 
            this.cb_nmk.AutoSize = true;
            this.cb_nmk.Location = new System.Drawing.Point(21, 260);
            this.cb_nmk.Name = "cb_nmk";
            this.cb_nmk.Size = new System.Drawing.Size(124, 19);
            this.cb_nmk.TabIndex = 24;
            this.cb_nmk.Text = "Ghi Nhớ Mật Khẩu";
            this.cb_nmk.UseVisualStyleBackColor = true;
            this.cb_nmk.CheckedChanged += new System.EventHandler(this.cb_nmk_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::_3.PL.Properties.Resources.user__1_;
            this.pictureBox3.Location = new System.Drawing.Point(17, 153);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::_3.PL.Properties.Resources.padlock;
            this.pictureBox2.Location = new System.Drawing.Point(21, 209);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 38);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(17, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 3);
            this.panel2.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_3.PL.Properties.Resources.login__1_;
            this.pictureBox1.Location = new System.Drawing.Point(120, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 134);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(17, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 3);
            this.panel1.TabIndex = 19;
            // 
            // lb_quenmatkhau
            // 
            this.lb_quenmatkhau.AutoSize = true;
            this.lb_quenmatkhau.ForeColor = System.Drawing.Color.Black;
            this.lb_quenmatkhau.Location = new System.Drawing.Point(21, 282);
            this.lb_quenmatkhau.Name = "lb_quenmatkhau";
            this.lb_quenmatkhau.Size = new System.Drawing.Size(89, 15);
            this.lb_quenmatkhau.TabIndex = 18;
            this.lb_quenmatkhau.Text = "Quên mật khẩu";
            this.lb_quenmatkhau.Click += new System.EventHandler(this.lb_quenmatkhau_Click);
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.BackColor = System.Drawing.Color.White;
            this.tb_matkhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_matkhau.Location = new System.Drawing.Point(63, 225);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.PasswordChar = '*';
            this.tb_matkhau.PlaceholderText = "PassWord";
            this.tb_matkhau.Size = new System.Drawing.Size(282, 16);
            this.tb_matkhau.TabIndex = 16;
            // 
            // tb_taikhoan
            // 
            this.tb_taikhoan.BackColor = System.Drawing.Color.White;
            this.tb_taikhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_taikhoan.ForeColor = System.Drawing.Color.Black;
            this.tb_taikhoan.Location = new System.Drawing.Point(63, 178);
            this.tb_taikhoan.Name = "tb_taikhoan";
            this.tb_taikhoan.PlaceholderText = "UserName";
            this.tb_taikhoan.Size = new System.Drawing.Size(282, 16);
            this.tb_taikhoan.TabIndex = 15;
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_dangnhap.BackgroundColor = System.Drawing.Color.OrangeRed;
            this.btn_dangnhap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_dangnhap.BorderRadius = 20;
            this.btn_dangnhap.BorderSize = 0;
            this.btn_dangnhap.FlatAppearance.BorderSize = 0;
            this.btn_dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangnhap.ForeColor = System.Drawing.Color.White;
            this.btn_dangnhap.Location = new System.Drawing.Point(238, 257);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(107, 40);
            this.btn_dangnhap.TabIndex = 25;
            this.btn_dangnhap.Text = "Đăng Nhập";
            this.btn_dangnhap.TextColor = System.Drawing.Color.White;
            this.btn_dangnhap.UseVisualStyleBackColor = false;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(377, 330);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.cb_nmk);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_quenmatkhau);
            this.Controls.Add(this.tb_matkhau);
            this.Controls.Add(this.tb_taikhoan);
            this.Name = "FrmDangNhap";
            this.Text = "FrmDangNhap";
            this.Load += new System.EventHandler(this.FrmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_nmk;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_quenmatkhau;
        private System.Windows.Forms.TextBox tb_matkhau;
        private System.Windows.Forms.TextBox tb_taikhoan;
        private Custom.AnButtons btn_dangnhap;
    }
}