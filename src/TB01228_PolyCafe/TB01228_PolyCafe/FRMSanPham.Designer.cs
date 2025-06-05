namespace GUI_PolyCafe
{
    partial class FRMSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            cbKhongHoatDong = new CheckBox();
            cbHoatDong = new CheckBox();
            btnLamMoi = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            label4 = new Label();
            txtTenSanPham = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dgvSanPham = new DataGridView();
            btnThem = new Button();
            txtMaSanPham = new TextBox();
            label1 = new Label();
            txtDonGia = new TextBox();
            label5 = new Label();
            txtLoaiSanPham = new TextBox();
            label6 = new Label();
            pbHinhAnh = new PictureBox();
            btnTimAnh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHinhAnh).BeginInit();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(575, 125);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(145, 23);
            txtTimKiem.TabIndex = 30;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(735, 125);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 29;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // cbKhongHoatDong
            // 
            cbKhongHoatDong.AutoSize = true;
            cbKhongHoatDong.Location = new Point(214, 351);
            cbKhongHoatDong.Name = "cbKhongHoatDong";
            cbKhongHoatDong.Size = new Size(122, 19);
            cbKhongHoatDong.TabIndex = 28;
            cbKhongHoatDong.Text = "Không Hoạt Động";
            cbKhongHoatDong.UseVisualStyleBackColor = true;
            // 
            // cbHoatDong
            // 
            cbHoatDong.AutoSize = true;
            cbHoatDong.Location = new Point(113, 350);
            cbHoatDong.Name = "cbHoatDong";
            cbHoatDong.Size = new Size(84, 19);
            cbHoatDong.TabIndex = 27;
            cbHoatDong.Text = "Hoạt Động";
            cbHoatDong.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(171, 455);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(75, 23);
            btnLamMoi.TabIndex = 26;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(17, 455);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 25;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(171, 399);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 24;
            btnXoa.Text = "Xóa ";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 351);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 23;
            label4.Text = "Trạng Thái";
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(113, 259);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(200, 23);
            txtTenSanPham.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 262);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 21;
            label3.Text = "Tên Sản Phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F);
            label2.Location = new Point(331, 31);
            label2.Name = "label2";
            label2.Size = new Size(160, 45);
            label2.TabIndex = 20;
            label2.Text = "Sản Phẩm";
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(357, 165);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.Size = new Size(630, 223);
            dgvSanPham.TabIndex = 19;
            dgvSanPham.CellDoubleClick += dgvSanPham_CellDoubleClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(17, 399);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 18;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.Location = new Point(113, 151);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.ReadOnly = true;
            txtMaSanPham.Size = new Size(200, 23);
            txtMaSanPham.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 154);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 16;
            label1.Text = "Mã Sản Phẩm";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(113, 306);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(200, 23);
            txtDonGia.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 309);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 31;
            label5.Text = "Đơn Giá";
            // 
            // txtLoaiSanPham
            // 
            txtLoaiSanPham.Location = new Point(113, 206);
            txtLoaiSanPham.Name = "txtLoaiSanPham";
            txtLoaiSanPham.Size = new Size(200, 23);
            txtLoaiSanPham.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 209);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 33;
            label6.Text = "Loại Sản Phẩm";
            // 
            // pbHinhAnh
            // 
            pbHinhAnh.Location = new Point(448, 399);
            pbHinhAnh.Name = "pbHinhAnh";
            pbHinhAnh.Size = new Size(292, 94);
            pbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHinhAnh.TabIndex = 35;
            pbHinhAnh.TabStop = false;
            // 
            // btnTimAnh
            // 
            btnTimAnh.Location = new Point(557, 509);
            btnTimAnh.Name = "btnTimAnh";
            btnTimAnh.Size = new Size(75, 23);
            btnTimAnh.TabIndex = 36;
            btnTimAnh.Text = "Tìm Ảnh";
            btnTimAnh.UseVisualStyleBackColor = true;
            btnTimAnh.Click += btnTimAnh_Click;
            // 
            // FRMSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 553);
            Controls.Add(btnTimAnh);
            Controls.Add(pbHinhAnh);
            Controls.Add(txtLoaiSanPham);
            Controls.Add(label6);
            Controls.Add(txtDonGia);
            Controls.Add(label5);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(cbKhongHoatDong);
            Controls.Add(cbHoatDong);
            Controls.Add(btnLamMoi);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(label4);
            Controls.Add(txtTenSanPham);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvSanPham);
            Controls.Add(btnThem);
            Controls.Add(txtMaSanPham);
            Controls.Add(label1);
            MaximumSize = new Size(1006, 592);
            MinimumSize = new Size(1006, 592);
            Name = "FRMSanPham";
            Text = "FRMSanPham";
            Load += FRMSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHinhAnh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private CheckBox cbKhongHoatDong;
        private CheckBox cbHoatDong;
        private Button btnLamMoi;
        private Button btnSua;
        private Button btnXoa;
        private Label label4;
        private TextBox txtTenSanPham;
        private Label label3;
        private Label label2;
        private DataGridView dgvSanPham;
        private Button btnThem;
        private TextBox txtMaSanPham;
        private Label label1;
        private TextBox txtDonGia;
        private Label label5;
        private TextBox txtLoaiSanPham;
        private Label label6;
        private PictureBox pbHinhAnh;
        private Button btnTimAnh;
    }
}