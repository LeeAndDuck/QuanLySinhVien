using QuanLySinhVien.CapNhat;
using QuanLySinhVien.ThongTin;
using QuanLySinhVien.TimKiem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLySinhVien
{
    public partial class MainMenu : Form
    {
        private Timer timer;
        private bool isUserLoggedIn;
        private bool isGvLoggedIn;
        private bool isTruongKhoaLoggedIn;
        public MainMenu()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; // Đặt khoảng thời gian cập nhật là 1 giây
            timer.Tick += timer1_Tick;

            // Bắt đầu Timer
            timer.Start();
        }
        public bool IsUserLoggedIn
        {
            set
            {
                isUserLoggedIn = value;
                UpdateUserInterface();
            }
        }

        public bool IsGvLoggedIn
        {
            set
            {
                isGvLoggedIn = value;
                UpdateUserInterface();
            }
        }

        public bool IsTruongKhoaLoggedIn
        {
            set
            {
                isTruongKhoaLoggedIn = value;
                UpdateUserInterface();
            }
        }

        public void SetWelcomeMessage(string username)
        {
            label3.Text = "Xin chào, " + username + "!";
        }

        private void UpdateUserInterface()
        {
            if (isUserLoggedIn && !isGvLoggedIn && !isTruongKhoaLoggedIn)
            {
                Ts_Btn_dangnhap.Visible = false;
                Ts_Btn_admin.Visible = false;
                Ts_Btn_user.Visible = false;
                Ts_Btn_giaovien.Visible = false;
                Ts_Btn_truongkhoa.Visible = false;
                Ts_diem.Visible = false;
                Ts_Btn_quanli.Visible = false;
            }
            if (isGvLoggedIn && !isUserLoggedIn && !isTruongKhoaLoggedIn)
            {
                Ts_Btn_dangnhap.Visible = false;
                Ts_Btn_admin.Visible = false;
                Ts_Btn_user.Visible = false;
                Ts_Btn_giaovien.Visible = false;
                Ts_Btn_truongkhoa.Visible = false;
                Ts_Btn_quanli.Visible = false;
            }
            if (isTruongKhoaLoggedIn && !isUserLoggedIn && !isGvLoggedIn)
            {
                Ts_Btn_dangnhap.Visible = false;
                Ts_Btn_admin.Visible = false;
                Ts_Btn_user.Visible = false;
                Ts_Btn_giaovien.Visible = false;
                Ts_Btn_truongkhoa.Visible = false;
                Ts_diem.Visible = false;
            }
        }

        private void Btn_admin_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoanAdmin f = new QuanLyTaiKhoanAdmin();
            f.ShowDialog();
        }

        private void Btn_user_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoanUser f = new QuanLyTaiKhoanUser();
            f.ShowDialog();
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\system32\\mspaint.exe");
        }

        private void cmdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\system32\\cmd.exe");
        }

        private void noteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\system32\\notepad.exe");
        }

        private void máyTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\system32\\calc.exe");
        }

        private void microsoftWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files\\Microsoft Office\\root\\Office16\\WINWORD.exe");
        }
        private void microsoftExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files\\Microsoft Office\\root\\Office16\\EXCEL.exe");
        }
        private void microsoftPowerpointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files\\Microsoft Office\\root\\Office16\\POWERPNT.exe");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Cập nhật thời gian trên Label
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Btn_giaovien_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoanGiaoVien f = new QuanLyTaiKhoanGiaoVien();
            f.ShowDialog();
        }
        private void Btn_truongkhoa_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoanTruongKhoa f = new QuanLyTaiKhoanTruongKhoa();
            f.ShowDialog();
        }

        private void Btn_dangxuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Btn_ht_100_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.45;
        }

        private void Btn_ht_50_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.8;
        }

        private void Btn_ht_macdinh_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void ts_Btn_LienHe_Click(object sender, EventArgs e)
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

        private void thôngTinToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void cậpNhậtPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đang sử dụng phiên bản mới nhất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_doimatkhau_Click(object sender, EventArgs e)
        {
            DoiMatKhau f = new DoiMatKhau();
            f.ShowDialog();
        }

        private void Btn_ql_khoa_Click(object sender, EventArgs e)
        {
            CapNhatKhoa f = new CapNhatKhoa();
            f.ShowDialog();
        }

        private void Btn_ql_lop_Click(object sender, EventArgs e)
        {
            CapNhatLop f = new CapNhatLop();
            f.ShowDialog();
        }

        private void Btn_ql_monhoc_Click(object sender, EventArgs e)
        {
            CapNhatMonHoc f = new CapNhatMonHoc();
            f.ShowDialog();
        }

        private void Btn_ql_sinhvien_Click(object sender, EventArgs e)
        {
            CapNhatSinhVien f = new CapNhatSinhVien();
            f.ShowDialog();
        }

        private void Btn_ql_giaovien_Click(object sender, EventArgs e)
        {
            CapNhatGiaoVien f = new CapNhatGiaoVien();
            f.ShowDialog();
        }

        private void Btn_ql_chinhsach_Click(object sender, EventArgs e)
        {
            CapNhatChinhSach f = new CapNhatChinhSach();
            f.ShowDialog();
        }

        private void Btn_ql_diem_Click(object sender, EventArgs e)
        {
            CapNhatDiem f = new CapNhatDiem();
            f.ShowDialog();
        }
        private void Ts_diem_Click(object sender, EventArgs e)
        {
            CapNhatDiemSV f = new CapNhatDiemSV();
            f.ShowDialog();
        }

        private string currentLanguage = "Tiếng Việt";
        private void tiếngViệtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentLanguage = "Tiếng Việt";
            UpdateLanguage(); // Gọi hàm cập nhật ngôn ngữ
        }

        private void tiếngAnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentLanguage = "English";
            UpdateLanguage(); // Gọi hàm cập nhật ngôn ngữ
        }

        private void UpdateLanguage()
        {
            // Dựa vào giá trị của currentLanguage để cập nhật ngôn ngữ cho mỗi điều khiển
            if (currentLanguage == "English")
            {
                label1.Text = "Student Management";
                Ts_diem.Text = "Scores";
                Ts_Btn_hethong.Text = "System";
                Ts_Btn_thongtin.Text = "Information";
                Ts_Btn_timkiem.Text = "Search";
                Ts_Btn_quanli.Text = "Management";
                Ts_Btn_hienthi.Text = "Display";
                Ts_Btn_tienich.Text = "Utilities";
                Ts_Btn_khoa.Text = "Lock";
                Ts_Btn_tt_khoa.Text = "Department";
                Ts_Btn_tt_giaovien.Text = "Teacher";
                Ts_Btn_tt_lop.Text = "Class";
                Ts_Btn_tt_sinhvien.Text = "Student";
                Ts_Btn_tt_monhoc.Text = "Subject";
                Ts_Btn_tt_chinhsach.Text = "Policy";
                Ts_Btn_tt_diem.Text = "Scores";
                Ts_Btn_tk_khoa.Text = "Department";
                Ts_Btn_tk_giaovien.Text = "Teacher";
                Ts_Btn_tk_lop.Text = "Class";
                Ts_Btn_tk_sinhvien.Text = "Student";
                Ts_Btn_tk_monhoc.Text = "Subject";
                Ts_Btn_tk_chinhsach.Text = "Policy";
                kiểuXemToolStripMenuItem.Text = "View Mode";
                cậpNhậtPhầnMềnToolStripMenuItem.Text = "Update Software";
                Ts_Btn_ql_khoa.Text = "Department";
                Ts_Btn_ql_giaovien.Text = "Teacher";
                Ts_Btn_ql_lop.Text = "Class";
                Ts_Btn_ql_sinhvien.Text = "Student";
                Ts_Btn_ql_monhoc.Text = "Subject";
                Ts_Btn_ql_chinhsach.Text = "Policy";
                Ts_Btn_ql_diem.Text = "Scores";
                tiếngViệtToolStripMenuItem.Text = "Vietnamese";
                trongSuốtToolStripMenuItem.Text = "Transparency";
                ngônNgữToolStripMenuItem.Text = "Language";
                hỗTrợToolStripMenuItem.Text = "Support";
                ts_Btn_LienHe.Text = "Contact";
                Ts_Btn_admin.Text = "Manage Admin Account";
                Ts_Btn_dangxuat.Text = "Logout";
                Ts_Btn_truongkhoa.Text = "Manage Head of Department Account";
                Ts_Btn_user.Text = "Manage User Account";
                hỗTrợToolStripMenuItem.Text = "Contact";
                thôngTinToolStripMenuItem1.Text = "Information";
                paintToolStripMenuItem.Text = "Paint";
                cmdToolStripMenuItem.Text = "Command Prompt";
                noteToolStripMenuItem.Text = "Notepad";
                máyTínhToolStripMenuItem.Text = "Calculator";
                microsoftWordToolStripMenuItem.Text = "Microsoft Word";
                Ts_Btn_dangnhap.Text = "Log In";
                Ts_Btn_giaovien.Text = "Manage Teacher Account";
                Btn_ht_100.Text = "Opacity 100%";
                Btn_ht_50.Text = "Opacity 50%";
                Btn_ht_macdinh.Text = "Default Opacity";
                thoátToolStripMenuItem.Text = "Exit";
                Ts_Btn_doimatkhau.Text = "Change Password";
                Ts_ht_nn_tienganh.Text = "English";
                Text = "Admin Menu"; // Đổi tiêu đề của form
            }
            else
            {
                // Nếu ngôn ngữ là Tiếng Việt, bạn có thể để nó như mặc định
                // hoặc cập nhật tất cả các chuỗi về tiếng Việt ở đây
                label1.Text = "Quản Lý Sinh Viên";
                hỗTrợToolStripMenuItem.Text = "Hỗ Trợ";
                Ts_diem.Text = "Điểm";
                Ts_Btn_hethong.Text = "Hệ Thống";
                Ts_Btn_thongtin.Text = "Thông Tin";
                Ts_Btn_timkiem.Text = "Tìm Kiếm";
                Ts_Btn_quanli.Text = "Cập nhật điểm";
                Ts_Btn_quanli.Text = "Quản Lý";
                Ts_Btn_hienthi.Text = "Hiển Thị";
                Ts_Btn_tienich.Text = "Tiện Ích";
                Ts_Btn_khoa.Text = "Khóa";
                Ts_Btn_tt_khoa.Text = "Khoa";
                Ts_Btn_tt_giaovien.Text = "Giáo Viên";
                Ts_Btn_tt_lop.Text = "Lớp";
                Ts_Btn_tt_sinhvien.Text = "Sinh Viên";
                Ts_Btn_tt_monhoc.Text = "Môn Học";
                Ts_Btn_tt_chinhsach.Text = "Chính Sách";
                Ts_Btn_tt_diem.Text = "Điểm";
                Ts_Btn_tk_khoa.Text = "Khoa";
                Ts_Btn_tk_giaovien.Text = "Giáo Viên";
                Ts_Btn_tk_lop.Text = "Lớp";
                Ts_Btn_tk_sinhvien.Text = "Sinh Viên";
                Ts_Btn_tk_monhoc.Text = "Môn Học";
                Ts_Btn_tk_chinhsach.Text = "Chính Sách";
                kiểuXemToolStripMenuItem.Text = "Kiểu Xem";
                cậpNhậtPhầnMềnToolStripMenuItem.Text = "Cập Nhật Phần Mềm";
                Ts_Btn_ql_khoa.Text = "Khoa";
                Ts_Btn_ql_giaovien.Text = "Giáo Viên";
                Ts_Btn_ql_lop.Text = "Lớp";
                Ts_Btn_ql_sinhvien.Text = "Sinh Viên";
                Ts_Btn_ql_monhoc.Text = "Môn Học";
                Ts_Btn_ql_chinhsach.Text = "Chính Sách";
                Ts_Btn_ql_diem.Text = "Điểm";
                tiếngViệtToolStripMenuItem.Text = "Tiếng Việt";
                trongSuốtToolStripMenuItem.Text = "Trong Suốt";
                ngônNgữToolStripMenuItem.Text = "Ngôn Ngữ";
                Ts_Btn_admin.Text = "Quản lý tài khoản Admin";
                Ts_Btn_dangxuat.Text = "Đăng xuất";
                Ts_Btn_truongkhoa.Text = "Quản lý tài khoản Trưởng khoa";
                Ts_Btn_user.Text = "Quản lý tài khoản User";
                hỗTrợToolStripMenuItem.Text = "Liên hệ";
                ts_Btn_LienHe.Text = "Liên hệ";
                thôngTinToolStripMenuItem1.Text = "Thông tin";
                paintToolStripMenuItem.Text = "Paint";
                máyTínhToolStripMenuItem.Text = "Máy tính";
                Ts_Btn_dangnhap.Text = "Đăng nhập";
                Ts_Btn_giaovien.Text = "Quản lý tài khoản Giáo viên";
                Btn_ht_100.Text = "100%";
                Btn_ht_50.Text = "80%";
                Btn_ht_macdinh.Text = "Mặc định";
                thoátToolStripMenuItem.Text = "Thoát";
                Ts_Btn_doimatkhau.Text = "Đổi mật khẩu";
                Ts_ht_nn_tienganh.Text = "Tiếng Anh";
                Text = "Menu Admin";
            }
        }

        private void Ts_Btn_tt_sinhvien_Click(object sender, EventArgs e)
        {
            
            ThongTinSinhVien f = new ThongTinSinhVien();
            f.ShowDialog();
        }

        private void Ts_Btn_tt_chinhsach_Click(object sender, EventArgs e)
        {
            ThongTinChinhSach f = new ThongTinChinhSach();
            f.ShowDialog();
        }

        private void Ts_Btn_tt_khoa_Click(object sender, EventArgs e)
        {
            ThongTinKhoa f = new ThongTinKhoa();
            f.ShowDialog();
        }

        private void Ts_Btn_tt_lop_Click(object sender, EventArgs e)
        {
            ThongTinLop f = new ThongTinLop();
            f.ShowDialog();
        }

        private void Ts_Btn_tt_monhoc_Click(object sender, EventArgs e)
        {
            ThongTinMonHoc f = new ThongTinMonHoc();
            f.ShowDialog();
        }

        private void Ts_Btn_tt_diem_Click(object sender, EventArgs e)
        {
            ThongTinDiem f = new ThongTinDiem();
            f.ShowDialog();
        }
        private void Ts_Btn_tt_giaovien_Click(object sender, EventArgs e)
        {
            ThongTinGiaoVien f = new ThongTinGiaoVien();
            f.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Ts_Btn_tk_chinhsach_Click(object sender, EventArgs e)
        {
            TimKiemChinhSach f = new TimKiemChinhSach();
            f.ShowDialog();
        }

        private void Ts_Btn_tk_giaovien_Click(object sender, EventArgs e)
        {
            TimKiemGiaoVien f = new TimKiemGiaoVien();
            f.ShowDialog();
        }

        private void Ts_Btn_tk_khoa_Click(object sender, EventArgs e)
        {
            TimKiemKhoa f = new TimKiemKhoa();
            f.ShowDialog();
        }

        private void Ts_Btn_tk_lop_Click(object sender, EventArgs e)
        {
            TimKiemLop f = new TimKiemLop();
            f.ShowDialog();
        }

        private void Ts_Btn_tk_sinhvien_Click(object sender, EventArgs e)
        {
            TimKiemSinhVien f = new TimKiemSinhVien();
            f.ShowDialog(); 
        }

        private void Ts_Btn_tk_monhoc_Click(object sender, EventArgs e)
        {
            TimKiemMonHoc f = new TimKiemMonHoc();
            f.ShowDialog();
        }

        private bool isLocked = false;
        private void Ts_Btn_khoa_Click(object sender, EventArgs e)
        {
            ToggleLockState();
        }
        private void ToggleLockState()
        {
            isLocked = !isLocked;

            if (isLocked)
            {
                // Lock the controls
                LockControls();
                MessageBox.Show("Khóa!");
            }
            else
            {
                // Unlock the controls
                UnlockControls();
                MessageBox.Show("Mở Khóa!");
            }
        }

        private void LockControls()
        {
            Ts_diem.Enabled = false;
            // Disable or make controls read-only except ts_Btn_khoa
            foreach (ToolStripItem item in Ts_Btn_hethong.DropDownItems)
            {
                if (item != Ts_Btn_khoa)
                {
                    item.Enabled = false;
                }
            }

            foreach (ToolStripItem item in Ts_Btn_thongtin.DropDownItems)
            {
                item.Enabled = false;
            }


            foreach (ToolStripItem item in Ts_Btn_timkiem.DropDownItems)
            {
                item.Enabled = false;
            }

            foreach (ToolStripItem item in Ts_diem.DropDownItems)
            {
                item.Enabled = false;
            }

            foreach (ToolStripItem item in Ts_Btn_quanli.DropDownItems)
            {
                item.Enabled = false;
            }

            foreach (ToolStripItem item in Ts_Btn_hienthi.DropDownItems)
            {
                item.Enabled = false;
            }

            foreach (ToolStripItem item in Ts_Btn_tienich.DropDownItems)
            {
                item.Enabled = false;
            }

            foreach (ToolStripItem item in thoátToolStripMenuItem.DropDownItems)
            {
                item.Enabled = false;
            }

            foreach (ToolStripItem item in hỗTrợToolStripMenuItem.DropDownItems)
            {
                if (item != Ts_Btn_khoa)
                {
                    item.Enabled = false;
                }
            }

            thoátToolStripMenuItem.Enabled = false;
        }
        private void UnlockControls()
        {
            Ts_diem.Enabled = true;
            // Enable or make controls editable
            foreach (ToolStripItem item in Ts_Btn_hethong.DropDownItems)
            {
                item.Enabled = true;
            }

            foreach (ToolStripItem item in Ts_Btn_thongtin.DropDownItems)
            {
                item.Enabled = true;
            }
            foreach (ToolStripItem item in Ts_Btn_timkiem.DropDownItems)
            {
                item.Enabled = true;
            }

            foreach (ToolStripItem item in Ts_diem.DropDownItems)
            {
                item.Enabled = true;
            }

            foreach (ToolStripItem item in Ts_Btn_quanli.DropDownItems)
            {
                item.Enabled = true;
            }

            foreach (ToolStripItem item in Ts_Btn_hienthi.DropDownItems)
            {
                item.Enabled = true;
            }

            foreach (ToolStripItem item in Ts_Btn_tienich.DropDownItems)
            {
                item.Enabled = true;
            }

            foreach (ToolStripItem item in thoátToolStripMenuItem.DropDownItems)
            {
                item.Enabled = true;
            }

            foreach (ToolStripItem item in hỗTrợToolStripMenuItem.DropDownItems)
            {
                if (item != Ts_Btn_khoa)
                {
                    item.Enabled = true;
                }
            }

            thoátToolStripMenuItem.Enabled = false;
        }

        private void Ts_Btn_dangnhap_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng nhập lại không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }  
}
