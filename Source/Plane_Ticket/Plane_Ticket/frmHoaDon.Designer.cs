
namespace Plane_Ticket
{
	partial class frmHoaDon
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
			this.label17 = new System.Windows.Forms.Label();
			this.btnThoat = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtTimKiemKhach = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.crvInHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(413, 14);
			this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(106, 24);
			this.label17.TabIndex = 39;
			this.label17.Text = "HÓA ĐƠN";
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
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.panel1.Controls.Add(this.label17);
			this.panel1.Controls.Add(this.btnThoat);
			this.panel1.Location = new System.Drawing.Point(1, 1);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(957, 47);
			this.panel1.TabIndex = 76;
			// 
			// txtTimKiemKhach
			// 
			this.txtTimKiemKhach.Location = new System.Drawing.Point(712, 73);
			this.txtTimKiemKhach.Name = "txtTimKiemKhach";
			this.txtTimKiemKhach.Size = new System.Drawing.Size(163, 20);
			this.txtTimKiemKhach.TabIndex = 127;
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::Plane_Ticket.Properties.Resources.btnTimKiem;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.SystemColors.Control;
			this.button1.Location = new System.Drawing.Point(894, 68);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(35, 29);
			this.button1.TabIndex = 128;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(639, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 20);
			this.label1.TabIndex = 129;
			this.label1.Text = "Mã Vé:";
			// 
			// crvInHoaDon
			// 
			this.crvInHoaDon.ActiveViewIndex = -1;
			this.crvInHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.crvInHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
			this.crvInHoaDon.Location = new System.Drawing.Point(12, 117);
			this.crvInHoaDon.Name = "crvInHoaDon";
			this.crvInHoaDon.Size = new System.Drawing.Size(933, 427);
			this.crvInHoaDon.TabIndex = 130;
			// 
			// frmHoaDon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(957, 556);
			this.Controls.Add(this.crvInHoaDon);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtTimKiemKhach);
			this.Controls.Add(this.panel1);
			this.Name = "frmHoaDon";
			this.Text = "Hóa đơn";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtTimKiemKhach;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		public CrystalDecisions.Windows.Forms.CrystalReportViewer crvInHoaDon;
	}
}