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
using DTO_PolyCafe;

namespace GUI_PolyCafe
{
    public partial class FRMNhanVien : Form
    {
        BUSNhanVien busNhanVien = new BUSNhanVien();
        public FRMNhanVien()
        {
            InitializeComponent();
        }

        private void FRMNhanVien_Load(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
        }

        private void LoadDanhSachNhanVien()
        {
            BUSNhanVien busNhanVien = new BUSNhanVien();
            DGVNhanVien.DataSource = null;
            DGVNhanVien.DataSource = busNhanVien.GetNhanVienList();
            DGVNhanVien.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
            DGVNhanVien.Columns["HoTen"].HeaderText = "Họ Tên";
            DGVNhanVien.Columns["Email"].HeaderText = "Email";
            DGVNhanVien.Columns["MatKhau"].HeaderText = "Mật Khẩu";
            DGVNhanVien.Columns["VaiTroText"].HeaderText = "Vai Trò";
            DGVNhanVien.Columns["TrangThaiText"].HeaderText = "Trạng Thái";
            DGVNhanVien.Columns["VaiTro"].Visible = false; // Ẩn cột Vai Trò
            DGVNhanVien.Columns["TrangThai"].Visible = false; // Ẩn cột Trạng Thái

            DGVNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ClearForm()
        {
            txtMaNhanVien.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtMatKhau.Clear();
            txtXacNhanMatKhau.Clear();
            cbQuanLy.Checked = false;
            cbNhanVien.Checked = false;
            cbHoatDong.Checked = false;
            cbKhongHoatDong.Checked = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Bước 1: Lấy dữ liệu từ form
                string hoTen = txtHoTen.Text.Trim();
                string email = txtEmail.Text.Trim();
                string matKhau = txtMatKhau.Text.Trim();
                bool vaiTro = cbQuanLy.Checked;  // Nếu là Trưởng phòng
                bool trangThai = cbHoatDong.Checked; // Nếu được check là đang active

                // Bước 2: Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(hoTen) ||
                    string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (matKhau != txtXacNhanMatKhau.Text.Trim())
                {
                    MessageBox.Show("Mật khẩu xác nhận không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Bước 3: Tạo đối tượng nhân viên
                NhanVien nv = new NhanVien
                {
                    HoTen = hoTen,
                    Email = email,
                    MatKhau = matKhau,
                    VaiTro = vaiTro,
                    TrangThai = trangThai
                };

                // Bước 4: Thêm vào CSDL
                busNhanVien.InsertNhanVien(nv);
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm(); // Xóa form sau khi thêm
                LoadDanhSachNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Bước 1: Lấy mã nhân viên từ form
                string maNV = txtMaNhanVien.Text.Trim();
                // Bước 2: Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(maNV))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Bước 3: Xóa nhân viên khỏi CSDL
                busNhanVien.DeleteNhanVien(maNV);
                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm(); // Xóa form sau khi xóa
                LoadDanhSachNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ form
                string maNV = txtMaNhanVien.Text.Trim();
                string hoTen = txtHoTen.Text.Trim();
                string email = txtEmail.Text.Trim();
                string matKhau = txtMatKhau.Text.Trim();
                string xacNhanMK = txtXacNhanMatKhau.Text.Trim();
                bool vaiTro;

                if (cbNhanVien.Checked)
                {
                    vaiTro = false; // Nhân viên
                }
                else
                {
                    vaiTro = true; // Quản lý
                }

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (matKhau != xacNhanMK)
                {
                    MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng nhân viên
                NhanVien nv = new NhanVien
                {
                    MaNhanVien = maNV,
                    HoTen = hoTen,
                    Email = email,
                    MatKhau = matKhau,
                    VaiTro = vaiTro,
                    TrangThai = true // Giữ trạng thái mặc định là active
                };

                // Gọi DAL để cập nhật nhân viên vào trong database
                BUSNhanVien busNhanVien = new BUSNhanVien();
                busNhanVien.Update(nv);
                MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadDanhSachNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGVNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVNhanVien.Rows[e.RowIndex];
                txtMaNhanVien.Text = row.Cells["MaNhanVien"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                txtXacNhanMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                if (Convert.ToBoolean(row.Cells["VaiTro"].Value))
                {
                    cbQuanLy.Checked = true;
                }
                else
                {
                    cbNhanVien.Checked = true;
                }
                if (Convert.ToBoolean(row.Cells["TrangThai"].Value))
                {
                    cbHoatDong.Checked = true;
                }
                else
                {
                    cbKhongHoatDong.Checked = true;
                }
            }
        }

        private void rdbKhongHoatDong_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DGVNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
        }
    }
}

