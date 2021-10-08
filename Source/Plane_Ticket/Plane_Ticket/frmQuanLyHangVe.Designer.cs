namespace Plane_Ticket
{
    partial class frmQuanLyHangVe
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyHangVe));
			this.txtMaHangVe = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.txtTenHangVe = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.gbxThaoTac = new System.Windows.Forms.GroupBox();
			this.btnThem = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.btnThoat = new System.Windows.Forms.Button();
			this.gbxDSMayBay = new System.Windows.Forms.GroupBox();
			this.dtgvHangVe = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.gbxTTMayBay = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.gbxThaoTac.SuspendLayout();
			this.panel1.SuspendLayout();
			this.gbxDSMayBay.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvHangVe)).BeginInit();
			this.gbxTTMayBay.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtMaHangVe
			// 
			this.txtMaHangVe.Location = new System.Drawing.Point(106, 20);
			this.txtMaHangVe.Name = "txtMaHangVe";
			this.txtMaHangVe.ReadOnly = true;
			this.txtMaHangVe.Size = new System.Drawing.Size(175, 20);
			this.txtMaHangVe.TabIndex = 57;
			this.txtMaHangVe.TabStop = false;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(5, 24);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(64, 13);
			this.label20.TabIndex = 55;
			this.label20.Text = "Mã hạng vé";
			// 
			// txtTenHangVe
			// 
			this.txtTenHangVe.Location = new System.Drawing.Point(106, 46);
			this.txtTenHangVe.Name = "txtTenHangVe";
			this.txtTenHangVe.Size = new System.Drawing.Size(175, 20);
			this.txtTenHangVe.TabIndex = 1;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(5, 50);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(68, 13);
			this.label19.TabIndex = 56;
			this.label19.Text = "Tên hạng vé";
			// 
			// gbxThaoTac
			// 
			this.gbxThaoTac.Controls.Add(this.btnThem);
			this.gbxThaoTac.Controls.Add(this.label5);
			this.gbxThaoTac.Controls.Add(this.label4);
			this.gbxThaoTac.Controls.Add(this.label3);
			this.gbxThaoTac.Controls.Add(this.btnSua);
			this.gbxThaoTac.Controls.Add(this.btnXoa);
			this.gbxThaoTac.Location = new System.Drawing.Point(9, 459);
			this.gbxThaoTac.Margin = new System.Windows.Forms.Padding(2);
			this.gbxThaoTac.Name = "gbxThaoTac";
			this.gbxThaoTac.Padding = new System.Windows.Forms.Padding(2);
			this.gbxThaoTac.Size = new System.Drawing.Size(285, 82);
			this.gbxThaoTac.TabIndex = 2;
			this.gbxThaoTac.TabStop = false;
			this.gbxThaoTac.Text = "Thao tác";
			// 
			// btnThem
			// 
			this.btnThem.BackgroundImage = global::Plane_Ticket.Properties.Resources.btnThem;
			this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnThem.FlatAppearance.BorderSize = 0;
			this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThem.ForeColor = System.Drawing.SystemColors.Control;
			this.btnThem.Location = new System.Drawing.Point(28, 18);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(41, 41);
			this.btnThem.TabIndex = 2;
			this.btnThem.UseCompatibleTextRendering = true;
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(226, 62);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(26, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Xóa";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(132, 62);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(26, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "Sửa";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(31, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Thêm";
			// 
			// btnSua
			// 
			this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
			this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSua.FlatAppearance.BorderSize = 0;
			this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSua.Location = new System.Drawing.Point(125, 18);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(41, 41);
			this.btnSua.TabIndex = 3;
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.BackgroundImage = global::Plane_Ticket.Properties.Resources.btnXoa;
			this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnXoa.FlatAppearance.BorderSize = 0;
			this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnXoa.Location = new System.Drawing.Point(218, 18);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(41, 41);
			this.btnXoa.TabIndex = 4;
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.btnThoat);
			this.panel1.Location = new System.Drawing.Point(-3, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(957, 47);
			this.panel1.TabIndex = 65;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(359, 11);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(198, 24);
			this.label2.TabIndex = 39;
			this.label2.Text = "QUẢN LÝ HẠNG VÉ";
			// 
			// btnThoat
			// 
			this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnThoat.BackgroundImage = global::Plane_Ticket.Properties.Resources.btnCancel;
			this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnThoat.FlatAppearance.BorderSize = 0;
			this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThoat.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.ForeColor = System.Drawing.Color.White;
			this.btnThoat.Location = new System.Drawing.Point(904, 3);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(41, 41);
			this.btnThoat.TabIndex = 8;
			this.btnThoat.UseVisualStyleBackColor = false;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// gbxDSMayBay
			// 
			this.gbxDSMayBay.Controls.Add(this.button1);
			this.gbxDSMayBay.Controls.Add(this.dtgvHangVe);
			this.gbxDSMayBay.Controls.Add(this.label6);
			this.gbxDSMayBay.Controls.Add(this.txtTimKiem);
			this.gbxDSMayBay.Controls.Add(this.btnTimKiem);
			this.gbxDSMayBay.Location = new System.Drawing.Point(298, 52);
			this.gbxDSMayBay.Margin = new System.Windows.Forms.Padding(2);
			this.gbxDSMayBay.Name = "gbxDSMayBay";
			this.gbxDSMayBay.Padding = new System.Windows.Forms.Padding(2);
			this.gbxDSMayBay.Size = new System.Drawing.Size(640, 489);
			this.gbxDSMayBay.TabIndex = 3;
			this.gbxDSMayBay.TabStop = false;
			this.gbxDSMayBay.Text = "Danh sách hạng vé";
			// 
			// dtgvHangVe
			// 
			this.dtgvHangVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvHangVe.Location = new System.Drawing.Point(4, 51);
			this.dtgvHangVe.Margin = new System.Windows.Forms.Padding(2);
			this.dtgvHangVe.Name = "dtgvHangVe";
			this.dtgvHangVe.RowTemplate.Height = 24;
			this.dtgvHangVe.Size = new System.Drawing.Size(632, 433);
			this.dtgvHangVe.TabIndex = 7;
			this.dtgvHangVe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHangVe_CellClick);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(424, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 13);
			this.label6.TabIndex = 15;
			this.label6.Text = "Tìm kiếm ";
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.Location = new System.Drawing.Point(481, 20);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new System.Drawing.Size(125, 20);
			this.txtTimKiem.TabIndex = 5;
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.BackgroundImage = global::Plane_Ticket.Properties.Resources.btnTimKiem;
			this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnTimKiem.FlatAppearance.BorderSize = 0;
			this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTimKiem.Location = new System.Drawing.Point(610, 16);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(25, 24);
			this.btnTimKiem.TabIndex = 6;
			this.btnTimKiem.UseVisualStyleBackColor = true;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// gbxTTMayBay
			// 
			this.gbxTTMayBay.Controls.Add(this.txtMaHangVe);
			this.gbxTTMayBay.Controls.Add(this.label20);
			this.gbxTTMayBay.Controls.Add(this.txtTenHangVe);
			this.gbxTTMayBay.Controls.Add(this.label19);
			this.gbxTTMayBay.Location = new System.Drawing.Point(9, 52);
			this.gbxTTMayBay.Margin = new System.Windows.Forms.Padding(2);
			this.gbxTTMayBay.Name = "gbxTTMayBay";
			this.gbxTTMayBay.Padding = new System.Windows.Forms.Padding(2);
			this.gbxTTMayBay.Size = new System.Drawing.Size(285, 402);
			this.gbxTTMayBay.TabIndex = 1;
			this.gbxTTMayBay.TabStop = false;
			this.gbxTTMayBay.Text = "Thông tin hạng vé";
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.SystemColors.Control;
			this.button1.Location = new System.Drawing.Point(5, 18);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(32, 28);
			this.button1.TabIndex = 16;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmQuanLyHangVe
			// 
			this.AcceptButton = this.btnThem;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnThoat;
			this.ClientSize = new System.Drawing.Size(948, 551);
			this.Controls.Add(this.gbxThaoTac);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.gbxDSMayBay);
			this.Controls.Add(this.gbxTTMayBay);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "frmQuanLyHangVe";
			this.Text = "Thêm hạng vé";
			this.Shown += new System.EventHandler(this.frmQuanLyHangVe_Shown);
			this.gbxThaoTac.ResumeLayout(false);
			this.gbxThaoTac.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.gbxDSMayBay.ResumeLayout(false);
			this.gbxDSMayBay.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvHangVe)).EndInit();
			this.gbxTTMayBay.ResumeLayout(false);
			this.gbxTTMayBay.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtMaHangVe;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtTenHangVe;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox gbxThaoTac;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox gbxDSMayBay;
        private System.Windows.Forms.DataGridView dtgvHangVe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox gbxTTMayBay;
		private System.Windows.Forms.Button button1;
	}
}