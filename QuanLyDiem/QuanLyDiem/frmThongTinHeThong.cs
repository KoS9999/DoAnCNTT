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
    public partial class frmThongTinHeThong : Form
    {
        public frmThongTinHeThong()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        QLDiemDataContext dt = new QLDiemDataContext();
        private void frmThongTinHeThong_Load(object sender, EventArgs e)
        {
            txtTinhThanh.DataBindings.Clear();
            txtTinhThanh.DataBindings.Add("Text", dt.ThongTin_SelectAll(), "Tinh");
            txtDonViChuQuan.DataBindings.Clear();
            txtDonViChuQuan.DataBindings.Add("Text", dt.ThongTin_SelectAll(), "DonViChuQuan");
            txtTenTruong.DataBindings.Clear();
            txtTenTruong.DataBindings.Add("Text", dt.ThongTin_SelectAll(), "TenTruong");
            txtKhoaHoc.DataBindings.Clear();
            txtKhoaHoc.DataBindings.Add("Text", dt.ThongTin_SelectAll(), "KhoaHoc");
            txtNganhHoc.DataBindings.Clear();
            txtNganhHoc.DataBindings.Add("Text", dt.ThongTin_SelectAll(), "NganhHoc");
            txtChuyenNganh.DataBindings.Clear();
            txtChuyenNganh.DataBindings.Add("Text", dt.ThongTin_SelectAll(), "ChuyenNganh");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dt.ThongTin_Update(txtTinhThanh.Text, txtDonViChuQuan.Text, txtTenTruong.Text, txtKhoaHoc.Text, txtNganhHoc.Text, txtChuyenNganh.Text);
            frmThongTinHeThong_Load(sender, e);
        }
    }
}
