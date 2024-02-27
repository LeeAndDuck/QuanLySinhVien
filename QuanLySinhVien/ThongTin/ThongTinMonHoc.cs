using ClosedXML.Excel;
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

namespace QuanLySinhVien.ThongTin
{
    public partial class ThongTinMonHoc : Form
    {
        SqlConnection conn;
        public ThongTinMonHoc()
        {
            InitializeComponent();
            conn = Connection.GetConnection();
        }
        private void LoadData()
        {
            String sql = "select mamh [Mã Môn Học], tenmh [Tên Môn Học], sotiet [Số Tiết], magv [Mã Giáo Viên] from monhoc";
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
            dt.Fill(ds, "Môn Học");
            dgv_ThongTinMonHoc.DataSource = ds.Tables["Môn Học"];
            SetupDataGridView();
        }

        private void ThongTinMonHoc_Load(object sender, EventArgs e)
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

        private void dgv_ThongTinMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtbMaMH.Text = dgv_ThongTinMonHoc.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtbTenMH.Text = dgv_ThongTinMonHoc.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtbSoTiet.Text = dgv_ThongTinMonHoc.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtbMaGV.Text = dgv_ThongTinMonHoc.Rows[e.RowIndex].Cells[3].Value.ToString();
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
                var worksheet = workbook.Worksheets.Add("MonHoc");

                // Header on the left
                var leftHeaderCell = worksheet.Cell(1, 1);
                leftHeaderCell.Value = "BỘ CÔNG THƯƠNG" + Environment.NewLine + "TRƯỜNG ĐH KINH TẾ - KTCN";
                leftHeaderCell.Style.Font.Bold = true;
                leftHeaderCell.Style.Font.FontSize = 12;
                leftHeaderCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center; // Center align

                // Header on the right
                var rightHeaderCell = worksheet.Cell(1, dgv_ThongTinMonHoc.Columns.Count);
                rightHeaderCell.Value = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM" + Environment.NewLine + "ĐỘC LẬP - TỰ DO - HẠNH PHÚC";
                rightHeaderCell.Style.Font.Bold = true;
                rightHeaderCell.Style.Font.FontSize = 12;
                rightHeaderCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center; // Center align

                // Merge the right header cells
                worksheet.Range(1, dgv_ThongTinMonHoc.Columns.Count, 1, dgv_ThongTinMonHoc.Columns.Count).Merge();

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
                worksheet.Range(4, 1, 4, dgv_ThongTinMonHoc.Columns.Count).Merge();

                // Ghi tiêu đề cột và căn chỉnh độ rộng từ dòng 6
                for (int j = 0; j < dgv_ThongTinMonHoc.Columns.Count; j++)
                {
                    IXLCell columnHeaderCell = worksheet.Cell(6, j + 1);
                    columnHeaderCell.Value = dgv_ThongTinMonHoc.Columns[j].HeaderText.ToUpper(); // Chuyển đổi thành chữ in hoa

                    // Các thiết lập khác như trước
                    columnHeaderCell.Style.Font.Bold = true;
                    columnHeaderCell.Style.Font.FontSize = 13;
                    columnHeaderCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    columnHeaderCell.Style.Fill.BackgroundColor = XLColor.Yellow; // Màu nền cho tiêu đề cột

                    worksheet.Column(j + 1).AdjustToContents();
                }

                // Ghi dữ liệu từ DataGridView từ dòng 7
                for (int i = 0; i < dgv_ThongTinMonHoc.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgv_ThongTinMonHoc.Columns.Count; j++)
                    {
                        IXLCell dataCell = worksheet.Cell(i + 7, j + 1);
                        dataCell.Value = dgv_ThongTinMonHoc.Rows[i].Cells[j].Value.ToString();

                        // Các thiết lập khác như trước
                    }
                }

                // Kẻ bảng từ dòng 6
                var tableRange = worksheet.Range(6, 1, dgv_ThongTinMonHoc.Rows.Count + 6, dgv_ThongTinMonHoc.Columns.Count);
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
            dgv_ThongTinMonHoc.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_ThongTinMonHoc.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_ThongTinMonHoc.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_ThongTinMonHoc.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_ThongTinMonHoc.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgv_ThongTinMonHoc.DataBindingComplete += dgv_ThongTinMonHoc_DataBindingComplete;
            dgv_ThongTinMonHoc.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            dgv_ThongTinMonHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ThongTinMonHoc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgv_ThongTinMonHoc_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgv_ThongTinMonHoc.Columns)
            {
                column.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10);
            }
        }
    }
}
