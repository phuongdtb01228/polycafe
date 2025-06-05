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
using DTO_PolyCafe;

namespace GUI_PolyCafe
{
    public partial class FRMSanPham : Form
    {
        BUSSanPham busSanPham = new BUSSanPham();
        public FRMSanPham()
        {
            InitializeComponent();
            LoadSanPham();
        }

        private void LoadSanPham()
        {
            BUSSanPham busSanPham = new BUSSanPham();
            dgvSanPham.DataSource = null;
            dgvSanPham.DataSource = busSanPham.GetSanPhamList();
            dgvSanPham.Columns["MaSanPham"].HeaderText = "Mã Sản Phẩm";
            dgvSanPham.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
            dgvSanPham.Columns["DonGia"].HeaderText = "Đơn Giá";
            dgvSanPham.Columns["MaLoai"].HeaderText = "Mã Loại";
            dgvSanPham.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dgvSanPham.Columns["TrangThai"].Visible = false; // Ẩn cột Trạng Thái
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void ClearForm()
        {
            txtMaSanPham.Clear();
            txtTenSanPham.Clear();
            txtDonGia.Clear();
            txtLoaiSanPham.Clear();
            cbHoatDong.Checked = false;
            cbKhongHoatDong.Checked = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string tenSP = txtTenSanPham.Text.Trim();
                string donGiaText = txtDonGia.Text.Trim();
                string maLoai = txtLoaiSanPham.Text.Trim();
                bool trangThai = cbHoatDong.Checked;

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(donGiaText) || string.IsNullOrEmpty(maLoai))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chuyển đổi đơn giá
                if (!decimal.TryParse(donGiaText, out decimal donGia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string savedPath = ImageUtil.SaveImage(pbHinhAnh.Image, "Uploads/SanPham");

                // Tạo đối tượng sản phẩm
                SanPham sp = new SanPham
                {
                    TenSanPham = tenSP,
                    DonGia = donGia,
                    MaLoai = maLoai,
                    TrangThai = trangThai,
                    HinhAnh = savedPath,
                };

                // Thêm sản phẩm vào cơ sở dữ liệu
                BUSSanPham bUSSanPham = new BUSSanPham();
                bUSSanPham.InsertSanPham(sp);

                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Làm mới form sau khi thêm
                ClearForm();
                LoadSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FRMSanPham_Load(object sender, EventArgs e)
        {

        }

        private void dgvSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
                txtMaSanPham.Text = row.Cells["MaSanPham"].Value.ToString();
                txtTenSanPham.Text = row.Cells["TenSanPham"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
                txtLoaiSanPham.Text = row.Cells["MaLoai"].Value.ToString();
                string path = Path.Combine(Application.StartupPath, row.Cells["HinhAnh"].Value.ToString());
                pbHinhAnh.Image = ImageUtil.LoadImage(path);
                pbHinhAnh.Tag = path;
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ form
                string maSanPham = txtMaSanPham.Text.Trim();
                string tenSanPham = txtTenSanPham.Text.Trim();
                string donGiaa = txtDonGia.Text.Trim();
                string maLoai = txtLoaiSanPham.Text.Trim();
                bool TrangThai;

                if (cbHoatDong.Checked)
                {
                    TrangThai = false; // Nhân viên
                }
                else
                {
                    TrangThai = true; // Quản lý
                }

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(maSanPham) || string.IsNullOrEmpty(tenSanPham))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(donGiaa, out decimal donGia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng nhân viên
                SanPham sp = new SanPham
                {
                    MaSanPham = maSanPham,
                    TenSanPham = tenSanPham,
                    DonGia = donGia,
                    MaLoai = maLoai,
                    TrangThai = true // Giữ trạng thái mặc định là active
                };

                // Gọi DAL để cập nhật nhân viên vào trong database
                BUSSanPham bUSSanPham = new BUSSanPham();
                busSanPham.UpdateSanPham(sp);
                MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Bước 1: Lấy mã nhân viên từ form
                string maSanPham = txtMaSanPham.Text.Trim();
                // Bước 2: Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(maSanPham))
                {
                    MessageBox.Show("Vui lòng chọn Sản Phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Bước 3: Xóa nhân viên khỏi CSDL
                busSanPham.DeleteSanPham(maSanPham);
                MessageBox.Show("Xóa nhân Sản Phẩm Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm(); // Xóa form sau khi xóa
                LoadSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();

            LoadSanPham();
        }

        private void SearchInAllCells(string keyword)
        {
            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(keyword.ToLower()))
                    {

                        row.Selected = true;
                        break;
                    }
                    else
                    {
                        row.Selected = false;
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyWord = txtTimKiem.Text;
            if (!string.IsNullOrWhiteSpace(keyWord))
            {
                SearchInAllCells(keyWord);
            }
            txtTimKiem.Clear();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbHinhAnh.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
