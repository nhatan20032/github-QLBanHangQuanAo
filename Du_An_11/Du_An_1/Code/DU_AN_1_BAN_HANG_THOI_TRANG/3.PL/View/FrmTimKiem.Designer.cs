namespace _3.PL.View
{
    partial class FrmTimKiem
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
            this.tb_otp = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.anButtons1 = new _3.PL.Custom.AnButtons();
            this.anButtons2 = new _3.PL.Custom.AnButtons();
            this.SuspendLayout();
            // 
            // tb_otp
            // 
            this.tb_otp.Location = new System.Drawing.Point(279, 69);
            this.tb_otp.Name = "tb_otp";
            this.tb_otp.Size = new System.Drawing.Size(100, 23);
            this.tb_otp.TabIndex = 6;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(12, 40);
            this.tb_email.Name = "tb_email";
            this.tb_email.PlaceholderText = "Nhập gmail đăng kí tài khoản...";
            this.tb_email.Size = new System.Drawing.Size(510, 23);
            this.tb_email.TabIndex = 4;
            // 
            // anButtons1
            // 
            this.anButtons1.BackColor = System.Drawing.Color.OrangeRed;
            this.anButtons1.BackgroundColor = System.Drawing.Color.OrangeRed;
            this.anButtons1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.anButtons1.BorderRadius = 20;
            this.anButtons1.BorderSize = 0;
            this.anButtons1.FlatAppearance.BorderSize = 0;
            this.anButtons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anButtons1.ForeColor = System.Drawing.Color.White;
            this.anButtons1.Location = new System.Drawing.Point(12, 69);
            this.anButtons1.Name = "anButtons1";
            this.anButtons1.Size = new System.Drawing.Size(220, 23);
            this.anButtons1.TabIndex = 8;
            this.anButtons1.Text = "Lấy mã OTP";
            this.anButtons1.TextColor = System.Drawing.Color.White;
            this.anButtons1.UseVisualStyleBackColor = false;
            this.anButtons1.Click += new System.EventHandler(this.anButtons1_Click);
            // 
            // anButtons2
            // 
            this.anButtons2.BackColor = System.Drawing.Color.OrangeRed;
            this.anButtons2.BackgroundColor = System.Drawing.Color.OrangeRed;
            this.anButtons2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.anButtons2.BorderRadius = 20;
            this.anButtons2.BorderSize = 0;
            this.anButtons2.FlatAppearance.BorderSize = 0;
            this.anButtons2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anButtons2.ForeColor = System.Drawing.Color.White;
            this.anButtons2.Location = new System.Drawing.Point(385, 69);
            this.anButtons2.Name = "anButtons2";
            this.anButtons2.Size = new System.Drawing.Size(137, 23);
            this.anButtons2.TabIndex = 9;
            this.anButtons2.Text = "Xác nhận mã OPT";
            this.anButtons2.TextColor = System.Drawing.Color.White;
            this.anButtons2.UseVisualStyleBackColor = false;
            this.anButtons2.Click += new System.EventHandler(this.anButtons2_Click);
            // 
            // FrmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(534, 114);
            this.Controls.Add(this.anButtons2);
            this.Controls.Add(this.anButtons1);
            this.Controls.Add(this.tb_otp);
            this.Controls.Add(this.tb_email);
            this.Name = "FrmTimKiem";
            this.Text = "FrmTimKiem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_otp;
        private System.Windows.Forms.TextBox tb_email;
        private Custom.AnButtons anButtons1;
        private Custom.AnButtons anButtons2;
    }
}