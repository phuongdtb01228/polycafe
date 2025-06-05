namespace GUI_PolyCafe
{
    partial class FRMChiTietPhieu
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
            lbNgayLap = new Label();
            label4 = new Label();
            lbMaPhieu = new Label();
            label3 = new Label();
            lbChuSoHuu = new Label();
            label2 = new Label();
            label1 = new Label();
            dgrChiTiet = new DataGridView();
            dgrSanPham = new DataGridView();
            btnXoaChiTiet = new Button();
            btnThemChiTiet = new Button();
            groupBox1 = new GroupBox();
            label9 = new Label();
            txtPhanTram = new TextBox();
            txtThanhTien = new TextBox();
            txtGiamGia = new TextBox();
            txtDichVu = new TextBox();
            txtTong = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgrChiTiet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgrSanPham).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbNgayLap
            // 
            lbNgayLap.AutoSize = true;
            lbNgayLap.Font = new Font("Segoe UI", 11F);
            lbNgayLap.ForeColor = Color.Maroon;
            lbNgayLap.Location = new Point(838, 66);
            lbNgayLap.Name = "lbNgayLap";
            lbNgayLap.Size = new Size(70, 20);
            lbNgayLap.TabIndex = 5;
            lbNgayLap.Text = "Mã Phiếu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(748, 66);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 6;
            label4.Text = "Ngày Lập:";
            // 
            // lbMaPhieu
            // 
            lbMaPhieu.AutoSize = true;
            lbMaPhieu.Font = new Font("Segoe UI", 11F);
            lbMaPhieu.ForeColor = Color.Maroon;
            lbMaPhieu.Location = new Point(516, 66);
            lbMaPhieu.Name = "lbMaPhieu";
            lbMaPhieu.Size = new Size(70, 20);
            lbMaPhieu.TabIndex = 7;
            lbMaPhieu.Text = "Mã Phiếu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(426, 66);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 8;
            label3.Text = "Mã Phiếu:";
            // 
            // lbChuSoHuu
            // 
            lbChuSoHuu.AutoSize = true;
            lbChuSoHuu.Font = new Font("Segoe UI", 11F);
            lbChuSoHuu.ForeColor = Color.Maroon;
            lbChuSoHuu.Location = new Point(162, 66);
            lbChuSoHuu.Name = "lbChuSoHuu";
            lbChuSoHuu.Size = new Size(70, 20);
            lbChuSoHuu.TabIndex = 9;
            lbChuSoHuu.Text = "Mã Phiếu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(55, 66);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 10;
            label2.Text = "Chủ Sở Hữu:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(332, 9);
            label1.Name = "label1";
            label1.Size = new Size(365, 37);
            label1.TabIndex = 4;
            label1.Text = "CHI TIẾT PHIẾU BÁN HÀNG";
            // 
            // dgrChiTiet
            // 
            dgrChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrChiTiet.Location = new Point(12, 106);
            dgrChiTiet.Margin = new Padding(3, 2, 3, 2);
            dgrChiTiet.Name = "dgrChiTiet";
            dgrChiTiet.RowHeadersWidth = 51;
            dgrChiTiet.Size = new Size(457, 299);
            dgrChiTiet.TabIndex = 11;
            dgrChiTiet.CellEndEdit += dgrChiTiet_CellEndEdit;
            // 
            // dgrSanPham
            // 
            dgrSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrSanPham.Location = new Point(552, 104);
            dgrSanPham.Margin = new Padding(3, 2, 3, 2);
            dgrSanPham.Name = "dgrSanPham";
            dgrSanPham.ReadOnly = true;
            dgrSanPham.RowHeadersWidth = 51;
            dgrSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgrSanPham.Size = new Size(426, 444);
            dgrSanPham.TabIndex = 12;
            dgrSanPham.CellDoubleClick += dgrSanPham_CellDoubleClick;
            // 
            // btnXoaChiTiet
            // 
            btnXoaChiTiet.Location = new Point(483, 270);
            btnXoaChiTiet.Margin = new Padding(3, 2, 3, 2);
            btnXoaChiTiet.Name = "btnXoaChiTiet";
            btnXoaChiTiet.Size = new Size(53, 22);
            btnXoaChiTiet.TabIndex = 13;
            btnXoaChiTiet.Text = ">>";
            btnXoaChiTiet.UseVisualStyleBackColor = true;
            btnXoaChiTiet.Click += btnXoaChiTiet_Click;
            // 
            // btnThemChiTiet
            // 
            btnThemChiTiet.Location = new Point(484, 197);
            btnThemChiTiet.Margin = new Padding(3, 2, 3, 2);
            btnThemChiTiet.Name = "btnThemChiTiet";
            btnThemChiTiet.Size = new Size(53, 22);
            btnThemChiTiet.TabIndex = 14;
            btnThemChiTiet.Text = "<<";
            btnThemChiTiet.UseVisualStyleBackColor = true;
            btnThemChiTiet.Click += btnThemChiTiet_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtPhanTram);
            groupBox1.Controls.Add(txtThanhTien);
            groupBox1.Controls.Add(txtGiamGia);
            groupBox1.Controls.Add(txtDichVu);
            groupBox1.Controls.Add(txtTong);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(12, 417);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(457, 131);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Thanh Toán";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(138, 62);
            label9.Name = "label9";
            label9.Size = new Size(17, 15);
            label9.TabIndex = 3;
            label9.Text = "%";
            // 
            // txtPhanTram
            // 
            txtPhanTram.Location = new Point(86, 60);
            txtPhanTram.Margin = new Padding(3, 2, 3, 2);
            txtPhanTram.Name = "txtPhanTram";
            txtPhanTram.Size = new Size(46, 23);
            txtPhanTram.TabIndex = 2;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(86, 95);
            txtThanhTien.Margin = new Padding(3, 2, 3, 2);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(354, 23);
            txtThanhTien.TabIndex = 1;
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(180, 60);
            txtGiamGia.Margin = new Padding(3, 2, 3, 2);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.ReadOnly = true;
            txtGiamGia.Size = new Size(260, 23);
            txtGiamGia.TabIndex = 1;
            // 
            // txtDichVu
            // 
            txtDichVu.Location = new Point(313, 24);
            txtDichVu.Margin = new Padding(3, 2, 3, 2);
            txtDichVu.Name = "txtDichVu";
            txtDichVu.ReadOnly = true;
            txtDichVu.Size = new Size(127, 23);
            txtDichVu.TabIndex = 1;
            // 
            // txtTong
            // 
            txtTong.Location = new Point(86, 22);
            txtTong.Margin = new Padding(3, 2, 3, 2);
            txtTong.Name = "txtTong";
            txtTong.ReadOnly = true;
            txtTong.Size = new Size(161, 23);
            txtTong.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 99);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 0;
            label8.Text = "Thành Tiền:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 62);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 0;
            label7.Text = "Giảm Giá";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(253, 26);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 0;
            label6.Text = "Dịch Vụ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 23);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 0;
            label5.Text = "Tổng :";
            // 
            // FRMChiTietPhieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 553);
            Controls.Add(groupBox1);
            Controls.Add(btnXoaChiTiet);
            Controls.Add(btnThemChiTiet);
            Controls.Add(dgrSanPham);
            Controls.Add(dgrChiTiet);
            Controls.Add(lbNgayLap);
            Controls.Add(label4);
            Controls.Add(lbMaPhieu);
            Controls.Add(label3);
            Controls.Add(lbChuSoHuu);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FRMChiTietPhieu";
            Text = "FRMChiTietPhieu";
            Load += FRMChiTietPhieu_Load;
            ((System.ComponentModel.ISupportInitialize)dgrChiTiet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgrSanPham).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNgayLap;
        private Label label4;
        private Label lbMaPhieu;
        private Label label3;
        private Label lbChuSoHuu;
        private Label label2;
        private Label label1;
        private DataGridView dgrChiTiet;
        private DataGridView dgrSanPham;
        private Button btnXoaChiTiet;
        private Button btnThemChiTiet;
        private GroupBox groupBox1;
        private Label label9;
        private TextBox txtPhanTram;
        private TextBox txtThanhTien;
        private TextBox txtGiamGia;
        private TextBox txtDichVu;
        private TextBox txtTong;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
    }
}