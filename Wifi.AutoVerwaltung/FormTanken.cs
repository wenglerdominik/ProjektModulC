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
    public partial class FormTanken : Form
    {

        public KfzKostenTank KfzKostenTank { get; set; } = null;

        public FormTanken()
        {
            InitializeComponent();
            CenterToScreen();
        }
        public FormTanken(KfzKostenTank kfzKostenTank)
        {
            InitializeComponent();
            CenterToScreen();
            this.KfzKostenTank = kfzKostenTank;
            this.numericBetrag.Value = Convert.ToDecimal(kfzKostenTank.Tankbetrag);
            this.dateTankDatum.Value =Convert.ToDateTime(kfzKostenTank.TankDatum);
            this.numericMenge.Value = Convert.ToDecimal(kfzKostenTank.TankMenge);
            this.numericKilometer.Value = Convert.ToDecimal(kfzKostenTank.TankKilometer);

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (KfzKostenTank == null) this.KfzKostenTank = new KfzKostenTank();

            KfzKostenTank.TankDatum = this.dateTankDatum.Value.ToString("dd.MM.yyyy");

            string errorlog = "Bitte folgende Angaben ergänzen:\n\n";
                       
            if (string.IsNullOrEmpty(this.numericMenge.Text) || this.numericMenge.Value == 0)
            {
                errorlog += "getankte Liter\n";
                this.numericMenge.BackColor = Color.LightYellow;

            }
            else
            {
                this.KfzKostenTank.TankMenge = Convert.ToInt16(this.numericMenge.Value);
                this.numericMenge.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(this.numericBetrag.Text) || this.numericBetrag.Value == 0)
            {
                errorlog += "Tankbetrag\n";
                this.numericBetrag.BackColor = Color.LightYellow;
            }
            else
            {
                this.KfzKostenTank.Tankbetrag = Convert.ToDouble(this.numericBetrag.Value);
                this.numericBetrag.BackColor = Color.White;
            }


            if (string.IsNullOrEmpty(this.numericKilometer.Text) || this.numericKilometer.Value == 0)
            {
                errorlog += "Kilometerstand\n";
                this.numericKilometer.BackColor = Color.LightYellow;
            }
            else
            {
                this.KfzKostenTank.TankKilometer = Convert.ToInt32(this.numericKilometer.Value);
                this.numericKilometer.BackColor = Color.White;
            }

            if (errorlog != "Bitte folgende Angaben ergänzen:\n\n")
            {
                MessageBox.Show(errorlog, "Daten nicht vollständig", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }



        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.KfzKostenTank = null;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
