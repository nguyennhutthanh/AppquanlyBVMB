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
    public partial class frmQuanLySanBay : Form
    {
        #region Properties
        DTO_SanBay dtoSanBay;
        BUS_SanBay busSanBay;
        #endregion

        #region Initializes
        public frmQuanLySanBay()
        {
            InitializeComponent();
            busSanBay = new BUS_SanBay();
        }
        #endregion

        #region Methods
        private void TaoLai()
        {
            TaoBangDSSanBay();
            txtMaSanBay.Clear();
            txtTenSanBay.Clear();
            txtTenThanhPho.Clear();
            txtTenSanBay.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenSanBay.Text.Trim() != "" && txtTenThanhPho.Text.Trim() != "")
            {
                if (busSanBay.CheckSanBay(txtTenSanBay.Text, txtTenThanhPho.Text))
                {
                    MessageBox.Show("Sân bay đã tồn tại, vui lòng nhập lại thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    dtoSanBay = new DTO_SanBay(txtMaSanBay.Text, txtTenSanBay.Text, txtTenThanhPho.Text);
                    if(busSanBay.Add(dtoSanBay))
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
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSanBay.Text.Trim() != "")
            {
                if (txtTenSanBay.Text.Trim() != "" && txtTenThanhPho.Text.Trim() != "")
                {
                    try
                    {
                        dtoSanBay = new DTO_SanBay(txtMaSanBay.Text, txtTenSanBay.Text, txtTenThanhPho.Text);
                        if (busSanBay.Update(dtoSanBay))
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
            if (txtMaSanBay.Text.Trim() != "")
            {
                try
                {
                    string maSanBay = txtMaSanBay.Text;
                    if (busSanBay.Delete(maSanBay))
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
        private void TaoBangDSSanBay()
        {
            DataTable dtSanBay = busSanBay.GetForDisplay();
            dtgvSanBay.DataSource = dtSanBay;
            dtgvSanBay.Sort(dtgvSanBay.Columns[0], ListSortDirection.Descending);
            dtgvSanBay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvSanBay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void dtgvSanBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dtgvSanBay.Rows[e.RowIndex];
            txtMaSanBay.Text = row.Cells[0].Value.ToString();
            txtTenSanBay.Text = row.Cells[1].Value.ToString();
            txtTenThanhPho.Text = row.Cells[2].Value.ToString();
        }
        private void KhoiTaoGiaoDien()
        {
            TaoBangDSSanBay();
            txtTenSanBay.Focus();
        }
        private void frmQuanLySanBay_Shown(object sender, EventArgs e)
        {
            KhoiTaoGiaoDien();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtgvSanBay.DataSource = busSanBay.SearchOfMaSanBay(txtTimKiem.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtSanBay = busSanBay.GetForDisplay();
            dtgvSanBay.DataSource = dtSanBay;
            dtgvSanBay.Sort(dtgvSanBay.Columns[0], ListSortDirection.Descending);
            dtgvSanBay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvSanBay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        #endregion
    }
}
