namespace QuanLySinhVien.ThongTin
{
    partial class ThongTinMonHoc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.txtbMaGV = new System.Windows.Forms.TextBox();
            this.txtbSoTiet = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbTenMH = new System.Windows.Forms.TextBox();
            this.txtbMaMH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_ThongTinMonHoc = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTinMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1254, 121);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông Tin Môn Học";
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDong.Location = new System.Drawing.Point(328, 231);
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
            this.btnIn.Location = new System.Drawing.Point(57, 231);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(98, 33);
            this.btnIn.TabIndex = 8;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // txtbMaGV
            // 
            this.txtbMaGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbMaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaGV.Location = new System.Drawing.Point(151, 169);
            this.txtbMaGV.Name = "txtbMaGV";
            this.txtbMaGV.Size = new System.Drawing.Size(316, 27);
            this.txtbMaGV.TabIndex = 7;
            // 
            // txtbSoTiet
            // 
            this.txtbSoTiet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbSoTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSoTiet.Location = new System.Drawing.Point(151, 125);
            this.txtbSoTiet.Name = "txtbSoTiet";
            this.txtbSoTiet.Size = new System.Drawing.Size(316, 27);
            this.txtbSoTiet.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.btnDong);
            this.groupBox2.Controls.Add(this.btnIn);
            this.groupBox2.Controls.Add(this.txtbMaGV);
            this.groupBox2.Controls.Add(this.txtbSoTiet);
            this.groupBox2.Controls.Add(this.txtbTenMH);
            this.groupBox2.Controls.Add(this.txtbMaMH);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 360);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Môn học";
            // 
            // txtbTenMH
            // 
            this.txtbTenMH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbTenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTenMH.Location = new System.Drawing.Point(151, 81);
            this.txtbTenMH.Name = "txtbTenMH";
            this.txtbTenMH.Size = new System.Drawing.Size(316, 27);
            this.txtbTenMH.TabIndex = 5;
            // 
            // txtbMaMH
            // 
            this.txtbMaMH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbMaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaMH.Location = new System.Drawing.Point(151, 37);
            this.txtbMaMH.Name = "txtbMaMH";
            this.txtbMaMH.Size = new System.Drawing.Size(316, 27);
            this.txtbMaMH.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã Giáo Viên";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên Môn Học";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số Tiết";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Môn Học";
            // 
            // dgv_ThongTinMonHoc
            // 
            this.dgv_ThongTinMonHoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_ThongTinMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongTinMonHoc.Location = new System.Drawing.Point(552, 168);
            this.dgv_ThongTinMonHoc.Name = "dgv_ThongTinMonHoc";
            this.dgv_ThongTinMonHoc.RowHeadersWidth = 51;
            this.dgv_ThongTinMonHoc.RowTemplate.Height = 24;
            this.dgv_ThongTinMonHoc.Size = new System.Drawing.Size(714, 350);
            this.dgv_ThongTinMonHoc.TabIndex = 8;
            this.dgv_ThongTinMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ThongTinMonHoc_CellClick);
            this.dgv_ThongTinMonHoc.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_ThongTinMonHoc_DataBindingComplete);
            // 
            // ThongTinMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 534);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_ThongTinMonHoc);
            this.Name = "ThongTinMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Môn Học";
            this.Load += new System.EventHandler(this.ThongTinMonHoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTinMonHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.TextBox txtbMaGV;
        private System.Windows.Forms.TextBox txtbSoTiet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbTenMH;
        private System.Windows.Forms.TextBox txtbMaMH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_ThongTinMonHoc;
    }
}