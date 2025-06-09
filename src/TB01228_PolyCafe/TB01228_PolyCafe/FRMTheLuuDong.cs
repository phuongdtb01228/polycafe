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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

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
            dgvTheLuuDong.DataSource = null;
            

            dgvTheLuuDong.DataSource = busTheLuuDong.GetTheLuuDongList();
            dgvTheLuuDong.Columns["MaThe"].HeaderText = "Mã Thẻ";
            dgvTheLuuDong.Columns["ChuSoHuu"].HeaderText = "Chủ Sỡ Hữu";
            dgvTheLuuDong.Columns["TrangThaiText"].HeaderText = "Trạng Thái";
            dgvTheLuuDong.Columns["TrangThai"].Visible = false; // Ẩn cột Trạng Thái

            dgvTheLuuDong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTheLuuDong.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            
        }

        private void ClearForm()
        {
            txtMaThe.Clear();
            txtChuSoHuu.Clear();
            cbHoatDong.Checked = false;
            cbKhongHoatDong.Checked = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                string chuSoHuu = txtChuSoHuu.Text.Trim();
                bool trangThai = cbHoatDong.Checked;


                if (string.IsNullOrEmpty(chuSoHuu))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                TheLuuDong tld = new TheLuuDong
                {
                    ChuSoHuu = chuSoHuu,

                    TrangThai = trangThai
                };

                // Bước 4: Thêm vào CSDL
                busTheLuuDong.InsertTheLuuDong(tld);
                MessageBox.Show("Thêm Thẻ Lưu Động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm(); // Xóa form sau khi thêm
                LoadTheLuuDong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTheLuuDong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTheLuuDong.Rows[e.RowIndex];
                txtMaThe.Text = row.Cells["MaThe"].Value.ToString();
                txtChuSoHuu.Text = row.Cells["ChuSoHuu"].Value.ToString();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Bước 1: Lấy mã nhân viên từ form
                string maThe = txtMaThe.Text.Trim();
                // Bước 2: Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(maThe))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Bước 3: Xóa nhân viên khỏi CSDL
                busTheLuuDong.DeleteThe(maThe);
                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm(); // Xóa form sau khi xóa
                LoadTheLuuDong();
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
                string maThe = txtMaThe.Text.Trim();
                string chuSoHuu = txtChuSoHuu.Text.Trim();
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
                if (string.IsNullOrEmpty(maThe) || string.IsNullOrEmpty(chuSoHuu))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng nhân viên
                TheLuuDong tld = new TheLuuDong
                {
                    MaThe = maThe,
                    ChuSoHuu = chuSoHuu,
                    TrangThai = true // Giữ trạng thái mặc định là active
                };

                // Gọi DAL để cập nhật nhân viên vào trong database
                BUSTheLuuDong busTheLuuDong = new BUSTheLuuDong();
                busTheLuuDong.Update(tld);
                MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadTheLuuDong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadTheLuuDong();
        }

        private void SearchInAllCells(string keyword)
        {
            foreach (DataGridViewRow row in dgvTheLuuDong.Rows)
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
    }
    }

