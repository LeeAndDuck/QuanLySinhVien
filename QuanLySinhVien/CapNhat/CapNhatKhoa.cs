using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class CapNhatKhoa : Form
    {
        SqlConnection conn;
        public CapNhatKhoa()
        {
            InitializeComponent();
            conn = Connection.GetConnection();
        }

        private void LoadData()
        {
            String sql = "select makhoa [Mã Khoa], tenkhoa [Tên Khoa] from khoa";
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
            dt.Fill(ds, "Khoa");
            dgv_CapNhatKhoa.DataSource = ds.Tables["Khoa"];
            SetupDataGridView();
        }
        private bool KiemTraMaKhoaTonTai(string maKhoa)
        {
            string query = "SELECT COUNT(*) FROM khoa WHERE makhoa = @MaKhoa";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaKhoa", maKhoa);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void CapNhatKhoa_Load(object sender, EventArgs e)
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

        private void dgv_CapNhatKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtbMa.Text = dgv_CapNhatKhoa.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtbTen.Text = dgv_CapNhatKhoa.Rows[e.RowIndex].Cells[1].Value.ToString();
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

                // Kiểm tra nếu các trường dữ liệu không được nhập
                if (string.IsNullOrWhiteSpace(txtbMa.Text) || string.IsNullOrWhiteSpace(txtbTen.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra nếu Mã Khoa đã tồn tại
                if (KiemTraMaKhoaTonTai(txtbMa.Text))
                {
                    MessageBox.Show("Mã Khoa đã tồn tại! Bạn vui lòng nhập Mã Khoa khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                String s = "INSERT INTO khoa VALUES(@Ma, @Ten)";
                SqlCommand com = new SqlCommand(s, conn);
                com.Parameters.AddWithValue("@Ma", txtbMa.Text);
                com.Parameters.AddWithValue("@Ten", txtbTen.Text);
                com.ExecuteNonQuery();

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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

                // Kiểm tra nếu các trường dữ liệu không được nhập
                if (string.IsNullOrWhiteSpace(txtbMa.Text) || string.IsNullOrWhiteSpace(txtbTen.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra nếu Mã Khoa không tồn tại
                if (!KiemTraMaKhoaTonTai(txtbMa.Text))
                {
                    MessageBox.Show("Mã Khoa không tồn tại! Bạn vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                String s = "UPDATE khoa SET tenkhoa = @Ten WHERE makhoa = @Ma";
                SqlCommand com = new SqlCommand(s, conn);
                com.Parameters.AddWithValue("@Ma", txtbMa.Text);
                com.Parameters.AddWithValue("@Ten", txtbTen.Text);
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

                // Kiểm tra nếu Mã Khoa không tồn tại
                if (!KiemTraMaKhoaTonTai(txtbMa.Text))
                {
                    MessageBox.Show("Mã Khoa không tồn tại! Bạn vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    String s = "DELETE FROM khoa WHERE makhoa = @Ma";
                    SqlCommand com = new SqlCommand(s, conn);
                    com.Parameters.AddWithValue("@Ma", txtbMa.Text);
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
            txtbMa.Clear();
            txtbTen.Clear();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetupDataGridView()
        {
            dgv_CapNhatKhoa.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_CapNhatKhoa.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_CapNhatKhoa.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgv_CapNhatKhoa.DataBindingComplete += dgv_CapNhatKhoa_DataBindingComplete;
            dgv_CapNhatKhoa.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgv_CapNhatKhoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_CapNhatKhoa.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgv_CapNhatKhoa_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgv_CapNhatKhoa.Columns)
            {
                column.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10);
            }
        }
    }
}
