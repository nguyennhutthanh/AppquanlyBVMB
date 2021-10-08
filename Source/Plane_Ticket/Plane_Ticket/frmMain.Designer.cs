namespace Plane_Ticket
{
    partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.mstrMain = new System.Windows.Forms.MenuStrip();
			this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thoatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.thaoTacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.banVeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.QuanLyThongTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quanLyChuyenBayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.quanLyTuyenBayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quanLySanBayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quanLyMayBayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quanLyHangVeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quanLyDonGiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quanLyKhachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.themNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thayDoiQuyDinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.traCuuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.traCuuChuyenBayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.baoCaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.baoCaoThangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.baoCaoNamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.troGiupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.huongDanSuDungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thongTInNhaSanXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMain = new System.Windows.Forms.ToolStrip();
			this.toolStripBtnBanVe = new System.Windows.Forms.ToolStripButton();
			this.toolStripBtnTraCuuChuyenBay = new System.Windows.Forms.ToolStripButton();
			this.toolStripBtnDangXuat = new System.Windows.Forms.ToolStripButton();
			this.tabCtrlMain = new System.Windows.Forms.TabControl();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbUsername = new System.Windows.Forms.Label();
			this.lbMaNhanVien = new System.Windows.Forms.Label();
			this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mstrMain.SuspendLayout();
			this.toolStripMain.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mstrMain
			// 
			this.mstrMain.BackColor = System.Drawing.Color.White;
			this.mstrMain.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mstrMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongToolStripMenuItem,
            this.thaoTacToolStripMenuItem,
            this.traCuuToolStripMenuItem,
            this.baoCaoToolStripMenuItem,
            this.troGiupToolStripMenuItem});
			this.mstrMain.Location = new System.Drawing.Point(0, 0);
			this.mstrMain.Name = "mstrMain";
			this.mstrMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.mstrMain.Size = new System.Drawing.Size(956, 24);
			this.mstrMain.TabIndex = 2;
			this.mstrMain.Text = "menuStrip1";
			// 
			// heThongToolStripMenuItem
			// 
			this.heThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangXuatToolStripMenuItem,
            this.thoatToolStripMenuItem1});
			this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
			this.heThongToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.heThongToolStripMenuItem.Text = "Hệ thống";
			// 
			// dangXuatToolStripMenuItem
			// 
			this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
			this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.dangXuatToolStripMenuItem.Text = "Đăng xuất";
			this.dangXuatToolStripMenuItem.Click += new System.EventHandler(this.dangXuatToolStripMenuItem_Click);
			// 
			// thoatToolStripMenuItem1
			// 
			this.thoatToolStripMenuItem1.Name = "thoatToolStripMenuItem1";
			this.thoatToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
			this.thoatToolStripMenuItem1.Text = "Thoát";
			// 
			// thaoTacToolStripMenuItem
			// 
			this.thaoTacToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.banVeToolStripMenuItem,
            this.QuanLyThongTinToolStripMenuItem,
            this.thayDoiQuyDinhToolStripMenuItem});
			this.thaoTacToolStripMenuItem.Name = "thaoTacToolStripMenuItem";
			this.thaoTacToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
			this.thaoTacToolStripMenuItem.Text = "Thao tác";
			// 
			// banVeToolStripMenuItem
			// 
			this.banVeToolStripMenuItem.Name = "banVeToolStripMenuItem";
			this.banVeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.banVeToolStripMenuItem.Text = "Bán vé";
			this.banVeToolStripMenuItem.Click += new System.EventHandler(this.banVeToolStripMenuItem_Click);
			// 
			// QuanLyThongTinToolStripMenuItem
			// 
			this.QuanLyThongTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyChuyenBayToolStripMenuItem1,
            this.quanLyTuyenBayToolStripMenuItem,
            this.quanLySanBayToolStripMenuItem,
            this.quanLyMayBayToolStripMenuItem,
            this.quanLyHangVeToolStripMenuItem,
            this.quanLyDonGiaToolStripMenuItem,
            this.quanLyKhachHangToolStripMenuItem,
            this.themNhanVienToolStripMenuItem});
			this.QuanLyThongTinToolStripMenuItem.Name = "QuanLyThongTinToolStripMenuItem";
			this.QuanLyThongTinToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.QuanLyThongTinToolStripMenuItem.Text = "Quản lý thông tin";
			// 
			// quanLyChuyenBayToolStripMenuItem1
			// 
			this.quanLyChuyenBayToolStripMenuItem1.Name = "quanLyChuyenBayToolStripMenuItem1";
			this.quanLyChuyenBayToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
			this.quanLyChuyenBayToolStripMenuItem1.Text = "Chuyến bay";
			this.quanLyChuyenBayToolStripMenuItem1.Click += new System.EventHandler(this.themChuyenBayToolStripMenuItem1_Click);
			// 
			// quanLyTuyenBayToolStripMenuItem
			// 
			this.quanLyTuyenBayToolStripMenuItem.Name = "quanLyTuyenBayToolStripMenuItem";
			this.quanLyTuyenBayToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.quanLyTuyenBayToolStripMenuItem.Text = "Tuyến bay";
			this.quanLyTuyenBayToolStripMenuItem.Click += new System.EventHandler(this.themTuyenBayToolStripMenuItem_Click);
			// 
			// quanLySanBayToolStripMenuItem
			// 
			this.quanLySanBayToolStripMenuItem.Name = "quanLySanBayToolStripMenuItem";
			this.quanLySanBayToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.quanLySanBayToolStripMenuItem.Text = "Sân bay";
			this.quanLySanBayToolStripMenuItem.Click += new System.EventHandler(this.themSanBayToolStripMenuItem_Click);
			// 
			// quanLyMayBayToolStripMenuItem
			// 
			this.quanLyMayBayToolStripMenuItem.Name = "quanLyMayBayToolStripMenuItem";
			this.quanLyMayBayToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.quanLyMayBayToolStripMenuItem.Text = "Máy bay";
			this.quanLyMayBayToolStripMenuItem.Click += new System.EventHandler(this.themMayBayToolStripMenuItem_Click);
			// 
			// quanLyHangVeToolStripMenuItem
			// 
			this.quanLyHangVeToolStripMenuItem.Name = "quanLyHangVeToolStripMenuItem";
			this.quanLyHangVeToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.quanLyHangVeToolStripMenuItem.Text = "Hạng vé";
			this.quanLyHangVeToolStripMenuItem.Click += new System.EventHandler(this.themHangVeToolStripMenuItem_Click);
			// 
			// quanLyDonGiaToolStripMenuItem
			// 
			this.quanLyDonGiaToolStripMenuItem.Name = "quanLyDonGiaToolStripMenuItem";
			this.quanLyDonGiaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.quanLyDonGiaToolStripMenuItem.Text = "Đơn giá";
			this.quanLyDonGiaToolStripMenuItem.Click += new System.EventHandler(this.themDonGiaToolStripMenuItem_Click);
			// 
			// quanLyKhachHangToolStripMenuItem
			// 
			this.quanLyKhachHangToolStripMenuItem.Name = "quanLyKhachHangToolStripMenuItem";
			this.quanLyKhachHangToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.quanLyKhachHangToolStripMenuItem.Text = "Khách hàng";
			this.quanLyKhachHangToolStripMenuItem.Click += new System.EventHandler(this.themKhachHangToolStripMenuItem_Click);
			// 
			// themNhanVienToolStripMenuItem
			// 
			this.themNhanVienToolStripMenuItem.Name = "themNhanVienToolStripMenuItem";
			this.themNhanVienToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.themNhanVienToolStripMenuItem.Text = "Nhân viên";
			this.themNhanVienToolStripMenuItem.Click += new System.EventHandler(this.themNhanVienToolStripMenuItem_Click);
			// 
			// thayDoiQuyDinhToolStripMenuItem
			// 
			this.thayDoiQuyDinhToolStripMenuItem.Name = "thayDoiQuyDinhToolStripMenuItem";
			this.thayDoiQuyDinhToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.thayDoiQuyDinhToolStripMenuItem.Text = "Thay đổi quy định";
			this.thayDoiQuyDinhToolStripMenuItem.Click += new System.EventHandler(this.thayDoiQuyDinhToolStripMenuItem_Click);
			// 
			// traCuuToolStripMenuItem
			// 
			this.traCuuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traCuuChuyenBayToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem});
			this.traCuuToolStripMenuItem.Name = "traCuuToolStripMenuItem";
			this.traCuuToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.traCuuToolStripMenuItem.Text = "Tra cứu";
			// 
			// traCuuChuyenBayToolStripMenuItem
			// 
			this.traCuuChuyenBayToolStripMenuItem.Name = "traCuuChuyenBayToolStripMenuItem";
			this.traCuuChuyenBayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.traCuuChuyenBayToolStripMenuItem.Text = "Chuyến bay";
			this.traCuuChuyenBayToolStripMenuItem.Click += new System.EventHandler(this.traCuuChuyenBayToolStripMenuItem_Click);
			// 
			// baoCaoToolStripMenuItem
			// 
			this.baoCaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baoCaoThangToolStripMenuItem,
            this.baoCaoNamToolStripMenuItem});
			this.baoCaoToolStripMenuItem.Name = "baoCaoToolStripMenuItem";
			this.baoCaoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.baoCaoToolStripMenuItem.Text = "Báo cáo";
			// 
			// baoCaoThangToolStripMenuItem
			// 
			this.baoCaoThangToolStripMenuItem.Name = "baoCaoThangToolStripMenuItem";
			this.baoCaoThangToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.baoCaoThangToolStripMenuItem.Text = "Tháng";
			this.baoCaoThangToolStripMenuItem.Click += new System.EventHandler(this.baoCaoThangToolStripMenuItem_Click);
			// 
			// baoCaoNamToolStripMenuItem
			// 
			this.baoCaoNamToolStripMenuItem.Name = "baoCaoNamToolStripMenuItem";
			this.baoCaoNamToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.baoCaoNamToolStripMenuItem.Text = "Năm";
			this.baoCaoNamToolStripMenuItem.Click += new System.EventHandler(this.baoCaoNamToolStripMenuItem_Click);
			// 
			// troGiupToolStripMenuItem
			// 
			this.troGiupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.huongDanSuDungToolStripMenuItem,
            this.thongTInNhaSanXuatToolStripMenuItem});
			this.troGiupToolStripMenuItem.Name = "troGiupToolStripMenuItem";
			this.troGiupToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.troGiupToolStripMenuItem.Text = "Trợ giúp";
			// 
			// huongDanSuDungToolStripMenuItem
			// 
			this.huongDanSuDungToolStripMenuItem.Name = "huongDanSuDungToolStripMenuItem";
			this.huongDanSuDungToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.huongDanSuDungToolStripMenuItem.Text = "Hướng dẫn sử dụng";
			this.huongDanSuDungToolStripMenuItem.Click += new System.EventHandler(this.huongDanSuDungToolStripMenuItem_Click);
			// 
			// thongTInNhaSanXuatToolStripMenuItem
			// 
			this.thongTInNhaSanXuatToolStripMenuItem.Name = "thongTInNhaSanXuatToolStripMenuItem";
			this.thongTInNhaSanXuatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.thongTInNhaSanXuatToolStripMenuItem.Text = "Nhóm tác giả";
			this.thongTInNhaSanXuatToolStripMenuItem.Click += new System.EventHandler(this.thongTInNhaSanXuatToolStripMenuItem_Click);
			// 
			// toolStripMain
			// 
			this.toolStripMain.AutoSize = false;
			this.toolStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.toolStripMain.ImageScalingSize = new System.Drawing.Size(50, 50);
			this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnBanVe,
            this.toolStripBtnTraCuuChuyenBay,
            this.toolStripBtnDangXuat});
			this.toolStripMain.Location = new System.Drawing.Point(0, 24);
			this.toolStripMain.Name = "toolStripMain";
			this.toolStripMain.Size = new System.Drawing.Size(956, 79);
			this.toolStripMain.TabIndex = 1;
			this.toolStripMain.Text = "toolStrip1";
			// 
			// toolStripBtnBanVe
			// 
			this.toolStripBtnBanVe.AutoSize = false;
			this.toolStripBtnBanVe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripBtnBanVe.Image = global::Plane_Ticket.Properties.Resources.toolBanVe;
			this.toolStripBtnBanVe.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtnBanVe.Name = "toolStripBtnBanVe";
			this.toolStripBtnBanVe.Size = new System.Drawing.Size(120, 94);
			this.toolStripBtnBanVe.Text = "Bán vé";
			this.toolStripBtnBanVe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.toolStripBtnBanVe.Click += new System.EventHandler(this.banVeToolStripMenuItem_Click);
			// 
			// toolStripBtnTraCuuChuyenBay
			// 
			this.toolStripBtnTraCuuChuyenBay.AutoSize = false;
			this.toolStripBtnTraCuuChuyenBay.Image = global::Plane_Ticket.Properties.Resources.toolTraCuuChuyenBay;
			this.toolStripBtnTraCuuChuyenBay.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtnTraCuuChuyenBay.Name = "toolStripBtnTraCuuChuyenBay";
			this.toolStripBtnTraCuuChuyenBay.Size = new System.Drawing.Size(120, 94);
			this.toolStripBtnTraCuuChuyenBay.Text = "Tra cứu chuyến bay";
			this.toolStripBtnTraCuuChuyenBay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.toolStripBtnTraCuuChuyenBay.Click += new System.EventHandler(this.traCuuChuyenBayToolStripMenuItem_Click);
			// 
			// toolStripBtnDangXuat
			// 
			this.toolStripBtnDangXuat.AutoSize = false;
			this.toolStripBtnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnDangXuat.Image")));
			this.toolStripBtnDangXuat.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtnDangXuat.Name = "toolStripBtnDangXuat";
			this.toolStripBtnDangXuat.Size = new System.Drawing.Size(120, 94);
			this.toolStripBtnDangXuat.Text = "Đăng xuất";
			this.toolStripBtnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.toolStripBtnDangXuat.Click += new System.EventHandler(this.toolStripBtnDangXuat_Click);
			// 
			// tabCtrlMain
			// 
			this.tabCtrlMain.Location = new System.Drawing.Point(0, 99);
			this.tabCtrlMain.Margin = new System.Windows.Forms.Padding(2);
			this.tabCtrlMain.Name = "tabCtrlMain";
			this.tabCtrlMain.SelectedIndex = 0;
			this.tabCtrlMain.Size = new System.Drawing.Size(956, 577);
			this.tabCtrlMain.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.panel1.Controls.Add(this.lbUsername);
			this.panel1.Controls.Add(this.lbMaNhanVien);
			this.panel1.Location = new System.Drawing.Point(773, 25);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(182, 69);
			this.panel1.TabIndex = 3;
			// 
			// lbUsername
			// 
			this.lbUsername.AutoSize = true;
			this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbUsername.Location = new System.Drawing.Point(2, 46);
			this.lbUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbUsername.Name = "lbUsername";
			this.lbUsername.Size = new System.Drawing.Size(51, 16);
			this.lbUsername.TabIndex = 0;
			this.lbUsername.Text = "label1";
			// 
			// lbMaNhanVien
			// 
			this.lbMaNhanVien.AutoSize = true;
			this.lbMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMaNhanVien.Location = new System.Drawing.Point(2, 11);
			this.lbMaNhanVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbMaNhanVien.Name = "lbMaNhanVien";
			this.lbMaNhanVien.Size = new System.Drawing.Size(51, 16);
			this.lbMaNhanVien.TabIndex = 0;
			this.lbMaNhanVien.Text = "label1";
			// 
			// hóaĐơnToolStripMenuItem
			// 
			this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
			this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
			this.hóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(956, 679);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tabCtrlMain);
			this.Controls.Add(this.toolStripMain);
			this.Controls.Add(this.mstrMain);
			this.MainMenuStrip = this.mstrMain;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phần mềm bán vé máy bay";
			this.mstrMain.ResumeLayout(false);
			this.mstrMain.PerformLayout();
			this.toolStripMain.ResumeLayout(false);
			this.toolStripMain.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstrMain;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thaoTacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuanLyThongTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyTuyenBayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCuuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCuuChuyenBayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baoCaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baoCaoThangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baoCaoNamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem troGiupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huongDanSuDungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongTInNhaSanXuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem banVeToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripBtnBanVe;
        private System.Windows.Forms.ToolStripButton toolStripBtnTraCuuChuyenBay;
        private System.Windows.Forms.ToolStripMenuItem quanLySanBayToolStripMenuItem;
        private System.Windows.Forms.TabControl tabCtrlMain;
        private System.Windows.Forms.ToolStripButton toolStripBtnDangXuat;
        private System.Windows.Forms.ToolStripMenuItem quanLyMayBayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyChuyenBayToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quanLyHangVeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyKhachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyDonGiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themNhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbMaNhanVien;
        private System.Windows.Forms.ToolStripMenuItem thayDoiQuyDinhToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
	}
}

