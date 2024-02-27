namespace QuanLySinhVien
{
    partial class CapNhatLop
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
            this.dgv_CapNhatLop = new System.Windows.Forms.DataGridView();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtbMaKhoa = new System.Windows.Forms.TextBox();
            this.txtbTenLop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbMaLop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CapNhatLop)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_CapNhatLop
            // 
            this.dgv_CapNhatLop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_CapNhatLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CapNhatLop.Location = new System.Drawing.Point(552, 168);
            this.dgv_CapNhatLop.Name = "dgv_CapNhatLop";
            this.dgv_CapNhatLop.RowHeadersWidth = 51;
            this.dgv_CapNhatLop.RowTemplate.Height = 24;
            this.dgv_CapNhatLop.Size = new System.Drawing.Size(683, 308);
            this.dgv_CapNhatLop.TabIndex = 5;
            this.dgv_CapNhatLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CapNhatLop_CellClick);
            this.dgv_CapNhatLop.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_CapNhatLop_DataBindingComplete);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNhapLai.Location = new System.Drawing.Point(116, 258);
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
            this.btnDong.Location = new System.Drawing.Point(287, 258);
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
            this.btnXoa.Location = new System.Drawing.Point(369, 189);
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
            this.btnSua.Location = new System.Drawing.Point(200, 189);
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
            this.btnThem.Location = new System.Drawing.Point(31, 189);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 33);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtbMaKhoa
            // 
            this.txtbMaKhoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbMaKhoa.Location = new System.Drawing.Point(151, 125);
            this.txtbMaKhoa.Name = "txtbMaKhoa";
            this.txtbMaKhoa.Size = new System.Drawing.Size(316, 22);
            this.txtbMaKhoa.TabIndex = 6;
            // 
            // txtbTenLop
            // 
            this.txtbTenLop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbTenLop.Location = new System.Drawing.Point(151, 81);
            this.txtbTenLop.Name = "txtbTenLop";
            this.txtbTenLop.Size = new System.Drawing.Size(316, 22);
            this.txtbTenLop.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên Lớp";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Khoa";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Lớp";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.btnNhapLai);
            this.groupBox2.Controls.Add(this.btnDong);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.txtbMaKhoa);
            this.groupBox2.Controls.Add(this.txtbTenLop);
            this.groupBox2.Controls.Add(this.txtbMaLop);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 318);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Lớp";
            // 
            // txtbMaLop
            // 
            this.txtbMaLop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbMaLop.Location = new System.Drawing.Point(151, 37);
            this.txtbMaLop.Name = "txtbMaLop";
            this.txtbMaLop.Size = new System.Drawing.Size(316, 22);
            this.txtbMaLop.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cập Nhật Lớp";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1223, 121);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // CapNhatLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 497);
            this.Controls.Add(this.dgv_CapNhatLop);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CapNhatLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Lớp";
            this.Load += new System.EventHandler(this.CapNhatLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CapNhatLop)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_CapNhatLop;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtbMaKhoa;
        private System.Windows.Forms.TextBox txtbTenLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbMaLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}