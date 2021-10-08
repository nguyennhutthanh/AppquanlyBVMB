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
    public partial class frmQuanLyMayBay : Form
    {
        #region Properties
        DTO_MayBay dtoMayBay;
        BUS_MayBay busMayBay;
        #endregion

        #region Initializes
        public frmQuanLyMayBay()
        {
            InitializeComponent();
            busMayBay = new BUS_MayBay();
        }
        #endregion

        #region Methods
        private void TaoLai()
        {
            TaoBangDSMayBay();
            txtMaMayBay.Clear();
            txtTenMayBay.Clear();
            txtSoLuongGhe.Clear();
            txtTenMayBay.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenMayBay.Text.Trim() != "" && txtSoLuongGhe.Text.Trim() != "")
            {
                try
                {
                    dtoMayBay = new DTO_MayBay(txtMaMayBay.Text, txtTenMayBay.Text,Convert.ToInt32(txtSoLuongGhe.Text));
                    if(busMayBay.Add(dtoMayBay))
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
            if (txtMaMayBay.Text.Trim() != "")
            {
                if (txtTenMayBay.Text.Trim() != "" && txtSoLuongGhe.Text.Trim() != "")
                {
                    try
                    {
                        dtoMayBay = new DTO_MayBay(txtMaMayBay.Text, txtTenMayBay.Text, Convert.ToInt32(txtSoLuongGhe.Text));
                        if (busMayBay.Update(dtoMayBay))
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
            if (txtMaMayBay.Text.Trim() != "")
            {
                try
                {
                    if (busMayBay.Delete(txtMaMayBay.Text))
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
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtgvMayBay.DataSource = busMayBay.SearchOfMaMayBay(txtTimKiem.Text);
        }
        private void TaoBangDSMayBay()
        {
            DataTable dtTuyenBay = busMayBay.GetForDisplay();
            dtgvMayBay.DataSource = dtTuyenBay;
            dtgvMayBay.Sort(dtgvMayBay.Columns[0], ListSortDirection.Descending);
            dtgvMayBay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvMayBay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void dtgvMayBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dtgvMayBay.Rows[e.RowIndex];
            txtMaMayBay.Text = row.Cells[0].Value.ToString();
            txtTenMayBay.Text = row.Cells[1].Value.ToString();
            txtSoLuongGhe.Text = row.Cells[2].Value.ToString();
        }
        private void frmQuanLyMayBay_Shown(object sender, EventArgs e)
        {
            KhoiTaoGiaoDien();
        }
        private void KhoiTaoGiaoDien()
        {
            TaoBangDSMayBay();
            txtTenMayBay.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtTuyenBay = busMayBay.GetForDisplay();
            dtgvMayBay.DataSource = dtTuyenBay;
            dtgvMayBay.Sort(dtgvMayBay.Columns[0], ListSortDirection.Descending);
            dtgvMayBay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvMayBay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        #endregion
    }
}
