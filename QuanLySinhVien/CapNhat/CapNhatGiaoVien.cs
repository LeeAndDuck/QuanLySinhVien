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
    public partial class CapNhatGiaoVien : Form
    {
        SqlConnection conn;
        public CapNhatGiaoVien()
        {
            InitializeComponent();
            conn = Connection.GetConnection();
        }
        private void LoadData()
        {
            String sql = "select magv [Mã GV], tengv [Tên GV], gioitinh [Giới Tính], ngaysinh [Ngày Sinh], sdt [Số Điện Thoại], diachi [Địa Chỉ] from giaovien";
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
            dt.Fill(ds, "Giáo Viên");
            dgv_CapNhatGiaoVien.DataSource = ds.Tables["Giáo Viên"];
            SetupDataGridView();
        }
        private bool KiemTraMaGiaoVienTonTai(string maGiaoVien)
        {
            string query = "SELECT COUNT(*) FROM giaovien WHERE magv = @MaGV";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaGV", maGiaoVien);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        private bool IsPhoneNumberValid(string phoneNumber)
        {
            // Kiểm tra xem chuỗi chỉ chứa số và có độ dài từ 10 đến 11 ký tự
            return phoneNumber.All(char.IsDigit) && (phoneNumber.Length == 10 || phoneNumber.Length == 11);
        }

        private bool IsTeacherAbove22(DateTime birthdate)
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - birthdate.Year;

            // Kiểm tra nếu giáo viên chưa đủ 22 tuổi
            if (age < 22)
            {
                return false;
            }

            // Kiểm tra nếu giáo viên đã đủ 22 tuổi nhưng chưa qua ngày sinh của năm hiện tại
            if (birthdate.AddYears(age) > currentDate)
            {
                age--;
            }

            return age >= 22;
        }

        private void CapNhatGiaoVien_Load(object sender, EventArgs e)
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

        private void dgv_CapNhatGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtbMaGV.Text = dgv_CapNhatGiaoVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtbTenGV.Text = dgv_CapNhatGiaoVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                string gioiTinh = dgv_CapNhatGiaoVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (string.Equals(gioiTinh, "Nam", StringComparison.OrdinalIgnoreCase))
                {
                    rbNam.Checked = true;
                }
                else if (string.Equals(gioiTinh, "Nữ", StringComparison.OrdinalIgnoreCase))
                {
                    rbNu.Checked = true;
                }
                dtNgaySinh.Text = dgv_CapNhatGiaoVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtbSDT.Text = dgv_CapNhatGiaoVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtbDiaChi.Text = dgv_CapNhatGiaoVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                
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

                if (string.IsNullOrWhiteSpace(txtbMaGV.Text) || string.IsNullOrWhiteSpace(txtbTenGV.Text) ||
                   (rbNam.Checked || rbNu.Checked) == false || string.IsNullOrWhiteSpace(dtNgaySinh.Text) ||
                    string.IsNullOrWhiteSpace(txtbSDT.Text) || string.IsNullOrWhiteSpace(txtbDiaChi.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsPhoneNumberValid(txtbSDT.Text))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập số điện thoại đúng định dạng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsTeacherAbove22(dtNgaySinh.Value))
                {
                    MessageBox.Show("Giáo viên phải đủ 22 tuổi trở lên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (KiemTraMaGiaoVienTonTai(txtbMaGV.Text))
                {
                    MessageBox.Show("Mã Giáo Viên đã tồn tại! Bạn vui lòng nhập Mã Giáo Viên khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sql = "INSERT INTO giaovien VALUES(@MaGV, @TenGV, @GioiTinh, @NgaySinh, @SDT, @DiaChi)";
                SqlCommand com = new SqlCommand(sql, conn);
                com.Parameters.AddWithValue("@MaGV", txtbMaGV.Text);
                com.Parameters.AddWithValue("@TenGV", txtbTenGV.Text);
                string gioiTinh = rbNam.Checked ? "Nam" : "Nữ";
                com.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                com.Parameters.AddWithValue("@NgaySinh", dtNgaySinh.Value);
                com.Parameters.AddWithValue("@SDT", txtbSDT.Text);
                com.Parameters.AddWithValue("@DiaChi", txtbDiaChi.Text);
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

                if (string.IsNullOrWhiteSpace(txtbMaGV.Text) || string.IsNullOrWhiteSpace(txtbTenGV.Text) ||
                    (rbNam.Checked || rbNu.Checked) == false || string.IsNullOrWhiteSpace(dtNgaySinh.Text) ||
                    string.IsNullOrWhiteSpace(txtbSDT.Text) || string.IsNullOrWhiteSpace(txtbDiaChi.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsPhoneNumberValid(txtbSDT.Text))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập số điện thoại đúng định dạng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsTeacherAbove22(dtNgaySinh.Value))
                {
                    MessageBox.Show("Giáo viên phải đủ 22 tuổi trở lên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!KiemTraMaGiaoVienTonTai(txtbMaGV.Text))
                {
                    MessageBox.Show("Mã Giáo Viên không tồn tại! Bạn vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sql = "UPDATE giaovien SET tengv = @TenGV, gioitinh = @GioiTinh, ngaysinh = @NgaySinh, sdt = @SDT, diachi = @DiaChi WHERE magv = @MaGV";
                SqlCommand com = new SqlCommand(sql, conn);
                com.Parameters.AddWithValue("@MaGV", txtbMaGV.Text);
                com.Parameters.AddWithValue("@TenGV", txtbTenGV.Text);
                string gioiTinh = rbNam.Checked ? "Nam" : "Nữ";
                com.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                com.Parameters.AddWithValue("@NgaySinh", dtNgaySinh.Value);
                com.Parameters.AddWithValue("@SDT", txtbSDT.Text);
                com.Parameters.AddWithValue("@DiaChi", txtbDiaChi.Text);
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

                if (!KiemTraMaGiaoVienTonTai(txtbMaGV.Text))
                {
                    MessageBox.Show("Mã Giáo Viên không tồn tại! Bạn vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string sql = "DELETE FROM giaovien WHERE magv = @MaGV";
                    SqlCommand com = new SqlCommand(sql, conn);
                    com.Parameters.AddWithValue("@MaGV", txtbMaGV.Text);
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
            txtbMaGV.Clear();
            txtbTenGV.Clear();
            rbNam.Checked = false;
            rbNu.Checked = false;
            dtNgaySinh.Value = DateTime.Now;
            txtbSDT.Clear();
            txtbDiaChi.Clear();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetupDataGridView()
        {
            dgv_CapNhatGiaoVien.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_CapNhatGiaoVien.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_CapNhatGiaoVien.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_CapNhatGiaoVien.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_CapNhatGiaoVien.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_CapNhatGiaoVien.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv_CapNhatGiaoVien.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgv_CapNhatGiaoVien.DataBindingComplete += dgv_CapNhatGiaoVien_DataBindingComplete;
            dgv_CapNhatGiaoVien.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgv_CapNhatGiaoVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_CapNhatGiaoVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgv_CapNhatGiaoVien_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgv_CapNhatGiaoVien.Columns)
            {
                column.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10);
            }
        }
    }
}
