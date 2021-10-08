using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plane_Ticket
{
    public partial class frmQuanLyDonGia : Form
    {
        #region Properties
        DTO_DonGia dtoDonGia;
        BUS_DonGia busDonGia;
        bool flagCellClick;
        #endregion

        #region Initializes
        public frmQuanLyDonGia()
        {
            InitializeComponent();
            busDonGia = new BUS_DonGia();
            flagCellClick = false;
        }
        #endregion

        #region Methods

        private void TaoLai()
        {
            TaoBangDSDonGia();
            txtDonGia.Clear();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboMaTuyenBay.Text.Trim() != "" && cboMaHangVe.Text.Trim() != "" && txtDonGia.Text!="")
            {
                if(cboSanBayDi.Text==cboSanBayDen.Text)
                {
                    MessageBox.Show("Sân bay đến và sân bay đi phải khác nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    dtoDonGia = new DTO_DonGia(cboMaTuyenBay.Text, cboMaHangVe.SelectedValue.ToString(), Convert.ToInt32(txtDonGia.Text));
                    if (busDonGia.Add(dtoDonGia))
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
            if (flagCellClick)
            {

                if (cboSanBayDi.Text == cboSanBayDen.Text)
                {
                    MessageBox.Show("Sân bay đến và sân bay đi phải khác nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cboSanBayDen.Text.Trim() != "" && cboSanBayDi.Text.Trim() != "")
                {
                    try
                    {
                        dtoDonGia = new DTO_DonGia(cboMaTuyenBay.Text, cboMaHangVe.SelectedValue.ToString(), Convert.ToInt32(txtDonGia.Text));
                        if (busDonGia.Update(dtoDonGia))
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
                        flagCellClick = false;
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
            if (flagCellClick)
            {
                try
                {
                    dtoDonGia = new DTO_DonGia(cboMaTuyenBay.Text, cboMaHangVe.SelectedValue.ToString(), Convert.ToInt32(txtDonGia.Text));
                    if (busDonGia.Delete(dtoDonGia))
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
                    flagCellClick = false;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }
        private void KhoiTaoGiaoDien()
        {
            BUS_TuyenBay busTuyenBay = new BUS_TuyenBay();
            DataTable dtTuyenBay = new DataTable();
            dtTuyenBay = busTuyenBay.Get();
            cboMaTuyenBay.DataSource = dtTuyenBay;
            cboMaTuyenBay.DisplayMember = "MATUYENBAY";
            cboMaTuyenBay.ValueMember = "MATUYENBAY";

            BUS_HangVe busHangVe = new BUS_HangVe();
            DataTable dtHangVe = new DataTable();
            dtHangVe = busHangVe.Get();
            cboMaHangVe.DataSource = dtHangVe;
            cboMaHangVe.DisplayMember = "TENHANGVE";
            cboMaHangVe.ValueMember = "MAHANGVE";

            BUS_SanBay busSanBayDi = new BUS_SanBay();
            DataTable dtSanBayDi = new DataTable();
            dtSanBayDi = busSanBayDi.Get();
            cboSanBayDi.DataSource = dtSanBayDi;
            cboSanBayDi.DisplayMember = "TENSANBAY";
            cboSanBayDi.ValueMember = "MASANBAY";

            BUS_SanBay busSanBayDen = new BUS_SanBay();
            DataTable dtSanBayDen = new DataTable();
            dtSanBayDen = busSanBayDi.Get();
            cboSanBayDen.DataSource = dtSanBayDen;
            cboSanBayDen.DisplayMember = "TENSANBAY";
            cboSanBayDen.ValueMember = "MASANBAY";

            TaoBangDSDonGia();

            cboSanBayDi.Focus();
        }
        private void cboMaTuyenBay_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BUS_TuyenBay busTuyenBay = new BUS_TuyenBay();
            DataTable dtTuyenBay = busTuyenBay.GetOfMaTuyenBay(cboMaTuyenBay.SelectedValue.ToString());
            if (dtTuyenBay.Rows.Count == 0)
                return;
            DataRow row = dtTuyenBay.Rows[0];

            cboSanBayDi.SelectedValue = row["MASANBAYDI"].ToString();

            cboSanBayDen.SelectedValue = row["MASANBAYDEN"].ToString();
        }
        private void cboSanBayDi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BUS_TuyenBay busTuyenBay = new BUS_TuyenBay();
            DataTable dtTuyenBay = busTuyenBay.GetOfMaSanBay(cboSanBayDi.SelectedValue.ToString(), cboSanBayDen.SelectedValue.ToString());
            if (dtTuyenBay.Rows.Count == 0)
            {
                cboMaTuyenBay.Text = "";
            }
            else
            {
                DataRow row = dtTuyenBay.Rows[0];
                cboMaTuyenBay.Text = row["MATUYENBAY"].ToString();
            }
        }
        private void TaoBangDSDonGia()
        {
            DataTable dtDonGia = busDonGia.GetForDisplay();
            dtgvDonGia.DataSource = dtDonGia;
            dtgvDonGia.Sort(dtgvDonGia.Columns[0], ListSortDirection.Descending);
            dtgvDonGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvDonGia.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgvDonGia.Columns[2].DefaultCellStyle.Format = "#,####.####";
        }
        private void dtgvDonGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dtgvDonGia.Rows[e.RowIndex];
            cboMaTuyenBay.SelectedValue = row.Cells[0].Value.ToString();
            cboMaHangVe.SelectedValue = row.Cells[1].Value.ToString();
            txtDonGia.Text = row.Cells[2].Value.ToString();
            flagCellClick = true;
            cboMaTuyenBay_SelectionChangeCommitted(sender, e);
        }
        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGia.Text == "")
            {
                lbDonGia.Text = "";
                return;
            }
            decimal value = Convert.ToDecimal(txtDonGia.Text);
            lbDonGia.Text = string.Format("{0:0,0 VNĐ}", value);
        }

        private void frmQuanLyDonGia_Shown(object sender, EventArgs e)
        {
            KhoiTaoGiaoDien();
            cboMaTuyenBay_SelectionChangeCommitted(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtDonGia = busDonGia.GetForDisplay();
            dtgvDonGia.DataSource = dtDonGia;
            dtgvDonGia.Sort(dtgvDonGia.Columns[0], ListSortDirection.Descending);
            dtgvDonGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvDonGia.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dtgvDonGia.Columns[2].DefaultCellStyle.Format = "#,####.####";
        }
        #endregion
    }
}
