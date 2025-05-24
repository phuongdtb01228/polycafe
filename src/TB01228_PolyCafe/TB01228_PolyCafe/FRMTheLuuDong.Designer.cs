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
            label4 = new Label();
            btnXoa = new Button();
            btnSua = new Button();
            btnLamMoi = new Button();
            cbHoatDong = new CheckBox();
            cbKhongHoatDong = new CheckBox();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
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
            // 
            // dgvTheLuuDong
            // 
            dgvTheLuuDong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTheLuuDong.Location = new Point(379, 104);
            dgvTheLuuDong.Name = "dgvTheLuuDong";
            dgvTheLuuDong.Size = new Size(402, 343);
            dgvTheLuuDong.TabIndex = 3;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 235);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 7;
            label4.Text = "Trạng Thái";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(208, 325);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa ";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(54, 405);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(208, 405);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(75, 23);
            btnLamMoi.TabIndex = 11;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
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
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(706, 63);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 14;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(546, 63);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(145, 23);
            txtTimKiem.TabIndex = 15;
            // 
            // FRMTheLuuDong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 450);
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
        private Label label4;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLamMoi;
        private CheckBox cbHoatDong;
        private CheckBox cbKhongHoatDong;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
    }
}