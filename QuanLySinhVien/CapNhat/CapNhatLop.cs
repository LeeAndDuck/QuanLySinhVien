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
    public partial class CapNhatLop : Form
    {
        SqlConnection conn;
        public CapNhatLop()
        {
            InitializeComponent();
            conn = Connection.GetConnection();
        }
        private void LoadData()
        {
            String sql = "select malop [Mã Lớp], tenlop [Tên Lớp], makhoa [Mã Khoa] from lop";
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
            dt.Fill(ds, "Lớp");
            dgv_CapNhatLop.DataSource = ds.Tables["Lớp"];
            SetupDataGridView();
        }

        private bool KiemTraMaLopTonTai(string maLop)
        {
            string query = "SELECT COUNT(*) FROM lop WHERE malop = @MaLop";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaLop", maLop);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        private void CapNhatLop_Load(object sender, EventArgs e)
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

        private void dgv_CapNhatLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtbMaLop.Text = dgv_CapNhatLop.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtbTenLop.Text = dgv_CapNhatLop.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtbMaKhoa.Text = dgv_CapNhatLop.Rows[e.RowIndex].Cells[2].Value.ToString();
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
                if (string.IsNullOrWhiteSpace(txtbMaLop.Text) || string.IsNullOrWhiteSpace(txtbTenLop.Text) || string.IsNullOrWhiteSpace(txtbMaKhoa.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra nếu Mã Lớp đã tồn tại
                if (KiemTraMaLopTonTai(txtbMaLop.Text))
                {
                    MessageBox.Show("Mã Lớp đã tồn tại! Bạn vui lòng nhập Mã Lớp khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string s = "INSERT INTO lop VALUES(@MaLop, @TenLop, @MaKhoa)";
                SqlCommand com = new SqlCommand(s, conn);
                com.Parameters.AddWithValue("@MaLop", txtbMaLop.Text);
                com.Parameters.AddWithValue("@TenLop", txtbTenLop.Text);
                com.Parameters.AddWithValue("@MaKhoa", txtbMaKhoa.Text);
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

                // Kiểm tra nếu các trường dữ liệu không được nhập
                if (string.IsNullOrWhiteSpace(txtbMaLop.Text) || string.IsNullOrWhiteSpace(txtbTenLop.Text) || string.IsNullOrWhiteSpace(txtbMaKhoa.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra nếu Mã Lớp không tồn tại
                if (!KiemTraMaLopTonTai(txtbMaLop.Text))
                {
                    MessageBox.Show("Mã Lớp không tồn tại! Bạn vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string s = "UPDATE lop SET tenlop = @TenLop, makhoa = @MaKhoa WHERE malop = @MaLop";
                SqlCommand com = new SqlCommand(s, conn);
                com.Parameters.AddWithValue("@MaLop", txtbMaLop.Text);
                com.Parameters.AddWithValue("@TenLop", txtbTenLop.Text);
                com.Parameters.AddWithValue("@MaKhoa", txtbMaKhoa.Text);
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

                // Kiểm tra nếu Mã Lớp không tồn tại
                if (!KiemTraMaLopTonTai(txtbMaLop.Text))
                {
                    MessageBox.Show("Mã Lớp không tồn tại! Bạn vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string s = "DELETE FROM lop WHERE malop = @MaLop";
                    SqlCommand com = new SqlCommand(s, conn);
                    com.Parameters.AddWithValue("@MaLop", txtbMaLop.Text);
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
            txtbMaLop.Clear();
            txtbTenLop.Clear();
            txtbMaKhoa.Clear();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetupDataGridView()
        {
            dgv_CapNhatLop.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_CapNhatLop.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_CapNhatLop.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_CapNhatLop.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_CapNhatLop.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgv_CapNhatLop.DataBindingComplete += dgv_CapNhatLop_DataBindingComplete;
            dgv_CapNhatLop.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            dgv_CapNhatLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_CapNhatLop.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgv_CapNhatLop_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgv_CapNhatLop.Columns)
            {
                column.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10);
            }
        }
    }
}
