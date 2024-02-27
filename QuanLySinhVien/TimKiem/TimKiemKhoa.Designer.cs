namespace QuanLySinhVien.TimKiem
{
    partial class TimKiemKhoa
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.cbTim = new System.Windows.Forms.ComboBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtbTuKhoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_TimKiemKhoa = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TimKiemKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.btnNhapLai);
            this.groupBox2.Controls.Add(this.cbTim);
            this.groupBox2.Controls.Add(this.btnDong);
            this.groupBox2.Controls.Add(this.btnTim);
            this.groupBox2.Controls.Add(this.txtbTuKhoa);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 267);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Tìm Kiếm";
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNhapLai.Location = new System.Drawing.Point(205, 199);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(98, 33);
            this.btnNhapLai.TabIndex = 20;
            this.btnNhapLai.Text = "Nhập Lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // cbTim
            // 
            this.cbTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTim.FormattingEnabled = true;
            this.cbTim.Items.AddRange(new object[] {
            "Mã Khoa",
            "Tên Khoa"});
            this.cbTim.Location = new System.Drawing.Point(179, 91);
            this.cbTim.Name = "cbTim";
            this.cbTim.Size = new System.Drawing.Size(316, 28);
            this.cbTim.TabIndex = 19;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDong.Location = new System.Drawing.Point(385, 199);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(98, 33);
            this.btnDong.TabIndex = 18;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTim.Location = new System.Drawing.Point(25, 199);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(98, 33);
            this.btnTim.TabIndex = 17;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtbTuKhoa
            // 
            this.txtbTuKhoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbTuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTuKhoa.Location = new System.Drawing.Point(179, 47);
            this.txtbTuKhoa.Name = "txtbTuKhoa";
            this.txtbTuKhoa.Size = new System.Drawing.Size(316, 27);
            this.txtbTuKhoa.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tìm Theo";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Từ Khóa";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm Kiếm Khoa";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1145, 121);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // dgv_TimKiemKhoa
            // 
            this.dgv_TimKiemKhoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_TimKiemKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TimKiemKhoa.Location = new System.Drawing.Point(558, 161);
            this.dgv_TimKiemKhoa.Name = "dgv_TimKiemKhoa";
            this.dgv_TimKiemKhoa.RowHeadersWidth = 51;
            this.dgv_TimKiemKhoa.RowTemplate.Height = 24;
            this.dgv_TimKiemKhoa.Size = new System.Drawing.Size(599, 431);
            this.dgv_TimKiemKhoa.TabIndex = 14;
            this.dgv_TimKiemKhoa.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_TimKiemKhoa_DataBindingComplete);
            // 
            // TimKiemKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 618);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_TimKiemKhoa);
            this.Name = "TimKiemKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Kiếm Khoa";
            this.Load += new System.EventHandler(this.TimKiemKhoa_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TimKiemKhoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.ComboBox cbTim;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtbTuKhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_TimKiemKhoa;
    }
}