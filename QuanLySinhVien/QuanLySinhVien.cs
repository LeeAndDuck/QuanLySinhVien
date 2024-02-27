using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class QuanLySinhVien : Form
    {
        public QuanLySinhVien()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lb_truong.Left >= -this.Width)
                lb_truong.Left = lb_truong.Left - 10;
            else
                lb_truong.Left = lb_truong.Width;
        }


        private void btn_tt_Click(object sender, EventArgs e)
        {
            string tt;
            tt = "Phần mềm: QUẢN LÝ SINH VIÊN\n";
            tt += "\n";
            tt += "Version: 1.0\n";
            tt += "\n";
            tt += "Học phần thực tập:\n\n";
            tt += "Lập trình hướng cơ sở dữ liệu\n";
            tt += "\n\n";
            tt += "Copyright @ năm 2023\n";
            tt += "Designer by: Lê Anh Đức\n";
            tt += "Email: laduc.dhti14a2cl@gmail.com\n";
            MessageBox.Show((tt), "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            DangKy dangky = new DangKy();
            dangky.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            string tt;
            tt = "Phần mềm: QUẢN LÝ SINH VIÊN\n";
            tt += "\n";
            tt += "Version: 1.0\n";
            tt += "\n";
            tt += "Học phần thực tập:\n\n";
            tt += "Lập trình hướng cơ sở dữ liệu\n";
            tt += "\n\n";
            tt += "Copyright @ năm 2023\n";
            tt += "Designer by: Lê Anh Đức\n";
            tt += "Email: laduc.dhti14a2cl@gmail.com\n";
            MessageBox.Show((tt), "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
