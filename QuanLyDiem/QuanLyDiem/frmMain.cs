using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLopSV_Click(object sender, EventArgs e)
        {
            frmLopSV frm = new frmLopSV();  
            frm.ShowDialog();   
        }

        private void btnMonDiemHP_Click(object sender, EventArgs e)
        {
            frmMonDiemHP frm = new frmMonDiemHP();
            frm.ShowDialog();   
        }

        private void btnXLThongTinHeThong_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDiemChiTiet_Click(object sender, EventArgs e)
        {
            frmBangDiemChiTiet frm = new frmBangDiemChiTiet();
            frm.ShowDialog();   
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.ShowDialog();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinHeThong frm = new frmThongTinHeThong();
            frm.ShowDialog();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
        }
    }
}
