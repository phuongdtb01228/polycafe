using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_PolyCafe;
using DAL_PolyCafe;
using DTO_PolyCafe;

namespace GUI_PolyCafe
{
    public partial class FRMLoaiSanPham : Form
    {
        BUSLoaiSanPham busLoaiSanPham = new BUSLoaiSanPham();
        public FRMLoaiSanPham()
        {
            InitializeComponent();

        }

        private void FRMLoaiSanPham_Load(object sender, EventArgs e)
        {
            LoadLoaiSanPham();
        }

        private void LoadLoaiSanPham()
        {
            BLL_PolyCafe.BUSLoaiSanPham busLoaiSanPham = new BLL_PolyCafe.BUSLoaiSanPham();
            dgvLoaiSanPham.DataSource = null;
            dgvLoaiSanPham.DataSource = busLoaiSanPham.GetLoaiSanPhamList();
            dgvLoaiSanPham.Columns["MaLoai"].HeaderText = "Mã Loại";
            dgvLoaiSanPham.Columns["TenLoai"].HeaderText = "Tên Loại";
            dgvLoaiSanPham.Columns["GhiChu"].HeaderText = "Ghi Chú";
            dgvLoaiSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ClearForm()
        {
            txtMaSanPham.Clear();
            txtTenSanPham.Clear();
            txtGhiChu.Clear();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                string tenLoai = txtTenSanPham.Text.Trim();
                string ghiChu = txtGhiChu.Text.Trim();


                if (string.IsNullOrEmpty(tenLoai))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                LoaiSanPham lsp = new LoaiSanPham
                {
                    TenLoai = tenLoai,

                    GhiChu = ghiChu
                };

                // Bước 4: Thêm vào CSDL
                busLoaiSanPham.InsertLoaiSanPham(lsp);
                MessageBox.Show("Thêm Thẻ Lưu Động Thanhf Coong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm(); // Xóa form sau khi thêm
                LoadLoaiSanPham();
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
                string maLoai = txtMaSanPham.Text.Trim();
                string tenLoai = txtTenSanPham.Text.Trim();
                string ghiChu = txtGhiChu.Text.Trim();

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(maLoai) || string.IsNullOrEmpty(tenLoai))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng nhân viên
                LoaiSanPham lsp = new LoaiSanPham
                {
                    MaLoai = maLoai,
                    TenLoai = tenLoai,
                    GhiChu = ghiChu,
                };

                // Gọi DAL để cập nhật nhân viên vào trong database
                BUSLoaiSanPham busLoaiSanPham = new BUSLoaiSanPham();
                busLoaiSanPham.Update(lsp);
                MessageBox.Show("Cập nhật Loai San Pham thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadLoaiSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLoaiSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLoaiSanPham.Rows[e.RowIndex];
                txtMaSanPham.Text = row.Cells["MaLoai"].Value.ToString();
                txtTenSanPham.Text = row.Cells["TenLoai"].Value.ToString();
                txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Bước 1: Lấy mã nhân viên từ form
                string maLoai = txtMaSanPham.Text.Trim();
                // Bước 2: Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(maLoai))
                {
                    MessageBox.Show("Vui lòng San Pham để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Bước 3: Xóa nhân viên khỏi CSDL
                busLoaiSanPham.DeleteThe(maLoai);
                MessageBox.Show("Xóa Loai San Pham thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm(); // Xóa form sau khi xóa
                LoadLoaiSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadLoaiSanPham();
        }

        private void SearchInAllCells(string keyword)
        {
            foreach (DataGridViewRow row in dgvLoaiSanPham.Rows)
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
    }
}
