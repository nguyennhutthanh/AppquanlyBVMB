namespace Plane_Ticket
{
    partial class frmDangNhap
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label67 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnDangNhap = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(278, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 25);
			this.label1.TabIndex = 36;
			this.label1.Text = "ĐĂNG NHẬP";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label67);
			this.panel1.Controls.Add(this.txtPassword);
			this.panel1.Controls.Add(this.txtUsername);
			this.panel1.Location = new System.Drawing.Point(215, 62);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(298, 144);
			this.panel1.TabIndex = 37;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(17, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 16);
			this.label3.TabIndex = 24;
			this.label3.Text = "Username";
			// 
			// label67
			// 
			this.label67.AutoSize = true;
			this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label67.Location = new System.Drawing.Point(20, 91);
			this.label67.Name = "label67";
			this.label67.Size = new System.Drawing.Size(76, 16);
			this.label67.TabIndex = 25;
			this.label67.Text = "Password";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(108, 87);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(162, 20);
			this.txtPassword.TabIndex = 23;
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(108, 38);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(162, 20);
			this.txtUsername.TabIndex = 22;
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.btnReset);
			this.panel3.Controls.Add(this.btnDangNhap);
			this.panel3.Controls.Add(this.btnThoat);
			this.panel3.Location = new System.Drawing.Point(215, 212);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(298, 59);
			this.panel3.TabIndex = 40;
			// 
			// btnReset
			// 
			this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
			this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnReset.Location = new System.Drawing.Point(120, 1);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(72, 51);
			this.btnReset.TabIndex = 39;
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnDangNhap
			// 
			this.btnDangNhap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.BackgroundImage")));
			this.btnDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnDangNhap.FlatAppearance.BorderSize = 0;
			this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnDangNhap.Location = new System.Drawing.Point(23, 3);
			this.btnDangNhap.Name = "btnDangNhap";
			this.btnDangNhap.Size = new System.Drawing.Size(55, 51);
			this.btnDangNhap.TabIndex = 38;
			this.btnDangNhap.UseVisualStyleBackColor = true;
			this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click_1);
			// 
			// btnThoat
			// 
			this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
			this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnThoat.FlatAppearance.BorderSize = 0;
			this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThoat.ForeColor = System.Drawing.Color.Red;
			this.btnThoat.Location = new System.Drawing.Point(227, 2);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(50, 50);
			this.btnThoat.TabIndex = 37;
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Location = new System.Drawing.Point(5, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(204, 259);
			this.panel2.TabIndex = 41;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(192, 249);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 39;
			this.pictureBox1.TabStop = false;
			// 
			// frmDangNhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(524, 283);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "frmDangNhap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng nhập";
			this.Shown += new System.EventHandler(this.frmDangNhap_Shown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label67;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnDangNhap;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnReset;
	}
}