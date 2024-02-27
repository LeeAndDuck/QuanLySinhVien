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

namespace QuanLySinhVien
{
    public partial class CapNhatSinhVien : Form
    {
        SqlConnection conn;
        public CapNhatSinhVien()
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
            dgv_CapNhatSinhVien.DataSource = ds.Tables["Sinh Viên"];
            SetupDataGridView();
        }
        private bool KiemTraMaSinhVienTonTai(string maSinhVien)
        {
            string query = "SELECT COUNT(*) FROM sinhvien WHERE masv = @MaSV";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaSV", maSinhVien);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        private bool IsPhoneNumberValid(string phoneNumber)
        {
            // Kiểm tra xem chuỗi chỉ chứa số và có độ dài từ 10 đến 11 ký tự
            return phoneNumber.All(char.IsDigit) && (phoneNumber.Length == 10 || phoneNumber.Length == 11);
        }

        private bool IsStudentAbove16(DateTime birthdate)
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - birthdate.Year;

            // Kiểm tra nếu sinh viên chưa đủ 16 tuổi
            if (age < 16)
            {
                return false;
            }

            // Kiểm tra nếu sinh viên đã đủ 16 tuổi nhưng chưa qua ngày sinh của năm hiện tại
            if (birthdate.AddYears(age) > currentDate)
            {
                age--;
            }

            return age >= 16;
        }

        private void CapNhatSinhVien_Load(object sender, EventArgs e)
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

        private void dgv_CapNhatSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtbMaSV.Text = dgv_CapNhatSinhVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtbTenSV.Text = dgv_CapNhatSinhVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                string gioiTinh = dgv_CapNhatSinhVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (string.Equals(gioiTinh, "Nam", StringComparison.OrdinalIgnoreCase))
                {
                    rbNam.Checked = true;
                }
                else if (string.Equals(gioiTinh, "Nữ", StringComparison.OrdinalIgnoreCase))
                {
                    rbNu.Checked = true;
                }
                dtNgaySinh.Text = dgv_CapNhatSinhVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtbSDT.Text = dgv_CapNhatSinhVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtbDiaChi.Text = dgv_CapNhatSinhVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtbMaCS.Text = dgv_CapNhatSinhVien.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtbMaLop.Text = dgv_CapNhatSinhVien.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                if (string.IsNullOrWhiteSpace(txtbMaSV.Text) || string.IsNullOrWhiteSpace(txtbTenSV.Text) ||
                   (rbNam.Checked || rbNu.Checked) == false || string.IsNullOrWhiteSpace(dtNgaySinh.Text) ||
                    string.IsNullOrWhiteSpace(txtbSDT.Text) || string.IsNullOrWhiteSpace(txtbDiaChi.Text) ||
                    string.IsNullOrWhiteSpace(txtbMaCS.Text) || string.IsNullOrWhiteSpace(txtbMaLop.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsPhoneNumberValid(txtbSDT.Text))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập số điện thoại đúng định dạng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsStudentAbove16(dtNgaySinh.Value))
                {
                    MessageBox.Show("Sinh viên phải đủ 16 tuổi trở lên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (KiemTraMaSinhVienTonTai(txtbMaSV.Text))
                {
                    MessageBox.Show("Mã Sinh Viên đã tồn tại! Bạn vui lòng nhập Mã Sinh Viên khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sql = "INSERT INTO sinhvien VALUES(@MaSV, @TenSV, @GioiTinh, @NgaySinh, @SDT, @DiaChi, @MaCS, @MaLop)";
                SqlCommand com = new SqlCommand(sql, conn);
                com.Parameters.AddWithValue("@MaSV", txtbMaSV.Text);
                com.Parameters.AddWithValue("@TenSV", txtbTenSV.Text);
                string gioiTinh = rbNam.Checked ? "Nam" : "Nữ";
                com.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                com.Parameters.AddWithValue("@NgaySinh", dtNgaySinh.Value);
                com.Parameters.AddWithValue("@SDT", txtbSDT.Text);
                com.Parameters.AddWithValue("@DiaChi", txtbDiaChi.Text);
                com.Parameters.AddWithValue("@MaCS", txtbMaCS.Text);
                com.Parameters.AddWithValue("@MaLop", txtbMaLop.Text);
                com.ExecuteNonQuery();

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}. Dữ liệu đã tồn tại hoặc có lỗi khác! Bạn vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                if (string.IsNullOrWhiteSpace(txtbMaSV.Text) || string.IsNullOrWhiteSpace(txtbTenSV.Text) ||
                    (rbNam.Checked || rbNu.Checked) == false || string.IsNullOrWhiteSpace(dtNgaySinh.Text) ||
                    string.IsNullOrWhiteSpace(txtbSDT.Text) || string.IsNullOrWhiteSpace(txtbDiaChi.Text) ||
                    string.IsNullOrWhiteSpace(txtbMaCS.Text) || string.IsNullOrWhiteSpace(txtbMaLop.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsPhoneNumberValid(txtbSDT.Text))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập số điện thoại đúng định dạng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsStudentAbove16(dtNgaySinh.Value))
                {
                    MessageBox.Show("Sinh viên phải đủ 16 tuổi trở lên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!KiemTraMaSinhVienTonTai(txtbMaSV.Text))
                {
                    MessageBox.Show("Mã Sinh Viên không tồn tại! Bạn vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sql = "UPDATE sinhvien SET tensv = @TenSV, gioitinh = @GioiTinh, ngaysinh = @NgaySinh, sdt = @SDT, diachi = @DiaChi, macs = @MaCS, malop = @MaLop WHERE masv = @MaSV";
                SqlCommand com = new SqlCommand(sql, conn);
                com.Parameters.AddWithValue("@MaSV", txtbMaSV.Text);
                com.Parameters.AddWithValue("@TenSV", txtbTenSV.Text);
                string gioiTinh = rbNam.Checked ? "Nam" : "Nữ";
                com.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                com.Parameters.AddWithValue("@NgaySinh", dtNgaySinh.Value);
                com.Parameters.AddWithValue("@SDT", txtbSDT.Text);
                com.Parameters.AddWithValue("@DiaChi", txtbDiaChi.Text);
                com.Parameters.AddWithValue("@MaCS", txtbMaCS.Text);
                com.Parameters.AddWithValue("@MaLop", txtbMaLop.Text);
                com.ExecuteNonQuery();

                LoadData();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}. Không thể cập nhật thông tin! Bạn vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                if (!KiemTraMaSinhVienTonTai(txtbMaSV.Text))
                {
                    MessageBox.Show("Mã Sinh Viên không tồn tại! Bạn vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string sql = "DELETE FROM sinhvien WHERE masv = @MaSV";
                    SqlCommand com = new SqlCommand(sql, conn);
                    com.Parameters.AddWithValue("@MaSV", txtbMaSV.Text);
                    com.ExecuteNonQuery();

                    LoadData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}. Không thể xóa thông tin! Bạn vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtbMaSV.Clear();
            txtbTenSV.Clear();
            rbNam.Checked = false;
            rbNu.Checked = false;
            dtNgaySinh.Value = DateTime.Now;
            txtbSDT.Clear();
            txtbDiaChi.Clear();
            txtbMaCS.Clear();
            txtbMaLop.Clear();

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetupDataGridView()
        {
            dgv_CapNhatSinhVien.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_CapNhatSinhVien.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_CapNhatSinhVien.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_CapNhatSinhVien.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_CapNhatSinhVien.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_CapNhatSinhVien.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_CapNhatSinhVien.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_CapNhatSinhVien.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv_CapNhatSinhVien.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgv_CapNhatSinhVien.DataBindingComplete += dgv_CapNhatSinhVien_DataBindingComplete;
            dgv_CapNhatSinhVien.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            dgv_CapNhatSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_CapNhatSinhVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgv_CapNhatSinhVien_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgv_CapNhatSinhVien.Columns)
            {
                column.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10);
            }
        }
    }
}
