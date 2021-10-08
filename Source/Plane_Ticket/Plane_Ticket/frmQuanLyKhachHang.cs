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
    public partial class frmQuanLyKhachHang : Form
    {
        #region Properties
        DTO_KhachHang dtoKhachHang;
        BUS_KhachHang busKhachHang;
        #endregion

        #region Initializes
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
            busKhachHang = new BUS_KhachHang();
        }
        #endregion

        #region Methods
        private void frmQuanLyKhachHang_Shown(object sender, EventArgs e)
        {
            KhoiTaoGiaoDien();
        }
        private void TaoLai()
        {
            TaoBangDSKhachHang();
            txtTenKhachHang.Clear();
            txtCMND.Clear();
            txtSDT.Clear();
        }
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text.Trim() != "")
            {
                if (txtTenKhachHang.Text.Trim() != "" && txtCMND.Text.Trim() != "" && txtSDT.Text.Trim() != "")
                {
                    try
                    {
                        dtoKhachHang = new DTO_KhachHang(txtMaKhachHang.Text, txtTenKhachHang.Text,txtCMND.Text,txtSDT.Text);
                        if (busKhachHang.Update(dtoKhachHang))
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
            if (txtMaKhachHang.Text.Trim() != "")
            {
                try
                {
                    if (busKhachHang.Delete(txtMaKhachHang.Text))
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
            dtgvKhachHang.DataSource = busKhachHang.SearchOfMaKhachHang(txtTimKiem.Text);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }
        private void KhoiTaoGiaoDien()
        {
            TaoBangDSKhachHang();
            txtTenKhachHang.Focus();
        }
        private void TaoBangDSKhachHang()
        {
            DataTable dtKhachHang = busKhachHang.GetForDisplay();
            dtgvKhachHang.DataSource = dtKhachHang;
            dtgvKhachHang.Sort(dtgvKhachHang.Columns[0], ListSortDirection.Descending);
            dtgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvKhachHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void dtgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dtgvKhachHang.Rows[e.RowIndex];
            txtMaKhachHang.Text = row.Cells[0].Value.ToString();
            txtTenKhachHang.Text = row.Cells[1].Value.ToString();
            txtCMND.Text = row.Cells[2].Value.ToString();
            txtSDT.Text = row.Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtKhachHang = busKhachHang.GetForDisplay();
            dtgvKhachHang.DataSource = dtKhachHang;
            dtgvKhachHang.Sort(dtgvKhachHang.Columns[0], ListSortDirection.Descending);
            dtgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvKhachHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        #endregion
    }
}
