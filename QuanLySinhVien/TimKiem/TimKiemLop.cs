using DocumentFormat.OpenXml.Spreadsheet;
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
    public partial class TimKiemLop : Form
    {
        SqlConnection conn;
        public TimKiemLop()
        {
            InitializeComponent();
            conn = Connection.GetConnection();
        }

        private void TimKiemLop_Load(object sender, EventArgs e)
        {
            String strsql;
            strsql = "select malop[Mã Lớp], tenlop[Tên Lớp], makhoa[Mã Khoa] from lop";
            DataSet dtset = new DataSet();
            SqlDataAdapter dtaAdapter = new SqlDataAdapter(strsql, conn);
            dtaAdapter.Fill(dtset);
            this.dgv_TimKiemLop.DataSource = dtset.Tables[0];
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

                if (cbTim.SelectedItem.ToString() == "Mã Lớp")
                {
                    string malop = "select count(*) from lop where malop like '%" + txtbTuKhoa.Text + "%'";
                    tim = new SqlCommand(malop, conn);
                    int count = (int)tim.ExecuteScalar();

                    if (count > 0)
                    {
                        kt = true;
                    }
                }
                else if (cbTim.SelectedItem.ToString() == "Tên Lớp")
                {
                    string tenlop = "select count(*) from lop where tenlop like '%" + txtbTuKhoa.Text + "%'";
                    tim = new SqlCommand(tenlop, conn);
                    int count = (int)tim.ExecuteScalar();

                    if (count > 0)
                    {
                        kt = true;
                    }
                }
                else if (cbTim.SelectedItem.ToString() == "Mã Khoa")
                {
                    string makhoa = "select count(*) from lop where makhoa like '%" + txtbTuKhoa.Text + "%'";
                    tim = new SqlCommand(makhoa, conn);
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

                if (cbTim.SelectedItem.ToString() == "Mã Lớp")
                {
                    kq = "select malop[Mã Lớp], tenlop[Tên Lớp], makhoa[Mã Khoa] from lop where malop like '%" + txtbTuKhoa.Text + "%'";
                }
                else if (cbTim.SelectedItem.ToString() == "Tên Lớp")
                {
                    kq = "select malop[Mã Lớp], tenlop[Tên Lớp], makhoa[Mã Khoa] from lop where tenlop like '%" + txtbTuKhoa.Text + "%'";
                }
                else if (cbTim.SelectedItem.ToString() == "Mã Khoa")
                {
                    kq = "select malop[Mã Lớp], tenlop[Tên Lớp], makhoa[Mã Khoa] from lop where makhoa like '%" + txtbTuKhoa.Text + "%'";
                }

                DataSet ds1 = new DataSet();
                SqlDataAdapter dt = new SqlDataAdapter(kq, conn);
                dt.Fill(ds1);
                dgv_TimKiemLop.DataSource = ds1.Tables[0];
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
            string strsql = "select malop[Mã Lớp], tenlop[Tên Lớp], makhoa[Mã Khoa] from lop";
            DataSet dtset = new DataSet();
            SqlDataAdapter dtadapter = new SqlDataAdapter(strsql, conn);
            dtadapter.Fill(dtset);
            dgv_TimKiemLop.DataSource = dtset.Tables[0];
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetupDataGridView()
        {
            dgv_TimKiemLop.Columns["Mã Lớp"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_TimKiemLop.Columns["Tên Lớp"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_TimKiemLop.Columns["Mã Khoa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_TimKiemLop.Columns["Tên Lớp"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_TimKiemLop.Columns["Mã Khoa"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgv_TimKiemLop.DataBindingComplete += dgv_TimKiemLop_DataBindingComplete;
            dgv_TimKiemLop.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            dgv_TimKiemLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_TimKiemLop.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgv_TimKiemLop_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgv_TimKiemLop.Columns)
            {
                column.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10);
            }
        }
    }
}
