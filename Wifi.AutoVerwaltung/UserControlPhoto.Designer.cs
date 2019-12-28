namespace Wifi.AutoVerwaltung
{
    partial class UserControlPhoto
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlPhoto));
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCar.Image")));
            this.pictureBoxCar.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCar.InitialImage")));
            this.pictureBoxCar.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(420, 364);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCar.TabIndex = 22;
            this.pictureBoxCar.TabStop = false;
            this.pictureBoxCar.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBoxCar_DragDrop);
            this.pictureBoxCar.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBoxCar_DragEnter);
            this.pictureBoxCar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCar_MouseDown);
            // 
            // UserControlPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBoxCar);
            this.Name = "UserControlPhoto";
            this.Size = new System.Drawing.Size(446, 385);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCar;
    }
}
