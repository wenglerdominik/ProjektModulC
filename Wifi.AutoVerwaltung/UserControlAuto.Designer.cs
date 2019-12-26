namespace Wifi.AutoVerwaltung
{
    partial class UserControlAuto
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
            this.labelMarke = new System.Windows.Forms.Label();
            this.labelModell = new System.Windows.Forms.Label();
            this.labelErstzullasung = new System.Windows.Forms.Label();
            this.labelFarbe = new System.Windows.Forms.Label();
            this.labelGesamtkosten = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMarke
            // 
            this.labelMarke.AutoSize = true;
            this.labelMarke.Location = new System.Drawing.Point(7, 7);
            this.labelMarke.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMarke.Name = "labelMarke";
            this.labelMarke.Size = new System.Drawing.Size(35, 13);
            this.labelMarke.TabIndex = 0;
            this.labelMarke.Text = "label1";
            this.labelMarke.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.labelMarke_MouseDoubleClick);
            // 
            // labelModell
            // 
            this.labelModell.AutoSize = true;
            this.labelModell.Location = new System.Drawing.Point(99, 7);
            this.labelModell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelModell.Name = "labelModell";
            this.labelModell.Size = new System.Drawing.Size(35, 13);
            this.labelModell.TabIndex = 1;
            this.labelModell.Text = "label1";
            // 
            // labelErstzullasung
            // 
            this.labelErstzullasung.AutoSize = true;
            this.labelErstzullasung.Location = new System.Drawing.Point(277, 7);
            this.labelErstzullasung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelErstzullasung.Name = "labelErstzullasung";
            this.labelErstzullasung.Size = new System.Drawing.Size(35, 13);
            this.labelErstzullasung.TabIndex = 3;
            this.labelErstzullasung.Text = "label1";
            // 
            // labelFarbe
            // 
            this.labelFarbe.AutoSize = true;
            this.labelFarbe.Location = new System.Drawing.Point(179, 7);
            this.labelFarbe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFarbe.Name = "labelFarbe";
            this.labelFarbe.Size = new System.Drawing.Size(35, 13);
            this.labelFarbe.TabIndex = 2;
            this.labelFarbe.Text = "label1";
            // 
            // labelGesamtkosten
            // 
            this.labelGesamtkosten.AutoSize = true;
            this.labelGesamtkosten.Location = new System.Drawing.Point(411, 7);
            this.labelGesamtkosten.Name = "labelGesamtkosten";
            this.labelGesamtkosten.Size = new System.Drawing.Size(35, 13);
            this.labelGesamtkosten.TabIndex = 4;
            this.labelGesamtkosten.Text = "label1";
            // 
            // UserControlAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelGesamtkosten);
            this.Controls.Add(this.labelErstzullasung);
            this.Controls.Add(this.labelFarbe);
            this.Controls.Add(this.labelModell);
            this.Controls.Add(this.labelMarke);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlAuto";
            this.Size = new System.Drawing.Size(565, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMarke;
        private System.Windows.Forms.Label labelModell;
        private System.Windows.Forms.Label labelErstzullasung;
        private System.Windows.Forms.Label labelFarbe;
        private System.Windows.Forms.Label labelGesamtkosten;
    }
}
