namespace GUI_PolyCafe
{
    partial class FRMTheLuuDong
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
            label1 = new Label();
            txtMaThe = new TextBox();
            btnThem = new Button();
            dgvTheLuuDong = new DataGridView();
            label2 = new Label();
            txtChuSoHuu = new TextBox();
            label3 = new Label();
            btnXoa = new Button();
            btnSua = new Button();
            btnLamMoi = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            label4 = new Label();
            cbHoatDong = new CheckBox();
            cbKhongHoatDong = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvTheLuuDong).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 104);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã Thẻ";
            // 
            // txtMaThe
            // 
            txtMaThe.Location = new Point(150, 101);
            txtMaThe.Name = "txtMaThe";
            txtMaThe.ReadOnly = true;
            txtMaThe.Size = new Size(100, 23);
            txtMaThe.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(54, 325);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dgvTheLuuDong
            // 
            dgvTheLuuDong.AllowUserToAddRows = false;
            dgvTheLuuDong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTheLuuDong.Location = new Point(394, 115);
            dgvTheLuuDong.Name = "dgvTheLuuDong";
            dgvTheLuuDong.Size = new Size(536, 343);
            dgvTheLuuDong.TabIndex = 3;
            dgvTheLuuDong.CellDoubleClick += dgvTheLuuDong_CellDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F);
            label2.Location = new Point(251, 9);
            label2.Name = "label2";
            label2.Size = new Size(220, 45);
            label2.TabIndex = 4;
            label2.Text = "Thẻ Lưu Động";
            // 
            // txtChuSoHuu
            // 
            txtChuSoHuu.Location = new Point(150, 161);
            txtChuSoHuu.Name = "txtChuSoHuu";
            txtChuSoHuu.Size = new Size(100, 23);
            txtChuSoHuu.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 164);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 5;
            label3.Text = "Chủ Sỡ Hữu";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(208, 325);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa ";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(54, 405);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(208, 405);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(75, 23);
            btnLamMoi.TabIndex = 11;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(855, 68);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 14;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(695, 68);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(145, 23);
            txtTimKiem.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 235);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 7;
            label4.Text = "Trạng Thái";
            // 
            // cbHoatDong
            // 
            cbHoatDong.AutoSize = true;
            cbHoatDong.Location = new Point(150, 234);
            cbHoatDong.Name = "cbHoatDong";
            cbHoatDong.Size = new Size(84, 19);
            cbHoatDong.TabIndex = 12;
            cbHoatDong.Text = "Hoạt Động";
            cbHoatDong.UseVisualStyleBackColor = true;
            // 
            // cbKhongHoatDong
            // 
            cbKhongHoatDong.AutoSize = true;
            cbKhongHoatDong.Location = new Point(251, 235);
            cbKhongHoatDong.Name = "cbKhongHoatDong";
            cbKhongHoatDong.Size = new Size(122, 19);
            cbKhongHoatDong.TabIndex = 13;
            cbKhongHoatDong.Text = "Không Hoạt Động";
            cbKhongHoatDong.UseVisualStyleBackColor = true;
            // 
            // FRMTheLuuDong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 553);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(cbKhongHoatDong);
            Controls.Add(cbHoatDong);
            Controls.Add(btnLamMoi);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(label4);
            Controls.Add(txtChuSoHuu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvTheLuuDong);
            Controls.Add(btnThem);
            Controls.Add(txtMaThe);
            Controls.Add(label1);
            MaximumSize = new Size(1006, 592);
            MinimumSize = new Size(1006, 592);
            Name = "FRMTheLuuDong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRMTheLuuDong";
            Load += FRMTheLuuDong_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTheLuuDong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMaThe;
        private Button btnThem;
        private DataGridView dgvTheLuuDong;
        private Label label2;
        private TextBox txtChuSoHuu;
        private Label label3;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLamMoi;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label label4;
        private CheckBox cbHoatDong;
        private CheckBox cbKhongHoatDong;
    }
}