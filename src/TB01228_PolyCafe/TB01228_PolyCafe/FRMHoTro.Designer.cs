namespace GUI_PolyCafe
{
    partial class FRMHoTro
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(200, 9);
            label1.Name = "label1";
            label1.Size = new Size(486, 54);
            label1.TabIndex = 0;
            label1.Text = "Thông Tin Liên Hệ Hỗ Trợ ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25F);
            label2.Location = new Point(96, 113);
            label2.Name = "label2";
            label2.Size = new Size(227, 46);
            label2.TabIndex = 1;
            label2.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 25F);
            label3.Location = new Point(380, 113);
            label3.Name = "label3";
            label3.Size = new Size(200, 46);
            label3.TabIndex = 2;
            label3.Text = "0326577609";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 25F);
            label4.Location = new Point(285, 233);
            label4.Name = "label4";
            label4.Size = new Size(465, 46);
            label4.TabIndex = 4;
            label4.Text = "phuongdtb01228@gmail.com";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 25F);
            label5.Location = new Point(96, 233);
            label5.Name = "label5";
            label5.Size = new Size(99, 46);
            label5.TabIndex = 3;
            label5.Text = "Email";
            // 
            // FRMHoTro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 553);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FRMHoTro";
            Text = "FRMHoTro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}