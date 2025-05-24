using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_PolyCafe;
using UTIL_PolyCafe;

namespace GUI_PolyCafe
{
    public partial class frmDoiMatKhau1 : Form
    {
        BUSNhanVien busNhanVien = new BUSNhanVien();
        public frmDoiMatKhau1()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau1_Load(object sender, EventArgs e)
        {
            if (AuthUtil.IsLogin())
            {
                txtMaNV.Text = AuthUtil.user.MaNhanVien;
                txtTenNV.Text = AuthUtil.user.HoTen;
            }
        }

        private void rdbHienThi1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbHienThi2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (!AuthUtil.user.MatKhau.Equals(txtMatKhauCu.Text))
            {
                MessageBox.Show(this, "Mật Khẩu Cũ Không Chính Xác");
            }
            else
            {
                if (!txtXacNhanMatKhau.Text.Equals(txtXacNhanMatKhau.Text))
                {
                    MessageBox.Show(this, "Xác Nhận Mật Khẩu Mới Chưa Trùng Khớp!!");
                }
                else
                {
                    AuthUtil.user.MatKhau = txtMatKhauMoi.Text;

                    if (busNhanVien.UpdateMatKhau(AuthUtil.user.Email, txtMatKhauMoi.Text))
                    {
                        MessageBox.Show("Đổi Mật Khẩu Thành Công");
                    }
                    else
                    {
                        MessageBox.Show("Đổi Mật Khẩu Thất Bại");
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            Application.Exit();
        }

        private void btnDoiMK_Click_1(object sender, EventArgs e)
        {
            if (!AuthUtil.user.MatKhau.Equals(txtMatKhauCu.Text))
            {
                MessageBox.Show(this, "Mật Khẩu Cũ Không Chính Xác");
            }
            else
            {
                if (!txtXacNhanMatKhau.Text.Equals(txtXacNhanMatKhau.Text))
                {
                    MessageBox.Show(this, "Xác Nhận Mật Khẩu Mới Chưa Trùng Khớp!!");
                }
                else
                {
                    AuthUtil.user.MatKhau = txtMatKhauMoi.Text;

                    if (busNhanVien.UpdateMatKhau(AuthUtil.user.Email, txtMatKhauMoi.Text))
                    {
                        MessageBox.Show("Đổi Mật Khẩu Thành Công");
                    }
                    else
                    {
                        MessageBox.Show("Đổi Mật Khẩu Thất Bại");
                    }
                }
            }
        }

        private void cbMKCU_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhauCu.PasswordChar = cbMKCU.Checked ? '\0' : '*';
        }

        private void cbMKMOI_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhauMoi.PasswordChar = cbMKMOI.Checked ? '\0' : '*';
        }

        private void CBXACNHANMK_CheckedChanged(object sender, EventArgs e)
        {
            txtXacNhanMK.PasswordChar = cbXACNHANMK.Checked ? '\0' : '*';
        }
    }
}
