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

namespace QuanLySinhVien.TimKiem
{
    public partial class TimKiemChinhSach : Form
    {
        SqlConnection conn;
        public TimKiemChinhSach()
        {
            InitializeComponent();
            conn = Connection.GetConnection();
        }

        private void TimKiemChinhSach_Load(object sender, EventArgs e)
        {
            String strsql;
            strsql = "select macs[Mã Chính Sách], tencs[Tên Chính Sách], chedo[Chế Độ] from chinhsach";
            DataSet dtset = new DataSet();
            SqlDataAdapter dtaAdapter = new SqlDataAdapter(strsql, conn);
            dtaAdapter.Fill(dtset);
            this.dgv_TimKiemChinhSach.DataSource = dtset.Tables[0];
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

                if (cbTim.SelectedItem.ToString() == "Mã Chính Sách")
                {
                    string machinhsach = "select count(*) from chinhsach where macs like '%" + txtbTuKhoa.Text + "%'";
                    tim = new SqlCommand(machinhsach, conn);
                    int count = (int)tim.ExecuteScalar();

                    if (count > 0)
                    {
                        kt = true;
                    }
                }
                else if (cbTim.SelectedItem.ToString() == "Tên Chính Sách")
                {
                    string tencs = "select count(*) from chinhsach where tencs like '%" + txtbTuKhoa.Text + "%'";
                    tim = new SqlCommand(tencs, conn);
                    int count = (int)tim.ExecuteScalar();

                    if (count > 0)
                    {
                        kt = true;
                    }
                }
                else if (cbTim.SelectedItem.ToString() == "Chế Độ")
                {
                    string chedo = "select count(*) from chinhsach where chedo like '%" + txtbTuKhoa.Text + "%'";
                    tim = new SqlCommand(chedo, conn);
                    int count = (int)tim.ExecuteScalar();

                    if (count > 0)
                    {
                        kt = true;
                    }
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

                if (cbTim.SelectedItem.ToString() == "Mã Chính Sách")
                {
                    kq = "select macs as [Mã Chính Sách], tencs as [Tên Chính Sách], chedo as [Chế Độ] from chinhsach where macs like '%" + txtbTuKhoa.Text + "%'";
                }
                else if (cbTim.SelectedItem.ToString() == "Tên Chính Sách")
                {
                    kq = "select macs as [Mã Chính Sách], tencs as [Tên Chính Sách], chedo as [Chế Độ] from chinhsach where tencs like '%" + txtbTuKhoa.Text + "%'";
                }
                else if (cbTim.SelectedItem.ToString() == "Chế Độ")
                {
                    kq = "select macs as [Mã Chính Sách], tencs as [Tên Chính Sách], chedo as [Chế Độ] from chinhsach where chedo like '%" + txtbTuKhoa.Text + "%'";
                }

                DataSet ds1 = new DataSet();
                SqlDataAdapter dt = new SqlDataAdapter(kq, conn);
                dt.Fill(ds1);
                dgv_TimKiemChinhSach.DataSource = ds1.Tables[0];
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu!", "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            conn.Close();
        }
        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtbTuKhoa.Clear();
            cbTim.SelectedIndex = -1;
            cbTim.Focus();
            string strsql = "select macs as [Mã Chính Sách], tencs as [Tên Chính Sách], chedo as [Chế Độ] from chinhsach";
            DataSet dtset = new DataSet();
            SqlDataAdapter dtadapter = new SqlDataAdapter(strsql, conn);
            dtadapter.Fill(dtset);
            dgv_TimKiemChinhSach.DataSource = dtset.Tables[0];
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetupDataGridView()
        {
            dgv_TimKiemChinhSach.Columns["Mã Chính Sách"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_TimKiemChinhSach.Columns["Tên Chính Sách"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_TimKiemChinhSach.Columns["Chế Độ"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_TimKiemChinhSach.Columns["Tên Chính Sách"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_TimKiemChinhSach.Columns["Chế Độ"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgv_TimKiemChinhSach.DataBindingComplete += dgv_TimKiemChinhSach_DataBindingComplete;
            dgv_TimKiemChinhSach.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgv_TimKiemChinhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_TimKiemChinhSach.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgv_TimKiemChinhSach_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgv_TimKiemChinhSach.Columns)
            {
                column.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10);
            }
        }
    }
}
