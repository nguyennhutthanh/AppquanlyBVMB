namespace Plane_Ticket
{
    partial class frmQuanLySanBay
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLySanBay));
			this.txtMaSanBay = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.txtTenSanBay = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.txtTenThanhPho = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
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
			this.gbxDSSanBay = new System.Windows.Forms.GroupBox();
			this.dtgvSanBay = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.gbxTTSanBay = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.gbxThaoTac.SuspendLayout();
			this.panel1.SuspendLayout();
			this.gbxDSSanBay.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvSanBay)).BeginInit();
			this.gbxTTSanBay.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtMaSanBay
			// 
			this.txtMaSanBay.Location = new System.Drawing.Point(109, 20);
			this.txtMaSanBay.Name = "txtMaSanBay";
			this.txtMaSanBay.ReadOnly = true;
			this.txtMaSanBay.Size = new System.Drawing.Size(166, 20);
			this.txtMaSanBay.TabIndex = 47;
			this.txtMaSanBay.TabStop = false;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(8, 24);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(62, 13);
			this.label20.TabIndex = 45;
			this.label20.Text = "Mã sân bay";
			// 
			// txtTenSanBay
			// 
			this.txtTenSanBay.Location = new System.Drawing.Point(109, 46);
			this.txtTenSanBay.Name = "txtTenSanBay";
			this.txtTenSanBay.Size = new System.Drawing.Size(166, 20);
			this.txtTenSanBay.TabIndex = 1;
			this.txtTenSanBay.Tag = "";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(8, 50);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(66, 13);
			this.label19.TabIndex = 46;
			this.label19.Text = "Tên sân bay";
			// 
			// txtTenThanhPho
			// 
			this.txtTenThanhPho.Location = new System.Drawing.Point(109, 72);
			this.txtTenThanhPho.Name = "txtTenThanhPho";
			this.txtTenThanhPho.Size = new System.Drawing.Size(166, 20);
			this.txtTenThanhPho.TabIndex = 2;
			this.txtTenThanhPho.Tag = "2";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(8, 76);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(77, 13);
			this.label18.TabIndex = 43;
			this.label18.Text = "Tên thành phố";
			// 
			// gbxThaoTac
			// 
			this.gbxThaoTac.Controls.Add(this.btnThem);
			this.gbxThaoTac.Controls.Add(this.label5);
			this.gbxThaoTac.Controls.Add(this.label4);
			this.gbxThaoTac.Controls.Add(this.label3);
			this.gbxThaoTac.Controls.Add(this.btnSua);
			this.gbxThaoTac.Controls.Add(this.btnXoa);
			this.gbxThaoTac.Location = new System.Drawing.Point(9, 464);
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
			this.btnThem.Location = new System.Drawing.Point(28, 18);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(41, 41);
			this.btnThem.TabIndex = 3;
			this.btnThem.Tag = "";
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
			this.btnSua.Tag = "";
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
			this.btnXoa.Tag = "";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.btnThoat);
			this.panel1.Location = new System.Drawing.Point(-4, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(957, 47);
			this.panel1.TabIndex = 55;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(359, 11);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(193, 24);
			this.label2.TabIndex = 39;
			this.label2.Text = "QUẢN LÝ SÂN BAY";
			// 
			// btnThoat
			// 
			this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnThoat.BackgroundImage = global::Plane_Ticket.Properties.Resources.btnCancel;
			this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
			// gbxDSSanBay
			// 
			this.gbxDSSanBay.Controls.Add(this.button1);
			this.gbxDSSanBay.Controls.Add(this.dtgvSanBay);
			this.gbxDSSanBay.Controls.Add(this.label6);
			this.gbxDSSanBay.Controls.Add(this.txtTimKiem);
			this.gbxDSSanBay.Controls.Add(this.btnTimKiem);
			this.gbxDSSanBay.Location = new System.Drawing.Point(298, 57);
			this.gbxDSSanBay.Margin = new System.Windows.Forms.Padding(2);
			this.gbxDSSanBay.Name = "gbxDSSanBay";
			this.gbxDSSanBay.Padding = new System.Windows.Forms.Padding(2);
			this.gbxDSSanBay.Size = new System.Drawing.Size(640, 489);
			this.gbxDSSanBay.TabIndex = 3;
			this.gbxDSSanBay.TabStop = false;
			this.gbxDSSanBay.Text = "Danh sách sân bay";
			// 
			// dtgvSanBay
			// 
			this.dtgvSanBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvSanBay.Location = new System.Drawing.Point(4, 51);
			this.dtgvSanBay.Margin = new System.Windows.Forms.Padding(2);
			this.dtgvSanBay.Name = "dtgvSanBay";
			this.dtgvSanBay.RowTemplate.Height = 24;
			this.dtgvSanBay.Size = new System.Drawing.Size(632, 433);
			this.dtgvSanBay.TabIndex = 8;
			this.dtgvSanBay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSanBay_CellClick);
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
			this.txtTimKiem.TabIndex = 6;
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
			// gbxTTSanBay
			// 
			this.gbxTTSanBay.Controls.Add(this.txtMaSanBay);
			this.gbxTTSanBay.Controls.Add(this.label18);
			this.gbxTTSanBay.Controls.Add(this.txtTenThanhPho);
			this.gbxTTSanBay.Controls.Add(this.label20);
			this.gbxTTSanBay.Controls.Add(this.label19);
			this.gbxTTSanBay.Controls.Add(this.txtTenSanBay);
			this.gbxTTSanBay.Location = new System.Drawing.Point(9, 52);
			this.gbxTTSanBay.Margin = new System.Windows.Forms.Padding(2);
			this.gbxTTSanBay.Name = "gbxTTSanBay";
			this.gbxTTSanBay.Padding = new System.Windows.Forms.Padding(2);
			this.gbxTTSanBay.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.gbxTTSanBay.Size = new System.Drawing.Size(285, 407);
			this.gbxTTSanBay.TabIndex = 1;
			this.gbxTTSanBay.TabStop = false;
			this.gbxTTSanBay.Text = "Thông tin sân bay";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(131, 7);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(163, 24);
			this.label1.TabIndex = 52;
			this.label1.Text = "THÊM SÂN BAY";
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.SystemColors.Control;
			this.button1.Location = new System.Drawing.Point(4, 18);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(31, 28);
			this.button1.TabIndex = 16;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmQuanLySanBay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(948, 551);
			this.Controls.Add(this.gbxThaoTac);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.gbxDSSanBay);
			this.Controls.Add(this.gbxTTSanBay);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "frmQuanLySanBay";
			this.Text = "Thêm sân bay";
			this.Shown += new System.EventHandler(this.frmQuanLySanBay_Shown);
			this.gbxThaoTac.ResumeLayout(false);
			this.gbxThaoTac.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.gbxDSSanBay.ResumeLayout(false);
			this.gbxDSSanBay.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvSanBay)).EndInit();
			this.gbxTTSanBay.ResumeLayout(false);
			this.gbxTTSanBay.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMaSanBay;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtTenSanBay;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtTenThanhPho;
        private System.Windows.Forms.Label label18;
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
        private System.Windows.Forms.GroupBox gbxDSSanBay;
        private System.Windows.Forms.DataGridView dtgvSanBay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox gbxTTSanBay;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}