using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plane_Ticket
{
	public partial class frmHoaDon : Form
	{
		public frmHoaDon()
		{
			InitializeComponent();
		}
		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Parent.Dispose();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			BUS_VeChuyenBay veChuyenBay = new BUS_VeChuyenBay();
			crHoaDonBanVe cr = new crHoaDonBanVe();
			DataTable HoaDon = veChuyenBay.GetSumBill(txtTimKiemKhach.Text);
			cr.SetDataSource(HoaDon);
			crvInHoaDon.ReportSource = cr;
		}
	}
}