using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        QLDiemDataContext dt = new QLDiemDataContext();
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmNewPassword = txtConfirmNewPassword.Text;

            // Kiểm tra xác nhận mật khẩu mới
            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu mới không trùng khớp.");
                return;
            }

            // Kiểm tra tài khoản và mật khẩu hiện tại
            if (CheckCurrentPassword(userName, currentPassword))
            {
                // Thực hiện cập nhật mật khẩu
                if (UpdatePassword(userName, newPassword))
                {
                    MessageBox.Show("Đổi mật khẩu thành công.");
                    this.Close(); // Đóng form đổi mật khẩu
                }
                else
                {
                    MessageBox.Show("Lỗi khi cập nhật mật khẩu.");
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu hiện tại không đúng.");
            }
        }

        private bool CheckCurrentPassword(string userName, string currentPassword)
        {
            var user = dt.DangNhaps.SingleOrDefault(u => u.UserName == userName && u.PassWord == currentPassword);
            return user != null;
        }

        private bool UpdatePassword(string userName, string newPassword)
        {
            try
            {
                // Sử dụng đối tượng context đã có
                using (QLDiemDataContext dt = new QLDiemDataContext())
                {
                    // Gọi stored procedure DangNhap_Update để cập nhật mật khẩu mới
                    dt.DangNhap_Update(userName, newPassword);
                }

                return true;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần
                MessageBox.Show("Lỗi khi cập nhật mật khẩu: " + ex.Message);
                return false;
            }
        }
    }
}
