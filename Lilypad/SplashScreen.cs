using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Lilypad
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            Random rng = new Random();
            Thread sleep = new Thread(() => Thread.Sleep(2000 + rng.Next(0, 500))); // so it looks like it's doing something
            sleep.Start();
            sleep.Join();

            Form MainLauncher = new MainLauncherForm();
            MainLauncher.Show();
            Hide();
        }
    }
}
