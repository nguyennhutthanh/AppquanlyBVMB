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
    public partial class frmQuanLyHangVe : Form
    {
        #region Properties
        DTO_HangVe dtoHangVe;
        BUS_HangVe busHangVe;
        #endregion

        #region Initializes
        public frmQuanLyHangVe()
        {
            InitializeComponent();
            busHangVe = new BUS_HangVe();
            KhoiTaoGiaoDien();
        }
        #endregion

        #region Methods
        private void TaoLai()
        {
            TaoBangDSHangVe();
            txtMaHangVe.Clear();
            txtTenHangVe.Clear();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenHangVe.Text.Trim() != "")
            {
                try
                {
                    dtoHangVe = new DTO_HangVe(txtMaHangVe.Text, txtTenHangVe.Text);
                    if(busHangVe.Add(dtoHangVe))
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }

        private void dtgvHangVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dtgvHangVe.Rows[e.RowIndex];
            txtMaHangVe.Text = row.Cells[0].Value.ToString();
            txtTenHangVe.Text = row.Cells[1].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHangVe.Text.Trim() != "")
            {
                if (txtTenHangVe.Text.Trim() != "")
                {
                    try
                    {
                        dtoHangVe = new DTO_HangVe(txtMaHangVe.Text, txtTenHangVe.Text);
                        if (busHangVe.Update(dtoHangVe))
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
            if (txtMaHangVe.Text.Trim() != "")
            {
                try
                {
                    if (busHangVe.Delete(txtMaHangVe.Text))
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
            dtgvHangVe.DataSource = busHangVe.SearchOfMaHangVe(txtTimKiem.Text);
        }
        private void frmQuanLyHangVe_Shown(object sender, EventArgs e)
        {
            KhoiTaoGiaoDien();
        }
        private void TaoBangDSHangVe()
        {
            DataTable dtHangVe = busHangVe.GetForDisplay();
            dtgvHangVe.DataSource = dtHangVe;
            dtgvHangVe.Sort(dtgvHangVe.Columns[0], ListSortDirection.Descending);
            dtgvHangVe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvHangVe.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void KhoiTaoGiaoDien()
        {
            TaoBangDSHangVe();
            txtTenHangVe.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtHangVe = busHangVe.GetForDisplay();
            dtgvHangVe.DataSource = dtHangVe;
            dtgvHangVe.Sort(dtgvHangVe.Columns[0], ListSortDirection.Descending);
            dtgvHangVe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvHangVe.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        #endregion
    }
}
