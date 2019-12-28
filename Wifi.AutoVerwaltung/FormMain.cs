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

            this.listViewMain.Visible = false;
            this.panelKeinFahrzeug.Visible = true;
            CenterToScreen();

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
                buttonKfzÜbersicht.PerformClick();
                panelKeinFahrzeug.Visible = false;
                this.listViewMain.Items[this.listViewMain.Items.Count - 1].Selected = true;
            }
            else buttonKfzÜbersicht_Click(this, EventArgs.Empty);

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
                FormLogin formLogin = new FormLogin();
                if (formLogin.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        this.securedAutoFile = SecuredAutoFile.Read(fileDialog.FileName, formLogin.Password);
                        if (this.securedAutoFile.Owner == formLogin.Username)
                        {
                            this.toolStripOpenFile.Text = "Datei: " + fileDialog.FileName;
                            this.toolStripLoggedUser.Text = "Benutzer: " + formLogin.Username;
                            this.listViewMain.Items.Clear();
                            this.masterPassword = formLogin.Password;
                            foreach (KfzData kfzData in this.securedAutoFile.FahrzeugInfos)
                            {
                                fillListView(kfzData);
                            }
                            this.listViewMain.Items[0].Selected = true;
                        }
                        else
                        {
                            MessageBox.Show("Keine Berechtigung");
                            this.securedAutoFile = null;
                        }
                        this.panelKeinFahrzeug.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Keine Berechtigung");
                        this.securedAutoFile = null;
                    }

                }
                buttonKfzÜbersicht_Click(this, EventArgs.Empty);
            }
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
                //showImage(formEdit.KfzData);
            }
        }

        private void buttonKfzÜbersicht_Click(object sender, EventArgs e)
        {
            panelShowButton.Height = buttonKfzÜbersicht.Height;
            panelShowButton.Top = buttonKfzÜbersicht.Top;

            if (this.securedAutoFile != null)
            {
                this.listViewMain.Visible = true;
            }
            else
            {
                panelKeinFahrzeug.Visible = true;
                panelKeinFahrzeug.Height = panelMain.Height;
                panelKeinFahrzeug.Width = panelMain.Width;
                panelKeinFahrzeug.Location = panelMain.Location;

            }
        }

        private void buttonNeuesFahrzeug_Click(object sender, EventArgs e)
        {
            panelShowButton.Height = buttonNeuesFahrzeug.Height;
            panelShowButton.Top = buttonNeuesFahrzeug.Top;
            this.panelKeinFahrzeug.Visible = false;
            newCar();

        }

        private void fahrzeugLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listViewMain.SelectedItems.Count == 1 && MessageBox.Show("Wollen Sie das Fahrzeug wirklich löschen?",
                "Frage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.listViewMain.Items.Remove(this.listViewMain.SelectedItems[0]);
                //for (int i = 0; i < this.listViewMain.Items.Count; i++)
                //{
                //    if (i % 2 == 0) this.listViewMain.Items[i].BackColor = Color.White;
                //    else this.listViewMain.Items[i].BackColor = Color.LightSteelBlue;
                //}

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
            if(e.IsSelected)
            {
                this.flowLayoutPanelMain.Controls.Clear();
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

    }
}
