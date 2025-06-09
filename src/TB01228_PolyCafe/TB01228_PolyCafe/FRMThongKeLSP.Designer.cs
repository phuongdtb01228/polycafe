namespace GUI_PolyCafe
{
    partial class FRMThongKeLSP
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
            cbLSP = new ComboBox();
            label3 = new Label();
            dtpTuNgay = new DateTimePicker();
            dtpDenNgay = new DateTimePicker();
            label4 = new Label();
            btnThongKe = new Button();
            dgvThongKe = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(235, 9);
            label1.Name = "label1";
            label1.Size = new Size(559, 54);
            label1.TabIndex = 0;
            label1.Text = "Thống Kê Theo Loại Sản Phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Loại Sản Phẩm";
            // 
            // cbLSP
            // 
            cbLSP.FormattingEnabled = true;
            cbLSP.Location = new Point(103, 80);
            cbLSP.Name = "cbLSP";
            cbLSP.Size = new Size(121, 23);
            cbLSP.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 83);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 3;
            label3.Text = "Từ Ngày";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Location = new Point(339, 80);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(216, 23);
            dtpTuNgay.TabIndex = 4;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Location = new Point(645, 80);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(216, 23);
            dtpDenNgay.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(572, 86);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 5;
            label4.Text = "Đến Ngày";
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(870, 66);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(108, 49);
            btnThongKe.TabIndex = 7;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // dgvThongKe
            // 
            dgvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongKe.Location = new Point(12, 121);
            dgvThongKe.Name = "dgvThongKe";
            dgvThongKe.Size = new Size(966, 420);
            dgvThongKe.TabIndex = 8;
            // 
            // FRMThongKeLSP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 553);
            Controls.Add(dgvThongKe);
            Controls.Add(btnThongKe);
            Controls.Add(dtpDenNgay);
            Controls.Add(label4);
            Controls.Add(dtpTuNgay);
            Controls.Add(label3);
            Controls.Add(cbLSP);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FRMThongKeLSP";
            Text = "FRMThongKeLSP";
            Load += FRMThongKeLSP_Load;
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbLSP;
        private Label label3;
        private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpDenNgay;
        private Label label4;
        private Button btnThongKe;
        private DataGridView dgvThongKe;
    }
}