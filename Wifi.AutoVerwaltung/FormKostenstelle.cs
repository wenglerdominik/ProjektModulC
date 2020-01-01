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
    public partial class FormKostenstelle : Form
    {
        public KfzKostenAllg kfzKostenAllg { get; set; } = null;


        public FormKostenstelle()
        {
            InitializeComponent();
            CenterToScreen();
            
        }

        public FormKostenstelle(KfzKostenAllg kfzKostenAllg)
        {
            InitializeComponent();
            CenterToScreen();
            this.kfzKostenAllg = kfzKostenAllg;
            this.comboBoxKategorie.Text = kfzKostenAllg.KostenKategorie;
            this.numericBetrag.Value = Convert.ToDecimal(kfzKostenAllg.KostenWert);
            this.dateKostenDatum.Value = Convert.ToDateTime(kfzKostenAllg.KostenDatum);
            this.numericKilometer.Value = Convert.ToDecimal(kfzKostenAllg.KostenKilom);
            this.comboBoxZahlweise.SelectedItem = kfzKostenAllg.KostenZahlweise;
            this.textBoxBemerkung.Text = kfzKostenAllg.KostenBemerkung;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

            this.kfzKostenAllg = null;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string errorlog = "Bitte folgende Angaben ergänzen:\n\n";

            if (this.kfzKostenAllg == null) this.kfzKostenAllg = new KfzKostenAllg();
            {
                this.kfzKostenAllg.KostenBemerkung = this.textBoxBemerkung.Text;
                this.kfzKostenAllg.KostenDatum = this.dateKostenDatum.Value.ToString("dd.MM.yyyy");

                if (this.comboBoxKategorie.Text == "Service" && (string.IsNullOrEmpty(this.numericKilometer.Text) || this.numericKilometer.Value == 0))
                {
                    errorlog += "Kilometerstand\n";
                    this.numericKilometer.BackColor = Color.LightYellow;

                }
                else
                { this.kfzKostenAllg.KostenKilom = Convert.ToString(this.numericKilometer.Value);
                    this.numericKilometer.BackColor = Color.White;
                }

                if (string.IsNullOrEmpty(this.comboBoxKategorie.Text))
                {
                    errorlog += "Kategorie\n";
                    this.comboBoxKategorie.BackColor = Color.LightYellow;
                }
                else
                {
                    this.kfzKostenAllg.KostenKategorie = this.comboBoxKategorie.Text;
                    this.comboBoxKategorie.BackColor = Color.White;
                }

                if (string.IsNullOrEmpty(this.numericBetrag.Text) || this.numericBetrag.Value == 0)
                {
                    errorlog += "Betrag\n";
                    this.numericBetrag.BackColor = Color.LightYellow;
                }
                else
                {
                    this.kfzKostenAllg.KostenWert = Convert.ToDouble(this.numericBetrag.Value);
                    this.numericBetrag.BackColor = Color.White;
                }

                if (string.IsNullOrEmpty(this.comboBoxZahlweise.Text))
                {
                    errorlog += "Zahlungsweise\n";
                    this.comboBoxZahlweise.BackColor = Color.LightYellow;
                }
                else
                {
                    this.kfzKostenAllg.KostenZahlweise = Convert.ToString(this.comboBoxZahlweise.SelectedItem);
                    this.comboBoxZahlweise.BackColor = Color.White;
                }

                if (errorlog != "Bitte folgende Angaben ergänzen:\n\n")
                {
                    MessageBox.Show(errorlog, "Daten nicht vollständig", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormKostenstelle_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FormKostenSize.Width == 0) Properties.Settings.Default.Upgrade();
            if (Properties.Settings.Default.FormKostenSize.Width == 0 || Properties.Settings.Default.FormKostenSize.Height == 0)
            {
                // first start
                // optional: add default values
            }
            else
            {
                this.WindowState = Properties.Settings.Default.FormKostenState;

                // we don't want a minimized window at startup
                if (this.WindowState == FormWindowState.Minimized) this.WindowState = FormWindowState.Normal;

                this.Location = Properties.Settings.Default.FormKostenLocation;
                this.Size = Properties.Settings.Default.FormKostenSize;


            }
        }

        private void FormKostenstelle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.FormKostenState = this.WindowState;
            if (this.WindowState == FormWindowState.Normal)
            {
                // save location and size if the state is normal
                Properties.Settings.Default.FormKostenLocation = this.Location;
                Properties.Settings.Default.FormKostenSize = this.Size;

            }
            else
            {
                // save the RestoreBounds if the form is minimized or maximized!
                Properties.Settings.Default.FormKostenLocation = this.RestoreBounds.Location;
                Properties.Settings.Default.FormKostenSize = this.RestoreBounds.Size;
            }

            // don't forget to save the settings
            Properties.Settings.Default.Save();
        }
    }
}
