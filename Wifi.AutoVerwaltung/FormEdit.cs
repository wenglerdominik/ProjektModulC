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
using Wifi.Auto.Data;
using System.IO;


namespace Wifi.AutoVerwaltung
{
    public partial class FormEdit : Form
    {
        public KfzData KfzData { get; set; } = new KfzData();

        public FormEdit()
        {
            InitializeComponent();
            CenterToScreen();
            this.pictureBoxCar.AllowDrop = true;
        }

        public FormEdit(KfzData kfzData)
        {
            InitializeComponent();
            CenterToScreen();
            this.pictureBoxCar.AllowDrop = true;
            this.KfzData = kfzData;
            this.textBoxMarke.Text = kfzData.Marke;
            this.textBoxModell.Text = kfzData.Modell;
            this.dateTimePicker1.Value = Convert.ToDateTime(kfzData.Zulassung);
            this.comboBoxFarbe.SelectedItem = kfzData.Farbe;
            this.numericUpDownLeistung.Text = kfzData.Leistung;
            this.numericUpDownWartung.Text = kfzData.Wartungsintervall;
            this.textBoxKennz.Text = kfzData.Kennzeichen;
            if (this.KfzData.ImagePath != null)
            {
                try
                {
                    string val = kfzData.ImagePath;
                    byte[] bytes = Convert.FromBase64String(val);
                    MemoryStream mem = new MemoryStream(bytes);
                    Bitmap bmp2 = new Bitmap(mem);

                    this.pictureBoxCar.Image = bmp2;
                    this.pictureBoxCar.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Bild konnte nicht geöffnet werden. \nPfad prüfen und Bild neu hinzufügen\n" + kfzData.ImagePath);
                    kfzData.ImagePath = null;
                }
            }


            if (this.KfzData.Fahrzeugkosten != null)
                foreach (KfzData itemKfzData in this.KfzData.Fahrzeugkosten)
                {
                    if (itemKfzData is KfzKostenAllg) addListViewItemKostenAllg((KfzKostenAllg)itemKfzData);
                    if (itemKfzData is KfzKostenTank) addListViewItemKostenTank((KfzKostenTank)itemKfzData);
                }
        }


        private void buttonOk_Click(object sender, EventArgs e)
        {
            string errorlog = "Bitte folgende Felder ausfüllen:\n";
            if (this.KfzData != null)
            {
                try
                {
                    foreach (Control control in this.tabPageAllgemein.Controls)
                    {
                        if (control is TextBox)
                        {
                            if (string.IsNullOrEmpty(control.Text) && control.Name != "textBoxKennz")
                            {
                                control.BackColor = Color.LightYellow;
                            }
                            else control.BackColor = Color.White;
                        }
                        if (control is NumericUpDown)
                        {
                            if (string.IsNullOrEmpty(numericUpDownLeistung.Text) || numericUpDownLeistung.Value == 0) control.BackColor = Color.LightYellow;
                            else numericUpDownLeistung.BackColor = Color.White;
                        }
                        if (control is MaskedTextBox)
                        {
                            if (string.IsNullOrEmpty(control.Text)) control.BackColor = Color.LightYellow;
                            else control.BackColor = Color.White;
                        }
                        if (control is ComboBox)
                        {
                            // DrawLinePoint();
                            if (comboBoxFarbe.SelectedItem == null) control.BackColor = Color.LightYellow;
                            else control.BackColor = Color.White;
                        }

                    }

                    if (string.IsNullOrEmpty(this.textBoxMarke.Text)) errorlog += "\nMarke";
                    if (string.IsNullOrEmpty(this.textBoxModell.Text)) errorlog += "\nModell";
                    if (string.IsNullOrEmpty(numericUpDownLeistung.Text) || numericUpDownLeistung.Value == 0) errorlog += "\nLeistung";
                    if (comboBoxFarbe.SelectedItem == null) errorlog += "\nFarbe";
                    if (errorlog != "Bitte folgende Felder ausfüllen:\n") throw new Exception(errorlog);

                    #region readData
                    this.KfzData.Marke = this.textBoxMarke.Text;
                    this.KfzData.Modell = this.textBoxModell.Text;
                    this.KfzData.Zulassung = this.dateTimePicker1.Value.ToString("dd.MM.yyy");
                    this.KfzData.Farbe = this.comboBoxFarbe.SelectedItem.ToString();
                    this.KfzData.Leistung = this.numericUpDownLeistung.Text;
                    this.KfzData.Wartungsintervall = this.numericUpDownWartung.Text;
                    this.KfzData.Kennzeichen = this.textBoxKennz.Text;
                    if (this.KfzData.Fahrzeugkosten != null) calcCost();
                    #endregion
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception)
                {
                    this.tabControlAutoInfo.SelectTab(0);
                    MessageBox.Show(errorlog, "Daten nicht vollständig", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void calcCost()
        {
            double sumTank = 0;
            double sumAllgAll = 0;
            double sumAllgMonth = 0;
            foreach (KfzData item in KfzData.Fahrzeugkosten)
            {
                if (item is KfzKostenTank)
                {
                    KfzKostenTank kostenTank = (KfzKostenTank)item;
                    sumTank += kostenTank.Tankbetrag;
                }
                if (item is KfzKostenAllg)
                {
                    KfzKostenAllg kostenAllg = (KfzKostenAllg)item;
                    sumAllgAll += kostenAllg.KostenWert;
                    switch (kostenAllg.KostenZahlweise)
                    {
                        case "Täglich":
                            sumAllgMonth += kostenAllg.KostenWert * 30;
                            break;
                        case "Wöchentlich":
                            sumAllgMonth += kostenAllg.KostenWert * 4;
                            break;

                        case "Monatlich":
                            sumAllgMonth += kostenAllg.KostenWert;
                            break;

                        case "Halbjährlich":
                            sumAllgMonth += kostenAllg.KostenWert / 6;
                            break;

                        case "Jährlicht":
                            sumAllgMonth += kostenAllg.KostenWert / 12;
                            break;

                        case "Einmalig":
                            sumAllgMonth += kostenAllg.KostenWert / 12;
                            break;

                        default:
                            break;
                    }
                }

            }
            KfzData.Gesamtkosten = sumAllgAll + sumTank;
            KfzData.Monatskosten = sumAllgMonth + sumTank;
        }



        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.KfzData = null;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public void neueKostenstelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKostenstelle formKosten = new FormKostenstelle();

            if (formKosten.ShowDialog() == DialogResult.OK)
            {
                if (this.KfzData.Fahrzeugkosten == null) this.KfzData.Fahrzeugkosten = new List<KfzData>();
                this.KfzData.Fahrzeugkosten.Add(formKosten.kfzKostenAllg);
                addListViewItemKostenAllg(formKosten.kfzKostenAllg);
            }
        }

        private void neueTankrechnungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTanken formTanken = new FormTanken();

            if (formTanken.ShowDialog() == DialogResult.OK)
            {
                if (KfzData.Fahrzeugkosten == null) KfzData.Fahrzeugkosten = new List<KfzData>();
                this.KfzData.Fahrzeugkosten.Add(formTanken.KfzKostenTank);
                addListViewItemKostenTank(formTanken.KfzKostenTank);
            }
        }

        private void addListViewItemKostenAllg(KfzKostenAllg kfzKostenAllg)
        {
            ListViewItem item = new ListViewItem();
            item.Tag = kfzKostenAllg;
            item.Text = kfzKostenAllg.KostenKategorie;
            item.SubItems.Add(Convert.ToString(kfzKostenAllg.KostenDatum));
            item.SubItems.Add(Convert.ToString(kfzKostenAllg.KostenWert));
            item.SubItems.Add(kfzKostenAllg.KostenKilom);
            item.SubItems.Add(kfzKostenAllg.KostenZahlweise);
            item.SubItems.Add(kfzKostenAllg.KostenBemerkung);
            this.listViewAllgKosten.Items.Add(item);
        }
        private void addListViewItemKostenTank(KfzKostenTank kfzKostenTank)
        {
            ListViewItem item = new ListViewItem();
            item.Tag = kfzKostenTank;
            item.Text = Convert.ToString((kfzKostenTank.Tankbetrag));
            item.SubItems.Add(Convert.ToString(kfzKostenTank.TankDatum));
            item.SubItems.Add(Convert.ToString(kfzKostenTank.TankMenge));
            item.SubItems.Add(Convert.ToString(kfzKostenTank.TankKilometer));
            item.SubItems.Add("--");
            item.SubItems.Add("--");
            this.listViewTankKosten.Items.Add(item);
            calcDistancVerbrauch();

            #region old
            //this.listViewTankKosten.Items.Clear();
            //this.listViewAllgKosten.Items.Clear();
            //item.Tag = kfzData;

            //if (item.Tag is KfzKostenTank)
            //{
            //    KfzKostenTank kfzKostenTank = (KfzKostenTank)kfzData;
            //    item.Text = Convert.ToString((kfzKostenTank.Tankbetrag));
            //    item.SubItems.Add(Convert.ToString(kfzKostenTank.TankDatum));
            //    item.SubItems.Add(Convert.ToString(kfzKostenTank.TankMenge));
            //    item.SubItems.Add(Convert.ToString(kfzKostenTank.TankKilometer));
            //    item.SubItems.Add("--");
            //    item.SubItems.Add("--");
            //    this.listViewTankKosten.Items.Add(item);
            //    //calcDistancVerbrauch();
            //}

            //if (item.Tag is KfzKostenAllg)
            //{
            //    //KfzKostenAllg kostenAllg = (KfzKostenAllg)kfzData;
            //    //item.Text = kostenAllg.KostenKategorie;
            //    //item.SubItems.Add(Convert.ToString(kostenAllg.KostenDatum));
            //    //item.SubItems.Add(Convert.ToString(kostenAllg.KostenWert));
            //    //item.SubItems.Add(kostenAllg.KostenKilom);
            //    //item.SubItems.Add(kostenAllg.KostenZahlweise);
            //    //item.SubItems.Add(kostenAllg.KostenBemerkung);
            //    //this.listViewAllgKosten.Items.Add(item);
            //}
            #endregion
        }
        private void calcDistancVerbrauch()
        {
            string kilometer = null;
            int kilomlast, kilom = 0;
            double verbrauch = 0;

            for (int index = 1; index < this.listViewTankKosten.Items.Count; index++)
            {
                if (this.listViewTankKosten.Items.Count > 1)
                {

                    if (!string.IsNullOrEmpty(this.listViewTankKosten.Items[index - 1].SubItems[3].Text))
                    {
                        kilomlast = Convert.ToInt32(this.listViewTankKosten.Items[index].SubItems[3].Text);
                        kilom = kilomlast - Convert.ToInt32(this.listViewTankKosten.Items[index - 1].SubItems[3].Text);
                        if (kilom < 0)
                        {
                            MessageBox.Show("Kilometerstand nicht richtig, bitte prüfen");
                            this.listViewTankKosten.Items[index].SubItems[4].Text = "--";
                            this.listViewTankKosten.Items[index].SubItems[5].Text = "--";
                            this.listViewTankKosten.Items[index].BackColor = Color.LightYellow;
                        }
                        else
                        {
                            kilometer = Convert.ToString(kilom);
                            this.listViewTankKosten.Items[index].SubItems[4].Text = kilometer;
                            verbrauch = Convert.ToDouble(this.listViewTankKosten.Items[index].SubItems[2].Text) / kilom * 100;
                            this.listViewTankKosten.Items[index].SubItems[5].Text = verbrauch.ToString("0.00");
                            this.listViewTankKosten.Items[index].BackColor = Color.White;

                        }
                    }
                }
            }
        }
        private void listViewTankKosten_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = this.listViewTankKosten.GetItemAt(e.X, e.Y);
            KfzKostenTank kfzKostenTank = item.Tag as KfzKostenTank;
            FormTanken form = new FormTanken(kfzKostenTank);
            if (form.ShowDialog() == DialogResult.OK)
            {
                item.Tag = form.KfzKostenTank;
                item.Text = Convert.ToString(form.KfzKostenTank.Tankbetrag);
                item.SubItems[1].Text = Convert.ToString(form.KfzKostenTank.TankDatum);
                item.SubItems[2].Text = Convert.ToString(form.KfzKostenTank.TankMenge);
                item.SubItems[3].Text = (Convert.ToString(form.KfzKostenTank.TankKilometer));
                calcDistancVerbrauch();

            }
        }

        private void listViewAllgKosten_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = this.listViewAllgKosten.GetItemAt(e.X, e.Y);
            KfzKostenAllg kfzKostenAllg = item.Tag as KfzKostenAllg;
            FormKostenstelle form = new FormKostenstelle(kfzKostenAllg);
            if (form.ShowDialog() == DialogResult.OK)
            {
                item.Tag = form.kfzKostenAllg;
                item.Text = form.kfzKostenAllg.KostenKategorie;
                item.SubItems[1].Text = Convert.ToString(form.kfzKostenAllg.KostenWert);
                item.SubItems[2].Text = Convert.ToString(form.kfzKostenAllg.KostenDatum);
                item.SubItems[3].Text = form.kfzKostenAllg.KostenKilom;
                item.SubItems[4].Text = form.kfzKostenAllg.KostenZahlweise;
                item.SubItems[5].Text = form.kfzKostenAllg.KostenBemerkung;

            }

        }

        private void numericLeistungChanged_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numericUpDownLeistung.Text) || numericUpDownLeistung.Value == 0) this.labelLeistungPS.Text = "PS: ";
            else labelLeistungPS.Text = "PS: " + (Convert.ToString(Convert.ToDouble(numericUpDownLeistung.Text) * 1.36));
        }

        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            switch (this.tabControlAutoInfo.SelectedTab.Name)
            {
                case "tabPageKosten":
                    if (this.listViewAllgKosten.SelectedItems.Count == 1 && MessageBox.Show("Wollen Sie diese Kostenstelle wirklich löschen?",
               "Frage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        this.listViewAllgKosten.Items.Remove(this.listViewAllgKosten.SelectedItems[0]);

                    break;
                case "tabPageTank":
                    if (this.listViewTankKosten.SelectedItems.Count == 1 && MessageBox.Show("Wollen Sie diese Tankrechnung wirklich löschen?",
               "Frage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        this.listViewTankKosten.Items.Remove(this.listViewTankKosten.SelectedItems[0]);
                    calcDistancVerbrauch();
                    break;
                default:
                    break;
            }


            //for (int i = 0; i < this.listViewMain.Items.Count; i++)
            //{
            //    if (i % 2 == 0) this.listViewMain.Items[i].BackColor = Color.White;
            //    else this.listViewMain.Items[i].BackColor = Color.LightSteelBlue;
            //}


        }

        private void pictureBoxCar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image files(*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.bmp) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.bmp";
            fileDialog.InitialDirectory = "c:\\temp\\";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.pictureBoxCar.Image = Image.FromFile(fileDialog.FileName);
                this.KfzData.ImagePath = fileDialog.FileName;
                this.pictureBoxCar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void pictureBoxCar_DragDrop(object sender, DragEventArgs e)
        {
            
            foreach (string pic in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                Image img = Image.FromFile(pic);
                pictureBoxCar.Image = img;
               // this.KfzData.ImagePath = Convert.ToBase64String(File.ReadAllBytes(pic));
            }
        }

        private void pictureBoxCar_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
