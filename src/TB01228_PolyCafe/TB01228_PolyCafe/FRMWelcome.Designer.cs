namespace GUI_PolyCafe
{
    partial class FRMWelcome
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
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2025_05_13_144544;
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(921, 405);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(1, 412);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(921, 43);
            progressBar1.TabIndex = 1;
            progressBar1.Click += progressBar1_Click;
            // 
            // FRMWelcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 467);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Name = "FRMWelcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRMWelcome";
            Load += FRMWelcome_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
    }
}