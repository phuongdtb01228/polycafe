namespace GUI_PolyCafe
{
    partial class FRMThongKeTheoNV
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
            dgvThongKe = new DataGridView();
            btnThongKe = new Button();
            dtpDenNgay = new DateTimePicker();
            label4 = new Label();
            dtpTuNgay = new DateTimePicker();
            label3 = new Label();
            cbNV = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).BeginInit();
            SuspendLayout();
            // 
            // dgvThongKe
            // 
            dgvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongKe.Location = new Point(8, 121);
            dgvThongKe.Name = "dgvThongKe";
            dgvThongKe.Size = new Size(966, 420);
            dgvThongKe.TabIndex = 17;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(866, 57);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(108, 49);
            btnThongKe.TabIndex = 16;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Location = new Point(629, 74);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(216, 23);
            dtpDenNgay.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(544, 79);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 14;
            label4.Text = "Đến Ngày";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Location = new Point(307, 75);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(216, 23);
            dtpTuNgay.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 81);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 12;
            label3.Text = "Từ Ngày";
            // 
            // cbNV
            // 
            cbNV.FormattingEnabled = true;
            cbNV.Location = new Point(88, 74);
            cbNV.Name = "cbNV";
            cbNV.Size = new Size(144, 23);
            cbNV.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-83, 33);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 10;
            label2.Text = "Loại Sản Phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(146, 0);
            label1.Name = "label1";
            label1.Size = new Size(488, 54);
            label1.TabIndex = 9;
            label1.Text = "Thống Kê Theo Nhân Viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 79);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 18;
            label5.Text = "Nhân Viên";
            // 
            // FRMThongKeTheoNV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 553);
            Controls.Add(label5);
            Controls.Add(dgvThongKe);
            Controls.Add(btnThongKe);
            Controls.Add(dtpDenNgay);
            Controls.Add(label4);
            Controls.Add(dtpTuNgay);
            Controls.Add(label3);
            Controls.Add(cbNV);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FRMThongKeTheoNV";
            Text = "FRMThongKeTheoNV";
            Load += FRMThongKeTheoNV_Load;
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvThongKe;
        private Button btnThongKe;
        private DateTimePicker dtpDenNgay;
        private Label label4;
        private DateTimePicker dtpTuNgay;
        private Label label3;
        private ComboBox cbNV;
        private Label label2;
        private Label label1;
        private Label label5;
    }
}