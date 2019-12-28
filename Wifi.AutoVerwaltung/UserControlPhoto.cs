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
        public string imageString = null;
        public bool pictureDrop = false;
        public UserControlPhoto()
        {
            InitializeComponent();
            pictureBoxCar.AllowDrop = pictureDrop;
        }
        public UserControlPhoto(Image image, bool drop)
        {
            InitializeComponent();
            pictureBoxCar.AllowDrop = drop;


            pictureBoxCar.Image = image;
            //this.imageString = Convert.ToBase64String(File.ReadAllBytes(image));


        }

        private void pictureBoxCar_DragDrop(object sender, DragEventArgs e)
        {

            foreach (string pic in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                Image img = Image.FromFile(pic);

                pictureBoxCar.Image = img;
                this.imageString = Convert.ToBase64String(File.ReadAllBytes(pic));
                //if (this.KfzData.ImagePath == null) this.KfzData.ImagePath = new List<string>();
                //this.KfzData.ImagePath.Add(Convert.ToBase64String(File.ReadAllBytes(pic)));
                //pictureBoxCar.Tag = this.KfzData.ImagePath.Count - 1;
            }
        }

        private void pictureBoxCar_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
