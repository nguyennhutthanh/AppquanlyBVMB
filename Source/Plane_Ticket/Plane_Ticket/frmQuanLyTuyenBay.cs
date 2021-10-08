using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace Plane_Ticket
{
	public partial class frmQuanLyTuyenBay : Form
	{
		#region Properties
		DTO_TuyenBay dtoTuyenBay;
		BUS_TuyenBay busTuyenBay;
		#endregion

		#region Initializes
		public frmQuanLyTuyenBay()
		{
			InitializeComponent();
			busTuyenBay = new BUS_TuyenBay();
		}
		#endregion

		#region Methods
		private void btnThem_Click(object sender, EventArgs e)
		{

			if (cboSanBayDen.Text.Trim() != "" && cboSanBayDi.Text.Trim() != "")
			{
				if (cboSanBayDi.Text == cboSanBayDen.Text)
				{
					MessageBox.Show("Sân bay đến và sân bay đi phải khác nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				try
				{
					dtoTuyenBay = new DTO_TuyenBay(txtMaTuyenBay.Text, cboSanBayDi.SelectedValue.ToString(), cboSanBayDen.SelectedValue.ToString());
					if (busTuyenBay.Add(dtoTuyenBay))
						MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					else
						MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				catch (Exception a)
				{
					MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (txtMaTuyenBay.Text.Trim() != "")
			{
				if (cboSanBayDen.Text.Trim() != "" && cboSanBayDi.Text.Trim() != "")
				{
					if (cboSanBayDi.Text == cboSanBayDen.Text)
					{
						MessageBox.Show("Sân bay đến và sân bay đi phải khác nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					try
					{
						dtoTuyenBay = new DTO_TuyenBay(txtMaTuyenBay.Text, cboSanBayDi.SelectedValue.ToString(), cboSanBayDen.SelectedValue.ToString());
						if (busTuyenBay.Update(dtoTuyenBay))
							MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						else
							MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					catch (Exception a)
					{
						MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			else
			{
				MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (txtMaTuyenBay.Text.Trim() != "")
			{
				try
				{
					if (busTuyenBay.Delete(txtMaTuyenBay.Text))
						MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					else
						MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				catch (Exception a)
				{
					MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					TaoLai();
				}
			}
			else
			{
				MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			dtgvTuyenBay.DataSource = busTuyenBay.SearchOfMaTuyenBay(txtTimKiemve.Text);
		}
		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Parent.Dispose();
		}

		private void KhoiTaoGiaoDien()
		{
			BUS_SanBay busSanBay = new BUS_SanBay();
			DataTable dtSanBayDen = new DataTable();
			DataTable dtSanBayDi = new DataTable();

			dtSanBayDen = busSanBay.Get();
			cboSanBayDen.DataSource = dtSanBayDen;
			cboSanBayDen.DisplayMember = "TENSANBAY";
			cboSanBayDen.ValueMember = "MASANBAY";

			dtSanBayDi = busSanBay.Get();
			cboSanBayDi.DataSource = dtSanBayDi;
			cboSanBayDi.DisplayMember = "TENSANBAY";
			cboSanBayDi.ValueMember = "MASANBAY";

			TaoBangDSTuyenBay();

			cboSanBayDi.Focus();
		}
		private void TaoBangDSTuyenBay()
		{
			DataTable dtTuyenBay = busTuyenBay.GetForDSTuyenBay();
			dtgvTuyenBay.DataSource = dtTuyenBay;
			dtgvTuyenBay.Sort(dtgvTuyenBay.Columns[0], ListSortDirection.Descending);
			dtgvTuyenBay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dtgvTuyenBay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
		}
		private void TaoLai()
		{
			TaoBangDSTuyenBay();
			txtMaTuyenBay.Clear();
			cboSanBayDen.Text = "";
			cboSanBayDi.Text = "";
			cboSanBayDi.Focus();
		}
		private void frmQuanLyTuyenBay_Shown(object sender, EventArgs e)
		{
			KhoiTaoGiaoDien();
		}
		private void dtgvTuyenBay_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1)
				return;
			DataGridViewRow row = dtgvTuyenBay.Rows[e.RowIndex];
			txtMaTuyenBay.Text = row.Cells[0].Value.ToString();
			cboSanBayDi.Text = row.Cells[1].Value.ToString();
			cboSanBayDen.Text = row.Cells[2].Value.ToString();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			DataTable dtTuyenBay = busTuyenBay.GetForDSTuyenBay();
			dtgvTuyenBay.DataSource = dtTuyenBay;
			dtgvTuyenBay.Sort(dtgvTuyenBay.Columns[0], ListSortDirection.Descending);
			dtgvTuyenBay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dtgvTuyenBay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
		}
		#endregion
	}
}
