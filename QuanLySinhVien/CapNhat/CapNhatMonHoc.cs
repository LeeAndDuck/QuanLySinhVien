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
    public partial class CapNhatMonHoc : Form
    {
        SqlConnection conn;
        public CapNhatMonHoc()
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
            dgv_CapNhatMonHoc.DataSource = ds.Tables["Môn Học"];
            SetupDataGridView();
        }
        private bool KiemTraMaMonHocTonTai(string maMonHoc)
        {
            string query = "SELECT COUNT(*) FROM monhoc WHERE mamh = @MaMH";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaMH", maMonHoc);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void CapNhatMonHoc_Load(object sender, EventArgs e)
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

        private void dgv_CapNhatMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtbMaMH.Text = dgv_CapNhatMonHoc.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtbTenMH.Text = dgv_CapNhatMonHoc.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtbSoTiet.Text = dgv_CapNhatMonHoc.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtbMaGV.Text = dgv_CapNhatMonHoc.Rows[e.RowIndex].Cells[3].Value.ToString();
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

                if (string.IsNullOrWhiteSpace(txtbMaMH.Text) || string.IsNullOrWhiteSpace(txtbTenMH.Text) ||
                    string.IsNullOrWhiteSpace(txtbSoTiet.Text) || string.IsNullOrWhiteSpace(txtbMaGV.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (KiemTraMaMonHocTonTai(txtbMaMH.Text))
                {
                    MessageBox.Show("Mã Môn Học đã tồn tại! Bạn vui lòng nhập Mã Môn Học khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    string s = "INSERT INTO monhoc VALUES(@MaMH, @TenMH, @SoTiet, @MaGV)";
                    SqlCommand com = new SqlCommand(s, conn);
                    com.Parameters.AddWithValue("@MaMH", txtbMaMH.Text);
                    com.Parameters.AddWithValue("@TenMH", txtbTenMH.Text);
                    com.Parameters.AddWithValue("@SoTiet", txtbSoTiet.Text);
                    com.Parameters.AddWithValue("@MaGV", txtbMaGV.Text);
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

                if (string.IsNullOrWhiteSpace(txtbMaMH.Text) || string.IsNullOrWhiteSpace(txtbTenMH.Text) ||
                    string.IsNullOrWhiteSpace(txtbSoTiet.Text) || string.IsNullOrWhiteSpace(txtbMaGV.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!KiemTraMaMonHocTonTai(txtbMaMH.Text))
                {
                    MessageBox.Show("Mã Môn Học không tồn tại! Bạn vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string s = "UPDATE monhoc SET tenmh = @TenMH, sotiet = @SoTiet, magv = @MaGV WHERE mamh = @MaMH";
                SqlCommand com = new SqlCommand(s, conn);
                com.Parameters.AddWithValue("@MaMH", txtbMaMH.Text);
                com.Parameters.AddWithValue("@TenMH", txtbTenMH.Text);
                com.Parameters.AddWithValue("@SoTiet", txtbSoTiet.Text);
                com.Parameters.AddWithValue("@MaGV", txtbMaGV.Text);
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

                if (!KiemTraMaMonHocTonTai(txtbMaMH.Text))
                {
                    MessageBox.Show("Mã Môn Học không tồn tại! Bạn vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string s = "DELETE FROM monhoc WHERE mamh = @MaMH";
                    SqlCommand com = new SqlCommand(s, conn);
                    com.Parameters.AddWithValue("@MaMH", txtbMaMH.Text);
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
            txtbMaMH.Clear();
            txtbTenMH.Clear();
            txtbSoTiet.Clear();
            txtbMaGV.Clear();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetupDataGridView()
        {
            dgv_CapNhatMonHoc.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_CapNhatMonHoc.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_CapNhatMonHoc.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_CapNhatMonHoc.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_CapNhatMonHoc.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgv_CapNhatMonHoc.DataBindingComplete += dgv_CapNhatMonHoc_DataBindingComplete;
            dgv_CapNhatMonHoc.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            dgv_CapNhatMonHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_CapNhatMonHoc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgv_CapNhatMonHoc_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgv_CapNhatMonHoc.Columns)
            {
                column.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10);
            }
        }
    }
}
