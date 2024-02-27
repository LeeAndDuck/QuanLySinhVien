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
    public partial class CapNhatDiem : Form
    {
        SqlConnection conn;
        public CapNhatDiem()
        {
            InitializeComponent();
            conn = Connection.GetConnection();
        }
        private void LoadData()
        {
            String sql = "select id [ID], masv [Mã SV], mamh [Mã Môn Học], diem [Điểm] from diem";
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
            dt.Fill(ds, "Sinh Viên");
            dgv_CapNhatDiem.DataSource = ds.Tables["Sinh Viên"];
            SetupDataGridView();
        }

        private bool KiemTraIDTonTai(string id)
        {
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM ten_bang WHERE ma_id = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true; // Trả về true để đảm bảo không thể thêm dữ liệu khi có lỗi xảy ra
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        private void CapNhatDiem_Load(object sender, EventArgs e)
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

        private void dgv_CapNhatDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtbID.Text = dgv_CapNhatDiem.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtbMaSV.Text = dgv_CapNhatDiem.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtbMaMH.Text = dgv_CapNhatDiem.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtbDiem.Text = dgv_CapNhatDiem.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra trùng mã ID
                if (KiemTraIDTonTai(txtbID.Text))
                {
                    MessageBox.Show("Mã ID đã tồn tại! Vui lòng nhập mã ID khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                conn.Open();
                // Tiếp tục thêm dữ liệu vào cơ sở dữ liệu
                string sql = "INSERT INTO ten_bang (ma_id, ...) VALUES (@ID, ...)";
                using (SqlCommand com = new SqlCommand(sql, conn))
                {
                    com.Parameters.AddWithValue("@ID", txtbID.Text);
                    // Thêm các tham số còn lại

                    com.ExecuteNonQuery();
                }

                // Cập nhật lại hiển thị
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                // Kiểm tra nếu mã ID không tồn tại, thông báo lỗi
                if (!KiemTraIDTonTai(txtbID.Text))
                {
                    MessageBox.Show("Mã ID không tồn tại! Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tiếp tục sửa dữ liệu trong cơ sở dữ liệu
                string sql = "UPDATE ten_bang SET ... WHERE ma_id = @ID";
                using (SqlCommand com = new SqlCommand(sql, conn))
                {
                    com.Parameters.AddWithValue("@ID", txtbID.Text);
                    // Thêm các tham số còn lại

                    com.ExecuteNonQuery();
                }

                // Cập nhật lại hiển thị
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                if (string.IsNullOrWhiteSpace(txtbID.Text))
                {
                    MessageBox.Show("Vui lòng chọn dữ liệu cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Kiểm tra nếu mã ID không tồn tại, thông báo lỗi
                if (!KiemTraIDTonTai(txtbID.Text))
                {
                    MessageBox.Show("Mã ID không tồn tại! Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string sql = "DELETE FROM ten_bang WHERE ma_id = @ID";
                    using (SqlCommand com = new SqlCommand(sql, conn))
                    {
                        com.Parameters.AddWithValue("@ID", txtbID.Text);
                        com.ExecuteNonQuery();
                    }

                    // Cập nhật lại hiển thị
                    LoadData();
                }
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

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtbID.Clear();
            txtbMaSV.Clear();
            txtbMaMH.Clear();
            txtbDiem.Clear();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetupDataGridView()
        {
            dgv_CapNhatDiem.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_CapNhatDiem.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_CapNhatDiem.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_CapNhatDiem.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv_CapNhatDiem.DataBindingComplete += dgv_CapNhatDiem_DataBindingComplete;
            dgv_CapNhatDiem.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgv_CapNhatDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_CapNhatDiem.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgv_CapNhatDiem_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgv_CapNhatDiem.Columns)
            {
                column.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10);
            }
        }
    }
}
