namespace QuanLyDiem
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xửLýDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLopSV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMonDiemHP = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDiemChiTiet = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 498);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.btnDoiMatKhau,
            this.xửLýDữLiệuToolStripMenuItem,
            this.btnDiemChiTiet,
            this.btnExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1027, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            this.hệThốngToolStripMenuItem.Click += new System.EventHandler(this.hệThốngToolStripMenuItem_Click);
            // 
            // xửLýDữLiệuToolStripMenuItem
            // 
            this.xửLýDữLiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLopSV,
            this.btnMonDiemHP});
            this.xửLýDữLiệuToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xửLýDữLiệuToolStripMenuItem.Name = "xửLýDữLiệuToolStripMenuItem";
            this.xửLýDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.xửLýDữLiệuToolStripMenuItem.Text = "Xử lý dữ liệu";
            // 
            // btnLopSV
            // 
            this.btnLopSV.Name = "btnLopSV";
            this.btnLopSV.Size = new System.Drawing.Size(385, 26);
            this.btnLopSV.Text = "Xử lý dữ liệu lớp, sinh viên";
            this.btnLopSV.Click += new System.EventHandler(this.btnLopSV_Click);
            // 
            // btnMonDiemHP
            // 
            this.btnMonDiemHP.Name = "btnMonDiemHP";
            this.btnMonDiemHP.Size = new System.Drawing.Size(385, 26);
            this.btnMonDiemHP.Text = "Xử lý dữ liệu môn, điểm học phần";
            this.btnMonDiemHP.Click += new System.EventHandler(this.btnMonDiemHP_Click);
            // 
            // btnDiemChiTiet
            // 
            this.btnDiemChiTiet.Name = "btnDiemChiTiet";
            this.btnDiemChiTiet.Size = new System.Drawing.Size(182, 24);
            this.btnDiemChiTiet.Text = "Bảng điểm chi tiết";
            this.btnDiemChiTiet.Click += new System.EventHandler(this.btnDiemChiTiet_Click);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 26);
            this.btnExit.Text = "Đăng xuất";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyDiem.Properties.Resources.Screenshot_2023_11_26_202708;
            this.pictureBox1.Location = new System.Drawing.Point(3, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1024, 467);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(139, 24);
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 501);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý điểm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xửLýDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnLopSV;
        private System.Windows.Forms.ToolStripMenuItem btnMonDiemHP;
        private System.Windows.Forms.ToolStripMenuItem btnDiemChiTiet;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem btnDoiMatKhau;
    }
}

