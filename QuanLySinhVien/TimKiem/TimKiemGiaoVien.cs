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
    public partial class TimKiemGiaoVien : Form
    {
        SqlConnection conn;
        public TimKiemGiaoVien()
        {
            InitializeComponent();
            conn = Connection.GetConnection();
        }

        private void TimKiemGiaoVien_Load(object sender, EventArgs e)
        {
            String strsql;
            strsql = "select magv[Mã GV], tengv[Tên GV], gioitinh[Giới Tính], ngaysinh[Ngày Sinh], sdt[Số Điện Thoại], diachi[Địa Chỉ] from giaovien";
            DataSet dtset = new DataSet();
            SqlDataAdapter dtaAdapter = new SqlDataAdapter(strsql, conn);
            dtaAdapter.Fill(dtset);
            this.dgv_TimKiemGiaoVien.DataSource = dtset.Tables[0];
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

                if (cbTim.SelectedItem.ToString() == "Mã Giáo Viên")
                {
                    string magv = "select count(*) from giaovien where magv like '%" + txtbTuKhoa.Text + "%'";
                    tim = new SqlCommand(magv, conn);
                    int count = (int)tim.ExecuteScalar();

                    if (count > 0)
                    {
                        kt = true;
                    }
                }
                else if (cbTim.SelectedItem.ToString() == "Tên Giáo Viên")
                {
                    string tengv = "select count(*) from giaovien where tengv like '%" + txtbTuKhoa.Text + "%'";
                    tim = new SqlCommand(tengv, conn);
                    int count = (int)tim.ExecuteScalar();

                    if (count > 0)
                    {
                        kt = true;
                    }
                }
                else if (cbTim.SelectedItem.ToString() == "Giới Tính")
                {
                    string gioitinh = "select count(*) from giaovien where gioitinh like '%" + txtbTuKhoa.Text + "%'";
                    tim = new SqlCommand(gioitinh, conn);
                    int count = (int)tim.ExecuteScalar();

                    if (count > 0)
                    {
                        kt = true;
                    }
                }
                else if (cbTim.SelectedItem.ToString() == "Ngày Sinh")
                {
                    string ngaysinh = "select count(*) from giaovien where ngaysinh like '%" + txtbTuKhoa.Text + "%'";
                    tim = new SqlCommand(ngaysinh, conn);
                    int count = (int)tim.ExecuteScalar();

                    if (count > 0)
                    {
                        kt = true;
                    }
                }
                else if (cbTim.SelectedItem.ToString() == "Số Điện Thoại")
                {
                    string sdt = "select count(*) from giaovien where sdt like '%" + txtbTuKhoa.Text + "%'";
                    tim = new SqlCommand(sdt, conn);
                    int count = (int)tim.ExecuteScalar();

                    if (count > 0)
                    {
                        kt = true;
                    }
                }
                else if (cbTim.SelectedItem.ToString() == "Địa Chỉ")
                {
                    string diachi = "select count(*) from giaovien where diachi like '%" + txtbTuKhoa.Text + "%'";
                    tim = new SqlCommand(diachi, conn);
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

                if (cbTim.SelectedItem.ToString() == "Mã Giáo Viên")
                {
                    kq = "select magv[Mã GV], tengv[Tên GV], gioitinh[Giới Tính], ngaysinh[Ngày Sinh], sdt[Số Điện Thoại], diachi[Địa Chỉ] from giaovien where magv like '%" + txtbTuKhoa.Text + "%'";
                }
                else if (cbTim.SelectedItem.ToString() == "Tên Giáo Viên")
                {
                    kq = "select magv[Mã GV], tengv[Tên GV], gioitinh[Giới Tính], ngaysinh[Ngày Sinh], sdt[Số Điện Thoại], diachi[Địa Chỉ] from giaovien where tengv like '%" + txtbTuKhoa.Text + "%'";
                }
                else if (cbTim.SelectedItem.ToString() == "Giới Tính")
                {
                    kq = "select magv[Mã GV], tengv[Tên GV], gioitinh[Giới Tính], ngaysinh[Ngày Sinh], sdt[Số Điện Thoại], diachi[Địa Chỉ] from giaovien where gioitinh like '%" + txtbTuKhoa.Text + "%'";
                }
                if (cbTim.SelectedItem.ToString() == "Ngày Sinh")
                {
                    kq = "select magv[Mã GV], tengv[Tên GV], gioitinh[Giới Tính], ngaysinh[Ngày Sinh], sdt[Số Điện Thoại], diachi[Địa Chỉ] from giaovien where ngaysinh like '%" + txtbTuKhoa.Text + "%'";
                }
                if (cbTim.SelectedItem.ToString() == "Số Điện Thoại")
                {
                    kq = "select magv[Mã GV], tengv[Tên GV], gioitinh[Giới Tính], ngaysinh[Ngày Sinh], sdt[Số Điện Thoại], diachi[Địa Chỉ] from giaovien where sdt like '%" + txtbTuKhoa.Text + "%'";
                }
                if (cbTim.SelectedItem.ToString() == "Địa Chỉ")
                {
                    kq = "select magv[Mã GV], tengv[Tên GV], gioitinh[Giới Tính], ngaysinh[Ngày Sinh], sdt[Số Điện Thoại], diachi[Địa Chỉ] from giaovien where diachi like '%" + txtbTuKhoa.Text + "%'";
                }


                DataSet ds1 = new DataSet();
                SqlDataAdapter dt = new SqlDataAdapter(kq, conn);
                dt.Fill(ds1);
                dgv_TimKiemGiaoVien.DataSource = ds1.Tables[0];
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
            string strsql = "select magv[Mã GV], tengv[Tên GV], gioitinh[Giới Tính], ngaysinh[Ngày Sinh], sdt[Số Điện Thoại], diachi[Địa Chỉ] from giaovien";
            DataSet dtset = new DataSet();
            SqlDataAdapter dtadapter = new SqlDataAdapter(strsql, conn);
            dtadapter.Fill(dtset);
            dgv_TimKiemGiaoVien.DataSource = dtset.Tables[0];
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetupDataGridView()
        {
            dgv_TimKiemGiaoVien.Columns["Mã GV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_TimKiemGiaoVien.Columns["Tên GV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_TimKiemGiaoVien.Columns["Giới Tính"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_TimKiemGiaoVien.Columns["Ngày Sinh"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_TimKiemGiaoVien.Columns["Số Điện Thoại"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_TimKiemGiaoVien.Columns["Địa Chỉ"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_TimKiemGiaoVien.Columns["Địa Chỉ"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;


            dgv_TimKiemGiaoVien.DataBindingComplete += dgv_TimKiemGiaoVien_DataBindingComplete;
            dgv_TimKiemGiaoVien.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgv_TimKiemGiaoVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_TimKiemGiaoVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgv_TimKiemGiaoVien_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgv_TimKiemGiaoVien.Columns)
            {
                column.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10);
            }
        }
    }
}
