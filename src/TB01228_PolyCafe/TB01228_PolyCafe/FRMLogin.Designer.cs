namespace TB01228_PolyCafe
{
    partial class FRMLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            rdbHienThiMatKhau = new RadioButton();
            txtpassword = new TextBox();
            label2 = new Label();
            txtusername = new TextBox();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = GUI_PolyCafe.Properties.Resources.Screenshot_2025_05_16_082306;
            pictureBox1.Location = new Point(0, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(547, 549);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GrayText;
            button2.Location = new Point(592, 434);
            button2.Name = "button2";
            button2.Size = new Size(332, 75);
            button2.TabIndex = 14;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GrayText;
            button1.Location = new Point(592, 308);
            button1.Name = "button1";
            button1.Size = new Size(332, 83);
            button1.TabIndex = 13;
            button1.Text = "Đăng Nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // rdbHienThiMatKhau
            // 
            rdbHienThiMatKhau.AutoSize = true;
            rdbHienThiMatKhau.Location = new Point(812, 234);
            rdbHienThiMatKhau.Name = "rdbHienThiMatKhau";
            rdbHienThiMatKhau.Size = new Size(124, 19);
            rdbHienThiMatKhau.TabIndex = 12;
            rdbHienThiMatKhau.TabStop = true;
            rdbHienThiMatKhau.Text = "Hiển Thị Mật Khẩu";
            rdbHienThiMatKhau.UseVisualStyleBackColor = true;
            rdbHienThiMatKhau.CheckedChanged += rdbHienThiMatKhau_CheckedChanged;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = SystemColors.ScrollBar;
            txtpassword.Location = new Point(724, 193);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(212, 23);
            txtpassword.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(595, 193);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 10;
            label2.Text = "Mật Khẩu";
            // 
            // txtusername
            // 
            txtusername.BackColor = SystemColors.ScrollBar;
            txtusername.Location = new Point(724, 119);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(212, 23);
            txtusername.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(595, 119);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 8;
            label1.Text = "Đăng Nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22F);
            label3.Location = new Point(681, 31);
            label3.Name = "label3";
            label3.Size = new Size(169, 41);
            label3.TabIndex = 15;
            label3.Text = "Đăng Nhập";
            // 
            // FRMLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(990, 553);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(rdbHienThiMatKhau);
            Controls.Add(txtpassword);
            Controls.Add(label2);
            Controls.Add(txtusername);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(1006, 592);
            MinimumSize = new Size(1006, 592);
            Name = "FRMLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FRMLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button2;
        private Button button1;
        private RadioButton rdbHienThiMatKhau;
        private TextBox txtpassword;
        private Label label2;
        private TextBox txtusername;
        private Label label1;
        private Label label3;
    }
}
