namespace QuanLyDiem
{
    partial class frmLopSV
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgSinhVien = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanToc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveSV = new System.Windows.Forms.Button();
            this.btnDeleteSV = new System.Windows.Forms.Button();
            this.btnAddSV = new System.Windows.Forms.Button();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimeNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDanToc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveLop = new System.Windows.Forms.Button();
            this.btnDeleteLop = new System.Windows.Forms.Button();
            this.btnAddLop = new System.Windows.Forms.Button();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 554);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgSinhVien);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSaveSV);
            this.groupBox1.Controls.Add(this.btnDeleteSV);
            this.groupBox1.Controls.Add(this.btnAddSV);
            this.groupBox1.Controls.Add(this.txtTenLop);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateTimeNgaySinh);
            this.groupBox1.Controls.Add(this.txtNoiSinh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDanToc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtGioiTinh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTenSV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSaveLop);
            this.groupBox1.Controls.Add(this.btnDeleteLop);
            this.groupBox1.Controls.Add(this.btnAddLop);
            this.groupBox1.Controls.Add(this.txtMaLop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboLop);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(29, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1197, 551);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dtgSinhVien
            // 
            this.dtgSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.HoTen,
            this.NgaySinh,
            this.GioiTinh,
            this.NoiSinh,
            this.DanToc,
            this.MaLop});
            this.dtgSinhVien.Location = new System.Drawing.Point(6, 267);
            this.dtgSinhVien.Name = "dtgSinhVien";
            this.dtgSinhVien.RowHeadersWidth = 51;
            this.dtgSinhVien.RowTemplate.Height = 24;
            this.dtgSinhVien.Size = new System.Drawing.Size(1166, 275);
            this.dtgSinhVien.TabIndex = 30;
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã Sinh Viên";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            this.MaSV.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ và tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 310;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 125;
            // 
            // NoiSinh
            // 
            this.NoiSinh.DataPropertyName = "NoiSinh";
            this.NoiSinh.HeaderText = "Nơi sinh";
            this.NoiSinh.MinimumWidth = 6;
            this.NoiSinh.Name = "NoiSinh";
            this.NoiSinh.Width = 125;
            // 
            // DanToc
            // 
            this.DanToc.DataPropertyName = "DanToc";
            this.DanToc.HeaderText = "Dân tộc";
            this.DanToc.MinimumWidth = 6;
            this.DanToc.Name = "DanToc";
            this.DanToc.Width = 125;
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã Lớp";
            this.MaLop.MinimumWidth = 6;
            this.MaLop.Name = "MaLop";
            this.MaLop.Width = 125;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(405, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(436, 25);
            this.label11.TabIndex = 29;
            this.label11.Text = "CẬP NHẬT THÔNG TIN LỚP VÀ SINH VIÊN";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(580, 200);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(528, 28);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(393, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Tìm kiếm sinh viên:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(986, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Dân tộc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Danh sách lớp:";
            // 
            // btnSaveSV
            // 
            this.btnSaveSV.Location = new System.Drawing.Point(171, 194);
            this.btnSaveSV.Name = "btnSaveSV";
            this.btnSaveSV.Size = new System.Drawing.Size(83, 38);
            this.btnSaveSV.TabIndex = 14;
            this.btnSaveSV.Text = "Lưu";
            this.btnSaveSV.UseVisualStyleBackColor = true;
            this.btnSaveSV.Click += new System.EventHandler(this.btnSaveSV_Click);
            // 
            // btnDeleteSV
            // 
            this.btnDeleteSV.Location = new System.Drawing.Point(260, 194);
            this.btnDeleteSV.Name = "btnDeleteSV";
            this.btnDeleteSV.Size = new System.Drawing.Size(83, 38);
            this.btnDeleteSV.TabIndex = 15;
            this.btnDeleteSV.Text = "Xóa";
            this.btnDeleteSV.UseVisualStyleBackColor = true;
            this.btnDeleteSV.Click += new System.EventHandler(this.btnDeleteSV_Click);
            // 
            // btnAddSV
            // 
            this.btnAddSV.Location = new System.Drawing.Point(82, 194);
            this.btnAddSV.Name = "btnAddSV";
            this.btnAddSV.Size = new System.Drawing.Size(83, 38);
            this.btnAddSV.TabIndex = 13;
            this.btnAddSV.Text = "Thêm";
            this.btnAddSV.UseVisualStyleBackColor = true;
            this.btnAddSV.Click += new System.EventHandler(this.btnAddSV_Click);
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(547, 83);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(293, 28);
            this.txtTenLop.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(543, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tên Lớp:";
            // 
            // dateTimeNgaySinh
            // 
            this.dateTimeNgaySinh.Location = new System.Drawing.Point(397, 157);
            this.dateTimeNgaySinh.Name = "dateTimeNgaySinh";
            this.dateTimeNgaySinh.Size = new System.Drawing.Size(339, 28);
            this.dateTimeNgaySinh.TabIndex = 9;
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Location = new System.Drawing.Point(852, 157);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(132, 28);
            this.txtNoiSinh.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(848, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nơi sinh:";
            // 
            // txtDanToc
            // 
            this.txtDanToc.Location = new System.Drawing.Point(990, 157);
            this.txtDanToc.Name = "txtDanToc";
            this.txtDanToc.Size = new System.Drawing.Size(118, 28);
            this.txtDanToc.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ngày sinh:";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(742, 157);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(104, 28);
            this.txtGioiTinh.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(738, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Giới tính:";
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(213, 157);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(178, 28);
            this.txtTenSV.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Họ và tên:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(82, 157);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(125, 28);
            this.txtMaSV.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã sinh viên:";
            // 
            // btnSaveLop
            // 
            this.btnSaveLop.Location = new System.Drawing.Point(936, 73);
            this.btnSaveLop.Name = "btnSaveLop";
            this.btnSaveLop.Size = new System.Drawing.Size(83, 38);
            this.btnSaveLop.TabIndex = 5;
            this.btnSaveLop.Text = "Lưu";
            this.btnSaveLop.UseVisualStyleBackColor = true;
            this.btnSaveLop.Click += new System.EventHandler(this.btnSaveLop_Click);
            // 
            // btnDeleteLop
            // 
            this.btnDeleteLop.Location = new System.Drawing.Point(1025, 73);
            this.btnDeleteLop.Name = "btnDeleteLop";
            this.btnDeleteLop.Size = new System.Drawing.Size(83, 38);
            this.btnDeleteLop.TabIndex = 6;
            this.btnDeleteLop.Text = "Xóa";
            this.btnDeleteLop.UseVisualStyleBackColor = true;
            this.btnDeleteLop.Click += new System.EventHandler(this.btnDeleteLop_Click);
            // 
            // btnAddLop
            // 
            this.btnAddLop.Location = new System.Drawing.Point(847, 73);
            this.btnAddLop.Name = "btnAddLop";
            this.btnAddLop.Size = new System.Drawing.Size(83, 38);
            this.btnAddLop.TabIndex = 4;
            this.btnAddLop.Text = "Thêm";
            this.btnAddLop.UseVisualStyleBackColor = true;
            this.btnAddLop.Click += new System.EventHandler(this.btnAddLop_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(367, 83);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(174, 28);
            this.txtMaLop.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã lớp:";
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(86, 83);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(257, 28);
            this.cboLop.TabIndex = 1;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // frmLopSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 551);
            this.Controls.Add(this.panel1);
            this.Name = "frmLopSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin lớp, sinh viên";
            this.Load += new System.EventHandler(this.frmLopSV_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveSV;
        private System.Windows.Forms.Button btnDeleteSV;
        private System.Windows.Forms.Button btnAddSV;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimeNgaySinh;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDanToc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveLop;
        private System.Windows.Forms.Button btnDeleteLop;
        private System.Windows.Forms.Button btnAddLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dtgSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanToc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
    }
}