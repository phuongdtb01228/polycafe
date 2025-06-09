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

namespace GUI_PolyCafe
{
    public partial class FRMThongTinTaiKhoan : Form
    {
        public FRMThongTinTaiKhoan(NhanVien nv)
        {
            InitializeComponent();
            if (nv != null)
            {
                txtMaNV.Text = nv.MaNhanVien;
                txtHoTen.Text = nv.HoTen;
                txtEmail.Text = nv.Email;
                txtVaiTro.Text = nv.VaiTro ? "Quản lý" : "Nhân viên";
                txtTrangThai.Text = nv.TrangThai ? "Đang hoạt động" : "Ngưng hoạt động";
            }

        }

        private void FRMThongTinTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
