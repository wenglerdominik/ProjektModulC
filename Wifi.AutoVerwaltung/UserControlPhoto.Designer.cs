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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlPhoto));
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCar.Image")));
            this.pictureBoxCar.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCar.InitialImage")));
            this.pictureBoxCar.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCar.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(200, 180);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCar.TabIndex = 22;
            this.pictureBoxCar.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxCar, "Bilder per Drag/Drop hinzufügen");
            this.pictureBoxCar.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBoxCar_DragDrop);
            this.pictureBoxCar.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBoxCar_DragEnter);
            this.pictureBoxCar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCar_MouseDown);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            this.toolTip1.AutoPopDelay = 4000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 40;
            // 
            // UserControlPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBoxCar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlPhoto";
            this.Size = new System.Drawing.Size(200, 180);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
