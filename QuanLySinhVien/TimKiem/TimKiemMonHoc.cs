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
    public partial class TimKiemMonHoc : Form
    {
        SqlConnection conn;
        public TimKiemMonHoc()
        {
            InitializeComponent();
            conn = Connection.GetConnection();
        }

        private void TimKiemMonHoc_Load(object sender, EventArgs e)
        {
            String strsql;
            strsql = "select mamh[Mã Môn Học], tenmh[Tên Môn Học], sotiet[Số Tiết], magv[Mã Giáo Viên] from monhoc";
            DataSet dtset = new DataSet();
            SqlDataAdapter dtaAdapter = new SqlDataAdapter(strsql, conn);
            dtaAdapter.Fill(dtset);
            this.dgv_TimKiemMonHoc.DataSource = dtset.Tables[0];
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

                if (cbTim.SelectedItem.ToString() == "Mã Môn Học")
                {
                    string mamh = "select count(*) from monhoc where mamh like '%" + txtbTuKhoa.Text + "%'";
                    tim = new SqlCommand(mamh, conn);
                    int count = (int)tim.ExecuteScalar();

                    if (count > 0)
                    {
                        kt = true;
                    }
                }
                else if (cbTim.SelectedItem.ToString() == "Tên Môn Học")
                {
                    string tenmh = "select count(*) from monhoc where tenmh like '%" + txtbTuKhoa.Text + "%'";
                    tim = new SqlCommand(tenmh, conn);
                    int count = (int)tim.ExecuteScalar();

                    if (count > 0)
                    {
                        kt = true;
                    }
                }
                else if (cbTim.SelectedItem.ToString() == "Số Tiết")
                {
                    string sotiet = "select count(*) from monhoc where sotiet like '%" + txtbTuKhoa.Text + "%'";
                    tim = new SqlCommand(sotiet, conn);
                    int count = (int)tim.ExecuteScalar();

                    if (count > 0)
                    {
                        kt = true;
                    }
                }
                else if (cbTim.SelectedItem.ToString() == "Mã Giáo Viên")
                {
                    string magv = "select count(*) from monhoc where magv like '%" + txtbTuKhoa.Text + "%'";
                    tim = new SqlCommand(magv, conn);
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

                if (cbTim.SelectedItem.ToString() == "Mã Môn Học")
                {
                    kq = "select mamh[Mã Môn Học], tenmh[Tên Môn Học], sotiet[Số Tiết], magv[Mã Giáo Viên] from monhoc where mamh like '%" + txtbTuKhoa.Text + "%'";
                }
                else if (cbTim.SelectedItem.ToString() == "Tên Môn Học")
                {
                    kq = "select mamh[Mã Môn Học], tenmh[Tên Môn Học], sotiet[Số Tiết], magv[Mã Giáo Viên] from monhoc where tenmh like '%" + txtbTuKhoa.Text + "%'";
                }
                else if (cbTim.SelectedItem.ToString() == "Số Tiết")
                {
                    kq = "select mamh[Mã Môn Học], tenmh[Tên Môn Học], sotiet[Số Tiết], magv[Mã Giáo Viên] from monhoc where sotiet like '%" + txtbTuKhoa.Text + "%'";
                }
                else if (cbTim.SelectedItem.ToString() == "Mã Giáo Viên")
                {
                    kq = "select mamh[Mã Môn Học], tenmh[Tên Môn Học], sotiet[Số Tiết], magv[Mã Giáo Viên] from monhoc where magv like '%" + txtbTuKhoa.Text + "%'";
                }

                DataSet ds1 = new DataSet();
                SqlDataAdapter dt = new SqlDataAdapter(kq, conn);
                dt.Fill(ds1);
                dgv_TimKiemMonHoc.DataSource = ds1.Tables[0];
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
            string strsql = "select mamh[Mã Môn Học], tenmh[Tên Môn Học], sotiet[Số Tiết], magv[Mã Giáo Viên] from monhoc";
            DataSet dtset = new DataSet();
            SqlDataAdapter dtadapter = new SqlDataAdapter(strsql, conn);
            dtadapter.Fill(dtset);
            dgv_TimKiemMonHoc.DataSource = dtset.Tables[0];
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetupDataGridView()
        {
            dgv_TimKiemMonHoc.Columns["Mã Môn Học"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_TimKiemMonHoc.Columns["Tên Môn Học"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_TimKiemMonHoc.Columns["Số Tiết"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_TimKiemMonHoc.Columns["Mã Giáo Viên"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_TimKiemMonHoc.Columns["Tên Môn Học"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgv_TimKiemMonHoc.DataBindingComplete += dgv_TimKiemMonHoc_DataBindingComplete;
            dgv_TimKiemMonHoc.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            dgv_TimKiemMonHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_TimKiemMonHoc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgv_TimKiemMonHoc_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgv_TimKiemMonHoc.Columns)
            {
                column.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10);
            }
        }
    }
}
