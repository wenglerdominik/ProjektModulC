using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wifi.Auto.Data;

namespace Wifi.AutoVerwaltung
{
    public partial class FormTank : Form
    {
        KfzDetails kfzDetails = null;
        public KfzKosten kfzKostenTank { get; set; } = null;

        public FormTank()
        {
            InitializeComponent();
        }
        public FormTank(KfzDetails kfz)
        {
            InitializeComponent();
            this.kfzDetails = kfz;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (kfzKostenTank == null) this.kfzKostenTank = new KfzKosten();
            kfzKostenTank.Tankbetrag = Convert.ToDouble(this.numericBetrag.Value);
            kfzKostenTank.TankDatum = this.dateTankDatum.Value;
            kfzKostenTank.TankKilometer = Convert.ToInt32(this.numericKilometer.Value);
            kfzKostenTank.TankMenge = Convert.ToInt32(this.numericMenge.Value);

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
