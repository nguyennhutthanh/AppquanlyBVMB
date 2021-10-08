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
    public partial class frmQuanLyNhanVien : Form
    {
        #region Properties
        DTO_NhanVien dtoNhanVien;
        BUS_NhanVien busNhanVien;
        #endregion

        #region Initializes
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
            busNhanVien = new BUS_NhanVien();
        }
        #endregion

        #region Methods
        private void frmQuanLyNhanVien_Shown(object sender, EventArgs e)
        {
            KhoiTaoGiaoDien();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            if (txtTenNhanVien.Text.Trim() != "" && txtUsername.Text.Trim() != "" && txtUsername.Text.Trim() != "")
            {
                int type=0;
                if (rdbtnNVQuanTri.Checked)
                    type = 0;
                if (rdbtnNVBanVe.Checked)
                    type = 1;
                try
                {
                    dtoNhanVien = new DTO_NhanVien(txtMaNhanVien.Text, txtTenNhanVien.Text,txtUsername.Text,txtPassword.Text, type);
                    if (busNhanVien.Add(dtoNhanVien))
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
            if (txtMaNhanVien.Text.Trim() != "")
            {
                if (txtTenNhanVien.Text.Trim() != "" && txtUsername.Text.Trim() != "" && txtUsername.Text.Trim() != "")
                {
                    int type = 0;
                    if (rdbtnNVQuanTri.Checked)
                        type = 0;
                    if (rdbtnNVBanVe.Checked)
                        type = 1;
                    try
                    {
                        dtoNhanVien = new DTO_NhanVien(txtMaNhanVien.Text, txtTenNhanVien.Text, txtUsername.Text, txtPassword.Text, type);
                        if (busNhanVien.Update(dtoNhanVien))
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
            if (txtMaNhanVien.Text.Trim() != "")
            {
                try
                {
                    if (busNhanVien.Delete(txtMaNhanVien.Text))
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
            dtgvNhanVien.DataSource = busNhanVien.SearchOfMaNhanVien(txtTimKiem.Text);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }

        private void KhoiTaoGiaoDien()
        {
            TaoBangDSNhanVien();
            txtTenNhanVien.Focus();
        }
        private void TaoBangDSNhanVien()
        {
            DataTable dtNhanVien = busNhanVien.GetForDisplay();
            dtgvNhanVien.DataSource = dtNhanVien;
            dtgvNhanVien.Sort(dtgvNhanVien.Columns[0], ListSortDirection.Descending);
            dtgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvNhanVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void TaoLai()
        {
            TaoBangDSNhanVien();
            txtMaNhanVien.Clear();
            txtTenNhanVien.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }
        private void dtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dtgvNhanVien.Rows[e.RowIndex];
            txtMaNhanVien.Text = row.Cells[0].Value.ToString();
            txtTenNhanVien.Text = row.Cells[1].Value.ToString();
            txtUsername.Text = row.Cells[2].Value.ToString();
            txtPassword.Text = row.Cells[3].Value.ToString();
            if (row.Cells[4].Value.ToString() == "0")
                rdbtnNVQuanTri.Checked = true;
            else
                rdbtnNVBanVe.Checked = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtNhanVien = busNhanVien.GetForDisplay();
            dtgvNhanVien.DataSource = dtNhanVien;
            dtgvNhanVien.Sort(dtgvNhanVien.Columns[0], ListSortDirection.Descending);
            dtgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvNhanVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        #endregion
    }
}
