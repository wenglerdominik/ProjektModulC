﻿namespace Wifi.AutoVerwaltung
{
    partial class FormKostenstelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKostenstelle));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.numericKilometer = new System.Windows.Forms.NumericUpDown();
            this.dateKostenDatum = new System.Windows.Forms.DateTimePicker();
            this.numericBetrag = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxZahlweise = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBemerkung = new System.Windows.Forms.TextBox();
            this.comboBoxKategorie = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericKilometer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBetrag)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(810, 62);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 27);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(901, 62);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(87, 27);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // numericKilometer
            // 
            this.numericKilometer.Location = new System.Drawing.Point(437, 29);
            this.numericKilometer.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericKilometer.Name = "numericKilometer";
            this.numericKilometer.Size = new System.Drawing.Size(103, 23);
            this.numericKilometer.TabIndex = 3;
            // 
            // dateKostenDatum
            // 
            this.dateKostenDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateKostenDatum.Location = new System.Drawing.Point(244, 27);
            this.dateKostenDatum.Name = "dateKostenDatum";
            this.dateKostenDatum.Size = new System.Drawing.Size(87, 23);
            this.dateKostenDatum.TabIndex = 1;
            // 
            // numericBetrag
            // 
            this.numericBetrag.DecimalPlaces = 2;
            this.numericBetrag.Location = new System.Drawing.Point(344, 27);
            this.numericBetrag.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericBetrag.Name = "numericBetrag";
            this.numericBetrag.Size = new System.Drawing.Size(83, 23);
            this.numericBetrag.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Kilometerstand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Betrag €";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Zahlungsweise";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Datum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "Kategorie (z.B Leasingrate)";
            // 
            // comboBoxZahlweise
            // 
            this.comboBoxZahlweise.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxZahlweise.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxZahlweise.FormattingEnabled = true;
            this.comboBoxZahlweise.Items.AddRange(new object[] {
            "Täglich",
            "Wöchentlich",
            "Monatlich",
            "Halbjährlich",
            "Jährlicht",
            "Einmalig"});
            this.comboBoxZahlweise.Location = new System.Drawing.Point(552, 28);
            this.comboBoxZahlweise.Name = "comboBoxZahlweise";
            this.comboBoxZahlweise.Size = new System.Drawing.Size(117, 23);
            this.comboBoxZahlweise.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(681, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "Bemerkung";
            // 
            // textBoxBemerkung
            // 
            this.textBoxBemerkung.Location = new System.Drawing.Point(681, 28);
            this.textBoxBemerkung.Name = "textBoxBemerkung";
            this.textBoxBemerkung.Size = new System.Drawing.Size(306, 23);
            this.textBoxBemerkung.TabIndex = 5;
            // 
            // comboBoxKategorie
            // 
            this.comboBoxKategorie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxKategorie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxKategorie.FormattingEnabled = true;
            this.comboBoxKategorie.Items.AddRange(new object[] {
            "Versicherung",
            "Leasingrate",
            "Service",
            "Reparatur",
            "Reifen"});
            this.comboBoxKategorie.Location = new System.Drawing.Point(17, 27);
            this.comboBoxKategorie.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxKategorie.Name = "comboBoxKategorie";
            this.comboBoxKategorie.Size = new System.Drawing.Size(217, 23);
            this.comboBoxKategorie.TabIndex = 0;
            // 
            // FormKostenstelle
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(999, 98);
            this.Controls.Add(this.comboBoxKategorie);
            this.Controls.Add(this.textBoxBemerkung);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxZahlweise);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.numericKilometer);
            this.Controls.Add(this.dateKostenDatum);
            this.Controls.Add(this.numericBetrag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormKostenstelle";
            this.Text = "Fahrzeugkosten anlegen/bearbeiten";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormKostenstelle_FormClosing);
            this.Load += new System.EventHandler(this.FormKostenstelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericKilometer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBetrag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.NumericUpDown numericKilometer;
        private System.Windows.Forms.DateTimePicker dateKostenDatum;
        private System.Windows.Forms.NumericUpDown numericBetrag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxZahlweise;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBemerkung;
        private System.Windows.Forms.ComboBox comboBoxKategorie;
    }
}