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
    public partial class frmDangNhap : Form
    {
        #region Properties

        BUS_NhanVien busNhanVien;

        #endregion

        #region Initializes
        public frmDangNhap()
        {
            InitializeComponent();
            busNhanVien = new BUS_NhanVien();
            KhoiTaoGiaoDien();
        }

        #endregion

        #region Methods
        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                DataTable dtNhanVien = busNhanVien.GetOfUsernameAndPassword(txtUsername.Text, txtPassword.Text);
                if (dtNhanVien.Rows.Count > 0)
                {
                    DataRow row = dtNhanVien.Rows[0];
                    Form frm = new frmMain(row);
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void frmDangNhap_Shown(object sender, EventArgs e)
        {
            txtUsername.Focus();
            
        }
        private void KhoiTaoGiaoDien()
        {
            txtUsername.Focus();

            txtUsername.TabIndex = 0;
            txtPassword.TabIndex = 1;
            btnDangNhap.TabIndex = 2;
            btnThoat.TabIndex = 3;

            txtPassword.UseSystemPasswordChar = true;

            AcceptButton = btnDangNhap;
            CancelButton = btnThoat;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
        #endregion
    }
}
