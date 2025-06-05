namespace GUI_PolyCafe
{
    partial class FRMMain
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
            menuStrip1 = new MenuStrip();
            msTK = new ToolStripMenuItem();
            menustripDoiMK = new ToolStripMenuItem();
            menustripTTTK = new ToolStripMenuItem();
            menustripDangXuat = new ToolStripMenuItem();
            menustripThoat = new ToolStripMenuItem();
            msQuanLy = new ToolStripMenuItem();
            menustripTheLuuDong = new ToolStripMenuItem();
            sảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            loạiSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            phiếuBánHàngToolStripMenuItem = new ToolStripMenuItem();
            msThongKe = new ToolStripMenuItem();
            msHoTro = new ToolStripMenuItem();
            msNhanVien = new ToolStripMenuItem();
            pnMain = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            pnMain1 = new Panel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDarkDark;
            menuStrip1.Items.AddRange(new ToolStripItem[] { msTK, msQuanLy, msThongKe, msHoTro, msNhanVien });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1006, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // msTK
            // 
            msTK.DropDownItems.AddRange(new ToolStripItem[] { menustripDoiMK, menustripTTTK, menustripDangXuat, menustripThoat });
            msTK.Image = Properties.Resources.Screenshot_2025_05_13_144544;
            msTK.Name = "msTK";
            msTK.Size = new Size(87, 20);
            msTK.Text = "Tài Khoản";
            // 
            // menustripDoiMK
            // 
            menustripDoiMK.Name = "menustripDoiMK";
            menustripDoiMK.Size = new Size(184, 22);
            menustripDoiMK.Text = "Đổi Mật Khẩu";
            menustripDoiMK.Click += menustripDoiMK_Click;
            // 
            // menustripTTTK
            // 
            menustripTTTK.Name = "menustripTTTK";
            menustripTTTK.Size = new Size(184, 22);
            menustripTTTK.Text = "Thông Tin Tài Khoản";
            menustripTTTK.Click += menustripTTTK_Click;
            // 
            // menustripDangXuat
            // 
            menustripDangXuat.Name = "menustripDangXuat";
            menustripDangXuat.Size = new Size(184, 22);
            menustripDangXuat.Text = "Đăng Xuất";
            // 
            // menustripThoat
            // 
            menustripThoat.Name = "menustripThoat";
            menustripThoat.Size = new Size(184, 22);
            menustripThoat.Text = "Thoát";
            menustripThoat.Click += menustripThoat_Click;
            // 
            // msQuanLy
            // 
            msQuanLy.DropDownItems.AddRange(new ToolStripItem[] { menustripTheLuuDong, sảnPhẩmToolStripMenuItem, loạiSảnPhẩmToolStripMenuItem, phiếuBánHàngToolStripMenuItem });
            msQuanLy.Image = Properties.Resources.Screenshot_2025_05_16_082306;
            msQuanLy.Name = "msQuanLy";
            msQuanLy.Size = new Size(78, 20);
            msQuanLy.Text = "Quản Lý";
            // 
            // menustripTheLuuDong
            // 
            menustripTheLuuDong.Name = "menustripTheLuuDong";
            menustripTheLuuDong.Size = new Size(180, 22);
            menustripTheLuuDong.Text = "Thẻ Lưu Động";
            menustripTheLuuDong.Click += thẻLưuĐộngToolStripMenuItem_Click;
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            sảnPhẩmToolStripMenuItem.Size = new Size(180, 22);
            sảnPhẩmToolStripMenuItem.Text = "Sản Phẩm";
            sảnPhẩmToolStripMenuItem.Click += sảnPhẩmToolStripMenuItem_Click;
            // 
            // loạiSảnPhẩmToolStripMenuItem
            // 
            loạiSảnPhẩmToolStripMenuItem.Name = "loạiSảnPhẩmToolStripMenuItem";
            loạiSảnPhẩmToolStripMenuItem.Size = new Size(180, 22);
            loạiSảnPhẩmToolStripMenuItem.Text = "Loại Sản Phẩm";
            loạiSảnPhẩmToolStripMenuItem.Click += loạiSảnPhẩmToolStripMenuItem_Click;
            // 
            // phiếuBánHàngToolStripMenuItem
            // 
            phiếuBánHàngToolStripMenuItem.Name = "phiếuBánHàngToolStripMenuItem";
            phiếuBánHàngToolStripMenuItem.Size = new Size(180, 22);
            phiếuBánHàngToolStripMenuItem.Text = "Phiếu Bán Hàng";
            phiếuBánHàngToolStripMenuItem.Click += phiếuBánHàngToolStripMenuItem_Click;
            // 
            // msThongKe
            // 
            msThongKe.Image = Properties.Resources.Screenshot_2025_05_13_144544;
            msThongKe.Name = "msThongKe";
            msThongKe.Size = new Size(86, 20);
            msThongKe.Text = "Thống Kê";
            // 
            // msHoTro
            // 
            msHoTro.Image = Properties.Resources.sos;
            msHoTro.Name = "msHoTro";
            msHoTro.Size = new Size(71, 20);
            msHoTro.Text = "Hỗ Trợ";
            msHoTro.Click += msHoTro_Click;
            // 
            // msNhanVien
            // 
            msNhanVien.Image = Properties.Resources.Screenshot_2025_05_22_132550;
            msNhanVien.Name = "msNhanVien";
            msNhanVien.Size = new Size(90, 20);
            msNhanVien.Text = "Nhân Viên";
            msNhanVien.Click += nhânViênToolStripMenuItem_Click_1;
            // 
            // pnMain
            // 
            pnMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnMain.AutoSize = true;
            pnMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnMain.BackgroundImageLayout = ImageLayout.Stretch;
            pnMain.Location = new Point(0, 32);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(0, 0);
            pnMain.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 609);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1006, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(32, 17);
            toolStripStatusLabel1.Text = "Ô YE";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // pnMain1
            // 
            pnMain1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnMain1.Location = new Point(0, 27);
            pnMain1.Name = "pnMain1";
            pnMain1.Size = new Size(1006, 592);
            pnMain1.TabIndex = 3;
            pnMain1.Paint += pnMain1_Paint;
            // 
            // FRMMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 631);
            Controls.Add(pnMain1);
            Controls.Add(statusStrip1);
            Controls.Add(pnMain);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(1022, 670);
            MinimumSize = new Size(1022, 670);
            Name = "FRMMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRMMain";
            Load += FRMMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem msTK;
        private ToolStripMenuItem msQuanLy;
        private ToolStripMenuItem msThongKe;
        private ToolStripMenuItem msHoTro;
        private ToolStripMenuItem menustripDoiMK;
        private ToolStripMenuItem menustripTTTK;
        private ToolStripMenuItem menustripDangXuat;
        private ToolStripMenuItem menustripThoat;
        private Panel pnMain;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem menustripTheLuuDong;
        private ToolStripMenuItem msNhanVien;
        private Panel pnMain1;
        private ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem loạiSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem phiếuBánHàngToolStripMenuItem;
    }
}