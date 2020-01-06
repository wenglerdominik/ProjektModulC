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
using System.Xml.Serialization;
using System.Resources;
using System.Xml.Linq;
using System.Xml;
using System.Reflection;

namespace Wifi.AutoVerwaltung
{
    public partial class FormEdit : Form
    {
        public KfzData KfzData { get; set; } = new KfzData();
        private Cars Cars;
        bool ignoreErrorStart = false;
        bool showError = false;
        public FormEdit()
        {
            InitializeComponent();
            CenterToScreen();
            if (this.flowLayoutPanel1.Controls.Count == 0) addUcPhoto();
            loadCarCollection();
           
        }

       

        public FormEdit(KfzData kfzData)
        {
            InitializeComponent();
            CenterToScreen();
            loadCarCollection();
            this.KfzData = kfzData;
            this.comboBoxBrand.Text = kfzData.Marke;
            this.comboBoxCarModel.Text = kfzData.Modell;
            this.dateTimePicker1.Value = Convert.ToDateTime(kfzData.Zulassung);
            this.comboBoxFarbe.Text = kfzData.Farbe;
            this.numericUpDownLeistung.Text = kfzData.Leistung;
            this.numericUpDownWartung.Text = kfzData.Wartungsintervall;
            this.textBoxKennz.Text = kfzData.Kennzeichen;
            if (this.KfzData.ImagePath != null)
            {
                foreach (string item in kfzData.ImagePath)
                {

                    try
                    {
                        string val = item;
                        byte[] bytes = Convert.FromBase64String(val);
                        MemoryStream mem = new MemoryStream(bytes);
                        Bitmap bmp2 = new Bitmap(mem);
                        UserControlPhoto userControl = new UserControlPhoto(bmp2, true, true);
                        userControl.imageString = item;
                        userControl.Name = item;
                        this.flowLayoutPanel1.Controls.Add(userControl);

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Bild konnte nicht geöffnet werden.");
                    }
                }
                addUcPhoto();

            }


            if (this.KfzData.Fahrzeugkosten != null)
            {
                foreach (KfzData itemKfzData in this.KfzData.Fahrzeugkosten)
                {
                    ignoreErrorStart = true;
                    if (itemKfzData is KfzKostenAllg) addListViewItemKostenAllg((KfzKostenAllg)itemKfzData);
                    if (itemKfzData is KfzKostenTank) addListViewItemKostenTank((KfzKostenTank)itemKfzData);
                }
            }
            
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string errorlog = "Bitte folgende Felder ausfüllen:\n";
            if (this.KfzData != null)
            {
                try
                {
                    foreach (Control control in this.groupBoxKfzData.Controls)
                    {
                        if (control is TextBox)
                        {
                            if (string.IsNullOrEmpty(control.Text) && control.Name != "textBoxKennz")
                            {
                                control.BackColor = Color.LightCoral;
                            }
                            else control.BackColor = Color.White;
                        }
                        if (control is NumericUpDown)
                        {
                            if (string.IsNullOrEmpty(numericUpDownLeistung.Text) || numericUpDownLeistung.Value == 0) numericUpDownLeistung.BackColor = Color.LightCoral;
                            else numericUpDownLeistung.BackColor = Color.White;
                        }
                        if (control is MaskedTextBox)
                        {
                            if (string.IsNullOrEmpty(control.Text)) control.BackColor = Color.LightCoral;
                            else control.BackColor = Color.White;
                        }
                        if (control is ComboBox)
                        {
                            if (string.IsNullOrEmpty(comboBoxFarbe.Text)) comboBoxFarbe.BackColor = Color.LightCoral;
                            else comboBoxFarbe.BackColor = Color.White;
                            if (string.IsNullOrEmpty(comboBoxBrand.Text)) comboBoxBrand.BackColor = Color.LightCoral;
                            else comboBoxBrand.BackColor = Color.White;
                            if (string.IsNullOrEmpty(comboBoxCarModel.Text)) comboBoxCarModel.BackColor = Color.LightCoral;
                            else comboBoxCarModel.BackColor = Color.White;
                            
                        }
                    }

                    if (string.IsNullOrEmpty(this.comboBoxBrand.Text)) errorlog += "\nMarke";
                    if (string.IsNullOrEmpty(this.comboBoxCarModel.Text)) errorlog += "\nModell";
                    if (string.IsNullOrEmpty(numericUpDownLeistung.Text) || numericUpDownLeistung.Value == 0) errorlog += "\nLeistung";
                    if (string.IsNullOrEmpty(comboBoxFarbe.Text)) errorlog += "\nFarbe";
                    if (errorlog != "Bitte folgende Felder ausfüllen:\n") throw new Exception(errorlog);

                    #region readData
                    this.KfzData.Marke = this.comboBoxBrand.Text;
                    this.KfzData.Modell = this.comboBoxCarModel.Text;
                    this.KfzData.Zulassung = this.dateTimePicker1.Value.ToString("dd.MM.yyy");
                    this.KfzData.Farbe = this.comboBoxFarbe.Text;
                    this.KfzData.Leistung = this.numericUpDownLeistung.Text;
                    this.KfzData.Wartungsintervall = this.numericUpDownWartung.Text;
                    this.KfzData.Kennzeichen = this.textBoxKennz.Text;
                    if(this.KfzData.KostDeleted!=null) foreach (KfzData item in this.KfzData.KostDeleted)
                    {
                        this.KfzData.Fahrzeugkosten.Remove(item);
                    }
                    if (this.KfzData.Fahrzeugkosten != null) calcCost();
                    #endregion
                    getImageData();
                    addCarModels();
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
            this.tabControlAutoInfo.SelectedTab = tabPageKosten;
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
            this.tabControlAutoInfo.SelectedTab = tabPageTank;
            ignoreErrorStart = false;
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
            item.SubItems.Add(Convert.ToString(kfzKostenAllg.KostenWert));
            item.SubItems.Add(Convert.ToString(kfzKostenAllg.KostenDatum));
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
                            if (!ignoreErrorStart)
                            {
                                MessageBox.Show("Kilometerstand der Tankrechnung ist nicht richtig. Bitte prüfen und beheben", "Fehler bei Tankrechnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                            showError = true;
                            this.listViewTankKosten.Items[index].SubItems[4].Text = "--";
                            this.listViewTankKosten.Items[index].SubItems[5].Text = "--";
                            this.listViewTankKosten.Items[index].BackColor = Color.LightCoral;
                            
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
            ignoreErrorStart = false;
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
            ListViewItem item = null;
            if (this.KfzData.KostDeleted == null) this.KfzData.KostDeleted = new List<KfzData>();

            switch (this.tabControlAutoInfo.SelectedTab.Name)
            {
                case "tabPageKosten":

                    if (this.listViewAllgKosten.SelectedItems.Count == 1 && MessageBox.Show("Wollen Sie diese Kostenstelle wirklich löschen?",
                    "Frage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        item = this.listViewAllgKosten.SelectedItems[0];
                        KfzKostenAllg kfzKostenAllg = item.Tag as KfzKostenAllg;
                        this.KfzData.KostDeleted.Add(kfzKostenAllg);
                        //this.KfzData.Fahrzeugkosten.Remove(kfzKostenAllg);
                        this.listViewAllgKosten.Items.Remove(this.listViewAllgKosten.SelectedItems[0]);
                    }
                    break;

                case "tabPageTank":
                    if (this.listViewTankKosten.SelectedItems.Count == 1 && MessageBox.Show("Wollen Sie diese Tankrechnung wirklich löschen?",
                    "Frage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        item = this.listViewTankKosten.SelectedItems[0];
                        KfzKostenTank kfzKostenTank = item.Tag as KfzKostenTank;
                        this.KfzData.KostDeleted.Add(kfzKostenTank);
                        // this.KfzData.Fahrzeugkosten.Remove(kfzKostenTank);
                        this.listViewTankKosten.Items.Remove(this.listViewTankKosten.SelectedItems[0]);
                        calcDistancVerbrauch();
                    }
                    break;

                default:
                    break;
            }
        }

        private void bildLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserControlPhoto.GetFocusedUserControl() == "UserControlPhoto")
            {
                MessageBox.Show("Es ist noch kein Bild hinterlegt", "Löschen nicht möglich", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else this.flowLayoutPanel1.Controls.RemoveByKey(UserControlPhoto.GetFocusedUserControl());

        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FormEditSize.Width == 0) Properties.Settings.Default.Upgrade();
            if (Properties.Settings.Default.FormEditSize.Width == 0 || Properties.Settings.Default.FormEditSize.Height == 0)
            {
                // first start
                // optional: add default values
            }
            else
            {
                this.WindowState = Properties.Settings.Default.FormEditState;

                // we don't want a minimized window at startup
                if (this.WindowState == FormWindowState.Minimized) this.WindowState = FormWindowState.Normal;

                this.Location = Properties.Settings.Default.FormEditLocation;
                this.Size = Properties.Settings.Default.FormEditSize;
                this.listViewAllgKosten.Columns[0].Width = Properties.Settings.Default.ListViewKostenColumnKategorie;
                this.listViewAllgKosten.Columns[1].Width = Properties.Settings.Default.ListViewKostenColumnDatum;
                this.listViewAllgKosten.Columns[2].Width = Properties.Settings.Default.ListViewKostenColumnKosten;
                this.listViewAllgKosten.Columns[3].Width = Properties.Settings.Default.ListViewKostenColumnKilometer;
                this.listViewAllgKosten.Columns[4].Width = Properties.Settings.Default.ListViewKostenColumnZahlweise;
                this.listViewAllgKosten.Columns[5].Width = Properties.Settings.Default.ListViewKostenColumnBemerkung;

                this.listViewTankKosten.Columns[0].Width = Properties.Settings.Default.ListViewTankColumnBetrag;
                this.listViewTankKosten.Columns[1].Width = Properties.Settings.Default.ListViewTankColumnDatum;
                this.listViewTankKosten.Columns[2].Width = Properties.Settings.Default.ListViewTankColumnMenge;
                this.listViewTankKosten.Columns[3].Width = Properties.Settings.Default.ListViewTankColumnStreckeGefahren;
                this.listViewTankKosten.Columns[4].Width = Properties.Settings.Default.ListViewTankColumnVerbrauch;

            }
        }

        private void FormEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.FormEditState = this.WindowState;
            if (this.WindowState == FormWindowState.Normal)
            {
                // save location and size if the state is normal
                Properties.Settings.Default.FormEditLocation = this.Location;
                Properties.Settings.Default.FormEditSize = this.Size;
                Properties.Settings.Default.ListViewKostenColumnKategorie = this.listViewAllgKosten.Columns[0].Width;
                Properties.Settings.Default.ListViewKostenColumnDatum = this.listViewAllgKosten.Columns[1].Width;
                Properties.Settings.Default.ListViewKostenColumnKosten = this.listViewAllgKosten.Columns[2].Width;
                Properties.Settings.Default.ListViewKostenColumnKilometer = this.listViewAllgKosten.Columns[3].Width;
                Properties.Settings.Default.ListViewKostenColumnZahlweise = this.listViewAllgKosten.Columns[4].Width;
                Properties.Settings.Default.ListViewKostenColumnBemerkung = this.listViewAllgKosten.Columns[5].Width;

                Properties.Settings.Default.ListViewTankColumnBetrag = this.listViewTankKosten.Columns[0].Width;
                Properties.Settings.Default.ListViewTankColumnDatum = this.listViewTankKosten.Columns[1].Width;
                Properties.Settings.Default.ListViewTankColumnMenge = this.listViewTankKosten.Columns[2].Width;
                Properties.Settings.Default.ListViewTankColumnStreckeGefahren = this.listViewTankKosten.Columns[3].Width;
                Properties.Settings.Default.ListViewTankColumnVerbrauch = this.listViewTankKosten.Columns[4].Width;


            }
            else
            {
                // save the RestoreBounds if the form is minimized or maximized!
                Properties.Settings.Default.FormEditLocation = this.RestoreBounds.Location;
                Properties.Settings.Default.FormEditSize = this.RestoreBounds.Size;
            }

            // don't forget to save the settings
            Properties.Settings.Default.Save();
        }

        public void addUcPhoto()
        {
            UserControlPhoto userControl = new UserControlPhoto();
            this.flowLayoutPanel1.Controls.Add(userControl);
            userControl.newPictureAddedEvent += this.addUcPhoto;
        }
        private void getImageData()
        {
            if (this.KfzData.ImagePath == null) this.KfzData.ImagePath = new List<string>();
            this.KfzData.ImagePath.Clear();

            foreach (UserControlPhoto userControl in this.flowLayoutPanel1.Controls)
            {
                if (!string.IsNullOrEmpty(userControl.imageString)) this.KfzData.ImagePath.Add(userControl.imageString);
            }
        }

        private void comboBoxBrand_TextChanged(object sender, EventArgs e)
        {
            this.comboBoxCarModel.Text = null;
            this.comboBoxCarModel.Items.Clear();
            switch (this.comboBoxBrand.Text)
            {
                case "Alfa Romeo":
                    this.pictureBoxBrand.Image = Properties.Resources.Alfa_Romeo_Logo_brandtreeIndexSmall_353e502_935510;
                    break;
                case "Alpina":
                    this.pictureBoxBrand.Image = Properties.Resources.Alpina_Logo_brandtreeIndexSmall_db9af53_945684;
                    break;
                case "Aston Martin":
                    this.pictureBoxBrand.Image = Properties.Resources.Aston_Martin_Logo_brandtreeIndexSmall_805186e1_945683;
                    break;
                case "Audi":
                    this.pictureBoxBrand.Image = Properties.Resources.Audi_Logo_Neu_02_2019_brandtreeIndexSmall_44d434cb_1430808;
                    break;
                case "Bentley":
                    this.pictureBoxBrand.Image = Properties.Resources.Bentley_Logo_brandtreeIndexSmall_41a61902_702423;
                    break;
                case "BMW":
                    this.pictureBoxBrand.Image = Properties.Resources.BMW_Logo_brandtreeIndexSmall_88182575_702392;
                    break;
                case "Bugatti":
                    this.pictureBoxBrand.Image = Properties.Resources.Bugatti_Logo_brandtreeIndexSmall_252888c_946200;
                    break;
                case "Cadillac":
                    this.pictureBoxBrand.Image = Properties.Resources.Cadillac_Logo_brandtreeIndexSmall_7ea8e883_945686;
                    break;
                case "Chevrolet":
                    this.pictureBoxBrand.Image = Properties.Resources.Chevrolet_Logo_brandtreeIndexSmall_32f60c53_702439;
                    break;
                case "Citroen":
                    this.pictureBoxBrand.Image = Properties.Resources.Citroen_Logo_brandtreeIndexSmall_5d4a92f8_700257;
                    break;
                case "Dacia":
                    this.pictureBoxBrand.Image = Properties.Resources.Dacia_Logo_brandtreeIndexSmall_538fec13_702394;
                    break;
                case "DS":
                    this.pictureBoxBrand.Image = Properties.Resources.DS_Logo_brandtreeIndexSmall_8a8042ef_940849;
                    break;
                case "Ferrari":
                    this.pictureBoxBrand.Image = Properties.Resources.Ferrari_Logo_brandtreeIndexSmall_3b47b704_702395;
                    break;
                case "Fiat":
                    this.pictureBoxBrand.Image = Properties.Resources.Fiat_Logo_brandtreeIndexSmall_b8ec2f4a_702396;
                    break;
                case "Ford":
                    this.pictureBoxBrand.Image = Properties.Resources.Ford_Logo_brandtreeIndexSmall_e4d8a4ce_702397;
                    break;
                case "Honda":
                    this.pictureBoxBrand.Image = Properties.Resources.Honda_Logo_brandtreeIndexSmall_e6d06e72_945693;
                    break;
                case "Hyundai":
                    this.pictureBoxBrand.Image = Properties.Resources.Hyundai_Logo_brandtreeIndexSmall_dba2d69d_941104;
                    break;
                case "Infiniti":
                    this.pictureBoxBrand.Image = Properties.Resources.Infiniti_Logo_brandtreeIndexSmall_ece52b3d_941119;
                    break;
                case "Isuzu":
                    this.pictureBoxBrand.Image = Properties.Resources.Isuzu_Logo_brandtreeIndexSmall_71406f9e_945694;
                    break;
                case "Jaguar":
                    this.pictureBoxBrand.Image = Properties.Resources.Jaguar_Logo_brandtreeIndexSmall_58c924ae_1554011;
                    break;
                case "Jeep":
                    this.pictureBoxBrand.Image = Properties.Resources.Jeep_Logo_brandtreeIndexSmall_2181a802_941106;
                    break;
                case "Kia":
                    this.pictureBoxBrand.Image = Properties.Resources.Kia_Logo_brandtreeIndexSmall_97b9f0b3_941107;
                    break;
                case "Lada":
                    this.pictureBoxBrand.Image = Properties.Resources.Lada_Logo_brandtreeIndexSmall_ef2db6ef_1128620;
                    break;
                case "Lamborghini":
                    this.pictureBoxBrand.Image = Properties.Resources.Lamborghini_Logo_brandtreeIndexSmall_df88a8a3_945695;
                    break;
                case "Land Rover":
                    this.pictureBoxBrand.Image = Properties.Resources.Land_Rover_Logo_brandtreeIndexSmall_1e8d2f4f_702457;
                    break;
                case "Lexus":
                    this.pictureBoxBrand.Image = Properties.Resources.Lexus_Logo_brandtreeIndexSmall_8ef5b88c_942610;
                    break;
                case "Lotus":
                    this.pictureBoxBrand.Image = Properties.Resources.Lotus_Logo_brandtreeIndexSmall_c2b345ee_945697;
                    break;
                case "Maserati":
                    this.pictureBoxBrand.Image = Properties.Resources.Maserati_Logo_brandtreeIndexSmall_3b5073c9_945700;
                    break;
                case "Mazda":
                    this.pictureBoxBrand.Image = Properties.Resources.Mazda_Logo_brandtreeIndexSmall_abd3161d_1128623;
                    break;
                case "McLaren":
                    this.pictureBoxBrand.Image = Properties.Resources.McLaren_Logo_brandtreeIndexSmall_c9f50d36_941804;
                    break;
                case "Mercedes":
                    this.pictureBoxBrand.Image = Properties.Resources.Mercedes_Logo_brandtreeIndexSmall_c0d1786b_702402;
                    break;
                case "Mini":
                    this.pictureBoxBrand.Image = Properties.Resources.Mini_Logo_brandtreeIndexSmall_d9e7b91_941110;
                    break;
                case "Mitsubishi":
                    this.pictureBoxBrand.Image = Properties.Resources.Mitsubishi_Logo_brandtreeIndexSmall_e52939cf_1128624;
                    break;
                case "Nissan":
                    this.pictureBoxBrand.Image = Properties.Resources.Nissan_Logo_brandtreeIndexSmall_44366170_941111;
                    break;
                case "Opel":
                    this.pictureBoxBrand.Image = Properties.Resources.Opel_Logo_brandtreeIndexSmall_3ddc24ff_702407;
                    break;
                case "Peugeot":
                    this.pictureBoxBrand.Image = Properties.Resources.Peugeot_Logo_brandtreeIndexSmall_b6a7040f_702414;
                    break;
                case "Porsche":
                    this.pictureBoxBrand.Image = Properties.Resources.Porsche_Logo_brandtreeIndexSmall_b8d7c99_702413;
                    break;
                case "Renault":
                    this.pictureBoxBrand.Image = Properties.Resources.Renault_Logo_brandtreeIndexSmall_e6878de7_702412;
                    break;
                case "Rolls-Royce":
                    this.pictureBoxBrand.Image = Properties.Resources.Rolls_Royce_Logo_brandtreeIndexSmall_d2e6b452_945703;
                    break;
                case "Seat":
                    this.pictureBoxBrand.Image = Properties.Resources.Seat_Logo_brandtreeIndexSmall_eb1ca1c8_941115;
                    break;
                case "Skoda":
                    this.pictureBoxBrand.Image = Properties.Resources.Skoda_Logo_brandtreeIndexSmall_e7930242_941116;
                    break;
                case "Smart":
                    this.pictureBoxBrand.Image = Properties.Resources.Smart_Logo_brandtreeIndexSmall_832b209c_945705;
                    break;
                case "SsangYong":
                    this.pictureBoxBrand.Image = Properties.Resources.SsangYong_Logo_brandtreeIndexSmall_47b5a1ab_945085;
                    break;
                case "Subaru":
                    this.pictureBoxBrand.Image = Properties.Resources.Subaru_Logo_brandtreeIndexSmall_c7f4790a_941162;
                    break;
                case "Suzuki":
                    this.pictureBoxBrand.Image = Properties.Resources.Suzuki_Logo_brandtreeIndexSmall_c9d26001_945253;
                    break;
                case "Tesla":
                    this.pictureBoxBrand.Image = Properties.Resources.Tesla_Logo_Neu_02_2019_brandtreeIndexSmall_3beaf0ab_1430807;
                    break;
                case "Toyota":
                    this.pictureBoxBrand.Image = Properties.Resources.Toyota_Logo_brandtreeIndexSmall_2d086b5b_702409;
                    break;
                case "Volvo":
                    this.pictureBoxBrand.Image = Properties.Resources.Volvo_Logo_brandtreeIndexSmall_b2257f5e_423001;
                    break;
                case "VW":
                    this.pictureBoxBrand.Image = Properties.Resources.VW_Logo_2019_brandtreeIndexSmall_3696dd3c_1631727;
                    break;

                default:
                    this.pictureBoxBrand.Image = null;
                    break;
            }

            if (comboBoxBrand.Items.Contains(comboBoxBrand.Text))
            {

                var result = Cars.CarCollection.Where(y => y.Brand == comboBoxBrand.Text);
                foreach (CarBrand item in result)
                {
                    comboBoxCarModel.Items.AddRange(item.Models.ToArray());

                }
                if (this.comboBoxCarModel.Items.Count != 0) this.comboBoxCarModel.SelectedIndex = 0;

            }



        }

        private void loadCarCollection()
        {

            if (this.Cars == null) this.Cars = new Cars();
            {

                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Wifi\\CarCollectionUser.xml"))
                {
                    StreamReader streamReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Wifi\\CarCollectionUser.xml", Encoding.UTF8);
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Cars));
                    Cars = (Cars)xmlSerializer.Deserialize(streamReader);
                    streamReader.Close();
                }
                else
                {
                    XmlReader reader = new XmlTextReader(new StringReader(Properties.Resources.CarCollectionInit));
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Cars));
                    Cars = (Cars)xmlSerializer.Deserialize(reader);
                    reader.Close();
                }

                //XmlReader reader = new XmlTextReader(new StringReader(Properties.Resources.CarCollectionInit));
                //XmlSerializer xmlSerializer = new XmlSerializer(typeof(Cars));
                //Cars = (Cars)xmlSerializer.Deserialize(reader);
                //StreamReader reader = new StreamReader(System.IO.Directory.GetCurrentDirectory(), Encoding.UTF8);
                //XmlSerializer serializer = new XmlSerializer(typeof(Cars));
                //Cars = (Cars)serializer.Deserialize(reader);
                //reader.Close();

                foreach (CarBrand item in Cars.CarCollection)
                {
                    this.comboBoxBrand.Items.Add(item.Brand);

                }
            }

        }

        private void addCarModels()
        {
            bool existingBrand = false;

            foreach (CarBrand brand in Cars.CarCollection)
            {

                if (comboBoxBrand.Text == brand.Brand)
                {
                    existingBrand = true;

                    if (!brand.Models.Contains(comboBoxCarModel.Text)) brand.Models.Add(comboBoxCarModel.Text);

                    break;
                }

            }
            if (!existingBrand)
            {
                CarBrand carBrand = new CarBrand { Brand = comboBoxBrand.Text };
                carBrand.Models.Add(comboBoxCarModel.Text);
                Cars.CarCollection.Add(carBrand);
            }
            writeCarCollectionFile();
        }

        private void writeCarCollectionFile()
        {
            try
            {
                StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Wifi\\CarCollectionUser.xml", false, Encoding.UTF8);
                XmlSerializer serializer = new XmlSerializer(typeof(Cars));
                serializer.Serialize(writer, Cars);

                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void FormEdit_Shown(object sender, EventArgs e)
        {
            if (showError)
            {
                this.tabControlAutoInfo.SelectedTab = tabPageTank;
                MessageBox.Show("Kilometerstand bei einer Tankrechnung ist nicht richtig. Bitte prüfen und beheben", "Fehler bei Tankrechnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
