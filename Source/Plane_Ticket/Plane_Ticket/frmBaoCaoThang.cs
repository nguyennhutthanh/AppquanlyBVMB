using BUS;
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
    public partial class frmBaoCaoThang : Form
    {
        public frmBaoCaoThang()
        {
            InitializeComponent();
        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            string month = dtpThangNam.Value.Month.ToString();
            string year = dtpThangNam.Value.Year.ToString();
            BUS_CTDoanhThuThang busCTDoanhThuThang = new BUS_CTDoanhThuThang();
            DataTable dtCTDoanhThuThang = busCTDoanhThuThang.GetOfThangNam(month, year);
            crDoanhThuThang cr = new crDoanhThuThang();
            cr.SetDataSource(dtCTDoanhThuThang);

            crvBaoCaoThang.ReportSource = cr;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }
    }
}
