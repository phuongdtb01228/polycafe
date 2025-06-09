namespace GUI_PolyCafe
{
    partial class FRMThongTinTaiKhoan
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
            label2 = new Label();
            txtMaNV = new TextBox();
            txtHoTen = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtTrangThai = new TextBox();
            label5 = new Label();
            txtVaiTro = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(201, 9);
            label1.Name = "label1";
            label1.Size = new Size(383, 54);
            label1.TabIndex = 0;
            label1.Text = "Thông Tin Tài Khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 106);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã Nhân Viên";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(324, 106);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(320, 23);
            txtMaNV.TabIndex = 2;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(324, 156);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(320, 23);
            txtHoTen.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(157, 156);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 3;
            label3.Text = "Họ Tên";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(324, 213);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(320, 23);
            txtEmail.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(157, 213);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 5;
            label4.Text = "Email";
            // 
            // txtTrangThai
            // 
            txtTrangThai.Location = new Point(324, 322);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.Size = new Size(320, 23);
            txtTrangThai.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(157, 322);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 9;
            label5.Text = "Trạng Thái";
            // 
            // txtVaiTro
            // 
            txtVaiTro.Location = new Point(324, 265);
            txtVaiTro.Name = "txtVaiTro";
            txtVaiTro.Size = new Size(320, 23);
            txtVaiTro.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(157, 265);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 7;
            label6.Text = "Vai Trò";
            // 
            // FRMThongTinTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 553);
            Controls.Add(txtTrangThai);
            Controls.Add(label5);
            Controls.Add(txtVaiTro);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtHoTen);
            Controls.Add(label3);
            Controls.Add(txtMaNV);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FRMThongTinTaiKhoan";
            Text = "FRMThongTinTaiKhoan";
            Load += FRMThongTinTaiKhoan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMaNV;
        private TextBox txtHoTen;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtTrangThai;
        private Label label5;
        private TextBox txtVaiTro;
        private Label label6;
    }
}