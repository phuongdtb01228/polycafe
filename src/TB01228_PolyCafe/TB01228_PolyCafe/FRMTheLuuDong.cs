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
using DAL_PolyCafe;

namespace GUI_PolyCafe
{
    public partial class FRMTheLuuDong : Form
    {
        BUSTheLuuDong busTheLuuDong = new BUSTheLuuDong();
        public FRMTheLuuDong()
        {
            InitializeComponent();
        }

        private void FRMTheLuuDong_Load(object sender, EventArgs e)
        {
            LoadTheLuuDong();
        }

        private void LoadTheLuuDong()
        {
            BUSTheLuuDong busTheLuuDong = new BUSTheLuuDong();
            DGVNhanVien.DataSource = null;
            DGVNhanVien.DataSource = busNhanVien.GetNhanVienList();
            DGVNhanVien.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
            DGVNhanVien.Columns["HoTen"].HeaderText = "Họ Tên";
            DGVNhanVien.Columns["Email"].HeaderText = "Email";
            DGVNhanVien.Columns["MatKhau"].HeaderText = "Mật Khẩu";
            DGVNhanVien.Columns["VaiTro"].HeaderText = "Vai Trò";
            DGVNhanVien.Columns["TrangThai"].HeaderText = "Trạng Thái";
            DGVNhanVien.Columns["VaiTro"].Visible = false; // Ẩn cột Vai Trò
            DGVNhanVien.Columns["TrangThai"].Visible = false; // Ẩn cột Trạng Thái

            DGVNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
