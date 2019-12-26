using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wifi.Auto.Data;

namespace Wifi.AutoVerwaltung
{
    public partial class UserControlAuto : UserControl
    {
        public KfzDetails FahrzeugInfo { get; set; } = null;
        public UserControlAuto()
        {
            InitializeComponent();
        }

        public UserControlAuto(KfzDetails fahrzeugInfo)
        {
            InitializeComponent();
            this.FahrzeugInfo = fahrzeugInfo;
            this.labelMarke.Text = this.FahrzeugInfo.Marke;
            this.labelModell.Text = this.FahrzeugInfo.Modell;
            this.labelFarbe.Text = this.FahrzeugInfo.Farbe;
            this.labelErstzullasung.Text = Convert.ToString(this.FahrzeugInfo.Zulassung);
            this.labelGesamtkosten.Text = Convert.ToString(this.FahrzeugInfo.Gesamtkosten);
            
        }

        private void labelMarke_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FormEdit formEdit = new FormEdit(this.FahrzeugInfo);
            if(formEdit.ShowDialog() == DialogResult.OK)
            {
                this.labelMarke.Text = this.FahrzeugInfo.Marke;
                this.labelModell.Text = this.FahrzeugInfo.Modell;
                this.labelFarbe.Text = this.FahrzeugInfo.Farbe;
                this.labelErstzullasung.Text = Convert.ToString(this.FahrzeugInfo.Zulassung);
                
            }
            


        }
    }
}
