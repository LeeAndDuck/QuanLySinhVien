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
using ClosedXML.Excel;

namespace QuanLySinhVien.ThongTin
{
    public partial class ThongTinSinhVien : Form
    {
        SqlConnection conn;
        public ThongTinSinhVien()
        {
            InitializeComponent();
            conn = Connection.GetConnection();
        }

        private void LoadData()
        {
            String sql = "select masv [Mã SV], tensv [Tên SV], gioitinh [Giới Tính], ngaysinh [Ngày Sinh], sdt [Số Điện Thoại], diachi [Địa Chỉ], macs [Mã Chính Sách], malop [Mã Lớp] from sinhvien";
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
            dt.Fill(ds, "Sinh Viên");
            dgv_ThongTinSinhVien.DataSource = ds.Tables["Sinh Viên"];
            SetupDataGridView();
        }

        private void ThongTinSinhVien_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void dgv_ThongTinSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtbMaSV.Text = dgv_ThongTinSinhVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtbTenSV.Text = dgv_ThongTinSinhVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                string gioiTinh = dgv_ThongTinSinhVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (string.Equals(gioiTinh, "Nam", StringComparison.OrdinalIgnoreCase))
                {
                    rbNam.Checked = true;
                }
                else if (string.Equals(gioiTinh, "Nữ", StringComparison.OrdinalIgnoreCase))
                {
                    rbNu.Checked = true;
                }
                dtNgaySinh.Text = dgv_ThongTinSinhVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtbSDT.Text = dgv_ThongTinSinhVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtbDiaChi.Text = dgv_ThongTinSinhVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtbMaCS.Text = dgv_ThongTinSinhVien.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtbMaLop.Text = dgv_ThongTinSinhVien.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("SinhVien");

                // Header on the left
                var leftHeaderCell = worksheet.Cell(1, 1);
                leftHeaderCell.Value = "BỘ CÔNG THƯƠNG" + Environment.NewLine + "TRƯỜNG ĐH KINH TẾ - KTCN";
                leftHeaderCell.Style.Font.Bold = true;
                leftHeaderCell.Style.Font.FontSize = 12;
                leftHeaderCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center; // Center align

                // Header on the right
                var rightHeaderCell = worksheet.Cell(1, dgv_ThongTinSinhVien.Columns.Count);
                rightHeaderCell.Value = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM" + Environment.NewLine + "ĐỘC LẬP - TỰ DO - HẠNH PHÚC";
                rightHeaderCell.Style.Font.Bold = true;
                rightHeaderCell.Style.Font.FontSize = 12;
                rightHeaderCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center; // Center align

                // Merge the right header cells
                worksheet.Range(1, dgv_ThongTinSinhVien.Columns.Count, 1, dgv_ThongTinSinhVien.Columns.Count).Merge();

                // Dòng trống sau "BỘ CÔNG THƯƠNG"
                worksheet.Row(2).InsertRowsBelow(1);

                // Lấy giá trị của Label và đặt làm tiêu đề ở dòng 4
                string labelValue = label1.Text; // Thay "yourLabel" bằng tên thật của Label
                var titleCell = worksheet.Cell(4, 1);
                titleCell.Value = labelValue.ToUpper(); // Chuyển đổi thành chữ in hoa
                titleCell.Style.Font.Bold = true;
                titleCell.Style.Font.FontSize = 20; // Đặt kích thước chữ cho tiêu đề
                titleCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                // Merge ô cho tiêu đề
                worksheet.Range(4, 1, 4, dgv_ThongTinSinhVien.Columns.Count).Merge();

                // Ghi tiêu đề cột và căn chỉnh độ rộng từ dòng 6
                for (int j = 0; j < dgv_ThongTinSinhVien.Columns.Count; j++)
                {
                    IXLCell columnHeaderCell = worksheet.Cell(6, j + 1);
                    columnHeaderCell.Value = dgv_ThongTinSinhVien.Columns[j].HeaderText.ToUpper(); // Chuyển đổi thành chữ in hoa

                    // Các thiết lập khác như trước
                    columnHeaderCell.Style.Font.Bold = true;
                    columnHeaderCell.Style.Font.FontSize = 13;
                    columnHeaderCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    columnHeaderCell.Style.Fill.BackgroundColor = XLColor.Yellow; // Màu nền cho tiêu đề cột

                    worksheet.Column(j + 1).AdjustToContents();
                }

                // Ghi dữ liệu từ DataGridView từ dòng 7
                for (int i = 0; i < dgv_ThongTinSinhVien.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgv_ThongTinSinhVien.Columns.Count; j++)
                    {
                        IXLCell dataCell = worksheet.Cell(i + 7, j + 1);
                        dataCell.Value = dgv_ThongTinSinhVien.Rows[i].Cells[j].Value.ToString();

                        // Các thiết lập khác như trước
                    }
                }

                // Kẻ bảng từ dòng 6
                var tableRange = worksheet.Range(6, 1, dgv_ThongTinSinhVien.Rows.Count + 6, dgv_ThongTinSinhVien.Columns.Count);
                tableRange.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                tableRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                tableRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                // AutoFit tất cả các cột để đảm bảo độ rộng vừa đủ
                worksheet.Columns().AdjustToContents();

                // Lưu Workbook
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save an Excel File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Đã lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    System.Diagnostics.Process.Start(saveFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetupDataGridView()
        {
            dgv_ThongTinSinhVien.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_ThongTinSinhVien.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_ThongTinSinhVien.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_ThongTinSinhVien.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_ThongTinSinhVien.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_ThongTinSinhVien.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_ThongTinSinhVien.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_ThongTinSinhVien.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv_ThongTinSinhVien.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgv_ThongTinSinhVien.DataBindingComplete += dgv_ThongTinSinhVien_DataBindingComplete;
            dgv_ThongTinSinhVien.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            dgv_ThongTinSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ThongTinSinhVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgv_ThongTinSinhVien_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgv_ThongTinSinhVien.Columns)
            {
                column.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10);
            }
        }
    }
}
