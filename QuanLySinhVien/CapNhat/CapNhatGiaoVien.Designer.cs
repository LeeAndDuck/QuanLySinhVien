namespace QuanLySinhVien
{
    partial class CapNhatGiaoVien
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
            this.dgv_CapNhatGiaoVien = new System.Windows.Forms.DataGridView();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtbTenGV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtbDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbMaGV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CapNhatGiaoVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_CapNhatGiaoVien
            // 
            this.dgv_CapNhatGiaoVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_CapNhatGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CapNhatGiaoVien.Location = new System.Drawing.Point(552, 168);
            this.dgv_CapNhatGiaoVien.Name = "dgv_CapNhatGiaoVien";
            this.dgv_CapNhatGiaoVien.RowHeadersWidth = 51;
            this.dgv_CapNhatGiaoVien.RowTemplate.Height = 24;
            this.dgv_CapNhatGiaoVien.Size = new System.Drawing.Size(883, 448);
            this.dgv_CapNhatGiaoVien.TabIndex = 5;
            this.dgv_CapNhatGiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CapNhatGiaoVien_CellClick);
            this.dgv_CapNhatGiaoVien.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_CapNhatGiaoVien_DataBindingComplete);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNhapLai.Location = new System.Drawing.Point(115, 407);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(98, 33);
            this.btnNhapLai.TabIndex = 12;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDong.Location = new System.Drawing.Point(286, 407);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(98, 33);
            this.btnDong.TabIndex = 11;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.Location = new System.Drawing.Point(368, 338);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 33);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.Location = new System.Drawing.Point(199, 338);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 33);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.Location = new System.Drawing.Point(30, 338);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 33);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtbTenGV
            // 
            this.txtbTenGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbTenGV.Location = new System.Drawing.Point(151, 84);
            this.txtbTenGV.Name = "txtbTenGV";
            this.txtbTenGV.Size = new System.Drawing.Size(316, 22);
            this.txtbTenGV.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên Giáo Viên";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giới Tính";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Giáo Viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.rbNu);
            this.groupBox2.Controls.Add(this.rbNam);
            this.groupBox2.Controls.Add(this.dtNgaySinh);
            this.groupBox2.Controls.Add(this.txtbDiaChi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtbSDT);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnNhapLai);
            this.groupBox2.Controls.Add(this.btnDong);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.txtbTenGV);
            this.groupBox2.Controls.Add(this.txtbMaGV);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 458);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Giáo Viên";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(151, 179);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(316, 22);
            this.dtNgaySinh.TabIndex = 19;
            // 
            // txtbDiaChi
            // 
            this.txtbDiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbDiaChi.Location = new System.Drawing.Point(151, 274);
            this.txtbDiaChi.Name = "txtbDiaChi";
            this.txtbDiaChi.Size = new System.Drawing.Size(316, 22);
            this.txtbDiaChi.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Địa Chỉ";
            // 
            // txtbSDT
            // 
            this.txtbSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbSDT.Location = new System.Drawing.Point(151, 227);
            this.txtbSDT.Name = "txtbSDT";
            this.txtbSDT.Size = new System.Drawing.Size(316, 22);
            this.txtbSDT.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Số Điện Thoại";
            // 
            // txtbMaGV
            // 
            this.txtbMaGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbMaGV.Location = new System.Drawing.Point(151, 37);
            this.txtbMaGV.Name = "txtbMaGV";
            this.txtbMaGV.Size = new System.Drawing.Size(316, 22);
            this.txtbMaGV.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cập Nhật Giáo Viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1423, 121);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rbNu
            // 
            this.rbNu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(347, 132);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(45, 20);
            this.rbNu.TabIndex = 26;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(219, 132);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(57, 20);
            this.rbNam.TabIndex = 25;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // CapNhatGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 633);
            this.Controls.Add(this.dgv_CapNhatGiaoVien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CapNhatGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Giáo Viên";
            this.Load += new System.EventHandler(this.CapNhatGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CapNhatGiaoVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_CapNhatGiaoVien;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtbTenGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbMaGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbSDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
    }
}