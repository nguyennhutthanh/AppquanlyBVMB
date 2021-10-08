using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plane_Ticket
{
	/// <summary>
	/// code by Minh Huy 10/5/2021, 2:30 AM
	/// </summary>
	public partial class frmBanVe : Form
	{
		#region Properties
		string maNhanVien;
		DTO_VeChuyenBay dtoVeChuyenBay;
		DTO_KhachHang dtoKhachHang;
		BUS_VeChuyenBay busVeChuyenBay;
		BUS_KhachHang busKhachHang;
		#endregion

		#region Initializes
		public frmBanVe(DataRow row)
		{
			InitializeComponent();
			busVeChuyenBay = new BUS_VeChuyenBay();
			busKhachHang = new BUS_KhachHang();
			this.maNhanVien = row["MANHANVIEN"].ToString();
		}
		#endregion

		#region Methods
		private void TaoLai()
		{
			TaoBangDSVeChuyenBay();
			txtCMND.Clear();
			txtSDT.Clear();
			txtTenKhachHang.Clear();
			LoadDaTatxtSoGheTrong();
		}
		private void btnMuaVe_Click(object sender, EventArgs e)
		{
			if (txtSoGheTrong.Text == "0" || txtSoGheTrong.Text == "")
			{
				MessageBox.Show("Không còn vé cho hạng vé này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (cboMaChuyenBay.Text.Trim() != "" && txtCMND.Text.Trim() != "" && txtTenKhachHang.Text.Trim() != "" && txtSDT.Text.Trim() != "" && cboHangVe.Text.Trim() != "")
			{
				try
				{
					string maKhachHang;
					string loaiVe = "Vé mua";
					DataTable dtKhachHang = busKhachHang.GetOfCMND(txtCMND.Text);

					if (dtKhachHang.Rows.Count > 0)
					{
						DataRow row = dtKhachHang.Rows[0];
						maKhachHang = row["MAKHACHHANG"].ToString();
					}
					else
					{
						dtoKhachHang = new DTO_KhachHang(null, txtTenKhachHang.Text, txtCMND.Text, txtSDT.Text);
						if (!busKhachHang.Add(dtoKhachHang))
						{
							MessageBox.Show("Thêm khách hàng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
							TaoLai();
							return;
						}
						dtKhachHang = busKhachHang.GetOfCMND(txtCMND.Text);
						DataRow row = dtKhachHang.Rows[0];
						maKhachHang = row["MAKHACHHANG"].ToString();
					}

					dtoVeChuyenBay = new DTO_VeChuyenBay(null, maKhachHang, cboMaChuyenBay.Text, cboHangVe.SelectedValue.ToString(), maNhanVien, Convert.ToDecimal(txtGiaTien.Text), DateTime.Now, Convert.ToDateTime(null), loaiVe);
					if (busVeChuyenBay.Add(dtoVeChuyenBay))
						MessageBox.Show("Mua vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					else
						MessageBox.Show("Mua vé không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception a)
				{
					MessageBox.Show("Mua vé không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					TaoLai();
				}
			}
			else
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Parent.Dispose();
		}
		private void KhoiTaoGiaoDien()
		{
			BUS_ChuyenBay busChuyenBay = new BUS_ChuyenBay();
			DataTable dtChuyenBay = new DataTable();

			dtChuyenBay = busChuyenBay.Get();
			cboMaChuyenBay.DataSource = dtChuyenBay;
			cboMaChuyenBay.DisplayMember = "MACHUYENBAY";
			cboMaChuyenBay.ValueMember = "MACHUYENBAY";

			BUS_HangVe busHangVe = new BUS_HangVe();
			DataTable dtHangVe = new DataTable();

			dtHangVe = busHangVe.Get();
			cboHangVe.DataSource = dtHangVe;
			cboHangVe.DisplayMember = "TENHANGVE";
			cboHangVe.ValueMember = "MAHANGVE";

			TaoBangDSVeChuyenBay();
		}
		private void cboMaChuyenBay_SelectedValueChanged(object sender, EventArgs e)
		{
			BUS_ChuyenBay busChuyenBay = new BUS_ChuyenBay();
			DataTable dtChuyenBay = busChuyenBay.GetOfMaChuyenBay(cboMaChuyenBay.Text);
			if (dtChuyenBay.Rows.Count == 0)
			{
				txtMaTuyenBay.Clear();
				txtSanBayDi.Clear();
				txtSanBayDen.Clear();
				txtThoiGianKhoiHanh.Clear();
				txtThoiGIanBay.Clear();
			}
			else
			{
				DataRow row = dtChuyenBay.Rows[0];
				txtMaTuyenBay.Text = row["MATUYENBAY"].ToString();
				txtSanBayDi.Text = row["TENSANBAYDI"].ToString();
				txtSanBayDen.Text = row["TENSANBAYDEN"].ToString();
				txtThoiGianKhoiHanh.Text = row["THOIGIANKHOIHANH"].ToString();
				txtThoiGIanBay.Text = row["THOIGIANBAY"].ToString();
				LoadDaTatxtSoGheTrong();
			}
		}
		private void cboHangVe_SelectedValueChanged(object sender, EventArgs e)
		{
			if (cboHangVe.SelectedValue != null)
			{
				BUS_DonGia busDonGia = new BUS_DonGia();
				DataTable dtDonGia = busDonGia.SearchOfMaTuyenBayAndMaHangVe(txtMaTuyenBay.Text, cboHangVe.SelectedValue.ToString());

				foreach (DataRow row in dtDonGia.Rows)
				{
					txtGiaTien.Text = row["DONGIA"].ToString();
				}
				LoadDaTatxtSoGheTrong();
			}
		}
		private void LoadDaTatxtSoGheTrong()
		{
			if (cboHangVe.SelectedValue != null)
			{
				BUS_TinhTrangVe busTinhTrangVe = new BUS_TinhTrangVe();
				txtSoGheTrong.Text = busTinhTrangVe.GetSoGheTrongOfMaChuyenBayAndMaHangVe(cboMaChuyenBay.Text, cboHangVe.SelectedValue.ToString());
			}
		}
		private void txtCMND_TextChanged(object sender, EventArgs e)
		{
			BUS_KhachHang busKhachHang = new BUS_KhachHang();
			DataTable dtKhachHang = busKhachHang.GetOfCMND(txtCMND.Text);
			if (dtKhachHang.Rows.Count == 0)
			{
				txtTenKhachHang.Clear();
				txtSDT.Clear();
			}
			else
			{
				DataRow row = dtKhachHang.Rows[0];
				txtTenKhachHang.Text = row["TENKHACHHANG"].ToString();
				txtSDT.Text = row["SDT"].ToString();
			}
		}
		private void TaoBangDSVeChuyenBay()
		{
			DataTable dtVeChuyenBay = busVeChuyenBay.GetForDisplay();
			dtgvVe.DataSource = dtVeChuyenBay;
			dtgvVe.Sort(dtgvVe.Columns[0], ListSortDirection.Descending);
			dtgvVe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dtgvVe.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
		}
		private void btnDatVe_Click(object sender, EventArgs e)
		{
			if (cboMaChuyenBay.Text.Trim() != "" && txtCMND.Text.Trim() != "" && txtTenKhachHang.Text.Trim() != "" && txtSDT.Text.Trim() != "" && cboHangVe.Text.Trim() != "")
			{
				try
				{
					string maKhachHang;
					string loaiVe = "Vé đặt";
					DataTable dtKhachHang = busKhachHang.GetOfCMND(txtCMND.Text);
					if (dtKhachHang.Rows.Count > 0)
					{
						DataRow row = dtKhachHang.Rows[0];
						maKhachHang = row["MAKHACHHANG"].ToString();
					}
					else
					{
						dtoKhachHang = new DTO_KhachHang(null, txtTenKhachHang.Text, txtCMND.Text, txtSDT.Text);
						if (!busKhachHang.Add(dtoKhachHang))
						{
							MessageBox.Show("Thêm khách hàng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
							TaoLai();
							return;
						}
						dtKhachHang = busKhachHang.GetOfCMND(txtCMND.Text);
						DataRow row = dtKhachHang.Rows[0];
						maKhachHang = row["MAKHACHHANG"].ToString();
					}
					dtoVeChuyenBay = new DTO_VeChuyenBay(null, maKhachHang, cboMaChuyenBay.Text, cboHangVe.SelectedValue.ToString(), maNhanVien, Convert.ToDecimal(txtGiaTien.Text), DateTime.Now, Convert.ToDateTime(null), loaiVe);
					if (busVeChuyenBay.Add(dtoVeChuyenBay))
						MessageBox.Show("Đặt vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					else
						MessageBox.Show("Đặt vé không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception a)
				{
					MessageBox.Show("Đặt vé không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					TaoLai();
				}
			}
			else
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		private void txtGiaTien_TextChanged(object sender, EventArgs e)
		{
			if (txtGiaTien.Text == "")
				return;
			string text = txtGiaTien.Text.Replace(",", "");
			decimal value = Convert.ToDecimal(text);
			txtGiaTien.Text = string.Format("{0:0,0}", value);

		}
		private void dtgvVe_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1)
				return;
			DataGridViewRow row = dtgvVe.Rows[e.RowIndex];
			txtCMND.Text = row.Cells[2].Value.ToString();
			cboMaChuyenBay.SelectedValue = row.Cells[3].Value.ToString();
			cboHangVe.Text = row.Cells[4].Value.ToString();
		}
		private void frmBanVe_Shown(object sender, EventArgs e)
		{
			KhoiTaoGiaoDien();
		}
		private void btnChiTietGheTrong_Click(object sender, EventArgs e)
		{
			Form frm = new frmTinhTrangVe(cboMaChuyenBay.Text);
			frm.Show();
		}

		#endregion

		private void btnTraCuu_Click(object sender, EventArgs e)
		{
			Form frm = new frmTraCuuChuyenBay(cboMaChuyenBay);
			frm.Show();
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			dtgvVe.DataSource = busVeChuyenBay.ResreachMave(txtTimKiemMaVe.Text);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DataTable dtVeChuyenBay = busVeChuyenBay.GetForDisplay();
			dtgvVe.DataSource = dtVeChuyenBay;
			dtgvVe.Sort(dtgvVe.Columns[0], ListSortDirection.Descending);
			dtgvVe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dtgvVe.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
		}
	}
}
