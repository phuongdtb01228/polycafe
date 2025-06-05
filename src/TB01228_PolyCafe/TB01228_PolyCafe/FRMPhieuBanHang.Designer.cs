namespace GUI_PolyCafe
{
    partial class FRMPhieuBanHang
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
            groupBox1 = new GroupBox();
            dtpNgayTao = new DateTimePicker();
            cboNhanVienBH = new ComboBox();
            cboMaTheLuuDong = new ComboBox();
            rdbPaid = new RadioButton();
            rdbConfirmation = new RadioButton();
            label8 = new Label();
            btnMoiPhieu = new Button();
            btnXoaPhieu = new Button();
            btnSuaPhieu = new Button();
            btnThemPhieu = new Button();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            txtMaPhieu = new TextBox();
            label2 = new Label();
            txttimKiemPhieu = new TextBox();
            dgrDanhSachPhieu = new DataGridView();
            groupBox2 = new GroupBox();
            btnTimKiemPhieu = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrDanhSachPhieu).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(379, 9);
            label1.Name = "label1";
            label1.Size = new Size(249, 37);
            label1.TabIndex = 2;
            label1.Text = "PHIẾU BÁN HÀNG";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(dtpNgayTao);
            groupBox1.Controls.Add(cboNhanVienBH);
            groupBox1.Controls.Add(cboMaTheLuuDong);
            groupBox1.Controls.Add(rdbPaid);
            groupBox1.Controls.Add(rdbConfirmation);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnMoiPhieu);
            groupBox1.Controls.Add(btnXoaPhieu);
            groupBox1.Controls.Add(btnSuaPhieu);
            groupBox1.Controls.Add(btnThemPhieu);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtMaPhieu);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(12, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 493);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Phiếu";
            // 
            // dtpNgayTao
            // 
            dtpNgayTao.CustomFormat = "dd/MM/yyyy";
            dtpNgayTao.Font = new Font("Segoe UI", 10F);
            dtpNgayTao.Format = DateTimePickerFormat.Custom;
            dtpNgayTao.Location = new Point(94, 197);
            dtpNgayTao.Name = "dtpNgayTao";
            dtpNgayTao.Size = new Size(238, 25);
            dtpNgayTao.TabIndex = 4;
            // 
            // cboNhanVienBH
            // 
            cboNhanVienBH.Font = new Font("Segoe UI", 11F);
            cboNhanVienBH.FormattingEnabled = true;
            cboNhanVienBH.Location = new Point(94, 145);
            cboNhanVienBH.Name = "cboNhanVienBH";
            cboNhanVienBH.Size = new Size(238, 28);
            cboNhanVienBH.TabIndex = 3;
            // 
            // cboMaTheLuuDong
            // 
            cboMaTheLuuDong.Font = new Font("Segoe UI", 11F);
            cboMaTheLuuDong.FormattingEnabled = true;
            cboMaTheLuuDong.Location = new Point(94, 35);
            cboMaTheLuuDong.Name = "cboMaTheLuuDong";
            cboMaTheLuuDong.Size = new Size(238, 28);
            cboMaTheLuuDong.TabIndex = 1;
            // 
            // rdbPaid
            // 
            rdbPaid.AutoSize = true;
            rdbPaid.Font = new Font("Segoe UI", 10F);
            rdbPaid.ForeColor = Color.Maroon;
            rdbPaid.Location = new Point(224, 245);
            rdbPaid.Name = "rdbPaid";
            rdbPaid.Size = new Size(119, 23);
            rdbPaid.TabIndex = 6;
            rdbPaid.Text = "Đã Thanh Toán";
            rdbPaid.UseVisualStyleBackColor = true;
            // 
            // rdbConfirmation
            // 
            rdbConfirmation.AutoSize = true;
            rdbConfirmation.BackColor = Color.Transparent;
            rdbConfirmation.Checked = true;
            rdbConfirmation.Font = new Font("Segoe UI", 9F);
            rdbConfirmation.ForeColor = Color.Maroon;
            rdbConfirmation.Location = new Point(94, 248);
            rdbConfirmation.Name = "rdbConfirmation";
            rdbConfirmation.Size = new Size(101, 19);
            rdbConfirmation.TabIndex = 5;
            rdbConfirmation.TabStop = true;
            rdbConfirmation.Text = "Chờ Xác Nhận";
            rdbConfirmation.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(4, 251);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 9;
            label8.Text = "Trạng Thái";
            // 
            // btnMoiPhieu
            // 
            btnMoiPhieu.BackColor = SystemColors.Window;
            btnMoiPhieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMoiPhieu.Location = new Point(261, 419);
            btnMoiPhieu.Name = "btnMoiPhieu";
            btnMoiPhieu.Size = new Size(84, 41);
            btnMoiPhieu.TabIndex = 10;
            btnMoiPhieu.Text = "Mới";
            btnMoiPhieu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMoiPhieu.UseVisualStyleBackColor = false;
            btnMoiPhieu.Click += btnMoiPhieu_Click;
            // 
            // btnXoaPhieu
            // 
            btnXoaPhieu.BackColor = SystemColors.Window;
            btnXoaPhieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoaPhieu.Location = new Point(175, 419);
            btnXoaPhieu.Name = "btnXoaPhieu";
            btnXoaPhieu.Size = new Size(80, 41);
            btnXoaPhieu.TabIndex = 9;
            btnXoaPhieu.Text = "Xóa";
            btnXoaPhieu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoaPhieu.UseVisualStyleBackColor = false;
            btnXoaPhieu.Click += btnXoaPhieu_Click;
            // 
            // btnSuaPhieu
            // 
            btnSuaPhieu.BackColor = SystemColors.Window;
            btnSuaPhieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSuaPhieu.Location = new Point(94, 419);
            btnSuaPhieu.Name = "btnSuaPhieu";
            btnSuaPhieu.Size = new Size(75, 41);
            btnSuaPhieu.TabIndex = 8;
            btnSuaPhieu.Text = "Sửa";
            btnSuaPhieu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSuaPhieu.UseVisualStyleBackColor = false;
            btnSuaPhieu.Click += btnSuaPhieu_Click;
            // 
            // btnThemPhieu
            // 
            btnThemPhieu.BackColor = SystemColors.Window;
            btnThemPhieu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThemPhieu.Location = new Point(7, 419);
            btnThemPhieu.Name = "btnThemPhieu";
            btnThemPhieu.Size = new Size(81, 41);
            btnThemPhieu.TabIndex = 7;
            btnThemPhieu.Text = "Thêm";
            btnThemPhieu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThemPhieu.UseVisualStyleBackColor = false;
            btnThemPhieu.Click += btnThemPhieu_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(3, 203);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 0;
            label4.Text = "Ngày Tạo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(3, 152);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 0;
            label3.Text = "Nhân Viên";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(3, 40);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 0;
            label7.Text = "Mã Thẻ";
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Font = new Font("Segoe UI", 12F);
            txtMaPhieu.Location = new Point(94, 95);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.ReadOnly = true;
            txtMaPhieu.Size = new Size(238, 29);
            txtMaPhieu.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(3, 98);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã Phiếu";
            // 
            // txttimKiemPhieu
            // 
            txttimKiemPhieu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txttimKiemPhieu.Location = new Point(123, 20);
            txttimKiemPhieu.Name = "txttimKiemPhieu";
            txttimKiemPhieu.Size = new Size(384, 23);
            txttimKiemPhieu.TabIndex = 12;
            // 
            // dgrDanhSachPhieu
            // 
            dgrDanhSachPhieu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgrDanhSachPhieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrDanhSachPhieu.Location = new Point(17, 50);
            dgrDanhSachPhieu.Name = "dgrDanhSachPhieu";
            dgrDanhSachPhieu.ReadOnly = true;
            dgrDanhSachPhieu.RowHeadersWidth = 51;
            dgrDanhSachPhieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgrDanhSachPhieu.Size = new Size(565, 437);
            dgrDanhSachPhieu.TabIndex = 14;
            dgrDanhSachPhieu.CellClick += dgrDanhSachPhieu_CellClick;
            dgrDanhSachPhieu.CellDoubleClick += dgrDanhSachPhieu_CellDoubleClick;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btnTimKiemPhieu);
            groupBox2.Controls.Add(dgrDanhSachPhieu);
            groupBox2.Controls.Add(txttimKiemPhieu);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.HotTrack;
            groupBox2.Location = new Point(390, 49);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(588, 493);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Phiếu";
            // 
            // btnTimKiemPhieu
            // 
            btnTimKiemPhieu.Location = new Point(513, 19);
            btnTimKiemPhieu.Name = "btnTimKiemPhieu";
            btnTimKiemPhieu.Size = new Size(75, 23);
            btnTimKiemPhieu.TabIndex = 15;
            btnTimKiemPhieu.Text = "button1";
            btnTimKiemPhieu.UseVisualStyleBackColor = true;
            // 
            // FRMPhieuBanHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 553);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FRMPhieuBanHang";
            Text = "FRMPhieuBanHang";
            Load += FRMPhieuBanHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrDanhSachPhieu).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private DateTimePicker dtpNgayTao;
        private ComboBox cboNhanVienBH;
        private ComboBox cboMaTheLuuDong;
        private RadioButton rdbPaid;
        private RadioButton rdbConfirmation;
        private Label label8;
        private Button btnMoiPhieu;
        private Button btnXoaPhieu;
        private Button btnSuaPhieu;
        private Button btnThemPhieu;
        private Label label4;
        private Label label3;
        private Label label7;
        private TextBox txtMaPhieu;
        private Label label2;
        private TextBox txttimKiemPhieu;
        private DataGridView dgrDanhSachPhieu;
        private GroupBox groupBox2;
        private Button btnTimKiemPhieu;
    }
}