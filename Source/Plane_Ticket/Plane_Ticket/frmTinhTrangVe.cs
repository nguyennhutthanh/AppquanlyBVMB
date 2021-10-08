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
    public partial class frmTinhTrangVe : Form
    {
        BUS_TinhTrangVe busTinhTrangVe;
        BUS_ChuyenBay busChuyenBay;
        string maChuyenBay;
        public frmTinhTrangVe()
        {
            InitializeComponent();
            busTinhTrangVe = new BUS_TinhTrangVe();
            busChuyenBay = new BUS_ChuyenBay();
            maChuyenBay = "";
        }
        public frmTinhTrangVe(string maChuyenBay)
        {
            InitializeComponent();
            busTinhTrangVe = new BUS_TinhTrangVe();
            busChuyenBay = new BUS_ChuyenBay();
            this.maChuyenBay = maChuyenBay;
        }
        private void KhoiTaoGiaoDien()
        {
            DataTable dtChuyenBay = busChuyenBay.Get();
            cboMaChuyenBay.DataSource = dtChuyenBay;
            cboMaChuyenBay.DisplayMember = "MACHUYENBAY";
            cboMaChuyenBay.ValueMember = "MACHUYENBAY";
            cboMaChuyenBay.SelectedValue = maChuyenBay;

            cboMaChuyenBay.Focus();
        }
        private void TaoBangTinhTrangVe(string maChuyenBay)
        {
            DataTable dtTinhTrangVe = busTinhTrangVe.GetForDisplayOfMaChuyenBay(maChuyenBay);
            dtgvTinhTrangVe.DataSource = dtTinhTrangVe;
            dtgvTinhTrangVe.Sort(dtgvTinhTrangVe.Columns[0], ListSortDirection.Descending);
            dtgvTinhTrangVe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvTinhTrangVe.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void frmTinhTrangVe_Shown(object sender, EventArgs e)
        {
            KhoiTaoGiaoDien();
        }



        private void cboMaChuyenBay_SelectedValueChanged(object sender, EventArgs e)
        {
            TaoBangTinhTrangVe(cboMaChuyenBay.Text);
        }
    }
}
