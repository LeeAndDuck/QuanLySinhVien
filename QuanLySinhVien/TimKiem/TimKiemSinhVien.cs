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
    public partial class TimKiemSinhVien : Form
    {
        SqlConnection conn;
        public TimKiemSinhVien()
        {
            InitializeComponent();
            conn = Connection.GetConnection();
        }

        private void TimKiemSinhVien_Load(object sender, EventArgs e)
        {
            String strsql;
            strsql = "select masv[Mã Sinh Viên], tensv[Tên Sinh Viên], gioitinh[Giới Tính], ngaysinh[Ngày Sinh], sdt[Số Điện Thoại], " +
                "diachi[Địa Chỉ], macs[Mã Chính Sách], malop[Mã Lớp] from sinhvien";
            DataSet dtset = new DataSet();
            SqlDataAdapter dtaAdapter = new SqlDataAdapter(strsql, conn);
            dtaAdapter.Fill(dtset);
            this.dgv_TimKiemSinhVien.DataSource = dtset.Tables[0];
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

                if (cbTim.SelectedItem.ToString() == "Mã Sinh Viên")
                {
                    string masv = "select count(*) from sinhvien where masv like '%" + txtbTuKhoa.Text + "%'";
                    tim = new SqlCommand(masv, conn);
                    int count = (int)tim.ExecuteScalar();

                    if (count > 0)
                    {
                        kt = true;
                    }
                }
                else if (cbTim.SelectedItem.ToString() == "Tên Sinh Viên")
                {
                    string tensv = "select count(*) from sinhvien where tensv like '%" + txtbTuKhoa.Text + "%'";
                    tim = new SqlCommand(tensv, conn);
                    int count = (int)tim.ExecuteScalar();

                    if (count > 0)
                    {
                        kt = true;
                    }
                }
                else if (cbTim.SelectedItem.ToString() == "Giới Tính")
                {
                    string gioitinh = "select count(*) from sinhvien where gioitinh like '%" + txtbTuKhoa.Text + "%'";
                    tim = new SqlCommand(gioitinh, conn);
                    int count = (int)tim.ExecuteScalar();

                    if (count > 0)
                    {
                        kt = true;
                    }
                }
                else if (cbTim.SelectedItem.ToString() == "Ngày Sinh")
                {
                    string ngaysinh = "select count(*) from sinhvien where ngaysinh like '%" + txtbTuKhoa.Text + "%'";
                    tim = new SqlCommand(ngaysinh, conn);
                    int count = (int)tim.ExecuteScalar();

                    if (count > 0)
                    {
                        kt = true;
                    }
                }
                else if (cbTim.SelectedItem.ToString() == "Số Điện Thoại")
                {
                    string sdt = "select count(*) from sinhvien where sdt like '%" + txtbTuKhoa.Text + "%'";
                    tim = new SqlCommand(sdt, conn);
                    int count = (int)tim.ExecuteScalar();

                    if (count > 0)
                    {
                        kt = true;
                    }
                }
                else if (cbTim.SelectedItem.ToString() == "Địa Chỉ")
                {
                    string diachi = "select count(*) from sinhvien where diachi like '%" + txtbTuKhoa.Text + "%'";
                    tim = new SqlCommand(diachi, conn);
                    int count = (int)tim.ExecuteScalar();

                    if (count > 0)
                    {
                        kt = true;
                    }
                }
                else if (cbTim.SelectedItem.ToString() == "Mã Chính Sách")
                {
                    string macs = "select count(*) from sinhvien where macs like '%" + txtbTuKhoa.Text + "%'";
                    tim = new SqlCommand(macs, conn);
                    int count = (int)tim.ExecuteScalar();

                    if (count > 0)
                    {
                        kt = true;
                    }
                }
                else if (cbTim.SelectedItem.ToString() == "Mã Lớp")
                {
                    string malop = "select count(*) from sinhvien where malop like '%" + txtbTuKhoa.Text + "%'";
                    tim = new SqlCommand(malop, conn);
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

                if (cbTim.SelectedItem.ToString() == "Mã Sinh Viên")
                {
                    kq = "select masv[Mã Sinh Viên], tensv[Tên Sinh Viên], gioitinh[Giới Tính], ngaysinh[Ngày Sinh], sdt[Số Điện Thoại], diachi[Địa Chỉ], macs[Mã Chính Sách], malop[Mã Lớp] from sinhvien where masv like '%" + txtbTuKhoa.Text + "%'";
                }
                if (cbTim.SelectedItem.ToString() == "Tên Sinh Viên")
                {
                    kq = "select masv[Mã Sinh Viên], tensv[Tên Sinh Viên], gioitinh[Giới Tính], ngaysinh[Ngày Sinh], sdt[Số Điện Thoại], diachi[Địa Chỉ], macs[Mã Chính Sách], malop[Mã Lớp] from sinhvien where tensv like '%" + txtbTuKhoa.Text + "%'";
                }
                if (cbTim.SelectedItem.ToString() == "Giới Tính")
                {
                    kq = "select masv[Mã Sinh Viên], tensv[Tên Sinh Viên], gioitinh[Giới Tính], ngaysinh[Ngày Sinh], sdt[Số Điện Thoại], diachi[Địa Chỉ], macs[Mã Chính Sách], malop[Mã Lớp] from sinhvien where gioitinh like '%" + txtbTuKhoa.Text + "%'";
                }
                if (cbTim.SelectedItem.ToString() == "Ngày Sinh")
                {
                    kq = "select masv[Mã Sinh Viên], tensv[Tên Sinh Viên], gioitinh[Giới Tính], ngaysinh[Ngày Sinh], sdt[Số Điện Thoại], diachi[Địa Chỉ], macs[Mã Chính Sách], malop[Mã Lớp] from sinhvien where ngaysinh like '%" + txtbTuKhoa.Text + "%'";
                }
                if (cbTim.SelectedItem.ToString() == "Số Điện Thoại")
                {
                    kq = "select masv[Mã Sinh Viên], tensv[Tên Sinh Viên], gioitinh[Giới Tính], ngaysinh[Ngày Sinh], sdt[Số Điện Thoại], diachi[Địa Chỉ], macs[Mã Chính Sách], malop[Mã Lớp] from sinhvien where sdt like '%" + txtbTuKhoa.Text + "%'";
                }
                if (cbTim.SelectedItem.ToString() == "Địa Chỉ")
                {
                    kq = "select masv[Mã Sinh Viên], tensv[Tên Sinh Viên], gioitinh[Giới Tính], ngaysinh[Ngày Sinh], sdt[Số Điện Thoại], diachi[Địa Chỉ], macs[Mã Chính Sách], malop[Mã Lớp] from sinhvien where diachi like '%" + txtbTuKhoa.Text + "%'";
                }
                if (cbTim.SelectedItem.ToString() == "Mã Chính Sách")
                {
                    kq = "select masv[Mã Sinh Viên], tensv[Tên Sinh Viên], gioitinh[Giới Tính], ngaysinh[Ngày Sinh], sdt[Số Điện Thoại], diachi[Địa Chỉ], macs[Mã Chính Sách], malop[Mã Lớp] from sinhvien where macs like '%" + txtbTuKhoa.Text + "%'";
                }
                if (cbTim.SelectedItem.ToString() == "Mã Lớp")
                {
                    kq = "select masv[Mã Sinh Viên], tensv[Tên Sinh Viên], gioitinh[Giới Tính], ngaysinh[Ngày Sinh], sdt[Số Điện Thoại], diachi[Địa Chỉ], macs[Mã Chính Sách], malop[Mã Lớp] from sinhvien where malop like '%" + txtbTuKhoa.Text + "%'";
                }

                DataSet ds1 = new DataSet();
                SqlDataAdapter dt = new SqlDataAdapter(kq, conn);
                dt.Fill(ds1);
                dgv_TimKiemSinhVien.DataSource = ds1.Tables[0];
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
            string strsql = "select masv[Mã Sinh Viên], tensv[Tên Sinh Viên], gioitinh[Giới Tính], ngaysinh[Ngày Sinh], sdt[Số Điện Thoại], " +
                "diachi[Địa Chỉ], macs[Mã Chính Sách], malop[Mã Lớp] from sinhvien";
            DataSet dtset = new DataSet();
            SqlDataAdapter dtadapter = new SqlDataAdapter(strsql, conn);
            dtadapter.Fill(dtset);
            dgv_TimKiemSinhVien.DataSource = dtset.Tables[0];
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetupDataGridView()
        {
            dgv_TimKiemSinhVien.Columns["Mã Sinh Viên"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_TimKiemSinhVien.Columns["Tên Sinh Viên"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_TimKiemSinhVien.Columns["Giới Tính"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_TimKiemSinhVien.Columns["Ngày Sinh"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_TimKiemSinhVien.Columns["Số Điện Thoại"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_TimKiemSinhVien.Columns["Địa Chỉ"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_TimKiemSinhVien.Columns["Mã Chính Sách"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_TimKiemSinhVien.Columns["Mã Lớp"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv_TimKiemSinhVien.Columns["Địa Chỉ"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgv_TimKiemSinhVien.DataBindingComplete += dgv_TimKiemSinhVien_DataBindingComplete;
            dgv_TimKiemSinhVien.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            dgv_TimKiemSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_TimKiemSinhVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgv_TimKiemSinhVien_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgv_TimKiemSinhVien.Columns)
            {
                column.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10);
            }
        }
    }
}
