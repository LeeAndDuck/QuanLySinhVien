namespace QuanLySinhVien.ThongTin
{
    partial class ThongTinLop
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
            this.dgv_ThongTinLop = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.txtbMaKhoa = new System.Windows.Forms.TextBox();
            this.txtbTenLop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbMaLop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTinLop)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_ThongTinLop
            // 
            this.dgv_ThongTinLop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_ThongTinLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongTinLop.Location = new System.Drawing.Point(554, 170);
            this.dgv_ThongTinLop.Name = "dgv_ThongTinLop";
            this.dgv_ThongTinLop.RowHeadersWidth = 51;
            this.dgv_ThongTinLop.RowTemplate.Height = 24;
            this.dgv_ThongTinLop.Size = new System.Drawing.Size(683, 308);
            this.dgv_ThongTinLop.TabIndex = 8;
            this.dgv_ThongTinLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ThongTinLop_CellClick);
            this.dgv_ThongTinLop.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_ThongTinLop_DataBindingComplete);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDong.Location = new System.Drawing.Point(307, 189);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(98, 33);
            this.btnDong.TabIndex = 11;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnIn
            // 
            this.btnIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIn.Location = new System.Drawing.Point(72, 189);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(98, 33);
            this.btnIn.TabIndex = 8;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // txtbMaKhoa
            // 
            this.txtbMaKhoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaKhoa.Location = new System.Drawing.Point(151, 125);
            this.txtbMaKhoa.Name = "txtbMaKhoa";
            this.txtbMaKhoa.Size = new System.Drawing.Size(316, 27);
            this.txtbMaKhoa.TabIndex = 6;
            // 
            // txtbTenLop
            // 
            this.txtbTenLop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTenLop.Location = new System.Drawing.Point(151, 81);
            this.txtbTenLop.Name = "txtbTenLop";
            this.txtbTenLop.Size = new System.Drawing.Size(316, 27);
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
            this.groupBox2.Controls.Add(this.btnDong);
            this.groupBox2.Controls.Add(this.btnIn);
            this.groupBox2.Controls.Add(this.txtbMaKhoa);
            this.groupBox2.Controls.Add(this.txtbTenLop);
            this.groupBox2.Controls.Add(this.txtbMaLop);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(14, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 318);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Lớp";
            // 
            // txtbMaLop
            // 
            this.txtbMaLop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaLop.Location = new System.Drawing.Point(151, 37);
            this.txtbMaLop.Name = "txtbMaLop";
            this.txtbMaLop.Size = new System.Drawing.Size(316, 27);
            this.txtbMaLop.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông Tin Lớp";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1223, 121);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // ThongTinLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 497);
            this.Controls.Add(this.dgv_ThongTinLop);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThongTinLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Lớp";
            this.Load += new System.EventHandler(this.ThongTinLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTinLop)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ThongTinLop;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnIn;
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