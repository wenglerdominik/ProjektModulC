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
	}
}
