using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TB01228_PolyCafe;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_PolyCafe
{
    public partial class FRMWelcome : Form
    {
        public FRMWelcome()
        {
            InitializeComponent();
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;
            Task.Delay(3000).ContinueWith(t =>
            {
                if (this.IsHandleCreated && !this.IsDisposed)
                {
                    this.Invoke(new Action(() =>
                    {
                        FRMLogin login = new FRMLogin();
                        login.Show();

                        this.Hide();
                    }));
                }
            });
        }



        private void FRMWelcome_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
