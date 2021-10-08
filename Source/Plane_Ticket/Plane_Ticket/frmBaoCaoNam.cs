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
    /// <summary>
    /// code by nthanh 17/5/2021, 3:20 PM
    /// </summary>
    public partial class frmBaoCaoNam : Form
    {
        public frmBaoCaoNam()
        {
            InitializeComponent();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            string year = dtpNam.Value.Year.ToString();
            BUS_DoanhThuThang busDoanhThuThang = new BUS_DoanhThuThang();
            DataTable dtDoanhThuThang = busDoanhThuThang.GetOfNam(year);
            crDoanhThuNam cr = new crDoanhThuNam();
            cr.SetDataSource(dtDoanhThuThang);
            crvBaoCaoNam.ReportSource = cr;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }
    }
}
