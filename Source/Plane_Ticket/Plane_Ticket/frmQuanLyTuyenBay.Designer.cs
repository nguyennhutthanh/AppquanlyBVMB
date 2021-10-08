namespace Plane_Ticket
{
    partial class frmQuanLyTuyenBay
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyTuyenBay));
			this.txtMaTuyenBay = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cboSanBayDi = new System.Windows.Forms.ComboBox();
			this.cboSanBayDen = new System.Windows.Forms.ComboBox();
			this.gbxTTTuyenBay = new System.Windows.Forms.GroupBox();
			this.txtTimKiemve = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.gbxDSTuyenBay = new System.Windows.Forms.GroupBox();
			this.dtgvTuyenBay = new System.Windows.Forms.DataGridView();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnThoat = new System.Windows.Forms.Button();
			this.gbxThaoTac = new System.Windows.Forms.GroupBox();
			this.btnThem = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.gbxTTTuyenBay.SuspendLayout();
			this.gbxDSTuyenBay.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvTuyenBay)).BeginInit();
			this.panel1.SuspendLayout();
			this.gbxThaoTac.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtMaTuyenBay
			// 
			this.txtMaTuyenBay.Location = new System.Drawing.Point(130, 23);
			this.txtMaTuyenBay.Name = "txtMaTuyenBay";
			this.txtMaTuyenBay.ReadOnly = true;
			this.txtMaTuyenBay.Size = new System.Drawing.Size(151, 20);
			this.txtMaTuyenBay.TabIndex = 17;
			this.txtMaTuyenBay.TabStop = false;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(5, 27);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(74, 13);
			this.label20.TabIndex = 15;
			this.label20.Text = "Mã tuyến bay ";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(5, 57);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(58, 13);
			this.label19.TabIndex = 16;
			this.label19.Text = "Sân bay đi";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(5, 83);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(68, 13);
			this.label18.TabIndex = 13;
			this.label18.Text = "Sân bay đến";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(359, 11);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(220, 24);
			this.label1.TabIndex = 39;
			this.label1.Text = "QUẢN LÝ TUYẾN BAY";
			// 
			// cboSanBayDi
			// 
			this.cboSanBayDi.FormattingEnabled = true;
			this.cboSanBayDi.Location = new System.Drawing.Point(130, 51);
			this.cboSanBayDi.Margin = new System.Windows.Forms.Padding(2);
			this.cboSanBayDi.Name = "cboSanBayDi";
			this.cboSanBayDi.Size = new System.Drawing.Size(151, 21);
			this.cboSanBayDi.TabIndex = 1;
			// 
			// cboSanBayDen
			// 
			this.cboSanBayDen.FormattingEnabled = true;
			this.cboSanBayDen.Location = new System.Drawing.Point(130, 77);
			this.cboSanBayDen.Margin = new System.Windows.Forms.Padding(2);
			this.cboSanBayDen.Name = "cboSanBayDen";
			this.cboSanBayDen.Size = new System.Drawing.Size(151, 21);
			this.cboSanBayDen.TabIndex = 2;
			// 
			// gbxTTTuyenBay
			// 
			this.gbxTTTuyenBay.Controls.Add(this.label20);
			this.gbxTTTuyenBay.Controls.Add(this.label18);
			this.gbxTTTuyenBay.Controls.Add(this.cboSanBayDen);
			this.gbxTTTuyenBay.Controls.Add(this.label19);
			this.gbxTTTuyenBay.Controls.Add(this.cboSanBayDi);
			this.gbxTTTuyenBay.Controls.Add(this.txtMaTuyenBay);
			this.gbxTTTuyenBay.Location = new System.Drawing.Point(9, 52);
			this.gbxTTTuyenBay.Margin = new System.Windows.Forms.Padding(2);
			this.gbxTTTuyenBay.Name = "gbxTTTuyenBay";
			this.gbxTTTuyenBay.Padding = new System.Windows.Forms.Padding(2);
			this.gbxTTTuyenBay.Size = new System.Drawing.Size(285, 402);
			this.gbxTTTuyenBay.TabIndex = 1;
			this.gbxTTTuyenBay.TabStop = false;
			this.gbxTTTuyenBay.Text = "Thông tin tuyến bay";
			// 
			// txtTimKiemve
			// 
			this.txtTimKiemve.Location = new System.Drawing.Point(481, 20);
			this.txtTimKiemve.Name = "txtTimKiemve";
			this.txtTimKiemve.Size = new System.Drawing.Size(125, 20);
			this.txtTimKiemve.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(424, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "Tìm kiếm ";
			// 
			// gbxDSTuyenBay
			// 
			this.gbxDSTuyenBay.Controls.Add(this.button1);
			this.gbxDSTuyenBay.Controls.Add(this.dtgvTuyenBay);
			this.gbxDSTuyenBay.Controls.Add(this.label2);
			this.gbxDSTuyenBay.Controls.Add(this.txtTimKiemve);
			this.gbxDSTuyenBay.Controls.Add(this.btnTimKiem);
			this.gbxDSTuyenBay.Location = new System.Drawing.Point(298, 52);
			this.gbxDSTuyenBay.Margin = new System.Windows.Forms.Padding(2);
			this.gbxDSTuyenBay.Name = "gbxDSTuyenBay";
			this.gbxDSTuyenBay.Padding = new System.Windows.Forms.Padding(2);
			this.gbxDSTuyenBay.Size = new System.Drawing.Size(640, 489);
			this.gbxDSTuyenBay.TabIndex = 3;
			this.gbxDSTuyenBay.TabStop = false;
			this.gbxDSTuyenBay.Text = "Danh sách tuyến bay";
			// 
			// dtgvTuyenBay
			// 
			this.dtgvTuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvTuyenBay.Location = new System.Drawing.Point(4, 51);
			this.dtgvTuyenBay.Margin = new System.Windows.Forms.Padding(2);
			this.dtgvTuyenBay.Name = "dtgvTuyenBay";
			this.dtgvTuyenBay.RowTemplate.Height = 24;
			this.dtgvTuyenBay.Size = new System.Drawing.Size(632, 433);
			this.dtgvTuyenBay.TabIndex = 8;
			this.dtgvTuyenBay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTuyenBay_CellClick);
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
			this.btnTimKiem.TabIndex = 7;
			this.btnTimKiem.UseVisualStyleBackColor = true;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnThoat);
			this.panel1.Location = new System.Drawing.Point(-3, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(957, 47);
			this.panel1.TabIndex = 48;
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
			this.btnThoat.TabIndex = 9;
			this.btnThoat.UseVisualStyleBackColor = false;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
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
			this.btnThem.TabIndex = 3;
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
			this.btnSua.TabIndex = 4;
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
			this.btnXoa.TabIndex = 5;
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.SystemColors.Control;
			this.button1.Location = new System.Drawing.Point(4, 17);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(31, 29);
			this.button1.TabIndex = 16;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmQuanLyTuyenBay
			// 
			this.AcceptButton = this.btnThem;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.CancelButton = this.btnThoat;
			this.ClientSize = new System.Drawing.Size(948, 551);
			this.Controls.Add(this.gbxThaoTac);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.gbxDSTuyenBay);
			this.Controls.Add(this.gbxTTTuyenBay);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "frmQuanLyTuyenBay";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thêm tuyến bay";
			this.Shown += new System.EventHandler(this.frmQuanLyTuyenBay_Shown);
			this.gbxTTTuyenBay.ResumeLayout(false);
			this.gbxTTTuyenBay.PerformLayout();
			this.gbxDSTuyenBay.ResumeLayout(false);
			this.gbxDSTuyenBay.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvTuyenBay)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.gbxThaoTac.ResumeLayout(false);
			this.gbxThaoTac.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtMaTuyenBay;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboSanBayDi;
        private System.Windows.Forms.ComboBox cboSanBayDen;
        private System.Windows.Forms.GroupBox gbxTTTuyenBay;
        private System.Windows.Forms.TextBox txtTimKiemve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxDSTuyenBay;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox gbxThaoTac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgvTuyenBay;
		private System.Windows.Forms.Button button1;
	}
}