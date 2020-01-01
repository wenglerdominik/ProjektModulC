namespace Wifi.AutoVerwaltung
{
    partial class FormTanken
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOK = new System.Windows.Forms.Button();
            this.numericKilometer = new System.Windows.Forms.NumericUpDown();
            this.numericMenge = new System.Windows.Forms.NumericUpDown();
            this.dateTankDatum = new System.Windows.Forms.DateTimePicker();
            this.numericBetrag = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericKilometer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMenge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBetrag)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(580, 119);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(6);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(138, 42);
            this.buttonOK.TabIndex = 21;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // numericKilometer
            // 
            this.numericKilometer.Location = new System.Drawing.Point(548, 46);
            this.numericKilometer.Margin = new System.Windows.Forms.Padding(6);
            this.numericKilometer.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericKilometer.Name = "numericKilometer";
            this.numericKilometer.Size = new System.Drawing.Size(161, 29);
            this.numericKilometer.TabIndex = 20;
            // 
            // numericMenge
            // 
            this.numericMenge.Location = new System.Drawing.Point(383, 46);
            this.numericMenge.Margin = new System.Windows.Forms.Padding(6);
            this.numericMenge.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericMenge.Name = "numericMenge";
            this.numericMenge.Size = new System.Drawing.Size(127, 29);
            this.numericMenge.TabIndex = 19;
            // 
            // dateTankDatum
            // 
            this.dateTankDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTankDatum.Location = new System.Drawing.Point(174, 46);
            this.dateTankDatum.Margin = new System.Windows.Forms.Padding(6);
            this.dateTankDatum.Name = "dateTankDatum";
            this.dateTankDatum.Size = new System.Drawing.Size(171, 29);
            this.dateTankDatum.TabIndex = 18;
            // 
            // numericBetrag
            // 
            this.numericBetrag.DecimalPlaces = 2;
            this.numericBetrag.Location = new System.Drawing.Point(22, 46);
            this.numericBetrag.Margin = new System.Windows.Forms.Padding(6);
            this.numericBetrag.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericBetrag.Name = "numericBetrag";
            this.numericBetrag.Size = new System.Drawing.Size(130, 29);
            this.numericBetrag.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Kilometerstand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Betrag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Menge [Liter]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Datum";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(437, 119);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(138, 42);
            this.buttonCancel.TabIndex = 22;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormTanken
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(733, 176);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.numericKilometer);
            this.Controls.Add(this.numericMenge);
            this.Controls.Add(this.dateTankDatum);
            this.Controls.Add(this.numericBetrag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormTanken";
            this.Text = "TankNeu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTanken_FormClosing);
            this.Load += new System.EventHandler(this.FormTanken_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericKilometer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMenge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBetrag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.NumericUpDown numericKilometer;
        private System.Windows.Forms.NumericUpDown numericMenge;
        private System.Windows.Forms.DateTimePicker dateTankDatum;
        private System.Windows.Forms.NumericUpDown numericBetrag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancel;
    }
}