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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace QuanLySinhVien.TimKiem
{
    public partial class TimKiemKhoa : Form
    {
        SqlConnection conn;
        public TimKiemKhoa()
        {
            InitializeComponent();
            conn = Connection.GetConnection();
        }

        private void TimKiemKhoa_Load(object sender, EventArgs e)
        {
            String strsql;
            strsql = "select makhoa[Mã Khoa], tenkhoa[Tên Khoa] from khoa";
            DataSet dtset = new DataSet();
            SqlDataAdapter dtaAdapter = new SqlDataAdapter(strsql, conn);
            dtaAdapter.Fill(dtset);
            this.dgv_TimKiemKhoa.DataSource = dtset.Tables[0];
            SetupDataGridView();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand tim;
            bool kt = false;
            string kq = "";

            if (cbTim.SelectedItem != null)
            {
                if (string.IsNullOrWhiteSpace(txtbTuKhoa.Text))
                {
                    MessageBox.Show("Xin hãy nhập thông tin vào trường Từ Khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conn.Close();
                    return;
                }

                if (cbTim.SelectedItem.ToString() == "Mã Khoa")
                {
                    string makhoa = "select count(*) from khoa where makhoa like '%" + txtbTuKhoa.Text + "%'";
                    tim = new SqlCommand(makhoa, conn);
                    int count = (int)tim.ExecuteScalar();

                    if (count > 0)
                    {
                        kt = true;
                    }
                }
                if (cbTim.SelectedItem.ToString() == "Tên Khoa")
                {
                    string tenkhoa = "select count(*) from khoa where tenkhoa like '%" + txtbTuKhoa.Text + "%'";
                    tim = new SqlCommand(tenkhoa, conn);
                    int count = (int)tim.ExecuteScalar();

                    if (count > 0)
                    {
                        kt = true;
                    }
                }
                if (cbTim.SelectedItem == null)
                {
                    MessageBox.Show("Xin hãy chọn loại tìm kiếm trong trường Tìm Theo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conn.Close();
                    return;
                }

                if (kt)
                {
                    MessageBox.Show("Đã tìm thấy dữ liệu !", "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (cbTim.SelectedItem.ToString() == "Mã Khoa")
                    {
                        kq = "select makhoa[Mã Khoa], tenkhoa[Tên Khoa] from khoa where makhoa like '%" + txtbTuKhoa.Text + "%'";
                    }
                    if (cbTim.SelectedItem.ToString() == "Tên Khoa")
                    {
                        kq = "select makhoa[Mã Khoa], tenkhoa[Tên Khoa] from khoa where tenkhoa like '%" + txtbTuKhoa.Text + "%'";
                    }
                    DataSet ds1 = new DataSet();
                    SqlDataAdapter dt = new SqlDataAdapter(kq, conn);
                    dt.Fill(ds1);
                    dgv_TimKiemKhoa.DataSource = ds1.Tables[0];
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu!", "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                conn.Close();
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtbTuKhoa.Clear();
            cbTim.SelectedIndex = -1;
            cbTim.Focus();
            string strsql = "select makhoa[Mã Khoa], tenkhoa[Tên Khoa] from khoa";
            DataSet dtset = new DataSet();
            SqlDataAdapter dtadapter = new SqlDataAdapter(strsql, conn);
            dtadapter.Fill(dtset);
            dgv_TimKiemKhoa.DataSource = dtset.Tables[0];
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetupDataGridView()
        {
            dgv_TimKiemKhoa.Columns["Mã Khoa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_TimKiemKhoa.Columns["Tên Khoa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_TimKiemKhoa.Columns["Tên Khoa"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgv_TimKiemKhoa.DataBindingComplete += dgv_TimKiemKhoa_DataBindingComplete;
            dgv_TimKiemKhoa.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgv_TimKiemKhoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_TimKiemKhoa.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgv_TimKiemKhoa_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgv_TimKiemKhoa.Columns)
            {
                column.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10);
            }
        }
    }
}
