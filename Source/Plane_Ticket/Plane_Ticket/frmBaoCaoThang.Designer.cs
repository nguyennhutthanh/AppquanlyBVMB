namespace Plane_Ticket
{
    partial class frmBaoCaoThang
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
			this.btnXemBaoCao = new System.Windows.Forms.Button();
			this.crvBaoCaoThang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.btnThoat = new System.Windows.Forms.Button();
			this.dtpThangNam = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnXemBaoCao
			// 
			this.btnXemBaoCao.AutoSize = true;
			this.btnXemBaoCao.Location = new System.Drawing.Point(449, 50);
			this.btnXemBaoCao.Name = "btnXemBaoCao";
			this.btnXemBaoCao.Size = new System.Drawing.Size(80, 28);
			this.btnXemBaoCao.TabIndex = 9;
			this.btnXemBaoCao.Text = "Xem báo cáo";
			this.btnXemBaoCao.UseVisualStyleBackColor = true;
			this.btnXemBaoCao.Click += new System.EventHandler(this.btnXuatBaoCao_Click);
			// 
			// crvBaoCaoThang
			// 
			this.crvBaoCaoThang.ActiveViewIndex = -1;
			this.crvBaoCaoThang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.crvBaoCaoThang.Cursor = System.Windows.Forms.Cursors.Default;
			this.crvBaoCaoThang.Location = new System.Drawing.Point(9, 80);
			this.crvBaoCaoThang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.crvBaoCaoThang.Name = "crvBaoCaoThang";
			this.crvBaoCaoThang.Size = new System.Drawing.Size(930, 462);
			this.crvBaoCaoThang.TabIndex = 13;
			this.crvBaoCaoThang.ToolPanelWidth = 150;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.btnThoat);
			this.panel1.Location = new System.Drawing.Point(0, -1);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(957, 47);
			this.panel1.TabIndex = 121;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(359, 11);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(181, 24);
			this.label7.TabIndex = 39;
			this.label7.Text = "BÁO CÁO THÁNG";
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
			this.btnThoat.TabIndex = 40;
			this.btnThoat.UseVisualStyleBackColor = false;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// dtpThangNam
			// 
			this.dtpThangNam.CustomFormat = "MM/yyyy";
			this.dtpThangNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpThangNam.Location = new System.Drawing.Point(360, 54);
			this.dtpThangNam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dtpThangNam.Name = "dtpThangNam";
			this.dtpThangNam.Size = new System.Drawing.Size(84, 20);
			this.dtpThangNam.TabIndex = 122;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(296, 57);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 13);
			this.label1.TabIndex = 123;
			this.label1.Text = "Tháng năm";
			// 
			// frmBaoCaoThang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(948, 551);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpThangNam);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.crvBaoCaoThang);
			this.Controls.Add(this.btnXemBaoCao);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "frmBaoCaoThang";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Báo cáo tháng";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnXemBaoCao;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvBaoCaoThang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DateTimePicker dtpThangNam;
        private System.Windows.Forms.Label label1;
    }
}