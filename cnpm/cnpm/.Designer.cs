namespace cnpm
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.QuanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyBanHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyHangHoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suaTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatChuongTrinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLuKhachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuanLyToolStripMenuItem,
            this.suaTaiKhoanToolStripMenuItem,
            this.thoatChuongTrinhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(448, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // QuanLyToolStripMenuItem
            // 
            this.QuanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyBanHangToolStripMenuItem,
            this.quanLyNhanVienToolStripMenuItem,
            this.quanLyHangHoaToolStripMenuItem,
            this.quanLuKhachHangToolStripMenuItem});
            this.QuanLyToolStripMenuItem.Name = "QuanLyToolStripMenuItem";
            this.QuanLyToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.QuanLyToolStripMenuItem.Text = "Quan ly";
            // 
            // quanLyBanHangToolStripMenuItem
            // 
            this.quanLyBanHangToolStripMenuItem.Name = "quanLyBanHangToolStripMenuItem";
            this.quanLyBanHangToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quanLyBanHangToolStripMenuItem.Text = "quan ly don hang";
            this.quanLyBanHangToolStripMenuItem.Click += new System.EventHandler(this.quanLyBanHangToolStripMenuItem_Click);
            // 
            // quanLyNhanVienToolStripMenuItem
            // 
            this.quanLyNhanVienToolStripMenuItem.Name = "quanLyNhanVienToolStripMenuItem";
            this.quanLyNhanVienToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quanLyNhanVienToolStripMenuItem.Text = "quan ly nhan vien";
            this.quanLyNhanVienToolStripMenuItem.Click += new System.EventHandler(this.quanLyNhanVienToolStripMenuItem_Click);
            // 
            // quanLyHangHoaToolStripMenuItem
            // 
            this.quanLyHangHoaToolStripMenuItem.Name = "quanLyHangHoaToolStripMenuItem";
            this.quanLyHangHoaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quanLyHangHoaToolStripMenuItem.Text = "quan ly san pham";
            this.quanLyHangHoaToolStripMenuItem.Click += new System.EventHandler(this.quanLyHangHoaToolStripMenuItem_Click);
            // 
            // suaTaiKhoanToolStripMenuItem
            // 
            this.suaTaiKhoanToolStripMenuItem.Name = "suaTaiKhoanToolStripMenuItem";
            this.suaTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.suaTaiKhoanToolStripMenuItem.Text = "Sua tai khoan";
            this.suaTaiKhoanToolStripMenuItem.Click += new System.EventHandler(this.suaTaiKhoanToolStripMenuItem_Click);
            // 
            // thoatChuongTrinhToolStripMenuItem
            // 
            this.thoatChuongTrinhToolStripMenuItem.Name = "thoatChuongTrinhToolStripMenuItem";
            this.thoatChuongTrinhToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.thoatChuongTrinhToolStripMenuItem.Text = "Thoat chuong trinh";
            this.thoatChuongTrinhToolStripMenuItem.Click += new System.EventHandler(this.thoatChuongTrinhToolStripMenuItem_Click);
            // 
            // quanLuKhachHangToolStripMenuItem
            // 
            this.quanLuKhachHangToolStripMenuItem.Name = "quanLuKhachHangToolStripMenuItem";
            this.quanLuKhachHangToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quanLuKhachHangToolStripMenuItem.Text = "quan ly khach hang";
            this.quanLuKhachHangToolStripMenuItem.Click += new System.EventHandler(this.quanLuKhachHangToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(448, 314);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem QuanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyBanHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyNhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyHangHoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suaTaiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatChuongTrinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLuKhachHangToolStripMenuItem;
    }
}