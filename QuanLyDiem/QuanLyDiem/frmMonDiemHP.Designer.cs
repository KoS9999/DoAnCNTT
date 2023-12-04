namespace QuanLyDiem
{
    partial class frmMonDiemHP
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
            this.dtgDiem = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCapNhatDuLieu = new System.Windows.Forms.Button();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeleteMonHP = new System.Windows.Forms.Button();
            this.btnSaveMonHP = new System.Windows.Forms.Button();
            this.btnAddMonHP = new System.Windows.Forms.Button();
            this.btnDeleteHK = new System.Windows.Forms.Button();
            this.btnSaveHK = new System.Windows.Forms.Button();
            this.btnAddHK = new System.Windows.Forms.Button();
            this.txtMaHK = new System.Windows.Forms.TextBox();
            this.txtTenHK = new System.Windows.Forms.TextBox();
            this.cboMon = new System.Windows.Forms.ComboBox();
            this.cboHocKy = new System.Windows.Forms.ComboBox();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemQuaTrinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.dtgDiem);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 570);
            this.panel1.TabIndex = 0;
            // 
            // dtgDiem
            // 
            this.dtgDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.HoTen,
            this.NgaySinh,
            this.DiemQuaTrinh,
            this.DiemThi});
            this.dtgDiem.Location = new System.Drawing.Point(54, 290);
            this.dtgDiem.Name = "dtgDiem";
            this.dtgDiem.RowHeadersWidth = 51;
            this.dtgDiem.RowTemplate.Height = 24;
            this.dtgDiem.Size = new System.Drawing.Size(1175, 277);
            this.dtgDiem.TabIndex = 1;
            this.dtgDiem.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDiem_CellEndEdit);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCapNhatDuLieu);
            this.groupBox1.Controls.Add(this.txtTenMon);
            this.groupBox1.Controls.Add(this.txtSoTinChi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnDeleteMonHP);
            this.groupBox1.Controls.Add(this.btnSaveMonHP);
            this.groupBox1.Controls.Add(this.btnAddMonHP);
            this.groupBox1.Controls.Add(this.btnDeleteHK);
            this.groupBox1.Controls.Add(this.btnSaveHK);
            this.groupBox1.Controls.Add(this.btnAddHK);
            this.groupBox1.Controls.Add(this.txtMaHK);
            this.groupBox1.Controls.Add(this.txtTenHK);
            this.groupBox1.Controls.Add(this.cboMon);
            this.groupBox1.Controls.Add(this.cboHocKy);
            this.groupBox1.Controls.Add(this.txtMaMon);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboLop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(54, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1175, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnCapNhatDuLieu
            // 
            this.btnCapNhatDuLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhatDuLieu.Location = new System.Drawing.Point(6, 215);
            this.btnCapNhatDuLieu.Name = "btnCapNhatDuLieu";
            this.btnCapNhatDuLieu.Size = new System.Drawing.Size(190, 38);
            this.btnCapNhatDuLieu.TabIndex = 1;
            this.btnCapNhatDuLieu.Text = "Cập nhật dữ liệu";
            this.btnCapNhatDuLieu.UseVisualStyleBackColor = true;
            this.btnCapNhatDuLieu.Click += new System.EventHandler(this.btnCapNhatDuLieu_Click);
            // 
            // txtTenMon
            // 
            this.txtTenMon.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenMon.Location = new System.Drawing.Point(317, 162);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(377, 28);
            this.txtTenMon.TabIndex = 11;
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoTinChi.Location = new System.Drawing.Point(700, 162);
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.Size = new System.Drawing.Size(144, 28);
            this.txtSoTinChi.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(696, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Số tín chỉ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(319, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Tên môn:";
            // 
            // btnDeleteMonHP
            // 
            this.btnDeleteMonHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteMonHP.Location = new System.Drawing.Point(1072, 152);
            this.btnDeleteMonHP.Name = "btnDeleteMonHP";
            this.btnDeleteMonHP.Size = new System.Drawing.Size(83, 38);
            this.btnDeleteMonHP.TabIndex = 15;
            this.btnDeleteMonHP.Text = "Xóa";
            this.btnDeleteMonHP.UseVisualStyleBackColor = true;
            this.btnDeleteMonHP.Click += new System.EventHandler(this.btnDeleteMonHP_Click);
            // 
            // btnSaveMonHP
            // 
            this.btnSaveMonHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSaveMonHP.Location = new System.Drawing.Point(974, 152);
            this.btnSaveMonHP.Name = "btnSaveMonHP";
            this.btnSaveMonHP.Size = new System.Drawing.Size(83, 38);
            this.btnSaveMonHP.TabIndex = 14;
            this.btnSaveMonHP.Text = "Lưu";
            this.btnSaveMonHP.UseVisualStyleBackColor = true;
            this.btnSaveMonHP.Click += new System.EventHandler(this.btnSaveMonHP_Click);
            // 
            // btnAddMonHP
            // 
            this.btnAddMonHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddMonHP.Location = new System.Drawing.Point(876, 152);
            this.btnAddMonHP.Name = "btnAddMonHP";
            this.btnAddMonHP.Size = new System.Drawing.Size(83, 38);
            this.btnAddMonHP.TabIndex = 13;
            this.btnAddMonHP.Text = "Thêm";
            this.btnAddMonHP.UseVisualStyleBackColor = true;
            this.btnAddMonHP.Click += new System.EventHandler(this.btnAddMonHP_Click);
            // 
            // btnDeleteHK
            // 
            this.btnDeleteHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteHK.Location = new System.Drawing.Point(1072, 76);
            this.btnDeleteHK.Name = "btnDeleteHK";
            this.btnDeleteHK.Size = new System.Drawing.Size(83, 38);
            this.btnDeleteHK.TabIndex = 8;
            this.btnDeleteHK.Text = "Xóa";
            this.btnDeleteHK.UseVisualStyleBackColor = true;
            this.btnDeleteHK.Click += new System.EventHandler(this.btnDeleteHK_Click);
            // 
            // btnSaveHK
            // 
            this.btnSaveHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSaveHK.Location = new System.Drawing.Point(974, 76);
            this.btnSaveHK.Name = "btnSaveHK";
            this.btnSaveHK.Size = new System.Drawing.Size(83, 38);
            this.btnSaveHK.TabIndex = 7;
            this.btnSaveHK.Text = "Lưu";
            this.btnSaveHK.UseVisualStyleBackColor = true;
            this.btnSaveHK.Click += new System.EventHandler(this.btnSaveHK_Click);
            // 
            // btnAddHK
            // 
            this.btnAddHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddHK.Location = new System.Drawing.Point(876, 76);
            this.btnAddHK.Name = "btnAddHK";
            this.btnAddHK.Size = new System.Drawing.Size(83, 38);
            this.btnAddHK.TabIndex = 6;
            this.btnAddHK.Text = "Thêm";
            this.btnAddHK.UseVisualStyleBackColor = true;
            this.btnAddHK.Click += new System.EventHandler(this.btnAddHK_Click);
            // 
            // txtMaHK
            // 
            this.txtMaHK.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaHK.Location = new System.Drawing.Point(380, 86);
            this.txtMaHK.Name = "txtMaHK";
            this.txtMaHK.Size = new System.Drawing.Size(141, 28);
            this.txtMaHK.TabIndex = 4;
            // 
            // txtTenHK
            // 
            this.txtTenHK.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenHK.Location = new System.Drawing.Point(537, 86);
            this.txtTenHK.Name = "txtTenHK";
            this.txtTenHK.Size = new System.Drawing.Size(307, 28);
            this.txtTenHK.TabIndex = 5;
            // 
            // cboMon
            // 
            this.cboMon.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboMon.FormattingEnabled = true;
            this.cboMon.Location = new System.Drawing.Point(6, 162);
            this.cboMon.Name = "cboMon";
            this.cboMon.Size = new System.Drawing.Size(121, 28);
            this.cboMon.TabIndex = 9;
            this.cboMon.SelectedIndexChanged += new System.EventHandler(this.cboMon_SelectedIndexChanged);
            // 
            // cboHocKy
            // 
            this.cboHocKy.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboHocKy.FormattingEnabled = true;
            this.cboHocKy.Location = new System.Drawing.Point(150, 86);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(208, 28);
            this.cboHocKy.TabIndex = 3;
            this.cboHocKy.SelectedIndexChanged += new System.EventHandler(this.cboHocKy_SelectedIndexChanged);
            // 
            // txtMaMon
            // 
            this.txtMaMon.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaMon.Location = new System.Drawing.Point(150, 162);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(157, 28);
            this.txtMaMon.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(6, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Môn học phần:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(146, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Học kì:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(146, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã môn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(533, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên học kì:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(376, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã học kì:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lớp:";
            // 
            // cboLop
            // 
            this.cboLop.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(6, 86);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(121, 28);
            this.cboLop.TabIndex = 2;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(312, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT HỌC KÌ, MÔN HỌC PHẦN, ĐIỂM HỌC PHẦN";
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã sinh viên";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            this.MaSV.Width = 220;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 350;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 250;
            // 
            // DiemQuaTrinh
            // 
            this.DiemQuaTrinh.DataPropertyName = "DiemQuaTrinh";
            this.DiemQuaTrinh.HeaderText = "Điểm quá trình";
            this.DiemQuaTrinh.MinimumWidth = 6;
            this.DiemQuaTrinh.Name = "DiemQuaTrinh";
            this.DiemQuaTrinh.Width = 150;
            // 
            // DiemThi
            // 
            this.DiemThi.DataPropertyName = "DiemThi";
            this.DiemThi.HeaderText = "Điểm thi";
            this.DiemThi.MinimumWidth = 6;
            this.DiemThi.Name = "DiemThi";
            this.DiemThi.Width = 150;
            // 
            // frmMonDiemHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 590);
            this.Controls.Add(this.panel1);
            this.Name = "frmMonDiemHP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật điểm, môn, học kì";
            this.Load += new System.EventHandler(this.frmMonDiemHP_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.TextBox txtSoTinChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDeleteMonHP;
        private System.Windows.Forms.Button btnSaveMonHP;
        private System.Windows.Forms.Button btnAddMonHP;
        private System.Windows.Forms.Button btnDeleteHK;
        private System.Windows.Forms.Button btnSaveHK;
        private System.Windows.Forms.Button btnAddHK;
        private System.Windows.Forms.TextBox txtMaHK;
        private System.Windows.Forms.TextBox txtTenHK;
        private System.Windows.Forms.ComboBox cboMon;
        private System.Windows.Forms.ComboBox cboHocKy;
        private System.Windows.Forms.DataGridView dtgDiem;
        private System.Windows.Forms.Button btnCapNhatDuLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemQuaTrinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThi;
    }
}