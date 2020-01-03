using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wifi.Auto.Data;

namespace Wifi.AutoVerwaltung
{
    public partial class FormMain : Form
    {
        private SecuredAutoFile securedAutoFile = null;
        private string masterPassword = null;
        private KfzData kfzData = null;


        public FormMain()
        {
            InitializeComponent();
           // Splash();
            this.listViewMain.Visible = false;
            this.panelKeinFahrzeug.Visible = true;
            CenterToScreen();
            //menuStrip1.Renderer = new MyRenderer();
            //this.menuItemOpenFile.BackColor = Color.FromArgb(48, 48, 48);
            //this.menuItemOpenFile.ForeColor = Color.FromArgb(250, 250, 255);
            //this.menuItemSpeichern.BackColor = Color.FromArgb(48, 48, 48);
            //this.menuItemSpeichern.ForeColor = Color.FromArgb(250, 250, 255);
            //this.menuItemNeu.BackColor = Color.FromArgb(48, 48, 48);
            //this.menuItemNeu.ForeColor = Color.FromArgb(250, 250, 255);
            //this.fahrzeugLöschenToolStripMenuItem.BackColor = Color.FromArgb(48, 48, 48);
            //this.fahrzeugLöschenToolStripMenuItem.ForeColor = Color.FromArgb(250, 250, 255);


        }
        private class MyRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                Color c = e.Item.Selected ? Color.FromArgb(140,140,140) : Color.FromArgb(48,48,48);
                using (SolidBrush brush = new SolidBrush(c))
                    e.Graphics.FillRectangle(brush, rc);
            }
        }
        public void Splash()
        {
            Application.Run(new Splash());
        }


        private void menuItemNeu_Click(object sender, EventArgs e)
        {
            newCar();
        }

        private void newCar()
        {
            FormEdit formEdit = new FormEdit();

            if (formEdit.ShowDialog() == DialogResult.OK)
            {
                if (this.securedAutoFile == null)
                {
                    this.securedAutoFile = new SecuredAutoFile();
                    this.securedAutoFile.CreationDate = DateTime.Now;
                }
                this.kfzData = formEdit.KfzData;
                this.securedAutoFile.FahrzeugInfos.Add(this.kfzData);
                fillListView(kfzData);
                panelKeinFahrzeug.Visible = false;
                this.listViewMain.Items[this.listViewMain.Items.Count - 1].Selected = true;
                this.listViewMain.Visible = true;
            }
            if(this.listViewMain.Items.Count==0) panelKeinFahrzeug.Visible = true;

        }

        private void fillListView(KfzData kfzData)
        {
            ListViewItem item = new ListViewItem();
            item.Tag = kfzData;
            item.Text = kfzData.Marke;
            item.SubItems.Add(kfzData.Modell);
            item.SubItems.Add(kfzData.Farbe);
            item.SubItems.Add(Convert.ToString(kfzData.Zulassung));
            item.SubItems.Add(Convert.ToString(kfzData.Gesamtkosten));

            this.listViewMain.Items.Add(item);
            // this.listViewMain.Items[0].Selected = true;

        }

        private void menuItemOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Secured XML Datei|*.sml";
            fileDialog.InitialDirectory = "c:\\temp\\";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!fileDialog.FileName.EndsWith("sml"))
                {
                    MessageBox.Show("Es können nur SecuredXML Dateien geöffnet werden (.sml)",
                        "Falsches Dateiformat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                while (!Login(fileDialog.FileName)) ;

            }
        }


        private bool Login(string filename)
        {
            FormLogin formLogin = new FormLogin();

            if (formLogin.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.securedAutoFile = SecuredAutoFile.Read(filename, formLogin.Password);
                    if (this.securedAutoFile.Owner == formLogin.Username)
                    {
                        this.toolStripOpenFile.Text = "Datei: " + filename;
                        this.toolStripLoggedUser.Text = "Benutzer: " + formLogin.Username;
                        this.listViewMain.Items.Clear();
                        this.masterPassword = formLogin.Password;
                        foreach (KfzData kfzData in this.securedAutoFile.FahrzeugInfos)
                        {
                            fillListView(kfzData);
                        }
                        this.listViewMain.Items[0].Selected = true;
                        this.panelKeinFahrzeug.Visible = false;
                        this.listViewMain.Visible = true;
                        this.toolStripLoggedUser.Visible = true;
                        this.toolStripOpenFile.Visible = true;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Keine Berechtigung");
                        this.securedAutoFile = null;
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Datei kann nicht geöffnet werden.\nBenutzer oder Kennwort falsch", "Fehler beim Öffnen"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.securedAutoFile = null;
                    return false;
                }

            }
            return true;
        }

        private void menuItemSpeichern_Click(object sender, EventArgs e)
        {
            if (this.securedAutoFile != null)
            {
                if (this.masterPassword == null)
                {
                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Filter = "Secured XML Datei |*.sml";
                    dialog.InitialDirectory = "c:\\temp\\";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        FormLogin login = new FormLogin();
                        if (login.ShowDialog() == DialogResult.OK)
                        {
                            SaveFile(dialog.FileName, login.Username, login.Password);
                            this.masterPassword = login.Password;
                            this.toolStripOpenFile.Text = "Datei: " + dialog.FileName;
                            this.toolStripLoggedUser.Text = "Benutzer: " + login.Username;
                        }
                    }
                }
                else SaveFile(toolStripOpenFile.Text.Remove(0, 6), string.Empty, this.masterPassword);

            }
        }

        private void SaveFile(string filename, string Username, string Password)
        {
            this.securedAutoFile.LastUpdate = DateTime.Now;

            if (!string.IsNullOrEmpty(Username)) this.securedAutoFile.Owner = Username;
            this.securedAutoFile.Save(filename, Password);
        }

        private void listViewMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = this.listViewMain.GetItemAt(e.X, e.Y);
            KfzData kfzData = item.Tag as KfzData;
            FormEdit formEdit = new FormEdit(kfzData);
            if (formEdit.ShowDialog() == DialogResult.OK)
            {
                item.Tag = formEdit.KfzData;
                item.Text = formEdit.KfzData.Marke;
                item.SubItems[1].Text = formEdit.KfzData.Modell;
                item.SubItems[2].Text = formEdit.KfzData.Farbe;
                item.SubItems[3].Text = Convert.ToString(formEdit.KfzData.Zulassung);
                item.SubItems[4].Text = Convert.ToString(formEdit.KfzData.Gesamtkosten);
                showImage(formEdit.KfzData);
            }
        }

      
        private void buttonNeuesFahrzeug_Click(object sender, EventArgs e)
        {
            panelShowButton.Height = buttonNeuesFahrzeug.Height;
            panelShowButton.Top = buttonNeuesFahrzeug.Top;
            newCar();

        }

        private void fahrzeugLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listViewMain.SelectedItems.Count == 1 && MessageBox.Show("Wollen Sie das Fahrzeug wirklich löschen?",
                "Frage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ListViewItem item = listViewMain.SelectedItems[0];
                KfzData kfzData = item.Tag as KfzData;
                this.securedAutoFile.FahrzeugInfos.Remove(kfzData);
                this.listViewMain.Items.Remove(this.listViewMain.SelectedItems[0]);
               

            }
            if (this.listViewMain.Items.Count == 0)
            {
                this.listViewMain.Visible = false;
                this.panelKeinFahrzeug.Visible = true;
            }



        }

        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fahrzeugLöschenToolStripMenuItem_Click(this, EventArgs.Empty);
        }

        private void listViewMain_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                ListViewItem item = e.Item;
                KfzData kfzData = item.Tag as KfzData;

                if (kfzData.ImagePath != null)
                {
                    showImage(kfzData);
                }
            }

        }

        private void showImage(KfzData kfzData)
        {
            this.flowLayoutPanelMain.Controls.Clear();

            Graphics g = Graphics.FromHwnd(this.Handle);
            try
            {
                foreach (string item in kfzData.ImagePath)
                {
                    string val = item;
                    byte[] bytes = Convert.FromBase64String(val);
                    MemoryStream mem = new MemoryStream(bytes);
                    Bitmap bmp2 = new Bitmap(mem);
                    UserControlPhoto userControl = new UserControlPhoto(bmp2, false);
                    this.flowLayoutPanelMain.Controls.Add(userControl);
                }
            }
            catch (Exception ex)
            {

                //MessageBox.Show("Bild konnte nicht geöffnet werden. \nPfad prüfen und Bild neu hinzufügen\n" + kfzData.ImagePath);
                //this.pictureBoxMain.Image = null;
                //kfzData.ImagePath = null;
            }


        }

        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Upgrade?
            if (Properties.Settings.Default.FormMainSize.Width == 0) Properties.Settings.Default.Upgrade();
            if (Properties.Settings.Default.FormMainSize.Width == 0 || Properties.Settings.Default.FormMainSize.Height == 0)
            {
                // first start
                // optional: add default values
            }
            else
            {
                this.WindowState = Properties.Settings.Default.FormMainState;

                // we don't want a minimized window at startup
                if (this.WindowState == FormWindowState.Minimized) this.WindowState = FormWindowState.Normal;

                this.Location = Properties.Settings.Default.FormMainLocation;
                this.Size = Properties.Settings.Default.FormMainSize;
                this.listViewMain.Columns[0].Width = Properties.Settings.Default.ListViewMainColumnMarke;
                this.listViewMain.Columns[1].Width = Properties.Settings.Default.ListViewMainColumnModell;
                this.listViewMain.Columns[2].Width = Properties.Settings.Default.ListViewMainColumnFarbe;
                this.listViewMain.Columns[3].Width = Properties.Settings.Default.ListViewMainColumnErstzulassung;
                this.listViewMain.Columns[4].Width = Properties.Settings.Default.ListViewMainColumnGesamtkosten;
                this.splitContainer1.SplitterDistance = Properties.Settings.Default.splitContainer1SplitterDistance;

            }
        }

        private void FormMain_Closing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.FormMainState = this.WindowState;
            if (this.WindowState == FormWindowState.Normal)
            {
                // save location and size if the state is normal
                Properties.Settings.Default.FormMainLocation = this.Location;
                Properties.Settings.Default.FormMainSize = this.Size;
                Properties.Settings.Default.ListViewMainColumnMarke = this.listViewMain.Columns[0].Width;
                Properties.Settings.Default.ListViewMainColumnModell = this.listViewMain.Columns[1].Width;
                Properties.Settings.Default.ListViewMainColumnFarbe = this.listViewMain.Columns[2].Width;
                Properties.Settings.Default.ListViewMainColumnErstzulassung = this.listViewMain.Columns[3].Width;
                Properties.Settings.Default.ListViewMainColumnGesamtkosten = this.listViewMain.Columns[4].Width;
                Properties.Settings.Default.splitContainer1SplitterDistance = this.splitContainer1.SplitterDistance;

            }
            else
            {
                // save the RestoreBounds if the form is minimized or maximized!
                Properties.Settings.Default.FormMainLocation = this.RestoreBounds.Location;
                Properties.Settings.Default.FormMainSize = this.RestoreBounds.Size;
            }
            // don't forget to save the settings
            Properties.Settings.Default.Save();
        }

        private void speichernUnterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.masterPassword = null;
            menuItemSpeichern_Click(this, EventArgs.Empty);
        }
    }
}
