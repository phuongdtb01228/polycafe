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

    public partial class FRMThongKeLSP : Form
    {
        BUSDoanhThuTheoLoaiSP bus = new BUSDoanhThuTheoLoaiSP();
        BUSLoaiSanPham busloai = new BUSLoaiSanPham();
        public FRMThongKeLSP()
        {
            InitializeComponent();
        }

        private void LoadLoaiSanPham()
        {
            var dsLoai = busloai.GetLoaiSanPhamList();
            dsLoai.Insert(0, new LoaiSanPham { MaLoai = "", TenLoai = "--Tất cả--" });
            cbLSP.DataSource = dsLoai;
            cbLSP.DisplayMember = "TenLoai";
            cbLSP.ValueMember = "MaLoai";
        }

        private void FRMThongKeLSP_Load(object sender, EventArgs e)
        {
            LoadLoaiSanPham();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string maLoai = cbLSP.SelectedValue?.ToString() ?? "";
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;

            var ketQua = bus.GetThongKeDoanhThuTheoLoai(maLoai, tuNgay, denNgay);

            // Thiết lập cột nếu chưa có  
            if (dgvThongKe.Columns.Count == 0)
            {
                dgvThongKe.Columns.Add("TenLoai", "Tên Loại");
                dgvThongKe.Columns.Add("DoanhThu", "Doanh Thu");
            }
            dgvThongKe.Rows.Clear();

            foreach (var item in ketQua)
            {
                dgvThongKe.Rows.Add(item.TenLoai, item.DoanhThu.ToString("#,0"));
            }
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
