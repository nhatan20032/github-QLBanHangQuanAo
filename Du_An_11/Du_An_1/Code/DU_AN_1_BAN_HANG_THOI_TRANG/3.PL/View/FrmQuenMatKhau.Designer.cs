namespace _3.PL.View
{
    partial class FrmQuenMatKhau
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
            this.lb_loichao = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nhaplai = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.btn_xacnhan = new _3.PL.Custom.AnButtons();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::_3.PL.Properties.Resources.quenpass;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 507);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // lb_loichao
            // 
            this.lb_loichao.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_loichao.Location = new System.Drawing.Point(581, 84);
            this.lb_loichao.Name = "lb_loichao";
            this.lb_loichao.Size = new System.Drawing.Size(411, 42);
            this.lb_loichao.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Gmail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã";
            // 
            // tb_nhaplai
            // 
            this.tb_nhaplai.Location = new System.Drawing.Point(611, 299);
            this.tb_nhaplai.Name = "tb_nhaplai";
            this.tb_nhaplai.Size = new System.Drawing.Size(411, 23);
            this.tb_nhaplai.TabIndex = 16;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(611, 253);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(411, 23);
            this.tb_pass.TabIndex = 15;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(611, 206);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(411, 23);
            this.tb_email.TabIndex = 14;
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(611, 159);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(411, 23);
            this.tb_ma.TabIndex = 13;
            // 
            // btn_xacnhan
            // 
            this.btn_xacnhan.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_xacnhan.BackgroundColor = System.Drawing.Color.OrangeRed;
            this.btn_xacnhan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_xacnhan.BorderRadius = 20;
            this.btn_xacnhan.BorderSize = 0;
            this.btn_xacnhan.FlatAppearance.BorderSize = 0;
            this.btn_xacnhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xacnhan.ForeColor = System.Drawing.Color.White;
            this.btn_xacnhan.Location = new System.Drawing.Point(872, 353);
            this.btn_xacnhan.Name = "btn_xacnhan";
            this.btn_xacnhan.Size = new System.Drawing.Size(150, 40);
            this.btn_xacnhan.TabIndex = 24;
            this.btn_xacnhan.Text = "Xác nhận";
            this.btn_xacnhan.TextColor = System.Drawing.Color.White;
            this.btn_xacnhan.UseVisualStyleBackColor = false;
            this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
            // 
            // FrmQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1044, 507);
            this.Controls.Add(this.btn_xacnhan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_loichao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_nhaplai);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_ma);
            this.Name = "FrmQuenMatKhau";
            this.Text = "FrmQuenMatKhau";
            this.Load += new System.EventHandler(this.FrmQuenMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_loichao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nhaplai;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_ma;
        private Custom.AnButtons btn_xacnhan;
    }
}