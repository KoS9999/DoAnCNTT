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
    public partial class frmLopSV : Form
    {
        public frmLopSV()
        {
            InitializeComponent();
        }
        QLDiemDataContext dt = new QLDiemDataContext();
        private void frmLopSV_Load(object sender, EventArgs e)
        {
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
            cboLop.DataSource = dt.LopHoc_SelectAll();
            txtMaLop.DataBindings.Clear();
            txtMaLop.DataBindings.Add("Text", cboLop.DataSource, "MaLop");
            txtTenLop.DataBindings.Clear();
            txtTenLop.DataBindings.Add("Text", cboLop.DataSource, "TenLop");
        }
        Boolean adLop = false;
        private void btnAddLop_Click(object sender, EventArgs e)
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtMaLop.Enabled = true;
            txtMaLop.Focus();
            adLop = true;
        }

        private void btnSaveLop_Click(object sender, EventArgs e)
        {
            if (adLop)
            {
                try
                {
                    dt.LopHoc_Insert(txtMaLop.Text, txtTenLop.Text);
                }
                catch
                {
                    MessageBox.Show("Thêm thất bại, kiểm tra lại dữ liệu nhập vào", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
                txtMaLop.Enabled = false; 
                adLop = false;
                frmLopSV_Load(sender, e);
            }
            else
            {
                try
                {
                    dt.LopHoc_Update(txtMaLop.Text, txtTenLop.Text);
                }
                catch
                {
                    MessageBox.Show("Cập nhật thất bại, kiểm tra lại dữ liệu nhập vào", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                frmLopSV_Load(sender, e);
            }
        }

        private void btnDeleteLop_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp " + txtTenLop.Text + "? Dữ liệu lớp này sẽ bị mất.", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                dt.LopHoc_Delete(cboLop.SelectedValue.ToString());
            }
            frmLopSV_Load(sender, e);
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Đảm bảo rằng một mục đã được chọn trong ComboBox
            if (cboLop.SelectedIndex != -1)
            {
                var MaLop = cboLop.SelectedValue.ToString();
                dtgSinhVien.DataSource = dt.SinhVien_SelectMaLop(MaLop);

                // Cập nhật DataBindings
                BindDataToControls();
                // Đảm bảo rằng txtGioiTinh không được tự động cập nhật từ nguồn dữ liệu
                txtGioiTinh.DataBindings.Clear();
                dateTimeNgaySinh.DataBindings.Clear();
            }
        }

        private void BindDataToControls()
        {
            // Ràng buộc dữ liệu cho TextBox mã sinh viên
            txtMaSV.DataBindings.Clear();
            txtMaSV.DataBindings.Add("Text", dtgSinhVien.DataSource, "MaSV");

            // Ràng buộc dữ liệu cho TextBox họ tên sinh viên
            txtTenSV.DataBindings.Clear();
            txtTenSV.DataBindings.Add("Text", dtgSinhVien.DataSource, "HoTen");

            // Ràng buộc dữ liệu cho DateTimePicker ngày sinh sinh viên
            dateTimeNgaySinh.DataBindings.Clear();
            dateTimeNgaySinh.DataBindings.Add("Value", dtgSinhVien.DataSource, "NgaySinh");

            // Ràng buộc dữ liệu cho TextBox giới tính
            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", dtgSinhVien.DataSource, "GioiTinh");

            // Ràng buộc dữ liệu cho TextBox nơi sinh
            txtNoiSinh.DataBindings.Clear();
            txtNoiSinh.DataBindings.Add("Text", dtgSinhVien.DataSource, "NoiSinh");

            // Ràng buộc dữ liệu cho TextBox dân tộc
            txtDanToc.DataBindings.Clear();
            txtDanToc.DataBindings.Add("Text", dtgSinhVien.DataSource, "DanToc");
        }
        Boolean adSV = false;
        private void btnAddSV_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = "";
            txtTenSV.Text = "";
            txtGioiTinh.Text = "";
            txtDanToc.Text = "";
            txtNoiSinh.Text = "";
            dateTimeNgaySinh.Text = "";
            txtMaSV.Enabled = true;    
            txtMaSV.Focus(); 
            adSV = true;
        }

        private void btnSaveSV_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtGioiTinh.Text, out int genderValue) || !(genderValue == 0 || genderValue == 1))
            {
                ShowGenderErrorMessage();
                return; // Thoát khỏi phương thức nếu giá trị giới tính không hợp lệ
            }

            if (adSV)
            {
                if (ValidateInput() && IsGenderValid())
                {
                    dt.SinhVien_Insert(txtMaSV.Text, txtTenSV.Text, dateTimeNgaySinh.Value, genderValue, txtDanToc.Text, txtNoiSinh.Text, txtMaLop.Text);
                    adSV = false;
                }
                else
                {
                    ShowGenderErrorMessage();
                    return; // Thoát khỏi phương thức nếu dữ liệu không hợp lệ
                }
            }
            else
            {
                if (ValidateInput() && IsGenderValid())
                {
                    dt.SinhVien_Update(txtMaSV.Text, txtTenSV.Text, dateTimeNgaySinh.Value, genderValue, txtDanToc.Text, txtNoiSinh.Text);
                }
                else
                {
                    ShowGenderErrorMessage();
                    return; // Thoát khỏi phương thức nếu dữ liệu không hợp lệ
                }
            }
            // tải lại dữ liệu 
            cboLop_SelectedIndexChanged(sender, e);
        }

        private void ShowGenderErrorMessage()
        {
            if (!IsGenderValid())
            {
                MessageBox.Show("Vui lòng nhập '0' là Nữ và '1' là Nam cho giới tính.", "Thông tin không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông tin không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool IsGenderValid()
        {
            bool parsed = int.TryParse(txtGioiTinh.Text, out int genderValue);
            return parsed && (genderValue == 0 || genderValue == 1);    
        }

        private bool ValidateInput()
        {
            // Kiểm tra xem các trường dữ liệu có trống không
            bool isDataNotEmpty = !string.IsNullOrEmpty(txtMaSV.Text) &&
                                  !string.IsNullOrEmpty(txtTenSV.Text) &&
                                  !string.IsNullOrEmpty(txtGioiTinh.Text) &&
                                  !string.IsNullOrEmpty(txtDanToc.Text) &&
                                  !string.IsNullOrEmpty(txtNoiSinh.Text) &&
                                  dateTimeNgaySinh.Value != null;

            // Kiểm tra xem giới tính có phải là 0 hoặc 1 không
            bool isGenderValid = int.TryParse(txtGioiTinh.Text, out int genderValue) &&
                                 (genderValue == 0 || genderValue == 1);

            return isDataNotEmpty && isGenderValid;
        }


        private void btnDeleteSV_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên " + txtMaSV.Text + "? Dữ liệu sinh viên này sẽ bị mất.", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                dt.SinhVien_Delete(txtMaSV.Text);
            } 
            cboLop_SelectedIndexChanged(sender, e );
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtgSinhVien.DataSource = dt.SinhVien_Search(txtSearch.Text, txtMaLop.Text);
            txtMaSV.DataBindings.Clear();
            txtMaSV.DataBindings.Add("Text", dtgSinhVien.DataSource, "MaSV");
            txtTenSV.DataBindings.Clear();
            txtTenSV.DataBindings.Add("Text", dtgSinhVien.DataSource, "HoTen");
            dateTimeNgaySinh.DataBindings.Clear();
            dateTimeNgaySinh.DataBindings.Add("Value", dtgSinhVien.DataSource, "NgaySinh");
            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", dtgSinhVien.DataSource, "GioiTinh");
            txtNoiSinh.DataBindings.Clear();
            txtNoiSinh.DataBindings.Add("Text", dtgSinhVien.DataSource, "NoiSinh");
            txtDanToc.DataBindings.Clear();
            txtDanToc.DataBindings.Add("Text", dtgSinhVien.DataSource, "DanToc");
        }
    }
}
