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
using System.IO;

namespace Wifi.AutoVerwaltung
{
    public partial class UserControlPhoto : UserControl
    {
        public delegate void DelegatePictureAdded();
        public event DelegatePictureAdded newPictureAddedEvent;

        public string imageString { get; set; } = null;
        static string nameFocusedControl = null;
        public UserControlPhoto()
        {
            InitializeComponent();
            pictureBoxCar.AllowDrop = true;


        }
        public UserControlPhoto(Image image, bool drop)
        {
            InitializeComponent();
            pictureBoxCar.AllowDrop = drop;

            pictureBoxCar.Image = image;

        }

        private void pictureBoxCar_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                foreach (string pic in ((string[])e.Data.GetData(DataFormats.FileDrop)))
                {
                    Image img = Image.FromFile(pic);

                    pictureBoxCar.Image = img;
                    pictureBoxCar.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.imageString = Convert.ToBase64String(File.ReadAllBytes(pic));
                    this.Name = imageString;
                    if (newPictureAddedEvent != null)
                    {
                        newPictureAddedEvent();
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Es können nur Bilddateien hinzugefügt werden. " +
                   "Bitte andere Datei wählen", "Bild konnte nicht eingefügt werden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBoxCar_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }


        public static string GetFocusedUserControl()
        {
            return nameFocusedControl;
        }

        private void pictureBoxCar_MouseDown(object sender, MouseEventArgs e)
        {
            nameFocusedControl = this.Name;
            this.pictureBoxCar.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
