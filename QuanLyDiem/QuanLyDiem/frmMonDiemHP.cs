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
    public partial class frmMonDiemHP : Form
    {
        public frmMonDiemHP()
        {
            InitializeComponent();
        }
        QLDiemDataContext dt = new QLDiemDataContext();
        private void frmMonDiemHP_Load(object sender, EventArgs e)
        {
            cboLop.DataSource = dt.LopHoc_SelectAll();
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
            cboHocKy.DataSource = dt.HocKy_SelectAll();
            cboHocKy.DisplayMember = "TenHK";
            cboHocKy.ValueMember = "MaHK";
            txtMaHK.DataBindings.Clear();
            txtMaHK.DataBindings.Add("Text", cboHocKy.DataSource, "MaHK");
            txtTenHK.DataBindings.Clear();
            txtTenHK.DataBindings.Add("Text", cboHocKy.DataSource, "TenHK");
            txtMaHK.Enabled = false;
            cboMon.ValueMember = "MaMon";
            cboMon.DisplayMember = "TenMon";
            cboMon.DataSource = dt.MonHoc_SelectMaHK(cboHocKy.SelectedValue.ToString());
            txtMaMon.DataBindings.Clear();
            txtMaMon.DataBindings.Add("Text", cboMon.DataSource, "MaMon");
            txtTenMon.DataBindings.Clear();
            txtTenMon.DataBindings.Add("Text", cboMon.DataSource, "TenMon");
            txtSoTinChi.DataBindings.Clear();
            txtSoTinChi.DataBindings.Add("Text", cboMon.DataSource, "SoTinChi");
            txtMaMon.Enabled = false;
        }
        Boolean adHK = false;
        private void btnAddHK_Click(object sender, EventArgs e)
        {
            txtMaHK.Text = "";
            txtTenHK.Text = "";
            txtMaHK.Enabled = true;
            txtMaHK.Focus();
            adHK = true;
        }

        private void btnSaveHK_Click(object sender, EventArgs e)
        {
            if (adHK)
            {
                try
                {
                    dt.HocKy_Insert(txtMaHK.Text, txtTenHK.Text);
                }
                catch
                {
                    MessageBox.Show("Thêm thất bại, kiểm tra lại dữ liệu nhập vào", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                txtMaHK.Enabled= false;
                adHK = false;
                frmMonDiemHP_Load(sender, e);   
            }
            else
            {
                try
                {
                    dt.HocKy_Update(txtMaHK.Text, txtTenHK.Text);
                }
                catch
                {
                    MessageBox.Show("Cập nhật thất bại, kiểm tra lại dữ liệu nhập vào", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                frmMonDiemHP_Load(sender, e);
            }
        }

        private void btnDeleteHK_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa " + txtTenHK.Text + "? Dữ liệu môn của học kỳ này sẽ bị mất.", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                dt.HocKy_Delete(txtMaHK.Text);
            }
            frmMonDiemHP_Load(sender, e);
        }

        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMon.ValueMember = "MaMon";
            cboMon.DisplayMember = "TenMon";
            cboMon.DataSource = dt.MonHoc_SelectMaHK(cboHocKy.SelectedValue.ToString());
            txtMaMon.DataBindings.Clear();
            txtMaMon.DataBindings.Add("Text", cboMon.DataSource, "MaMon");
            txtTenMon.DataBindings.Clear();
            txtTenMon.DataBindings.Add("Text", cboMon.DataSource, "TenMon");
            txtSoTinChi.DataBindings.Clear();
            txtSoTinChi.DataBindings.Add("Text", cboMon.DataSource, "SoTinChi");
            txtMaMon.Enabled = false;
        }
        Boolean adMon = false;
        private void btnAddMonHP_Click(object sender, EventArgs e)
        {
            // Xóa binding
            txtSoTinChi.DataBindings.Clear();

            // Thiết lập các trường thông tin mới
            txtMaMon.Text = "";
            txtTenMon.Text = "";
            txtSoTinChi.Text = ""; // Đảm bảo rằng trường này không bị ảnh hưởng bởi binding cũ
            txtMaMon.Enabled = true;
            adMon = true;
        }

        private void btnSaveMonHP_Click(object sender, EventArgs e)
        {
            if (adMon)
            {
                try
                {
                    dt.MonHoc_Insert(txtMaMon.Text, txtTenMon.Text, Convert.ToInt32(txtSoTinChi.Text), txtMaHK.Text);
                }
                catch
                {
                    MessageBox.Show("Thêm thất bại, kiểm tra lại dữ liệu nhập vào", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                adMon = false;
                cboHocKy_SelectedIndexChanged(sender, e);
            }
            else
            {
                try
                {
                    dt.MonHoc_Update(txtMaMon.Text, txtTenMon.Text, Convert.ToInt32(txtSoTinChi.Text));
                }
                catch
                {
                    MessageBox.Show("Cập nhật thất bại, kiểm tra lại dữ liệu nhập vào", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cboHocKy_SelectedIndexChanged(sender, e);
            }
        }

        private void btnDeleteMonHP_Click(object sender, EventArgs e)
        {
            string maMon = txtMaMon.Text;

            // Hiển thị MessageBox cảnh báo
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa môn " + txtTenMon.Text + "? Dữ liệu điểm của môn sẽ bị mất.", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Thực hiện xóa môn học và dữ liệu điểm
                dt.MonHoc_Delete(maMon);
                cboHocKy_SelectedIndexChanged(sender, e);
            }
            else
            {
                // Người dùng đã hủy xóa
            }
        }

        private void btnCapNhatDuLieu_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var m in dt.MonHoc_SelectAll())
                {
                    foreach (var s in dt.SinhVien_SelectAll())
                    {
                        if (dt.DiemHP_Search(m.MaMon, s.MaSV).Count() == 0)
                        {
                            dt.DiemHP_Insert(m.MaMon, s.MaSV);
                        }
                    }
                }
                MessageBox.Show("Cập nhật dữ liệu điểm học phần thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Cập nhật dữ liệu thất bại, kiểm tra lại dữ liệu.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void cboMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Đảm bảo rằng một mục đã được chọn trong ComboBox
            if (cboMon.SelectedIndex != -1)
            {
                var MaMon = cboMon.SelectedValue.ToString();
                dtgDiem.DataSource = dt.BangDiemHP(cboLop.SelectedValue.ToString(), MaMon);
            }
        }
        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Đảm bảo rằng một mục đã được chọn trong ComboBox
            if (cboMon.SelectedIndex != -1)
            {
                var MaMon = cboMon.SelectedValue.ToString();
                dtgDiem.DataSource = dt.BangDiemHP(cboLop.SelectedValue.ToString(), MaMon);
            }
        }

        private void dtgDiem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dtgDiem.CurrentCell.RowIndex;
            string maSV = dtgDiem.Rows[rowIndex].Cells["MaSV"].Value.ToString();

            if (e.ColumnIndex == dtgDiem.Columns["DiemQuaTrinh"].Index)
            {
                if (dtgDiem.Rows[rowIndex].Cells["DiemQuaTrinh"].Value != null)
                {
                    string diemQuaTrinhStr = dtgDiem.Rows[rowIndex].Cells["DiemQuaTrinh"].Value.ToString();
                    if (double.TryParse(diemQuaTrinhStr, out double diemQuaTrinh))
                    {
                        if (diemQuaTrinh >= 0 && diemQuaTrinh <= 10)
                        {
                            dt.DiemHP_UpdateLan1(diemQuaTrinh, txtMaMon.Text, maSV);
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập điểm từ 0 đến 10 cho Điểm Quá Trình.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dtgDiem.Rows[rowIndex].Cells["DiemQuaTrinh"].Value = null;
                        }
                    }
                    else
                    {
                        // Hiển thị thông báo lỗi nếu giá trị không hợp lệ
                        MessageBox.Show("Giá trị nhập vào không hợp lệ cho Điểm Quá Trình.");

                    }
                }
            }
            else if (e.ColumnIndex == dtgDiem.Columns["DiemThi"].Index)
            {
                if (dtgDiem.Rows[rowIndex].Cells["DiemThi"].Value != null)
                {
                    string diemThiStr = dtgDiem.Rows[rowIndex].Cells["DiemThi"].Value.ToString();
                    if (double.TryParse(diemThiStr, out double diemThi))
                    {
                        if (diemThi >= 0 && diemThi <= 10)
                        {
                            dt.DiemHP_UpdateLan2(diemThi, txtMaMon.Text, maSV);
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập điểm từ 0 đến 10 cho Điểm Thi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dtgDiem.Rows[rowIndex].Cells["DiemThi"].Value = null;
                        }
                    }
                    else
                    {
                        // Hiển thị thông báo lỗi nếu giá trị không hợp lệ
                        MessageBox.Show("Giá trị nhập vào không hợp lệ cho Điểm Thi.");
                    }
                }
            }
        }
    }
}
