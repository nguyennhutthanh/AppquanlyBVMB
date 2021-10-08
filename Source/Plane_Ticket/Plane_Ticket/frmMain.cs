using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Plane_Ticket
{
	/// <summary>
	/// code by Minh huy 10/5/2021, 11:20 AM
	/// </summary>
	public partial class frmMain : Form
	{
		#region Properties
		private DataRow rowTTNhanVien;
		#endregion

		#region Initializes
		public frmMain(DataRow row)
		{
			InitializeComponent();
			rowTTNhanVien = row;
			KhoiTaoGiaoDien();
		}
		#endregion

		#region Methods

		#region CreateMenuAndToolStrip
		private bool CheckExistForm(Form frm)
		{
			foreach (TabPage t in tabCtrlMain.TabPages)
			{
				if (frm.Text == t.Text)
				{
					return true;
				}
			}
			return false;
		}
		private void ActiveChildForm(Form frm)
		{
			foreach (TabPage t in tabCtrlMain.TabPages)
			{
				if (frm.Text == t.Text)
				{
					tabCtrlMain.SelectedTab = t;
					break;
				}
			}
		}
		private TabPage CreateTabPage(Form frm)
		{
			TabPage tabPage = new TabPage { Text = frm.Text };
			tabPage.BorderStyle = BorderStyle.None;
			tabCtrlMain.TabPages.Add(tabPage);
			tabCtrlMain.SelectedTab = tabPage;
			frm.TopLevel = false;
			frm.Parent = tabPage;
			frm.BackColor = Color.White;
			frm.FormBorderStyle = FormBorderStyle.None;
			frm.Show();
			return tabPage;
		}
		private void dangNhapToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmDangNhap frm = new frmDangNhap();
			if (!CheckExistForm(frm))
			{
				CreateTabPage(frm);
			}
			else
			{
				ActiveChildForm(frm);
			}
		}
		public void banVeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmBanVe frm = new frmBanVe(rowTTNhanVien);
			if (!CheckExistForm(frm))
			{
				CreateTabPage(frm);
			}
			else
			{
				ActiveChildForm(frm);
			}
		}
		private void themTuyenBayToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmQuanLyTuyenBay frm = new frmQuanLyTuyenBay();
			if (!CheckExistForm(frm))
			{
				CreateTabPage(frm);
			}
			else
			{
				ActiveChildForm(frm);
			}
		}
		private void themChuyenBayToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			frmQuanLyChuyenBay frm = new frmQuanLyChuyenBay();
			if (!CheckExistForm(frm))
			{
				CreateTabPage(frm);
			}
			else
			{
				ActiveChildForm(frm);
			}
		}
		private void traCuuChuyenBayToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmTraCuuChuyenBay frm = new frmTraCuuChuyenBay();
			if (!CheckExistForm(frm))
			{
				CreateTabPage(frm);
			}
			else
			{
				ActiveChildForm(frm);
			}
		}
		private void baoCaoThangToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmBaoCaoThang frm = new frmBaoCaoThang();
			if (!CheckExistForm(frm))
			{
				CreateTabPage(frm);
			}
			else
			{
				ActiveChildForm(frm);
			}
		}
		private void baoCaoNamToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmBaoCaoNam frm = new frmBaoCaoNam();
			if (!CheckExistForm(frm))
			{
				CreateTabPage(frm);
			}
			else
			{
				ActiveChildForm(frm);
			}
		}
		private void themSanBayToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmQuanLySanBay frm = new frmQuanLySanBay();
			if (!CheckExistForm(frm))
			{
				CreateTabPage(frm);
			}
			else
			{
				ActiveChildForm(frm);
			}
		}
		private void themMayBayToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmQuanLyMayBay frm = new frmQuanLyMayBay();
			if (!CheckExistForm(frm))
			{
				CreateTabPage(frm);
			}
			else
			{
				ActiveChildForm(frm);
			}
		}
		private void themHangVeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmQuanLyHangVe frm = new frmQuanLyHangVe();
			if (!CheckExistForm(frm))
			{
				CreateTabPage(frm);
			}
			else
			{
				ActiveChildForm(frm);
			}
		}
		private void themKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmQuanLyKhachHang frm = new frmQuanLyKhachHang();
			if (!CheckExistForm(frm))
			{
				CreateTabPage(frm);
			}
			else
			{
				ActiveChildForm(frm);
			}
		}
		private void themDonGiaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmQuanLyDonGia frm = new frmQuanLyDonGia();
			if (!CheckExistForm(frm))
			{
				CreateTabPage(frm);
			}
			else
			{
				ActiveChildForm(frm);
			}
		}
		private void themNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmQuanLyNhanVien frm = new frmQuanLyNhanVien();
			if (!CheckExistForm(frm))
			{
				CreateTabPage(frm);
			}
			else
			{
				ActiveChildForm(frm);
			}
		}
		private void thayDoiQuyDinhToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmThayDoiQuyDinh frm = new frmThayDoiQuyDinh();
			if (!CheckExistForm(frm))
			{
				CreateTabPage(frm);
			}
			else
			{
				ActiveChildForm(frm);
			}
		}
		private void toolStripBtnDangXuat_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.Hide();
				Form frm = new frmDangNhap();
				frm.ShowDialog();
				this.Close();
			}
		}

		private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.Hide();
				Form frm = new frmDangNhap();
				frm.ShowDialog();
				this.Close();
			}
		}

		#endregion

		private void KhoiTaoGiaoDien()
		{
			lbMaNhanVien.Text = "Mã nhân viên: " + rowTTNhanVien[2].ToString();
			lbUsername.Text = "Username: " + rowTTNhanVien[0].ToString();
			int type = Convert.ToInt32(rowTTNhanVien[3].ToString());
			if (type == 0)
			{
				mstrMain.Enabled = true;
				toolStripMain.Enabled = true;
			}
			if (type == 1)
			{
				mstrMain.Enabled = true;
				toolStripMain.Enabled = true;
				QuanLyThongTinToolStripMenuItem.Enabled = false;
				baoCaoToolStripMenuItem.Enabled = false;
			}
		}



		#endregion

		private void huongDanSuDungToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmHuongDan frm = new frmHuongDan();
			if (!CheckExistForm(frm))
			{
				CreateTabPage(frm);
			}
			else
			{
				ActiveChildForm(frm);
			}
		}

		private void thongTInNhaSanXuatToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmNhomTacGia frm = new frmNhomTacGia();
			if (!CheckExistForm(frm))
			{
				CreateTabPage(frm);
			}
			else
			{
				ActiveChildForm(frm);
			}
		}

		private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmHoaDon frm = new frmHoaDon();
			if (!CheckExistForm(frm))
			{
				CreateTabPage(frm);
			}
			else
			{
				ActiveChildForm(frm);
			}
		}
	}
}
