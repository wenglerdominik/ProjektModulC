using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wifi.AutoVerwaltung
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load_1(object sender, EventArgs e)
        {
            timerSplashScreen.Enabled = true;
            timerSplashScreen.Start();
            timerSplashScreen.Interval = 3000;
        }

        private void timerSplashScreen_Tick(object sender, EventArgs e)
        {
           
                timerSplashScreen.Stop();
                this.Close();
            
        }

    }
}
