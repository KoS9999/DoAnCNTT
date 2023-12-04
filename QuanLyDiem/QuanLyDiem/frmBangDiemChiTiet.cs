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
    public partial class frmBangDiemChiTiet : Form
    {
        public frmBangDiemChiTiet()
        {
            InitializeComponent();
        }

        QLDiemDataContext dt = new QLDiemDataContext();
        XuLyDiem xl = new XuLyDiem();

        private void frmBangDiemChiTiet_Load(object sender, EventArgs e)
        {
            cboLop.ValueMember = "MaLop";
            cboLop.DisplayMember = "TenLop";
            cboLop.DataSource = dt.LopHoc_SelectAll();
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            treeViewSV.Nodes.Clear();
            foreach (var r in dt.SinhVien_SelectMaLop(cboLop.SelectedValue.ToString())) 
            {
                TreeNode node = new TreeNode();
                node.Name = r.MaSV;
                node.Text = r.HoTen;
                treeViewSV.Nodes.Add(node);
            }
            treeViewSV.ExpandAll(); 
        }

        private void treeViewSV_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            foreach(var r in dt.SinhVien_SelectID(e.Node.Name))
            {
                lblMaSV.Text = e.Node.Name;
                lblHoTen.Text = r.HoTen;
                DateTime? ngaySinhNullable = r.NgaySinh;
                string ngaySinhFormatted = ngaySinhNullable.HasValue ? ngaySinhNullable.Value.ToString("dd/MM/yyyy") : "";
                lblNgaySinh.Text = ngaySinhFormatted;
                //lblNgaySinh.Text = r.NgaySinh.Value.ToShortDateString();
                if (r.GioiTinh.ToString()=="1")
                {
                    lblGioiTinh.Text = "Nam";
                }
                else
                {
                    lblGioiTinh.Text = "Nữ";
                }
                lblDanToc.Text= r.DanToc.ToString();
                lblNoiSinh.Text= r.NoiSinh.ToString();
            }
            var table = new DataTable();
            DataColumnCollection col = table.Columns;
            if (!col.Contains ("MaMon"))
                table.Columns.Add("MaMon", typeof (String));
            if (!col.Contains("TenMon"))
                table.Columns.Add("TenMon", typeof(String));
            if (!col.Contains("SoTinChi"))
                table.Columns.Add("SoTinChi", typeof(String));
            if (!col.Contains("DiemHP"))
                table.Columns.Add("DiemHP", typeof(String));
            if (!col.Contains("DiemChu"))
                table.Columns.Add("DiemChu", typeof(String));
            if (!col.Contains("DiemSo"))
                table.Columns.Add("DiemSo", typeof(String));

            // khai báo biến
            Double tong = 0;
            int soTC = 0;
            foreach (var m in dt.MonHoc_SelectAll())
            {
                DataRow r = table.NewRow();
                r["MaMon"] = m.MaMon;
                r["TenMon"] = m.TenMon;
                r["SoTinChi"] = m.SoTinChi;
                soTC += Convert.ToInt32(m.SoTinChi);
                foreach (var d in dt.DiemHP_Search(m.MaMon, e.Node.Name))
                {
                    double diemTongKetRounded = Math.Round(Convert.ToDouble(d.DiemTongKet), 1);
                    r["DiemHP"] = diemTongKetRounded;
                    r["DiemChu"] = xl.DiemChu(Convert.ToDouble(d.DiemTongKet));
                    r["DiemSo"] = xl.DiemSo(Convert.ToDouble(d.DiemTongKet));
                    tong += xl.DiemSo(Convert.ToDouble(d.DiemTongKet)) * Convert.ToDouble(m.SoTinChi);
                }
                table.Rows.Add(r);
            }
            Double t = Math.Round(tong / soTC, 2);
            lblDiemTB.Text= t.ToString();
            lblXepLoai.Text= xl.XepLoai(t);
            dtgDiem.DataSource = table;
        }
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            // đổ dữ liệu vào sheet
            // Gọi stored procedure
            var thongTinResult = dt.ThongTin_SelectAll();
            var thongTinResult1 = dt.ThongTin_SelectAll();
            // Lấy giá trị từ cột 'DonViChuQuan'
            var donViChuQuan = thongTinResult.FirstOrDefault()?.DonViChuQuan ?? "";
            var tenTruong = thongTinResult1.FirstOrDefault()?.TenTruong ?? "";
            // Gán giá trị cho cell trong worksheet
            worksheet.Cells[1, 1] = donViChuQuan;
            worksheet.Cells[1, 4] = "Cộng hòa xã hội chủ nghĩa Việt Nam";
            worksheet.Cells[2, 1] = tenTruong;
            worksheet.Cells[2, 4] = "Độc lập - Tự do - Hạnh phúc";
            worksheet.Cells[4, 1] = "BẢNG TỔNG HỢP ĐIỂM CHI TIẾT CỦA SINH VIÊN";
            worksheet.Cells[6, 2] = "Mã sinh viên: " + lblMaSV.Text;
            worksheet.Cells[7, 2] = "Họ và tên: " + lblHoTen.Text;
            worksheet.Cells[8, 2] = "Ngày sinh: " + lblNgaySinh.Text;
            worksheet.Cells[9, 2] = "Giới tính: " + lblGioiTinh.Text;
            worksheet.Cells[10, 2] = "Nơi sinh: " + lblNoiSinh.Text;
            worksheet.Cells[11, 2] = "Dân tộc: " + lblDanToc.Text;
            worksheet.Cells[12, 1] = "STT";
            worksheet.Cells[12, 2] = "Mã môn";
            worksheet.Cells[12, 3] = "Tên môn";
            worksheet.Cells[12, 4] = "Số tín chỉ";
            worksheet.Cells[12, 5] = "Điểm TK";
            worksheet.Cells[12, 6] = "Điểm chữ";
            worksheet.Cells[12, 7] = "Điểm số";
            for(int i = 0; i < dtgDiem.RowCount - 1; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    worksheet.Cells[i + 13, 1] = i + 1;
                    worksheet.Cells[i + 13, j + 2] = dtgDiem.Rows[i].Cells[j].Value;
                }
            }
            int mon = dtgDiem.RowCount;
            worksheet.Cells[mon + 13, 1] = "Trung bình toàn khóa: " + lblDiemTB.Text;
            worksheet.Cells[mon + 14, 1] = "Xếp loại toàn khóa: " + lblXepLoai.Text;
            worksheet.Cells[mon + 15, 5] = "TPHCM, Ngày.....tháng.....năm.....";
            worksheet.Cells[mon + 16, 5] = "P.Đào tạo";
            worksheet.Cells[mon + 17, 5] = "Ký tên";

            //ĐỊNH DẠNG CHO SHEET
            worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
            worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            worksheet.PageSetup.LeftMargin = 3;
            worksheet.PageSetup.RightMargin = 0;
            worksheet.PageSetup.TopMargin = 0;
            worksheet.PageSetup.BottomMargin = 0;

            worksheet.Range["A1"].ColumnWidth = 8.25;
            worksheet.Range["B1"].ColumnWidth = 11.5;
            worksheet.Range["C1"].ColumnWidth = 28;
            worksheet.Range["D1"].ColumnWidth = 10;
            worksheet.Range["E1"].ColumnWidth = 10;
            worksheet.Range["F1"].ColumnWidth = 10;
            worksheet.Range["G1"].ColumnWidth = 10;

            worksheet.Range["A1", "G100"].Font.Name = "Times New Roman";
            worksheet.Range["A1", "G100"].Font.Size = 14;
            worksheet.Range["A1", "C1"].MergeCells = true;
            worksheet.Range["D1", "G1"].MergeCells = true;
            worksheet.Range["A2", "C2"].MergeCells = true;
            worksheet.Range["D2", "G2"].MergeCells = true;
            worksheet.Range["A4", "G4"].MergeCells = true;

            worksheet.Range["A1", "C1"].Font.Bold = true;
            worksheet.Range["D1", "G1"].Font.Bold = true;
            worksheet.Range["A2", "C2"].Font.Bold = true;
            worksheet.Range["D2", "G2"].Font.Bold = true;
            worksheet.Range["A4", "G4"].Font.Bold = true;
            worksheet.Range["A12", "G12"].Font.Bold = true;

            worksheet.Range["A12", "G" + (mon + 11)].Borders.LineStyle = 1;


            worksheet.Range["A1", "C1"].HorizontalAlignment = 3;
            worksheet.Range["D1", "G1"].HorizontalAlignment = 3;
            worksheet.Range["A2", "C2"].HorizontalAlignment = 3;
            worksheet.Range["D2", "G2"].HorizontalAlignment = 3;
            worksheet.Range["A4", "G4"].HorizontalAlignment = 3;
            worksheet.Range["A12", "G12"].HorizontalAlignment = 3;
            worksheet.Range["A13", "A" + (mon + 11)].HorizontalAlignment = 3;
            worksheet.Range["D13", "D" + (mon + 11)].HorizontalAlignment = 3;
            worksheet.Range["E13", "E" + (mon + 11)].HorizontalAlignment = 3;
            worksheet.Range["F13", "F" + (mon + 11)].HorizontalAlignment = 3;
            worksheet.Range["G13", "G" + (mon + 11)].HorizontalAlignment = 3;
            worksheet.Range["E25", "E" + (mon + 16)].HorizontalAlignment = 3;
            worksheet.Range["E26", "E" + (mon + 17)].HorizontalAlignment = 3;
            worksheet.Range["E27", "E" + (mon + 18)].HorizontalAlignment = 3;
        }
    }
}
