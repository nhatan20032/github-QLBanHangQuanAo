namespace _3.PL.View
{
    partial class FrmQuanLy
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmsssssToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.dòngSPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 697);
            this.panel1.TabIndex = 6;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.sảnPhẩmsssssToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.dòngSPToolStripMenuItem,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1076, 24);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 20);
            this.toolStripMenuItem1.Text = "Quản lý sản phẩm chi tiết";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.sảnPhẩmToolStripMenuItem_Click);
            // 
            // sảnPhẩmsssssToolStripMenuItem1
            // 
            this.sảnPhẩmsssssToolStripMenuItem1.Image = global::_3.PL.Properties.Resources.prodcut;
            this.sảnPhẩmsssssToolStripMenuItem1.Name = "sảnPhẩmsssssToolStripMenuItem1";
            this.sảnPhẩmsssssToolStripMenuItem1.Size = new System.Drawing.Size(88, 20);
            this.sảnPhẩmsssssToolStripMenuItem1.Text = "Sản phẩm";
            this.sảnPhẩmsssssToolStripMenuItem1.Click += new System.EventHandler(this.sảnPhẩmToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::_3.PL.Properties.Resources.size;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(55, 20);
            this.toolStripMenuItem2.Text = "Size";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.sizeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::_3.PL.Properties.Resources.material;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(82, 20);
            this.toolStripMenuItem3.Text = "Chất liệu";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.chấtLiệuToolStripMenuItem_Click);
            // 
            // dòngSPToolStripMenuItem
            // 
            this.dòngSPToolStripMenuItem.Image = global::_3.PL.Properties.Resources.product_line;
            this.dòngSPToolStripMenuItem.Name = "dòngSPToolStripMenuItem";
            this.dòngSPToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.dòngSPToolStripMenuItem.Text = "Dòng Sản Phẩm";
            this.dòngSPToolStripMenuItem.Click += new System.EventHandler(this.dòngSPToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(86, 20);
            this.toolStripMenuItem4.Text = "Thương hiệu";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.thươngHiệuToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Image = global::_3.PL.Properties.Resources.color;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(79, 20);
            this.toolStripMenuItem5.Text = "Màu sắc";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.màuSắcToolStripMenuItem_Click);
            // 
            // FrmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 721);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FrmQuanLy";
            this.Text = "FrmQuanLy";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmsssssToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem dòngSPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
    }
}