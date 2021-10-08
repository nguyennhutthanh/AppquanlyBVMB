namespace Plane_Ticket
{
    partial class frmBaoCaoNam
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.btnThoat = new System.Windows.Forms.Button();
			this.crvBaoCaoNam = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.btnXemBaoCao = new System.Windows.Forms.Button();
			this.dtpNam = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.btnThoat);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(957, 47);
			this.panel1.TabIndex = 126;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(359, 11);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(155, 24);
			this.label7.TabIndex = 39;
			this.label7.Text = "BÁO CÁO NĂM";
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
			// crvBaoCaoNam
			// 
			this.crvBaoCaoNam.ActiveViewIndex = -1;
			this.crvBaoCaoNam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.crvBaoCaoNam.Cursor = System.Windows.Forms.Cursors.Default;
			this.crvBaoCaoNam.Location = new System.Drawing.Point(9, 80);
			this.crvBaoCaoNam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.crvBaoCaoNam.Name = "crvBaoCaoNam";
			this.crvBaoCaoNam.Size = new System.Drawing.Size(930, 462);
			this.crvBaoCaoNam.TabIndex = 125;
			this.crvBaoCaoNam.ToolPanelWidth = 150;
			// 
			// btnXemBaoCao
			// 
			this.btnXemBaoCao.AutoSize = true;
			this.btnXemBaoCao.Location = new System.Drawing.Point(461, 53);
			this.btnXemBaoCao.Name = "btnXemBaoCao";
			this.btnXemBaoCao.Size = new System.Drawing.Size(80, 23);
			this.btnXemBaoCao.TabIndex = 123;
			this.btnXemBaoCao.Text = "Xem báo cáo";
			this.btnXemBaoCao.UseVisualStyleBackColor = true;
			this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
			// 
			// dtpNam
			// 
			this.dtpNam.CustomFormat = "yyyy";
			this.dtpNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNam.Location = new System.Drawing.Point(363, 54);
			this.dtpNam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dtpNam.Name = "dtpNam";
			this.dtpNam.Size = new System.Drawing.Size(94, 20);
			this.dtpNam.TabIndex = 127;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(331, 56);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 128;
			this.label1.Text = "Năm";
			// 
			// frmBaoCaoNam
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(948, 551);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpNam);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.crvBaoCaoNam);
			this.Controls.Add(this.btnXemBaoCao);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "frmBaoCaoNam";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Báo cáo năm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThoat;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvBaoCaoNam;
        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.DateTimePicker dtpNam;
        private System.Windows.Forms.Label label1;
    }
}