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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string tk = txtbUser.Text;
            string mk = txtbPass.Text;
            string reMk = txtbPass_Nhaplai.Text;

            if (tk.Trim() == "" || mk.Trim() == "" || reMk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbUser.Focus();
                return;
            }

            if (mk != reMk)
            {
                MessageBox.Show("Mật khẩu và mật khẩu nhập lại không giống nhau!", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbPass.Clear();
                txtbPass_Nhaplai.Clear();
                txtbPass.Focus();
                return;
            }

            bool success = RegisterNewUser(tk, mk);

            if (success)
            {
                MessageBox.Show("Đăng ký thành công!", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại. Vui lòng kiểm tra lại thông tin đăng ký.", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool RegisterNewUser(string tk, string mk)
        {
            try
            {
                using (SqlConnection conn = Connection.GetConnection())
                {
                    conn.Open();

                    // Kiểm tra xem tài khoản đã tồn tại chưa
                    using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM nguoidung WHERE tk = @tk", conn))
                    {
                        checkCmd.Parameters.AddWithValue("@tk", tk);
                        int existingCount = (int)checkCmd.ExecuteScalar();

                        if (existingCount > 0)
                        {
                            MessageBox.Show("Tài khoản đã tồn tại. Vui lòng chọn tên tài khoản khác!", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false; // Đăng ký thất bại
                        }
                    }

                    // Nếu tài khoản chưa tồn tại, thêm vào bảng nguoidung
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO nguoidung (tk, mk) VALUES (@tk, @mk)", conn))
                    {
                        cmd.Parameters.AddWithValue("@tk", tk);
                        cmd.Parameters.AddWithValue("@mk", mk);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return true; // Đăng ký thành công
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false; // Đăng ký thất bại do lỗi
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            txtbPass.UseSystemPasswordChar = !cBoxPass.Checked;
            txtbPass_Nhaplai.UseSystemPasswordChar= !cBoxPass.Checked;
        }
    }
}
