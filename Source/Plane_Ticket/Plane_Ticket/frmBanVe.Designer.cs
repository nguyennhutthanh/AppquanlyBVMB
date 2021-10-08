namespace Plane_Ticket
{
    partial class frmBanVe
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanVe));
			this.txtTenKhachHang = new System.Windows.Forms.TextBox();
			this.txtSDT = new System.Windows.Forms.TextBox();
			this.txtCMND = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cboHangVe = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cboMaChuyenBay = new System.Windows.Forms.ComboBox();
			this.txtSanBayDi = new System.Windows.Forms.TextBox();
			this.txtSanBayDen = new System.Windows.Forms.TextBox();
			this.txtThoiGianKhoiHanh = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtGiaTien = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtThoiGIanBay = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtMaTuyenBay = new System.Windows.Forms.TextBox();
			this.gbxThaoTac = new System.Windows.Forms.GroupBox();
			this.btnTraCuu = new System.Windows.Forms.Button();
			this.btnMuaVe = new System.Windows.Forms.Button();
			this.btnDatVe = new System.Windows.Forms.Button();
			this.label16 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label17 = new System.Windows.Forms.Label();
			this.btnThoat = new System.Windows.Forms.Button();
			this.gbxDSVe = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.dtgvVe = new System.Windows.Forms.DataGridView();
			this.label18 = new System.Windows.Forms.Label();
			this.txtTimKiemMaVe = new System.Windows.Forms.TextBox();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.gbxTTVe = new System.Windows.Forms.GroupBox();
			this.btnChiTietGheTrong = new System.Windows.Forms.Button();
			this.txtSoGheTrong = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.gbxThaoTac.SuspendLayout();
			this.panel1.SuspendLayout();
			this.gbxDSVe.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvVe)).BeginInit();
			this.gbxTTVe.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtTenKhachHang
			// 
			this.txtTenKhachHang.Location = new System.Drawing.Point(113, 245);
			this.txtTenKhachHang.Name = "txtTenKhachHang";
			this.txtTenKhachHang.Size = new System.Drawing.Size(167, 20);
			this.txtTenKhachHang.TabIndex = 2;
			// 
			// txtSDT
			// 
			this.txtSDT.Location = new System.Drawing.Point(113, 278);
			this.txtSDT.Name = "txtSDT";
			this.txtSDT.Size = new System.Drawing.Size(167, 20);
			this.txtSDT.TabIndex = 3;
			// 
			// txtCMND
			// 
			this.txtCMND.Location = new System.Drawing.Point(114, 212);
			this.txtCMND.Name = "txtCMND";
			this.txtCMND.Size = new System.Drawing.Size(167, 20);
			this.txtCMND.TabIndex = 1;
			this.txtCMND.TextChanged += new System.EventHandler(this.txtCMND_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(4, 317);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(68, 13);
			this.label10.TabIndex = 64;
			this.label10.Text = "Tên hạng vé";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(5, 282);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(59, 13);
			this.label9.TabIndex = 63;
			this.label9.Text = "Điện Thoại";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(5, 249);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(87, 13);
			this.label8.TabIndex = 62;
			this.label8.Text = "Tên Khách hàng";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(4, 216);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(39, 13);
			this.label7.TabIndex = 61;
			this.label7.Text = "CMND";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(4, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 13);
			this.label4.TabIndex = 59;
			this.label4.Text = "Thời gian khởi hành";
			// 
			// cboHangVe
			// 
			this.cboHangVe.FormattingEnabled = true;
			this.cboHangVe.Location = new System.Drawing.Point(114, 311);
			this.cboHangVe.Name = "cboHangVe";
			this.cboHangVe.Size = new System.Drawing.Size(167, 21);
			this.cboHangVe.TabIndex = 4;
			this.cboHangVe.SelectedValueChanged += new System.EventHandler(this.cboHangVe_SelectedValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(5, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 55;
			this.label3.Text = "Sân Bay Đến";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 54;
			this.label1.Text = "Sân Bay Đi";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(5, 20);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 13);
			this.label6.TabIndex = 54;
			this.label6.Text = "Mã chuyến bay";
			// 
			// cboMaChuyenBay
			// 
			this.cboMaChuyenBay.FormattingEnabled = true;
			this.cboMaChuyenBay.Location = new System.Drawing.Point(115, 14);
			this.cboMaChuyenBay.Name = "cboMaChuyenBay";
			this.cboMaChuyenBay.Size = new System.Drawing.Size(167, 21);
			this.cboMaChuyenBay.TabIndex = 0;
			this.cboMaChuyenBay.TextUpdate += new System.EventHandler(this.cboMaChuyenBay_SelectedValueChanged);
			this.cboMaChuyenBay.SelectedValueChanged += new System.EventHandler(this.cboMaChuyenBay_SelectedValueChanged);
			// 
			// txtSanBayDi
			// 
			this.txtSanBayDi.Location = new System.Drawing.Point(114, 79);
			this.txtSanBayDi.Name = "txtSanBayDi";
			this.txtSanBayDi.ReadOnly = true;
			this.txtSanBayDi.Size = new System.Drawing.Size(167, 20);
			this.txtSanBayDi.TabIndex = 69;
			this.txtSanBayDi.TabStop = false;
			// 
			// txtSanBayDen
			// 
			this.txtSanBayDen.Location = new System.Drawing.Point(114, 109);
			this.txtSanBayDen.Name = "txtSanBayDen";
			this.txtSanBayDen.ReadOnly = true;
			this.txtSanBayDen.Size = new System.Drawing.Size(167, 20);
			this.txtSanBayDen.TabIndex = 69;
			this.txtSanBayDen.TabStop = false;
			// 
			// txtThoiGianKhoiHanh
			// 
			this.txtThoiGianKhoiHanh.Location = new System.Drawing.Point(114, 144);
			this.txtThoiGianKhoiHanh.Name = "txtThoiGianKhoiHanh";
			this.txtThoiGianKhoiHanh.ReadOnly = true;
			this.txtThoiGianKhoiHanh.Size = new System.Drawing.Size(167, 20);
			this.txtThoiGianKhoiHanh.TabIndex = 69;
			this.txtThoiGianKhoiHanh.TabStop = false;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(5, 384);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(43, 13);
			this.label11.TabIndex = 63;
			this.label11.Text = "Giá tiền";
			// 
			// txtGiaTien
			// 
			this.txtGiaTien.Location = new System.Drawing.Point(112, 380);
			this.txtGiaTien.Name = "txtGiaTien";
			this.txtGiaTien.ReadOnly = true;
			this.txtGiaTien.Size = new System.Drawing.Size(135, 20);
			this.txtGiaTien.TabIndex = 68;
			this.txtGiaTien.TabStop = false;
			this.txtGiaTien.TextChanged += new System.EventHandler(this.txtGiaTien_TextChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(4, 181);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(71, 13);
			this.label12.TabIndex = 59;
			this.label12.Text = "Thời gian bay";
			// 
			// txtThoiGIanBay
			// 
			this.txtThoiGIanBay.Location = new System.Drawing.Point(114, 177);
			this.txtThoiGIanBay.Name = "txtThoiGIanBay";
			this.txtThoiGIanBay.ReadOnly = true;
			this.txtThoiGIanBay.Size = new System.Drawing.Size(167, 20);
			this.txtThoiGIanBay.TabIndex = 69;
			this.txtThoiGIanBay.TabStop = false;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(5, 50);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(71, 13);
			this.label13.TabIndex = 54;
			this.label13.Text = "Mã tuyến bay";
			// 
			// txtMaTuyenBay
			// 
			this.txtMaTuyenBay.Location = new System.Drawing.Point(114, 46);
			this.txtMaTuyenBay.Name = "txtMaTuyenBay";
			this.txtMaTuyenBay.ReadOnly = true;
			this.txtMaTuyenBay.Size = new System.Drawing.Size(167, 20);
			this.txtMaTuyenBay.TabIndex = 69;
			this.txtMaTuyenBay.TabStop = false;
			// 
			// gbxThaoTac
			// 
			this.gbxThaoTac.Controls.Add(this.btnTraCuu);
			this.gbxThaoTac.Controls.Add(this.btnMuaVe);
			this.gbxThaoTac.Controls.Add(this.btnDatVe);
			this.gbxThaoTac.Controls.Add(this.label16);
			this.gbxThaoTac.Controls.Add(this.label5);
			this.gbxThaoTac.Controls.Add(this.label2);
			this.gbxThaoTac.Location = new System.Drawing.Point(9, 459);
			this.gbxThaoTac.Margin = new System.Windows.Forms.Padding(2);
			this.gbxThaoTac.Name = "gbxThaoTac";
			this.gbxThaoTac.Padding = new System.Windows.Forms.Padding(2);
			this.gbxThaoTac.Size = new System.Drawing.Size(285, 82);
			this.gbxThaoTac.TabIndex = 1;
			this.gbxThaoTac.TabStop = false;
			this.gbxThaoTac.Text = "Thao tác";
			// 
			// btnTraCuu
			// 
			this.btnTraCuu.BackgroundImage = global::Plane_Ticket.Properties.Resources.btnTimKiem;
			this.btnTraCuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnTraCuu.FlatAppearance.BorderSize = 0;
			this.btnTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTraCuu.Location = new System.Drawing.Point(210, 17);
			this.btnTraCuu.Margin = new System.Windows.Forms.Padding(2);
			this.btnTraCuu.Name = "btnTraCuu";
			this.btnTraCuu.Size = new System.Drawing.Size(41, 41);
			this.btnTraCuu.TabIndex = 64;
			this.btnTraCuu.UseVisualStyleBackColor = true;
			this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
			// 
			// btnMuaVe
			// 
			this.btnMuaVe.BackgroundImage = global::Plane_Ticket.Properties.Resources.btnMua;
			this.btnMuaVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnMuaVe.FlatAppearance.BorderSize = 0;
			this.btnMuaVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMuaVe.ForeColor = System.Drawing.SystemColors.Control;
			this.btnMuaVe.Location = new System.Drawing.Point(32, 17);
			this.btnMuaVe.Name = "btnMuaVe";
			this.btnMuaVe.Size = new System.Drawing.Size(44, 42);
			this.btnMuaVe.TabIndex = 5;
			this.btnMuaVe.UseVisualStyleBackColor = true;
			this.btnMuaVe.Click += new System.EventHandler(this.btnMuaVe_Click);
			// 
			// btnDatVe
			// 
			this.btnDatVe.BackgroundImage = global::Plane_Ticket.Properties.Resources.btnDat;
			this.btnDatVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnDatVe.FlatAppearance.BorderSize = 0;
			this.btnDatVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDatVe.Location = new System.Drawing.Point(124, 18);
			this.btnDatVe.Name = "btnDatVe";
			this.btnDatVe.Size = new System.Drawing.Size(41, 41);
			this.btnDatVe.TabIndex = 6;
			this.btnDatVe.UseVisualStyleBackColor = true;
			this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(180, 62);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(102, 13);
			this.label16.TabIndex = 63;
			this.label16.Text = "Tra cứu chuyến bay";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(126, 62);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 13);
			this.label5.TabIndex = 63;
			this.label5.Text = "Đặt vé";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(34, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 63;
			this.label2.Text = "Mua vé";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.panel1.Controls.Add(this.label17);
			this.panel1.Controls.Add(this.btnThoat);
			this.panel1.Location = new System.Drawing.Point(-3, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(957, 47);
			this.panel1.TabIndex = 75;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(400, 16);
			this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(182, 24);
			this.label17.TabIndex = 39;
			this.label17.Text = "BÁN VÉ MÁY BAY";
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
			this.btnThoat.TabIndex = 10;
			this.btnThoat.UseVisualStyleBackColor = false;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// gbxDSVe
			// 
			this.gbxDSVe.Controls.Add(this.button1);
			this.gbxDSVe.Controls.Add(this.dtgvVe);
			this.gbxDSVe.Controls.Add(this.label18);
			this.gbxDSVe.Controls.Add(this.txtTimKiemMaVe);
			this.gbxDSVe.Controls.Add(this.btnTimKiem);
			this.gbxDSVe.Location = new System.Drawing.Point(298, 52);
			this.gbxDSVe.Margin = new System.Windows.Forms.Padding(2);
			this.gbxDSVe.Name = "gbxDSVe";
			this.gbxDSVe.Padding = new System.Windows.Forms.Padding(2);
			this.gbxDSVe.Size = new System.Drawing.Size(640, 489);
			this.gbxDSVe.TabIndex = 2;
			this.gbxDSVe.TabStop = false;
			this.gbxDSVe.Text = "Danh sách vé";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.Control;
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.SystemColors.Control;
			this.button1.Location = new System.Drawing.Point(5, 19);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(28, 27);
			this.button1.TabIndex = 16;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dtgvVe
			// 
			this.dtgvVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvVe.Location = new System.Drawing.Point(4, 51);
			this.dtgvVe.Margin = new System.Windows.Forms.Padding(2);
			this.dtgvVe.Name = "dtgvVe";
			this.dtgvVe.RowTemplate.Height = 24;
			this.dtgvVe.Size = new System.Drawing.Size(632, 433);
			this.dtgvVe.TabIndex = 9;
			this.dtgvVe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvVe_CellClick);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(424, 24);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(52, 13);
			this.label18.TabIndex = 15;
			this.label18.Text = "Tìm kiếm ";
			// 
			// txtTimKiemMaVe
			// 
			this.txtTimKiemMaVe.Location = new System.Drawing.Point(481, 20);
			this.txtTimKiemMaVe.Name = "txtTimKiemMaVe";
			this.txtTimKiemMaVe.Size = new System.Drawing.Size(125, 20);
			this.txtTimKiemMaVe.TabIndex = 7;
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
			this.btnTimKiem.TabIndex = 8;
			this.btnTimKiem.UseVisualStyleBackColor = true;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// gbxTTVe
			// 
			this.gbxTTVe.Controls.Add(this.btnChiTietGheTrong);
			this.gbxTTVe.Controls.Add(this.txtThoiGIanBay);
			this.gbxTTVe.Controls.Add(this.cboMaChuyenBay);
			this.gbxTTVe.Controls.Add(this.label1);
			this.gbxTTVe.Controls.Add(this.label13);
			this.gbxTTVe.Controls.Add(this.label6);
			this.gbxTTVe.Controls.Add(this.txtGiaTien);
			this.gbxTTVe.Controls.Add(this.txtTenKhachHang);
			this.gbxTTVe.Controls.Add(this.txtSoGheTrong);
			this.gbxTTVe.Controls.Add(this.txtSDT);
			this.gbxTTVe.Controls.Add(this.txtSanBayDen);
			this.gbxTTVe.Controls.Add(this.label14);
			this.gbxTTVe.Controls.Add(this.label11);
			this.gbxTTVe.Controls.Add(this.label3);
			this.gbxTTVe.Controls.Add(this.label4);
			this.gbxTTVe.Controls.Add(this.txtCMND);
			this.gbxTTVe.Controls.Add(this.label10);
			this.gbxTTVe.Controls.Add(this.txtThoiGianKhoiHanh);
			this.gbxTTVe.Controls.Add(this.label15);
			this.gbxTTVe.Controls.Add(this.cboHangVe);
			this.gbxTTVe.Controls.Add(this.label9);
			this.gbxTTVe.Controls.Add(this.label12);
			this.gbxTTVe.Controls.Add(this.txtMaTuyenBay);
			this.gbxTTVe.Controls.Add(this.txtSanBayDi);
			this.gbxTTVe.Controls.Add(this.label8);
			this.gbxTTVe.Controls.Add(this.label7);
			this.gbxTTVe.Location = new System.Drawing.Point(9, 52);
			this.gbxTTVe.Margin = new System.Windows.Forms.Padding(2);
			this.gbxTTVe.Name = "gbxTTVe";
			this.gbxTTVe.Padding = new System.Windows.Forms.Padding(2);
			this.gbxTTVe.Size = new System.Drawing.Size(285, 402);
			this.gbxTTVe.TabIndex = 0;
			this.gbxTTVe.TabStop = false;
			this.gbxTTVe.Text = "Thông tin vé";
			// 
			// btnChiTietGheTrong
			// 
			this.btnChiTietGheTrong.Location = new System.Drawing.Point(214, 345);
			this.btnChiTietGheTrong.Margin = new System.Windows.Forms.Padding(2);
			this.btnChiTietGheTrong.Name = "btnChiTietGheTrong";
			this.btnChiTietGheTrong.Size = new System.Drawing.Size(66, 19);
			this.btnChiTietGheTrong.TabIndex = 70;
			this.btnChiTietGheTrong.Text = "Chi tiết";
			this.btnChiTietGheTrong.UseVisualStyleBackColor = true;
			this.btnChiTietGheTrong.Click += new System.EventHandler(this.btnChiTietGheTrong_Click);
			// 
			// txtSoGheTrong
			// 
			this.txtSoGheTrong.Location = new System.Drawing.Point(114, 346);
			this.txtSoGheTrong.Name = "txtSoGheTrong";
			this.txtSoGheTrong.ReadOnly = true;
			this.txtSoGheTrong.Size = new System.Drawing.Size(96, 20);
			this.txtSoGheTrong.TabIndex = 3;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(253, 383);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(30, 13);
			this.label14.TabIndex = 63;
			this.label14.Text = "VNĐ";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(6, 350);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(68, 13);
			this.label15.TabIndex = 63;
			this.label15.Text = "Số ghế trống";
			// 
			// frmBanVe
			// 
			this.AcceptButton = this.btnMuaVe;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.CancelButton = this.btnThoat;
			this.ClientSize = new System.Drawing.Size(948, 553);
			this.Controls.Add(this.gbxThaoTac);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.gbxDSVe);
			this.Controls.Add(this.gbxTTVe);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "frmBanVe";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Bán vé chuyến bay";
			this.Shown += new System.EventHandler(this.frmBanVe_Shown);
			this.gbxThaoTac.ResumeLayout(false);
			this.gbxThaoTac.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.gbxDSVe.ResumeLayout(false);
			this.gbxDSVe.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvVe)).EndInit();
			this.gbxTTVe.ResumeLayout(false);
			this.gbxTTVe.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboHangVe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboMaChuyenBay;
        private System.Windows.Forms.TextBox txtSanBayDi;
        private System.Windows.Forms.TextBox txtSanBayDen;
        private System.Windows.Forms.TextBox txtThoiGianKhoiHanh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtThoiGIanBay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaTuyenBay;
        private System.Windows.Forms.GroupBox gbxThaoTac;
        private System.Windows.Forms.Button btnMuaVe;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox gbxDSVe;
        private System.Windows.Forms.DataGridView dtgvVe;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTimKiemMaVe;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox gbxTTVe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnChiTietGheTrong;
        private System.Windows.Forms.TextBox txtSoGheTrong;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
    }
}