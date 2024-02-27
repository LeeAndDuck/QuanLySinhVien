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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLySinhVien
{
    public partial class DangNhap : Form
    {
        private string _username;
        private bool isAdminLoggedIn = false;
        private bool isUserLoggedIn = false;
        private bool isGvLoggedIn = false;
        private bool isTruongKhoaLoggedIn = false;
        int sai = 5;
        SqlConnection conn;
        private string userType;
        public DangNhap()
        {
            InitializeComponent();
            conn = Connection.GetConnection();
        }

        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string tk = txtbUser.Text;
            string mk = txtbPass.Text;
            _username = txtbUser.Text;
            if(tk.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản!", "Đăng nhập",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtbPass.Clear();
                this.txtbUser.Focus();
                return;
            }
            else if(mk.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!", "Đăng nhập",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtbUser.Clear();
                this.txtbUser.Focus();
                return;
            }

            string errorMessage;
            if (CheckLogin(tk, mk, out errorMessage))
            {
                if (isAdminLoggedIn)
                {
                    MessageBox.Show($"Đăng nhập thành công với tài khoản {userType}!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainMenu form1 = new MainMenu();
                    form1.SetWelcomeMessage(_username);
                    form1.ShowDialog();
                    isAdminLoggedIn = false;
                }
                if(isUserLoggedIn)
                {
                    MessageBox.Show($"Đăng nhập thành công với tài khoản {userType}!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainMenu form1 = new MainMenu();
                    form1.SetWelcomeMessage(_username);
                    form1.IsUserLoggedIn = true;
                    form1.ShowDialog();
                    isUserLoggedIn = false;
                }
                if (isGvLoggedIn)
                {
                    MessageBox.Show($"Đăng nhập thành công với tài khoản {userType}!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainMenu form1 = new MainMenu();
                    form1.SetWelcomeMessage(_username);
                    form1.IsGvLoggedIn = true;
                    form1.ShowDialog();
                    isGvLoggedIn = false;
                }
                if(isTruongKhoaLoggedIn)
                {
                    MessageBox.Show($"Đăng nhập thành công với tài khoản {userType}!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainMenu form1 = new MainMenu();
                    form1.SetWelcomeMessage(_username);
                    form1.IsTruongKhoaLoggedIn = true;
                    form1.ShowDialog();
                    isTruongKhoaLoggedIn = false;
                }
            }
            else
            {
                sai = sai - 1;
                MessageBox.Show($"Đăng nhập thất bại. {errorMessage} Bạn còn "+sai+" lần đăng nhập!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtbUser.Clear();
                this.txtbPass.Clear();
                this.txtbUser.Focus();
                if (sai == 0)
                {
                    MessageBox.Show("Đã Hết Lượt Truy Cập . Mời Bạn Đăng Nhập Lại!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private bool CheckLogin(string tk, string mk, out string errorMessage)
        {
            errorMessage = string.Empty;

            using (SqlConnection conn = Connection.GetConnection())
            {
                conn.Open();

                using (SqlCommand adminCmd = new SqlCommand("SELECT * FROM admin WHERE tk = @tk AND mk = @mk", conn))
                {
                    adminCmd.Parameters.AddWithValue("@tk", tk);
                    adminCmd.Parameters.AddWithValue("@mk", mk);

                    using (SqlDataReader adminReader = adminCmd.ExecuteReader())
                    {
                        if (adminReader.Read())
                        {
                            userType = "admin";
                            isAdminLoggedIn = true;
                            return true;
                        }
                    }
                }

                using (SqlCommand userCmd = new SqlCommand("SELECT * FROM nguoidung WHERE tk = @tk AND mk = @mk", conn))
                {
                    userCmd.Parameters.AddWithValue("@tk", tk);
                    userCmd.Parameters.AddWithValue("@mk", mk);

                    using (SqlDataReader userReader = userCmd.ExecuteReader())
                    {
                        if (userReader.Read())
                        {
                            userType = "người dùng";
                            isUserLoggedIn = true;
                            return true;
                        }
                    }
                }

                using (SqlCommand gvCmd = new SqlCommand("SELECT * FROM gv WHERE tk = @tk AND mk = @mk", conn))
                {
                    gvCmd.Parameters.AddWithValue("@tk", tk);
                    gvCmd.Parameters.AddWithValue("@mk", mk);

                    using (SqlDataReader gvReader = gvCmd.ExecuteReader())
                    {
                        if (gvReader.Read())
                        {
                            userType = "giáo viên";
                            isGvLoggedIn = true;
                            return true;
                        }
                    }
                }

                using (SqlCommand truongkhoaCmd = new SqlCommand("SELECT * FROM truongkhoa WHERE tk = @tk AND mk = @mk", conn))
                {
                    truongkhoaCmd.Parameters.AddWithValue("@tk", tk);
                    truongkhoaCmd.Parameters.AddWithValue("@mk", mk);

                    using (SqlDataReader truongkhoaReader = truongkhoaCmd.ExecuteReader())
                    {
                        if (truongkhoaReader.Read())
                        {
                            userType = "trưởng khoa";
                            isTruongKhoaLoggedIn = true;
                            return true;
                        }
                    }
                }
                conn.Close();
            }
            errorMessage = "Tài khoản hoặc mật khẩu không đúng.";
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            txtbPass.UseSystemPasswordChar = !cBoxPass.Checked;
        }
    }
}
