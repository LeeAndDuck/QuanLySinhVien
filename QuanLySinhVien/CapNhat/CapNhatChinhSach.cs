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
    public partial class CapNhatChinhSach : Form
    {
        SqlConnection conn;
        public CapNhatChinhSach()
        {
            InitializeComponent();
            conn = Connection.GetConnection();
        }
        private void LoadData()
        {
            String sql = "select macs [Mã Chính Sách], tencs [Tên Chính Sách], chedo [Chế Độ] from chinhsach";
            DataSet ds = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
            dt.Fill(ds, "Chính Sách");
            dgv_CapNhatChinhSach.DataSource = ds.Tables["Chính Sách"];
            SetupDataGridView();
        }
        private bool KiemTraMaChinhSachTonTai(string maChinhSach)
        {
            string query = "SELECT COUNT(*) FROM chinhsach WHERE macs = @MaCS";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaCS", maChinhSach);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void CapNhatChinhSach_Load(object sender, EventArgs e)
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

        private void dgv_CapNhatChinhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtbMa.Text = dgv_CapNhatChinhSach.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtbTen.Text = dgv_CapNhatChinhSach.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtbCheDo.Text = dgv_CapNhatChinhSach.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch(Exception)
            { 
            
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                if (string.IsNullOrWhiteSpace(txtbMa.Text) || string.IsNullOrWhiteSpace(txtbTen.Text) || string.IsNullOrWhiteSpace(txtbCheDo.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (KiemTraMaChinhSachTonTai(txtbMa.Text))
                {
                    MessageBox.Show("Mã Chính Sách đã tồn tại! Vui lòng nhập Mã Chính Sách khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sql = "INSERT INTO chinhsach VALUES(@MaCS, @TenCS, @CheDo)";
                SqlCommand com = new SqlCommand(sql, conn);
                com.Parameters.AddWithValue("@MaCS", txtbMa.Text);
                com.Parameters.AddWithValue("@TenCS", txtbTen.Text);
                com.Parameters.AddWithValue("@CheDo", txtbCheDo.Text);
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

                if (string.IsNullOrWhiteSpace(txtbMa.Text) || string.IsNullOrWhiteSpace(txtbTen.Text) || string.IsNullOrWhiteSpace(txtbCheDo.Text))
                {
                    MessageBox.Show("Vui lòng chọn dữ liệu cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!KiemTraMaChinhSachTonTai(txtbMa.Text))
                {
                    MessageBox.Show("Mã Chính Sách không tồn tại! Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sql = "UPDATE chinhsach SET tencs = @TenCS, chedo = @CheDo WHERE macs = @MaCS";
                SqlCommand com = new SqlCommand(sql, conn);
                com.Parameters.AddWithValue("@MaCS", txtbMa.Text);
                com.Parameters.AddWithValue("@TenCS", txtbTen.Text);
                com.Parameters.AddWithValue("@CheDo", txtbCheDo.Text);
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

                if (!KiemTraMaChinhSachTonTai(txtbMa.Text))
                {
                    MessageBox.Show("Mã Chính Sách không tồn tại! Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string sql = "DELETE FROM chinhsach WHERE macs = @MaCS";
                    SqlCommand com = new SqlCommand(sql, conn);
                    com.Parameters.AddWithValue("@MaCS", txtbMa.Text);
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
            txtbCheDo.Clear();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetupDataGridView()
        {
            dgv_CapNhatChinhSach.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_CapNhatChinhSach.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_CapNhatChinhSach.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_CapNhatChinhSach.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_CapNhatChinhSach.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgv_CapNhatChinhSach.DataBindingComplete += dgv_CapNhatChinhSach_DataBindingComplete;
            dgv_CapNhatChinhSach.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgv_CapNhatChinhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_CapNhatChinhSach.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgv_CapNhatChinhSach_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgv_CapNhatChinhSach.Columns)
            {
                column.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10);
            }
        }
    }
}
