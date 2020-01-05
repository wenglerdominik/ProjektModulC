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
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
            CenterToScreen();
        }

		public string Username
		{
			get { return this.textBoxBenutzer.Text; }
		}

		public string Password
		{
			get { return this.textBoxPasswort.Text; }
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

        private void FormLogin_Load(object sender, EventArgs e)
        {
                // we don't want a minimized window at startup
                if (this.WindowState == FormWindowState.Minimized) this.WindowState = FormWindowState.Normal;

                this.Location = Properties.Settings.Default.FormLoginLocation;
                
            }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.FormLoginLocation = this.Location;
        }
    }
}
