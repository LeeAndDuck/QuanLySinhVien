namespace QuanLySinhVien
{
    partial class QuanLyTaiKhoanUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Dgb_User = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_dong = new System.Windows.Forms.Button();
            this.Btn_nhaplai = new System.Windows.Forms.Button();
            this.Btn_xoa = new System.Windows.Forms.Button();
            this.Btn_sua = new System.Windows.Forms.Button();
            this.Btn_them = new System.Windows.Forms.Button();
            this.Tbx_mk = new System.Windows.Forms.TextBox();
            this.Tbx_ten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgb_User)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Tài Khoản User";
            // 
            // Dgb_User
            // 
            this.Dgb_User.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dgb_User.ColumnHeadersHeight = 29;
            this.Dgb_User.Location = new System.Drawing.Point(476, 180);
            this.Dgb_User.Name = "Dgb_User";
            this.Dgb_User.RowHeadersWidth = 51;
            this.Dgb_User.RowTemplate.Height = 24;
            this.Dgb_User.Size = new System.Drawing.Size(411, 313);
            this.Dgb_User.TabIndex = 5;
            this.Dgb_User.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgb_User_CellClick);
            this.Dgb_User.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.Dgb_User_DataBindingComplete);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.Btn_dong);
            this.groupBox2.Controls.Add(this.Btn_nhaplai);
            this.groupBox2.Controls.Add(this.Btn_xoa);
            this.groupBox2.Controls.Add(this.Btn_sua);
            this.groupBox2.Controls.Add(this.Btn_them);
            this.groupBox2.Controls.Add(this.Tbx_mk);
            this.groupBox2.Controls.Add(this.Tbx_ten);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(15, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 313);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Tài Khoản";
            // 
            // Btn_dong
            // 
            this.Btn_dong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_dong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_dong.Location = new System.Drawing.Point(248, 233);
            this.Btn_dong.Name = "Btn_dong";
            this.Btn_dong.Size = new System.Drawing.Size(100, 34);
            this.Btn_dong.TabIndex = 8;
            this.Btn_dong.Text = "Đóng";
            this.Btn_dong.UseVisualStyleBackColor = true;
            this.Btn_dong.Click += new System.EventHandler(this.Btn_dong_Click);
            // 
            // Btn_nhaplai
            // 
            this.Btn_nhaplai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_nhaplai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_nhaplai.Location = new System.Drawing.Point(81, 233);
            this.Btn_nhaplai.Name = "Btn_nhaplai";
            this.Btn_nhaplai.Size = new System.Drawing.Size(126, 34);
            this.Btn_nhaplai.TabIndex = 7;
            this.Btn_nhaplai.Text = "Nhập Lại";
            this.Btn_nhaplai.UseVisualStyleBackColor = true;
            this.Btn_nhaplai.Click += new System.EventHandler(this.Btn_nhaplai_Click);
            // 
            // Btn_xoa
            // 
            this.Btn_xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_xoa.Location = new System.Drawing.Point(309, 178);
            this.Btn_xoa.Name = "Btn_xoa";
            this.Btn_xoa.Size = new System.Drawing.Size(100, 34);
            this.Btn_xoa.TabIndex = 6;
            this.Btn_xoa.Text = "Xóa";
            this.Btn_xoa.UseVisualStyleBackColor = true;
            this.Btn_xoa.Click += new System.EventHandler(this.Btn_xoa_Click);
            // 
            // Btn_sua
            // 
            this.Btn_sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_sua.Location = new System.Drawing.Point(175, 178);
            this.Btn_sua.Name = "Btn_sua";
            this.Btn_sua.Size = new System.Drawing.Size(100, 34);
            this.Btn_sua.TabIndex = 5;
            this.Btn_sua.Text = "Sửa";
            this.Btn_sua.UseVisualStyleBackColor = true;
            this.Btn_sua.Click += new System.EventHandler(this.Btn_sua_Click);
            // 
            // Btn_them
            // 
            this.Btn_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_them.Location = new System.Drawing.Point(44, 178);
            this.Btn_them.Name = "Btn_them";
            this.Btn_them.Size = new System.Drawing.Size(100, 34);
            this.Btn_them.TabIndex = 4;
            this.Btn_them.Text = "Thêm";
            this.Btn_them.UseVisualStyleBackColor = true;
            this.Btn_them.Click += new System.EventHandler(this.Btn_them_Click);
            // 
            // Tbx_mk
            // 
            this.Tbx_mk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tbx_mk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_mk.Location = new System.Drawing.Point(172, 117);
            this.Tbx_mk.Name = "Tbx_mk";
            this.Tbx_mk.Size = new System.Drawing.Size(271, 24);
            this.Tbx_mk.TabIndex = 3;
            // 
            // Tbx_ten
            // 
            this.Tbx_ten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tbx_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_ten.Location = new System.Drawing.Point(172, 45);
            this.Tbx_ten.Name = "Tbx_ten";
            this.Tbx_ten.Size = new System.Drawing.Size(271, 24);
            this.Tbx_ten.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật Khẩu";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Đăng Nhập";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 159);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // QuanLyTaiKhoanUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.Controls.Add(this.Dgb_User);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "QuanLyTaiKhoanUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tài Khoản User";
            this.Load += new System.EventHandler(this.QuanLyTaiKhoanUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgb_User)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgb_User;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_dong;
        private System.Windows.Forms.Button Btn_nhaplai;
        private System.Windows.Forms.Button Btn_xoa;
        private System.Windows.Forms.Button Btn_sua;
        private System.Windows.Forms.Button Btn_them;
        private System.Windows.Forms.TextBox Tbx_mk;
        private System.Windows.Forms.TextBox Tbx_ten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}