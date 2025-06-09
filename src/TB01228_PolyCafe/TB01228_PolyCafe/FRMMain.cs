using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_PolyCafe;
using TB01228_PolyCafe;
using UTIL_PolyCafe;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_PolyCafe
{
    public partial class FRMMain : Form
    {
        public FRMMain()
        {
            InitializeComponent();
            CheckPermisson();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void menustripDoiMK_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau1 doiMatKhau = new frmDoiMatKhau1();
            openChildForm(doiMatKhau);
        }

        private void FRMMain_Load(object sender, EventArgs e)
        {

        }

        private Form currentFormChild;

        private void openChildForm(Form formchild)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = formchild;
            formchild.TopLevel = false;
            formchild.FormBorderStyle = FormBorderStyle.None;
            formchild.Dock = DockStyle.Fill;
            pnMain1.Controls.Add(formchild);
            pnMain1.Tag = formchild;
            formchild.BringToFront();
            formchild.Show();

        }

        private void menustripTTTK_Click(object sender, EventArgs e)
        {
            //load dữ liệu lên
            NhanVien nv = AuthUtil.user;
            FRMThongTinTaiKhoan frm = new FRMThongTinTaiKhoan(nv);
            openChildForm(frm);

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMNhanVien quanlynhanvien = new FRMNhanVien();
            openChildForm(quanlynhanvien);
        }

        private void menustripThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            Application.Exit();
        }

        private void thẻLưuĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMTheLuuDong theLuuDong = new FRMTheLuuDong();
            openChildForm(theLuuDong);
        }

        private void VaiTroNhanVien()
        {
            msTK.Visible = true;
            msThongKe.Visible = false;
            msQuanLy.Visible = true;
            msNhanVien.Visible = false;
        }

        private void CheckPermisson()
        {
            if (AuthUtil.IsLogin())
            {
                msTK.Visible = true;
                msThongKe.Visible = true;
                msQuanLy.Visible = true;
                msNhanVien.Visible = true;
                if (AuthUtil.user.VaiTro == false)
                {
                    VaiTroNhanVien();
                }
                else
                {
                    msTK.Visible = true;
                    msThongKe.Visible = true;
                    msQuanLy.Visible = true;
                    msNhanVien.Visible = true;
                }
            }
        }

        private void msHoTro_Click(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FRMNhanVien nhanVien = new FRMNhanVien();
            openChildForm(nhanVien);
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FRMSanPham());
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FRMLoaiSanPham());
        }

        private void phiếuBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FRMPhieuBanHang());
        }

        private void pnMain1_Paint(object sender, PaintEventArgs e)
        {
            openChildForm(new logomain());
        }

        private void msThongKe_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêTheoLoạiSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FRMThongKeLSP());
        }

        private void thốngKêTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FRMThongKeTheoNV());
        }

        private void menustripDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Ẩn form main
                this.Hide();

                // Hiển thị lại form đăng nhập
                FRMLogin frmDangNhap = new FRMLogin();
                frmDangNhap.Show();

                // Đóng form main khi form đăng nhập đóng (nếu muốn thoát hẳn app)
                this.Close();
            }
        }

        private void liênHệColdLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FRMHoTro());
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new logomain());
        }
    }
}
