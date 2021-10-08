namespace Plane_Ticket
{
    partial class frmQuanLyDonGia
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyDonGia));
			this.label20 = new System.Windows.Forms.Label();
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
			this.gboDSMayBay = new System.Windows.Forms.GroupBox();
			this.dtgvDonGia = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.gbxTTMayBay = new System.Windows.Forms.GroupBox();
			this.lbDonGia = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.cboSanBayDen = new System.Windows.Forms.ComboBox();
			this.cboSanBayDi = new System.Windows.Forms.ComboBox();
			this.txtDonGia = new System.Windows.Forms.TextBox();
			this.cboMaHangVe = new System.Windows.Forms.ComboBox();
			this.cboMaTuyenBay = new System.Windows.Forms.ComboBox();
			this.label18 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.gbxThaoTac.SuspendLayout();
			this.panel1.SuspendLayout();
			this.gboDSMayBay.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvDonGia)).BeginInit();
			this.gbxTTMayBay.SuspendLayout();
			this.SuspendLayout();
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(5, 22);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(74, 13);
			this.label20.TabIndex = 45;
			this.label20.Text = "Mã tuyến bay ";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(5, 117);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(68, 13);
			this.label19.TabIndex = 46;
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
			this.btnThem.TabIndex = 6;
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
			this.btnSua.TabIndex = 7;
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
			this.btnXoa.TabIndex = 8;
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
			this.panel1.TabIndex = 57;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(359, 11);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(190, 24);
			this.label2.TabIndex = 39;
			this.label2.Text = "QUẢN LÝ ĐƠN GIÁ";
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
			this.btnThoat.TabIndex = 12;
			this.btnThoat.UseVisualStyleBackColor = false;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// gboDSMayBay
			// 
			this.gboDSMayBay.Controls.Add(this.button1);
			this.gboDSMayBay.Controls.Add(this.dtgvDonGia);
			this.gboDSMayBay.Controls.Add(this.label6);
			this.gboDSMayBay.Controls.Add(this.txtTimKiem);
			this.gboDSMayBay.Controls.Add(this.btnTimKiem);
			this.gboDSMayBay.Location = new System.Drawing.Point(298, 52);
			this.gboDSMayBay.Margin = new System.Windows.Forms.Padding(2);
			this.gboDSMayBay.Name = "gboDSMayBay";
			this.gboDSMayBay.Padding = new System.Windows.Forms.Padding(2);
			this.gboDSMayBay.Size = new System.Drawing.Size(640, 489);
			this.gboDSMayBay.TabIndex = 3;
			this.gboDSMayBay.TabStop = false;
			this.gboDSMayBay.Text = "Danh sách đơn giá";
			// 
			// dtgvDonGia
			// 
			this.dtgvDonGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvDonGia.Location = new System.Drawing.Point(4, 51);
			this.dtgvDonGia.Margin = new System.Windows.Forms.Padding(2);
			this.dtgvDonGia.Name = "dtgvDonGia";
			this.dtgvDonGia.RowTemplate.Height = 24;
			this.dtgvDonGia.Size = new System.Drawing.Size(632, 433);
			this.dtgvDonGia.TabIndex = 11;
			this.dtgvDonGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDonGia_CellClick);
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
			this.txtTimKiem.TabIndex = 9;
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
			this.btnTimKiem.TabIndex = 10;
			this.btnTimKiem.UseVisualStyleBackColor = true;
			// 
			// gbxTTMayBay
			// 
			this.gbxTTMayBay.Controls.Add(this.lbDonGia);
			this.gbxTTMayBay.Controls.Add(this.label15);
			this.gbxTTMayBay.Controls.Add(this.label14);
			this.gbxTTMayBay.Controls.Add(this.cboSanBayDen);
			this.gbxTTMayBay.Controls.Add(this.cboSanBayDi);
			this.gbxTTMayBay.Controls.Add(this.txtDonGia);
			this.gbxTTMayBay.Controls.Add(this.cboMaHangVe);
			this.gbxTTMayBay.Controls.Add(this.cboMaTuyenBay);
			this.gbxTTMayBay.Controls.Add(this.label18);
			this.gbxTTMayBay.Controls.Add(this.label20);
			this.gbxTTMayBay.Controls.Add(this.label19);
			this.gbxTTMayBay.Location = new System.Drawing.Point(9, 52);
			this.gbxTTMayBay.Margin = new System.Windows.Forms.Padding(2);
			this.gbxTTMayBay.Name = "gbxTTMayBay";
			this.gbxTTMayBay.Padding = new System.Windows.Forms.Padding(2);
			this.gbxTTMayBay.Size = new System.Drawing.Size(285, 402);
			this.gbxTTMayBay.TabIndex = 1;
			this.gbxTTMayBay.TabStop = false;
			this.gbxTTMayBay.Text = "Thông tin đơn giá";
			// 
			// lbDonGia
			// 
			this.lbDonGia.AutoSize = true;
			this.lbDonGia.Location = new System.Drawing.Point(193, 145);
			this.lbDonGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbDonGia.Name = "lbDonGia";
			this.lbDonGia.Size = new System.Drawing.Size(0, 13);
			this.lbDonGia.TabIndex = 59;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(6, 84);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(68, 13);
			this.label15.TabIndex = 55;
			this.label15.Text = "Sân bay đến";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(6, 53);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(58, 13);
			this.label14.TabIndex = 56;
			this.label14.Text = "Sân bay đi";
			// 
			// cboSanBayDen
			// 
			this.cboSanBayDen.FormattingEnabled = true;
			this.cboSanBayDen.Location = new System.Drawing.Point(106, 79);
			this.cboSanBayDen.Margin = new System.Windows.Forms.Padding(2);
			this.cboSanBayDen.Name = "cboSanBayDen";
			this.cboSanBayDen.Size = new System.Drawing.Size(176, 21);
			this.cboSanBayDen.TabIndex = 3;
			this.cboSanBayDen.SelectionChangeCommitted += new System.EventHandler(this.cboSanBayDi_SelectionChangeCommitted);
			// 
			// cboSanBayDi
			// 
			this.cboSanBayDi.FormattingEnabled = true;
			this.cboSanBayDi.Location = new System.Drawing.Point(106, 47);
			this.cboSanBayDi.Margin = new System.Windows.Forms.Padding(2);
			this.cboSanBayDi.Name = "cboSanBayDi";
			this.cboSanBayDi.Size = new System.Drawing.Size(176, 21);
			this.cboSanBayDi.TabIndex = 2;
			this.cboSanBayDi.SelectionChangeCommitted += new System.EventHandler(this.cboSanBayDi_SelectionChangeCommitted);
			// 
			// txtDonGia
			// 
			this.txtDonGia.Location = new System.Drawing.Point(106, 141);
			this.txtDonGia.Margin = new System.Windows.Forms.Padding(2);
			this.txtDonGia.Name = "txtDonGia";
			this.txtDonGia.Size = new System.Drawing.Size(84, 20);
			this.txtDonGia.TabIndex = 5;
			this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
			// 
			// cboMaHangVe
			// 
			this.cboMaHangVe.FormattingEnabled = true;
			this.cboMaHangVe.Location = new System.Drawing.Point(106, 110);
			this.cboMaHangVe.Margin = new System.Windows.Forms.Padding(2);
			this.cboMaHangVe.Name = "cboMaHangVe";
			this.cboMaHangVe.Size = new System.Drawing.Size(176, 21);
			this.cboMaHangVe.TabIndex = 4;
			// 
			// cboMaTuyenBay
			// 
			this.cboMaTuyenBay.FormattingEnabled = true;
			this.cboMaTuyenBay.Location = new System.Drawing.Point(106, 16);
			this.cboMaTuyenBay.Margin = new System.Windows.Forms.Padding(2);
			this.cboMaTuyenBay.Name = "cboMaTuyenBay";
			this.cboMaTuyenBay.Size = new System.Drawing.Size(176, 21);
			this.cboMaTuyenBay.TabIndex = 1;
			this.cboMaTuyenBay.SelectionChangeCommitted += new System.EventHandler(this.cboMaTuyenBay_SelectionChangeCommitted);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(5, 145);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(44, 13);
			this.label18.TabIndex = 44;
			this.label18.Text = "Đơn giá";
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.SystemColors.Control;
			this.button1.Location = new System.Drawing.Point(5, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(32, 29);
			this.button1.TabIndex = 16;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmQuanLyDonGia
			// 
			this.AcceptButton = this.btnThem;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnThoat;
			this.ClientSize = new System.Drawing.Size(948, 551);
			this.Controls.Add(this.gbxThaoTac);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.gboDSMayBay);
			this.Controls.Add(this.gbxTTMayBay);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "frmQuanLyDonGia";
			this.Text = "Thêm đơn giá";
			this.Shown += new System.EventHandler(this.frmQuanLyDonGia_Shown);
			this.gbxThaoTac.ResumeLayout(false);
			this.gbxThaoTac.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.gboDSMayBay.ResumeLayout(false);
			this.gboDSMayBay.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvDonGia)).EndInit();
			this.gbxTTMayBay.ResumeLayout(false);
			this.gbxTTMayBay.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label20;
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
        private System.Windows.Forms.GroupBox gboDSMayBay;
        private System.Windows.Forms.DataGridView dtgvDonGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox gbxTTMayBay;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.ComboBox cboSanBayDen;
        private System.Windows.Forms.ComboBox cboSanBayDi;
        private System.Windows.Forms.ComboBox cboMaHangVe;
        private System.Windows.Forms.ComboBox cboMaTuyenBay;
        private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Button button1;
	}
}