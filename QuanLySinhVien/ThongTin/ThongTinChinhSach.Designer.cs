namespace QuanLySinhVien.ThongTin
{
    partial class ThongTinChinhSach
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
            this.dgv_ThongTinChinhSach = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.txtbCheDo = new System.Windows.Forms.TextBox();
            this.txtbTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTinChinhSach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_ThongTinChinhSach
            // 
            this.dgv_ThongTinChinhSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_ThongTinChinhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongTinChinhSach.Location = new System.Drawing.Point(557, 170);
            this.dgv_ThongTinChinhSach.Name = "dgv_ThongTinChinhSach";
            this.dgv_ThongTinChinhSach.RowHeadersWidth = 51;
            this.dgv_ThongTinChinhSach.RowTemplate.Height = 24;
            this.dgv_ThongTinChinhSach.Size = new System.Drawing.Size(803, 308);
            this.dgv_ThongTinChinhSach.TabIndex = 11;
            this.dgv_ThongTinChinhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ThongTinChinhSach_CellClick);
            this.dgv_ThongTinChinhSach.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_ThongTinChinhSach_DataBindingComplete);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDong.Location = new System.Drawing.Point(333, 189);
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
            this.btnIn.Location = new System.Drawing.Point(79, 189);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(98, 33);
            this.btnIn.TabIndex = 8;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // txtbCheDo
            // 
            this.txtbCheDo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbCheDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCheDo.Location = new System.Drawing.Point(180, 125);
            this.txtbCheDo.Name = "txtbCheDo";
            this.txtbCheDo.Size = new System.Drawing.Size(316, 27);
            this.txtbCheDo.TabIndex = 6;
            // 
            // txtbTen
            // 
            this.txtbTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTen.Location = new System.Drawing.Point(180, 81);
            this.txtbTen.Name = "txtbTen";
            this.txtbTen.Size = new System.Drawing.Size(316, 27);
            this.txtbTen.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên Chính Sách";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chế Độ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Chính Sách";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.btnDong);
            this.groupBox2.Controls.Add(this.btnIn);
            this.groupBox2.Controls.Add(this.txtbCheDo);
            this.groupBox2.Controls.Add(this.txtbTen);
            this.groupBox2.Controls.Add(this.txtbMa);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(17, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 318);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Chính Sách";
            // 
            // txtbMa
            // 
            this.txtbMa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMa.Location = new System.Drawing.Point(180, 37);
            this.txtbMa.Name = "txtbMa";
            this.txtbMa.Size = new System.Drawing.Size(316, 27);
            this.txtbMa.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông Tin Chính Sách";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1343, 121);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // ThongTinChinhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 497);
            this.Controls.Add(this.dgv_ThongTinChinhSach);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThongTinChinhSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Chính Sách";
            this.Load += new System.EventHandler(this.ThongTinChinhSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTinChinhSach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ThongTinChinhSach;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.TextBox txtbCheDo;
        private System.Windows.Forms.TextBox txtbTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}