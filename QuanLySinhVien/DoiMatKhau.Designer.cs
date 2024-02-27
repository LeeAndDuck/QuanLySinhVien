namespace QuanLySinhVien
{
    partial class DoiMatKhau
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
            this.cBoxPass = new System.Windows.Forms.CheckBox();
            this.txtbPass_old = new System.Windows.Forms.TextBox();
            this.txtbUser = new System.Windows.Forms.TextBox();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_Doi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtbNhapLaiPass = new System.Windows.Forms.TextBox();
            this.txtbPass_new = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(268, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 119);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi Mật Khẩu";
            // 
            // cBoxPass
            // 
            this.cBoxPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBoxPass.AutoSize = true;
            this.cBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxPass.Location = new System.Drawing.Point(389, 397);
            this.cBoxPass.Name = "cBoxPass";
            this.cBoxPass.Size = new System.Drawing.Size(160, 26);
            this.cBoxPass.TabIndex = 21;
            this.cBoxPass.Text = "Hiện mật khẩu";
            this.cBoxPass.UseVisualStyleBackColor = true;
            this.cBoxPass.CheckedChanged += new System.EventHandler(this.cBoxPass_CheckedChanged);
            // 
            // txtbPass_old
            // 
            this.txtbPass_old.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbPass_old.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPass_old.Location = new System.Drawing.Point(31, 143);
            this.txtbPass_old.Name = "txtbPass_old";
            this.txtbPass_old.Size = new System.Drawing.Size(321, 27);
            this.txtbPass_old.TabIndex = 19;
            this.txtbPass_old.UseSystemPasswordChar = true;
            this.txtbPass_old.TextChanged += new System.EventHandler(this.txtbPass_old_TextChanged_1);
            // 
            // txtbUser
            // 
            this.txtbUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbUser.Location = new System.Drawing.Point(31, 76);
            this.txtbUser.Name = "txtbUser";
            this.txtbUser.Size = new System.Drawing.Size(321, 27);
            this.txtbUser.TabIndex = 18;
            this.txtbUser.TextChanged += new System.EventHandler(this.txtbUser_TextChanged_1);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Dong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.Location = new System.Drawing.Point(546, 445);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(163, 39);
            this.btn_Dong.TabIndex = 17;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_Doi
            // 
            this.btn_Doi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Doi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Doi.Location = new System.Drawing.Point(243, 445);
            this.btn_Doi.Name = "btn_Doi";
            this.btn_Doi.Size = new System.Drawing.Size(163, 39);
            this.btn_Doi.TabIndex = 16;
            this.btn_Doi.Text = "Đổi";
            this.btn_Doi.UseVisualStyleBackColor = true;
            this.btn_Doi.Click += new System.EventHandler(this.btn_Doi_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mật Khẩu Cũ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên Đăng Nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txtbPass_old);
            this.groupBox2.Controls.Add(this.txtbUser);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 191);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tài khoản cũ";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.txtbNhapLaiPass);
            this.groupBox3.Controls.Add(this.txtbPass_new);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(544, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(394, 191);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mật khẩu mới";
            // 
            // txtbNhapLaiPass
            // 
            this.txtbNhapLaiPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbNhapLaiPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNhapLaiPass.Location = new System.Drawing.Point(31, 143);
            this.txtbNhapLaiPass.Name = "txtbNhapLaiPass";
            this.txtbNhapLaiPass.Size = new System.Drawing.Size(321, 27);
            this.txtbNhapLaiPass.TabIndex = 19;
            this.txtbNhapLaiPass.UseSystemPasswordChar = true;
            this.txtbNhapLaiPass.TextChanged += new System.EventHandler(this.txtbNhapLaiPass_TextChanged_1);
            // 
            // txtbPass_new
            // 
            this.txtbPass_new.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbPass_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPass_new.Location = new System.Drawing.Point(31, 76);
            this.txtbPass_new.Name = "txtbPass_new";
            this.txtbPass_new.Size = new System.Drawing.Size(321, 27);
            this.txtbPass_new.TabIndex = 18;
            this.txtbPass_new.UseSystemPasswordChar = true;
            this.txtbPass_new.TextChanged += new System.EventHandler(this.txtbPass_new_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nhập Lại Mật Khẩu";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mật Khẩu Mới";
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(950, 516);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cBoxPass);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Doi);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cBoxPass;
        private System.Windows.Forms.TextBox txtbPass_old;
        private System.Windows.Forms.TextBox txtbUser;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_Doi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtbNhapLaiPass;
        private System.Windows.Forms.TextBox txtbPass_new;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}