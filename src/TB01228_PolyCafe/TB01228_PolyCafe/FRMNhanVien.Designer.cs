namespace GUI_PolyCafe
{
    partial class FRMNhanVien
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
            label2 = new Label();
            txtMaNhanVien = new TextBox();
            txtHoTen = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtXacNhanMatKhau = new TextBox();
            label6 = new Label();
            txtMatKhau = new TextBox();
            label7 = new Label();
            rdbNhanVien = new RadioButton();
            rdbQuanLy = new RadioButton();
            DGVNhanVien = new DataGridView();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLamMoi = new Button();
            tbTimKiem = new TextBox();
            btnTimKiem = new Button();
            rdbKhongHoatDong = new RadioButton();
            rdbHoatDong = new RadioButton();
            label8 = new Label();
            pnTrangThai = new Panel();
            pnVaiTro = new Panel();
            ((System.ComponentModel.ISupportInitialize)DGVNhanVien).BeginInit();
            pnTrangThai.SuspendLayout();
            pnVaiTro.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(64, 64, 64);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(15, 94);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã Nhân Viên";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(120, 86);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.ReadOnly = true;
            txtMaNhanVien.Size = new Size(114, 23);
            txtMaNhanVien.TabIndex = 2;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(120, 137);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(114, 23);
            txtHoTen.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(64, 64, 64);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(26, 140);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 3;
            label3.Text = "Họ Tên";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(13, 13);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 7;
            label4.Text = "Vai Trò";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(120, 187);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(114, 23);
            txtEmail.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(64, 64, 64);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(26, 190);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 5;
            label5.Text = "Email";
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Location = new Point(126, 290);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.Size = new Size(108, 23);
            txtXacNhanMatKhau.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(64, 64, 64);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(8, 296);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 11;
            label6.Text = "Xác Nhận Mật Khẩu";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(120, 236);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(114, 23);
            txtMatKhau.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(64, 64, 64);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(23, 239);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 9;
            label7.Text = "Mật Khẩu";
            // 
            // rdbNhanVien
            // 
            rdbNhanVien.AutoSize = true;
            rdbNhanVien.ForeColor = SystemColors.ButtonHighlight;
            rdbNhanVien.Location = new Point(84, 9);
            rdbNhanVien.Name = "rdbNhanVien";
            rdbNhanVien.Size = new Size(80, 19);
            rdbNhanVien.TabIndex = 13;
            rdbNhanVien.TabStop = true;
            rdbNhanVien.Text = "Nhân Viên";
            rdbNhanVien.UseVisualStyleBackColor = true;
            // 
            // rdbQuanLy
            // 
            rdbQuanLy.AutoSize = true;
            rdbQuanLy.ForeColor = SystemColors.ControlLightLight;
            rdbQuanLy.Location = new Point(182, 11);
            rdbQuanLy.Name = "rdbQuanLy";
            rdbQuanLy.Size = new Size(68, 19);
            rdbQuanLy.TabIndex = 14;
            rdbQuanLy.TabStop = true;
            rdbQuanLy.Text = "Quản Lý";
            rdbQuanLy.UseVisualStyleBackColor = true;
            // 
            // DGVNhanVien
            // 
            DGVNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVNhanVien.Location = new Point(240, 86);
            DGVNhanVien.Name = "DGVNhanVien";
            DGVNhanVien.Size = new Size(558, 227);
            DGVNhanVien.TabIndex = 15;
            DGVNhanVien.CellDoubleClick += DGVNhanVien_CellDoubleClick;
            // 
            // btnThem
            // 
            btnThem.BackgroundImage = Properties.Resources.Screenshot_2025_05_22_132550;
            btnThem.ForeColor = SystemColors.ButtonHighlight;
            btnThem.Location = new Point(337, 328);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(190, 53);
            btnThem.TabIndex = 16;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackgroundImage = Properties.Resources.Screenshot_2025_05_22_132550;
            btnXoa.ForeColor = SystemColors.ButtonHighlight;
            btnXoa.Location = new Point(337, 405);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(190, 53);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackgroundImage = Properties.Resources.Screenshot_2025_05_22_132550;
            btnSua.ForeColor = SystemColors.ButtonHighlight;
            btnSua.Location = new Point(608, 327);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(190, 53);
            btnSua.TabIndex = 18;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackgroundImage = Properties.Resources.Screenshot_2025_05_22_132550;
            btnLamMoi.ForeColor = SystemColors.ButtonHighlight;
            btnLamMoi.Location = new Point(608, 402);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(190, 53);
            btnLamMoi.TabIndex = 19;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // tbTimKiem
            // 
            tbTimKiem.Location = new Point(425, 48);
            tbTimKiem.Name = "tbTimKiem";
            tbTimKiem.Size = new Size(173, 23);
            tbTimKiem.TabIndex = 20;
            tbTimKiem.TextChanged += tbTimKiem_TextChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackgroundImage = Properties.Resources.Screenshot_2025_05_22_132550;
            btnTimKiem.ForeColor = SystemColors.ButtonHighlight;
            btnTimKiem.Location = new Point(608, 32);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(190, 50);
            btnTimKiem.TabIndex = 21;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // rdbKhongHoatDong
            // 
            rdbKhongHoatDong.AutoSize = true;
            rdbKhongHoatDong.ForeColor = SystemColors.ButtonHighlight;
            rdbKhongHoatDong.Location = new Point(182, 3);
            rdbKhongHoatDong.Name = "rdbKhongHoatDong";
            rdbKhongHoatDong.Size = new Size(121, 19);
            rdbKhongHoatDong.TabIndex = 24;
            rdbKhongHoatDong.TabStop = true;
            rdbKhongHoatDong.Text = "Không Hoạt Đông";
            rdbKhongHoatDong.UseVisualStyleBackColor = true;
            rdbKhongHoatDong.CheckedChanged += rdbKhongHoatDong_CheckedChanged;
            // 
            // rdbHoatDong
            // 
            rdbHoatDong.AutoSize = true;
            rdbHoatDong.ForeColor = SystemColors.ButtonHighlight;
            rdbHoatDong.Location = new Point(84, 3);
            rdbHoatDong.Name = "rdbHoatDong";
            rdbHoatDong.Size = new Size(83, 19);
            rdbHoatDong.TabIndex = 23;
            rdbHoatDong.TabStop = true;
            rdbHoatDong.Text = "Hoạt Động";
            rdbHoatDong.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(6, 7);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 22;
            label8.Text = "Trạng Thái";
            // 
            // pnTrangThai
            // 
            pnTrangThai.BackColor = Color.FromArgb(64, 64, 64);
            pnTrangThai.Controls.Add(rdbKhongHoatDong);
            pnTrangThai.Controls.Add(label8);
            pnTrangThai.Controls.Add(rdbHoatDong);
            pnTrangThai.Location = new Point(5, 341);
            pnTrangThai.Name = "pnTrangThai";
            pnTrangThai.Size = new Size(307, 28);
            pnTrangThai.TabIndex = 25;
            pnTrangThai.Paint += panel1_Paint;
            // 
            // pnVaiTro
            // 
            pnVaiTro.BackColor = Color.FromArgb(64, 64, 64);
            pnVaiTro.Controls.Add(rdbQuanLy);
            pnVaiTro.Controls.Add(label4);
            pnVaiTro.Controls.Add(rdbNhanVien);
            pnVaiTro.Location = new Point(6, 410);
            pnVaiTro.Name = "pnVaiTro";
            pnVaiTro.Size = new Size(306, 41);
            pnVaiTro.TabIndex = 26;
            // 
            // FRMNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.Screenshot_2025_05_22_133704;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(878, 490);
            Controls.Add(pnVaiTro);
            Controls.Add(pnTrangThai);
            Controls.Add(btnTimKiem);
            Controls.Add(tbTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(DGVNhanVien);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(label6);
            Controls.Add(txtMatKhau);
            Controls.Add(label7);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtHoTen);
            Controls.Add(label3);
            Controls.Add(txtMaNhanVien);
            Controls.Add(label2);
            DoubleBuffered = true;
            Name = "FRMNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRMNhanVien";
            Load += FRMNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)DGVNhanVien).EndInit();
            pnTrangThai.ResumeLayout(false);
            pnTrangThai.PerformLayout();
            pnVaiTro.ResumeLayout(false);
            pnVaiTro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtMaNhanVien;
        private TextBox txtHoTen;
        private Label label3;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtXacNhanMatKhau;
        private Label label6;
        private TextBox txtMatKhau;
        private Label label7;
        private RadioButton rdbNhanVien;
        private RadioButton rdbQuanLy;
        private DataGridView DGVNhanVien;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLamMoi;
        private TextBox tbTimKiem;
        private Button btnTimKiem;
        private RadioButton rdbKhongHoatDong;
        private RadioButton rdbHoatDong;
        private Label label8;
        private Panel pnTrangThai;
        private Panel pnVaiTro;
    }
}