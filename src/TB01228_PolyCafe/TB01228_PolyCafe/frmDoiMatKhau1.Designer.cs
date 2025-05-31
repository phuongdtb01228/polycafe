namespace GUI_PolyCafe
{
    partial class frmDoiMatKhau1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau1));
            pictureBox1 = new PictureBox();
            btnThoat = new Button();
            btnDoiMK = new Button();
            txtXacNhanMK = new TextBox();
            txtXacNhanMatKhau = new Label();
            txtMatKhauMoi = new TextBox();
            label3 = new Label();
            txtMatKhauCu = new TextBox();
            label4 = new Label();
            txtTenNV = new TextBox();
            label2 = new Label();
            txtMaNV = new TextBox();
            label1 = new Label();
            cbMKMOI = new CheckBox();
            cbMKCU = new CheckBox();
            cbXACNHANMK = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(987, 552);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Transparent;
            btnThoat.BackgroundImage = Properties.Resources.Screenshot_2025_05_22_132550;
            btnThoat.ForeColor = SystemColors.ButtonHighlight;
            btnThoat.Location = new Point(457, 319);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(201, 82);
            btnThoat.TabIndex = 26;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDoiMK
            // 
            btnDoiMK.BackColor = SystemColors.ActiveCaptionText;
            btnDoiMK.BackgroundImage = Properties.Resources.Screenshot_2025_05_22_132550;
            btnDoiMK.ForeColor = SystemColors.ButtonHighlight;
            btnDoiMK.Location = new Point(158, 319);
            btnDoiMK.Name = "btnDoiMK";
            btnDoiMK.Size = new Size(199, 82);
            btnDoiMK.TabIndex = 25;
            btnDoiMK.Text = "Đổi Mật Khẩu";
            btnDoiMK.UseVisualStyleBackColor = false;
            btnDoiMK.Click += btnDoiMK_Click_1;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new Point(158, 251);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.PasswordChar = '*';
            txtXacNhanMK.Size = new Size(230, 23);
            txtXacNhanMK.TabIndex = 24;
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.AutoSize = true;
            txtXacNhanMatKhau.BackColor = Color.FromArgb(64, 64, 64);
            txtXacNhanMatKhau.ForeColor = SystemColors.ButtonHighlight;
            txtXacNhanMatKhau.Location = new Point(27, 259);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.Size = new Size(112, 15);
            txtXacNhanMatKhau.TabIndex = 23;
            txtXacNhanMatKhau.Text = "Xác Nhận Mật Khẩu";
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Location = new Point(161, 175);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.PasswordChar = '*';
            txtMatKhauMoi.Size = new Size(227, 23);
            txtMatKhauMoi.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(64, 64, 64);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(57, 175);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 21;
            label3.Text = "Mật Khẩu Mới";
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.BackColor = SystemColors.Info;
            txtMatKhauCu.Location = new Point(161, 109);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.PasswordChar = '*';
            txtMatKhauCu.Size = new Size(227, 23);
            txtMatKhauCu.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(64, 64, 64);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(63, 109);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 19;
            label4.Text = "Mật Khẩu Cũ";
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(738, 101);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.ReadOnly = true;
            txtTenNV.Size = new Size(188, 23);
            txtTenNV.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(64, 64, 64);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(605, 175);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 17;
            label2.Text = "Tên Nhân Viên";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(738, 167);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.ReadOnly = true;
            txtMaNV.Size = new Size(188, 23);
            txtMaNV.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 64, 64);
            label1.ForeColor = Color.White;
            label1.Location = new Point(607, 109);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 15;
            label1.Text = "Mã Nhân Viên";
            // 
            // cbMKMOI
            // 
            cbMKMOI.AutoSize = true;
            cbMKMOI.BackgroundImage = Properties.Resources.Screenshot_2025_05_22_132550;
            cbMKMOI.ForeColor = SystemColors.ButtonHighlight;
            cbMKMOI.Location = new Point(263, 213);
            cbMKMOI.Name = "cbMKMOI";
            cbMKMOI.Size = new Size(125, 19);
            cbMKMOI.TabIndex = 27;
            cbMKMOI.Text = "Hiển Thị Mật Khẩu";
            cbMKMOI.UseVisualStyleBackColor = true;
            cbMKMOI.CheckedChanged += cbMKMOI_CheckedChanged;
            // 
            // cbMKCU
            // 
            cbMKCU.AutoSize = true;
            cbMKCU.BackColor = SystemColors.ButtonHighlight;
            cbMKCU.BackgroundImage = Properties.Resources.Screenshot_2025_05_22_132550;
            cbMKCU.ForeColor = Color.White;
            cbMKCU.Location = new Point(263, 138);
            cbMKCU.Name = "cbMKCU";
            cbMKCU.Size = new Size(125, 19);
            cbMKCU.TabIndex = 28;
            cbMKCU.Text = "Hiển Thị Mật Khẩu";
            cbMKCU.UseVisualStyleBackColor = false;
            cbMKCU.CheckedChanged += cbMKCU_CheckedChanged;
            // 
            // cbXACNHANMK
            // 
            cbXACNHANMK.AutoSize = true;
            cbXACNHANMK.BackColor = Color.FromArgb(64, 64, 64);
            cbXACNHANMK.BackgroundImage = Properties.Resources.Screenshot_2025_05_22_132550;
            cbXACNHANMK.ForeColor = SystemColors.ButtonHighlight;
            cbXACNHANMK.Location = new Point(260, 280);
            cbXACNHANMK.Name = "cbXACNHANMK";
            cbXACNHANMK.Size = new Size(125, 19);
            cbXACNHANMK.TabIndex = 29;
            cbXACNHANMK.Text = "Hiển Thị Mật Khẩu";
            cbXACNHANMK.UseVisualStyleBackColor = false;
            cbXACNHANMK.CheckedChanged += CBXACNHANMK_CheckedChanged;
            // 
            // frmDoiMatKhau1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(990, 553);
            Controls.Add(cbXACNHANMK);
            Controls.Add(cbMKCU);
            Controls.Add(cbMKMOI);
            Controls.Add(btnThoat);
            Controls.Add(btnDoiMK);
            Controls.Add(txtXacNhanMK);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(label3);
            Controls.Add(txtMatKhauCu);
            Controls.Add(label4);
            Controls.Add(txtTenNV);
            Controls.Add(label2);
            Controls.Add(txtMaNV);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(1006, 592);
            MinimumSize = new Size(1006, 592);
            Name = "frmDoiMatKhau1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDoiMatKhau1";
            Load += frmDoiMatKhau1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnThoat;
        private Button btnDoiMK;
        private TextBox txtXacNhanMK;
        private Label txtXacNhanMatKhau;
        private TextBox txtMatKhauMoi;
        private Label label3;
        private TextBox txtMatKhauCu;
        private Label label4;
        private TextBox txtTenNV;
        private Label label2;
        private TextBox txtMaNV;
        private Label label1;
        private CheckBox cbMKMOI;
        private CheckBox cbMKCU;
        private CheckBox cbXACNHANMK;
    }
}