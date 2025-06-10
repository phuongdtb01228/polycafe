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
    public partial class FRMThongKeTheoNV : Form
    {
        BUSDoanhThuTheoNV busNV = new BUSDoanhThuTheoNV();
        BUSNhanVien busNhanVien = new BUSNhanVien();
        public FRMThongKeTheoNV()
        {
            InitializeComponent();
        }

        private void LoadNhanVien()
        {
            var dsNV = busNhanVien.GetNhanVienList();
            dsNV.Insert(0, new NhanVien { MaNhanVien = "", HoTen = "--Tất cả--" });
            cbNV.DataSource = dsNV;
            cbNV.DisplayMember = "HoTen";
            cbNV.ValueMember = "MaNhanVien";
        }


        private void FRMThongKeTheoNV_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.CustomFormat = "dd/MM/yyyy HH:mm:ss";

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string maNV = cbNV.SelectedValue?.ToString() ?? "";
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;

            var ketQua = busNV.GetThongKeDoanhThuTheoNhanVien(maNV, tuNgay, denNgay);

            // Thiết lập cột nếu chưa có
            if (dgvThongKe.Columns.Count == 0)
            {
                dgvThongKe.Columns.Add("HoTen", "Tên Nhân Viên");
                dgvThongKe.Columns.Add("DoanhThu", "Doanh Thu");
            }
            dgvThongKe.Rows.Clear();

            foreach (var item in ketQua)
            {
                dgvThongKe.Rows.Add(item.HoTen, item.DoanhThu.ToString("#,0"));
            }
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

    }
}
