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
    public partial class frmTraCuuChuyenBay : Form
    {
        #region Properties
        BUS_ChuyenBay busChuyenBay;
        ComboBox cboMaChuyenBay;
        #endregion

        #region Initialize
        public frmTraCuuChuyenBay()
        {
            InitializeComponent();
            busChuyenBay = new BUS_ChuyenBay();
        }
        public frmTraCuuChuyenBay(ComboBox cboMaChuyenBay)
        {
            InitializeComponent();
            busChuyenBay = new BUS_ChuyenBay();
            this.cboMaChuyenBay = cboMaChuyenBay;
        }
        #endregion

        #region Methods
        private void TaoLai()
        {

        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboSanBayDi.Text != "" && cboSanBayDen.Text != "" && dtpNgayKHTu.Text != "" && dtpNgayKHDen.Text != "")
            {
                try
                {
                    string maSanBayDi = cboSanBayDi.SelectedValue.ToString();
                    string maSanBayDen = cboSanBayDen.SelectedValue.ToString();
                    DateTime ngayKHTu = dtpNgayKHTu.Value;
                    DateTime ngayKHDen = dtpNgayKHDen.Value;
                    TaoBangDSChuyenBayTheoYeuCau(maSanBayDi, maSanBayDen, ngayKHTu, ngayKHDen);
                }
                catch(Exception a)
                {

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
        private void KhoiTaoGiaoDien()
        {
            BUS_SanBay busSanBay = new BUS_SanBay();
            busSanBay = new BUS_SanBay();
            DataTable dtSanBayDi = new DataTable();
            dtSanBayDi = busSanBay.Get();
            cboSanBayDi.DataSource = dtSanBayDi;
            cboSanBayDi.DisplayMember = "TENSANBAY";
            cboSanBayDi.ValueMember = "MASANBAY";


            DataTable dtSanBayDen = new DataTable();
            dtSanBayDen = busSanBay.Get();
            cboSanBayDen.DataSource = dtSanBayDen;
            cboSanBayDen.DisplayMember = "TENSANBAY";
            cboSanBayDen.ValueMember = "MASANBAY";

            if (cboMaChuyenBay == null)
            {
                btnChonChuyenBay.Visible = false;
                lbBanVe.Visible = false;
                btnTimKiem.Location = new Point(125,22);
                lbTimKiem.Location = new Point(123, 65);
            }
            cboSanBayDi.Focus();
        }
        private void TaoBangDSChuyenBayTheoYeuCau(string maSanBayDen, string maSanBayDi, DateTime thoiGianKHTu, DateTime thoiGianKHDen)
        {
            DataTable dtChuyenBay = busChuyenBay.Search(maSanBayDen,maSanBayDi, thoiGianKHTu, thoiGianKHDen);
            dtgvChuyenBay.DataSource = dtChuyenBay;
            dtgvChuyenBay.Sort(dtgvChuyenBay.Columns[0], ListSortDirection.Descending);
            dtgvChuyenBay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvChuyenBay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void dtgvChuyenBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dtgvChuyenBay.Rows[e.RowIndex];
            txtMaChuyenBay.Text = row.Cells[0].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (cboMaChuyenBay == null)
                this.Parent.Dispose();
            else
                this.Close();
            
        }

        private void frmTraCuuChuyenBay_Shown(object sender, EventArgs e)
        {
            KhoiTaoGiaoDien();
        }

        private void btnBanVe_Click(object sender, EventArgs e)
        {
            cboMaChuyenBay.Text = txtMaChuyenBay.Text;
            this.Close();
        }
        #endregion
    }
}
