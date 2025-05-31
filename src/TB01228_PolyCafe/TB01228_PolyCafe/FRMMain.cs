using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}
