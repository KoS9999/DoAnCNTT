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
        public partial class frmDangNhap : Form
        {
            public frmDangNhap()
            {
                InitializeComponent();
                txtMatKhau.PasswordChar = '*';
            }

            QLDiemDataContext dt = new QLDiemDataContext();
            private void btnDangNhap_Click(object sender, EventArgs e)
            {
                var userName = txtTaiKhoan.Text; 
                var passWord = txtMatKhau.Text; 

                var user = dt.DangNhap_Login(userName, passWord).SingleOrDefault();

                if (user != null)
                {
                    this.Hide();
                    frmMain frm = new frmMain();    
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu sai.");
                }
            }
            private void btnExit_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }
        }
    }
