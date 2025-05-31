namespace GUI_PolyCafe
{
    partial class FRMLoaiSanPham
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
            txtGhiChu = new TextBox();
            label5 = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnLamMoi = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            txtTenSanPham = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dgvLoaiSanPham = new DataGridView();
            btnThem = new Button();
            txtMaSanPham = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiSanPham).BeginInit();
            SuspendLayout();
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(108, 282);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(200, 23);
            txtGhiChu.TabIndex = 51;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 285);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 50;
            label5.Text = "Ghi Chú";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(563, 55);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(145, 23);
            txtTimKiem.TabIndex = 49;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(723, 55);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 48;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(200, 415);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(75, 23);
            btnLamMoi.TabIndex = 45;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(46, 415);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 44;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(200, 359);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 43;
            btnXoa.Text = "Xóa ";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(108, 205);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(200, 23);
            txtTenSanPham.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 208);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 40;
            label3.Text = "Tên Loại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F);
            label2.Location = new Point(274, 18);
            label2.Name = "label2";
            label2.Size = new Size(227, 45);
            label2.TabIndex = 39;
            label2.Text = "Loại Sản Phẩm";
            // 
            // dgvLoaiSanPham
            // 
            dgvLoaiSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiSanPham.Location = new Point(345, 95);
            dgvLoaiSanPham.Name = "dgvLoaiSanPham";
            dgvLoaiSanPham.Size = new Size(536, 343);
            dgvLoaiSanPham.TabIndex = 38;
            dgvLoaiSanPham.CellDoubleClick += dgvLoaiSanPham_CellDoubleClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(46, 359);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 37;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.Location = new Point(108, 115);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.ReadOnly = true;
            txtMaSanPham.Size = new Size(200, 23);
            txtMaSanPham.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 118);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 35;
            label1.Text = "Mã Loại";
            // 
            // FRMLoaiSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 553);
            Controls.Add(txtGhiChu);
            Controls.Add(label5);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(txtTenSanPham);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvLoaiSanPham);
            Controls.Add(btnThem);
            Controls.Add(txtMaSanPham);
            Controls.Add(label1);
            MaximumSize = new Size(1006, 592);
            MinimumSize = new Size(1006, 592);
            Name = "FRMLoaiSanPham";
            Text = "FRMLoaiSanPham";
            Load += FRMLoaiSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLoaiSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLoaiSanPham;
        private Label label6;
        private TextBox txtGhiChu;
        private Label label5;
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
        private DataGridView dgvLoaiSanPham;
        private Button btnThem;
        private TextBox txtMaSanPham;
        private Label label1;
    }
}