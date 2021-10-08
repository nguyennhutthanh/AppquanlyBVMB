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
	public partial class frmNhomTacGia : Form
	{
		public frmNhomTacGia()
		{
			InitializeComponent();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Parent.Dispose();
		}
	}
}
