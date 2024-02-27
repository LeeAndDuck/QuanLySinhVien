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
    public partial class QuanLyTaiKhoanTruongKhoa : Form
    {
        SqlConnection conn;
        public QuanLyTaiKhoanTruongKhoa()
        {
            InitializeComponent();
            conn = Connection.GetConnection();
        }

        private void QuanLyTaiKhoanTruongKhoa_Load(object sender, EventArgs e)
        {
            String strsql;
            strsql = "select tk[Tên Tài Khoản],mk[Mật Khẩu] from truongkhoa";
            DataSet dtset = new DataSet();
            SqlDataAdapter dtadapter = new SqlDataAdapter(strsql, conn);
            dtadapter.Fill(dtset);
            this.Dgv_truongkhoa.DataSource = dtset.Tables[0];
            SetupDataGridView();
        }

        private void Btn_nhaplai_Click(object sender, EventArgs e)
        {
            Tbx_ten.Clear();
            Tbx_mk.Clear();
        }

        private void Btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                conn = Connection.GetConnection();
                conn.Open();
                string s = "insert into truongkhoa values ('" + Tbx_ten.Text + "','" + Tbx_mk.Text + "')";
                SqlCommand com = new SqlCommand(s, conn);
                com.ExecuteNonQuery();
                com.Dispose();
                string sql = "select tk[Tên Tài Khoản],mk[Mật Khẩu] from truongkhoa ";
                DataSet ds = new DataSet();
                SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
                dt.Fill(ds);
                this.Dgv_truongkhoa.DataSource = ds.Tables[0];
                ds.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu đã tồn tại! Vui lòng nhập lại !!", "Báo lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void Btn_sua_Click(object sender, EventArgs e)
        {
            conn = Connection.GetConnection();
            conn.Open();
            SqlCommand s;
            string strsql;
            strsql = "update truongkhoa set mk='" + Tbx_mk.Text + "' where tk = '" + Tbx_ten.Text + "'";
            s = new SqlCommand(strsql, conn);
            s.ExecuteNonQuery();
            string sql = "select tk[Tên Tài Khoản],mk[Mật Khẩu] from truongkhoa";
            DataSet ds = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            dataAdapter.Fill(ds);
            this.Dgv_truongkhoa.DataSource = ds.Tables[0];
            ds.Dispose();
        }

        private void Btn_xoa_Click(object sender, EventArgs e)
        {
            conn = Connection.GetConnection();
            conn.Open();
            SqlCommand s;
            string strsql;
            strsql = "delete from truongkhoa where tk = '" + Tbx_ten.Text + "'";
            s = new SqlCommand(strsql, conn);
            s.ExecuteNonQuery();
            string sql = "select tk[Tên Tài Khoản],mk[Mật Khẩu] from truongkhoa";
            DataSet ds = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            dataAdapter.Fill(ds);
            this.Dgv_truongkhoa.DataSource = ds.Tables[0];
            ds.Dispose();

        }

        private void SetupDataGridView()
        {
            Dgv_truongkhoa.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dgv_truongkhoa.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            Dgv_truongkhoa.DataBindingComplete += Dgv_truongkhoa_DataBindingComplete;
            Dgv_truongkhoa.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            Dgv_truongkhoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_truongkhoa.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void Dgv_truongkhoa_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in Dgv_truongkhoa.Columns)
            {
                column.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10);
            }
        }

        private void Dgv_truongkhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Tbx_ten.Text = Dgv_truongkhoa.Rows[e.RowIndex].Cells[0].Value.ToString();
                Tbx_mk.Text = Dgv_truongkhoa.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}
