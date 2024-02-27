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

    public partial class DoiMatKhau : Form
    {
        SqlConnection conn;

        public DoiMatKhau()
        {
            InitializeComponent();
            conn = Connection.GetConnection();
            btn_Doi.Enabled = false;

        }
        private bool AreAllFieldsFilled()
        {
            return !string.IsNullOrWhiteSpace(txtbUser.Text) &&
                   !string.IsNullOrWhiteSpace(txtbPass_old.Text) &&
                   !string.IsNullOrWhiteSpace(txtbPass_new.Text) &&
                   !string.IsNullOrWhiteSpace(txtbNhapLaiPass.Text);
        }
        private void EnableDisableDoiButton()
        {
            // Enable or disable the "Đổi" button based on the state of all fields
            btn_Doi.Enabled = AreAllFieldsFilled();
        }
        private void btn_Doi_Click(object sender, EventArgs e)
        {
            conn.Open();
            String d = txtbPass_new.Text;
            String b = txtbNhapLaiPass.Text;
            String tentk = txtbUser.Text;
            String matkhau = txtbPass_old.Text;
            if(d == matkhau)
            {
                MessageBox.Show("Mật khẩu mới giống mật khẩu cũ! ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            String taikhoan = "select count(*) from admin where tk= '" + txtbUser.Text + "' and mk = '" + txtbPass_old.Text + "'";
            SqlCommand cmd = new SqlCommand(taikhoan, conn);
            int tk = (int)cmd.ExecuteScalar();
            cmd.Dispose();

            String tku = "select count(*) from nguoidung where tk= '" + txtbUser.Text + "' and mk = '" + txtbPass_old.Text + "'";
            SqlCommand cm = new SqlCommand(tku, conn);
            int a = (int)cm.ExecuteScalar();
            cm.Dispose();

            String tkgv = "select count(*) from gv where tk= '" + txtbUser.Text + "' and mk = '" + txtbPass_old.Text + "'";
            SqlCommand c = new SqlCommand(tkgv, conn);
            int gv = (int)c.ExecuteScalar();
            c.Dispose();
            String tktk = "select count(*) from truongkhoa where tk= '" + txtbUser.Text + "' and mk = '" + txtbPass_old.Text + "'";
            SqlCommand cmdtk = new SqlCommand(tktk, conn);
            int truongkhoa = (int)cmd.ExecuteScalar();
            cmdtk.Dispose();


            if (tk > 0)
            {
                try
                {
                    if (d == b)
                    {
                        SqlCommand s;
                        String strsql;
                        strsql = "update admin set mk='" + txtbPass_new.Text + "' where tk= '" + txtbUser.Text + "'";
                        s = new SqlCommand(strsql, conn);
                        s.ExecuteNonQuery();
                        MessageBox.Show("Bạn đã đổi mật khẩu thành công! Phần mềm sẽ tự đống lại mời bạn đăng nhập lại bằng mật khẩu mới ! ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu nhập lại không khớp ! ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception )
                {
                    MessageBox.Show("Thao tác không thực hiện được. Vui lòng kiểm tra lại! ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close(); // Make sure to close the connection in a finally block
                    }

                    Application.Restart();
                }
            }
            else if (gv > 0)
            {
                try
                {
                    if (d == b)
                    {
                        SqlCommand q;
                        String strsql2;
                        strsql2 = "update gv set mk='" + txtbPass_new.Text + "' where tk= '" + txtbUser.Text + "'";
                        q = new SqlCommand(strsql2, conn);
                        q.ExecuteNonQuery();
                        MessageBox.Show("Bạn đã đổi mật khẩu thành công! Phần mềm sẽ tự đống lại mời bạn đăng nhập lại bằng mật khẩu mới !", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu nhập lại không khớp ! ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception )
                {
                    MessageBox.Show("Thao tác không thực hiện được. Vui lòng kiểm tra lại! ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close(); // Make sure to close the connection in a finally block
                    }

                    Application.Restart();
                }
            }
            else if (a > 0)
            {
                try
                {
                    if (d == b)
                    {
                        SqlCommand l;
                        String strsql3;
                        strsql3 = "update nguoidung set mk='" + txtbPass_new.Text + "' where tk= '" + txtbUser.Text + "'";
                        l = new SqlCommand(strsql3, conn);
                        l.ExecuteNonQuery();
                        MessageBox.Show("Bạn đã đổi mật khẩu thành công! ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu nhập lại không khớp ! ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception )
                {
                    MessageBox.Show("Thao tác không thực hiện được. Vui lòng kiểm tra lại! ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close(); // Make sure to close the connection in a finally block
                    }

                    Application.Restart();
                }
            }
            else if (truongkhoa > 0)
            {
                try
                {
                    if (d == b)
                    {
                        SqlCommand o;
                        String strsql4;
                        strsql4 = "update truongkhoa set mk='" + txtbPass_new.Text + "' where tk= '" + txtbUser.Text + "'";
                        o = new SqlCommand(strsql4, conn);
                        o.ExecuteNonQuery();
                        MessageBox.Show("Bạn đã đổi mật khẩu thành công! Phần mềm sẽ tự đóng lại! Mời bạn đăng nhập lại bằng mật khẩu mới ! ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu nhập lại không khớp ! ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception )
                {
                    MessageBox.Show("Thao tác không thực hiện được. Vui lòng kiểm tra lại! ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close(); // Make sure to close the connection in a finally block
                    }

                    Application.Restart();
                }

            }
        }

        private void cBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            txtbNhapLaiPass.UseSystemPasswordChar = !cBoxPass.Checked;
            txtbPass_new.UseSystemPasswordChar = !cBoxPass.Checked;
            txtbPass_old.UseSystemPasswordChar = !cBoxPass.Checked;
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbUser_TextChanged_1(object sender, EventArgs e)
        {
            EnableDisableDoiButton();
        }

        private void txtbPass_old_TextChanged_1(object sender, EventArgs e)
        {
            EnableDisableDoiButton();
        }

        private void txtbPass_new_TextChanged(object sender, EventArgs e)
        {
            EnableDisableDoiButton();
        }

        private void txtbNhapLaiPass_TextChanged_1(object sender, EventArgs e)
        {
            EnableDisableDoiButton();
        }
    }
}

