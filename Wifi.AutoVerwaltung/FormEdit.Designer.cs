namespace Wifi.AutoVerwaltung
{
	partial class FormEdit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEdit));
            this.tabControlAutoInfo = new System.Windows.Forms.TabControl();
            this.tabPageAllgemein = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.numericUpDownLeistung = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDownWartung = new System.Windows.Forms.NumericUpDown();
            this.comboBoxFarbe = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelLeistungPS = new System.Windows.Forms.Label();
            this.textBoxKennz = new System.Windows.Forms.TextBox();
            this.textBoxModell = new System.Windows.Forms.TextBox();
            this.textBoxMarke = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageKosten = new System.Windows.Forms.TabPage();
            this.listViewAllgKosten = new System.Windows.Forms.ListView();
            this.columnKategorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDatumAllg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKostenAllg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKilometerAllg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnZahlweise = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBemerkung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStripNeueRechnung = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageTank = new System.Windows.Forms.TabPage();
            this.listViewTankKosten = new System.Windows.Forms.ListView();
            this.columnBetrag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMenge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKilometer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStreckeGefahren = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVerbrauch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.neueTankrechnungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControlAutoInfo.SuspendLayout();
            this.tabPageAllgemein.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeistung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWartung)).BeginInit();
            this.tabPageKosten.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPageTank.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAutoInfo
            // 
            this.tabControlAutoInfo.Controls.Add(this.tabPageAllgemein);
            this.tabControlAutoInfo.Controls.Add(this.tabPageKosten);
            this.tabControlAutoInfo.Controls.Add(this.tabPageTank);
            this.tabControlAutoInfo.Location = new System.Drawing.Point(24, 21);
            this.tabControlAutoInfo.Margin = new System.Windows.Forms.Padding(6);
            this.tabControlAutoInfo.Name = "tabControlAutoInfo";
            this.tabControlAutoInfo.SelectedIndex = 0;
            this.tabControlAutoInfo.Size = new System.Drawing.Size(1646, 713);
            this.tabControlAutoInfo.TabIndex = 1;
            // 
            // tabPageAllgemein
            // 
            this.tabPageAllgemein.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.tabPageAllgemein.Controls.Add(this.label1);
            this.tabPageAllgemein.Controls.Add(this.pictureBoxCar);
            this.tabPageAllgemein.Controls.Add(this.numericUpDownLeistung);
            this.tabPageAllgemein.Controls.Add(this.label14);
            this.tabPageAllgemein.Controls.Add(this.numericUpDownWartung);
            this.tabPageAllgemein.Controls.Add(this.comboBoxFarbe);
            this.tabPageAllgemein.Controls.Add(this.dateTimePicker1);
            this.tabPageAllgemein.Controls.Add(this.labelLeistungPS);
            this.tabPageAllgemein.Controls.Add(this.textBoxKennz);
            this.tabPageAllgemein.Controls.Add(this.textBoxModell);
            this.tabPageAllgemein.Controls.Add(this.textBoxMarke);
            this.tabPageAllgemein.Controls.Add(this.label8);
            this.tabPageAllgemein.Controls.Add(this.label7);
            this.tabPageAllgemein.Controls.Add(this.label6);
            this.tabPageAllgemein.Controls.Add(this.label5);
            this.tabPageAllgemein.Controls.Add(this.label4);
            this.tabPageAllgemein.Controls.Add(this.label3);
            this.tabPageAllgemein.Controls.Add(this.label2);
            this.tabPageAllgemein.Location = new System.Drawing.Point(8, 39);
            this.tabPageAllgemein.Margin = new System.Windows.Forms.Padding(6);
            this.tabPageAllgemein.Name = "tabPageAllgemein";
            this.tabPageAllgemein.Padding = new System.Windows.Forms.Padding(6);
            this.tabPageAllgemein.Size = new System.Drawing.Size(1630, 666);
            this.tabPageAllgemein.TabIndex = 0;
            this.tabPageAllgemein.Text = "Allgemeine Daten";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(692, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Bild hinzufügen";
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCar.Image")));
            this.pictureBoxCar.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCar.InitialImage")));
            this.pictureBoxCar.Location = new System.Drawing.Point(697, 73);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(458, 379);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCar.TabIndex = 21;
            this.pictureBoxCar.TabStop = false;
            this.pictureBoxCar.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBoxCar_DragDrop);
            this.pictureBoxCar.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBoxCar_DragEnter);
            this.pictureBoxCar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCar_MouseDoubleClick);
            // 
            // numericUpDownLeistung
            // 
            this.numericUpDownLeistung.Location = new System.Drawing.Point(226, 163);
            this.numericUpDownLeistung.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownLeistung.Name = "numericUpDownLeistung";
            this.numericUpDownLeistung.Size = new System.Drawing.Size(170, 31);
            this.numericUpDownLeistung.TabIndex = 20;
            this.numericUpDownLeistung.ValueChanged += new System.EventHandler(this.numericLeistungChanged_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(420, 263);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 25);
            this.label14.TabIndex = 18;
            this.label14.Text = "x1000 km";
            // 
            // numericUpDownWartung
            // 
            this.numericUpDownWartung.Location = new System.Drawing.Point(226, 256);
            this.numericUpDownWartung.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDownWartung.Name = "numericUpDownWartung";
            this.numericUpDownWartung.Size = new System.Drawing.Size(170, 31);
            this.numericUpDownWartung.TabIndex = 17;
            // 
            // comboBoxFarbe
            // 
            this.comboBoxFarbe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFarbe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxFarbe.FormattingEnabled = true;
            this.comboBoxFarbe.Items.AddRange(new object[] {
            "Blau",
            "Grau",
            "Grün",
            "Gelb",
            "Rot",
            "Schwarz",
            "Weiß"});
            this.comboBoxFarbe.Location = new System.Drawing.Point(226, 208);
            this.comboBoxFarbe.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxFarbe.Name = "comboBoxFarbe";
            this.comboBoxFarbe.Size = new System.Drawing.Size(364, 33);
            this.comboBoxFarbe.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(226, 119);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(364, 31);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // labelLeistungPS
            // 
            this.labelLeistungPS.AutoSize = true;
            this.labelLeistungPS.Location = new System.Drawing.Point(414, 169);
            this.labelLeistungPS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLeistungPS.Name = "labelLeistungPS";
            this.labelLeistungPS.Size = new System.Drawing.Size(40, 25);
            this.labelLeistungPS.TabIndex = 14;
            this.labelLeistungPS.Text = "PS";
            // 
            // textBoxKennz
            // 
            this.textBoxKennz.Location = new System.Drawing.Point(226, 304);
            this.textBoxKennz.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKennz.Name = "textBoxKennz";
            this.textBoxKennz.Size = new System.Drawing.Size(364, 31);
            this.textBoxKennz.TabIndex = 13;
            // 
            // textBoxModell
            // 
            this.textBoxModell.Location = new System.Drawing.Point(226, 73);
            this.textBoxModell.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxModell.Name = "textBoxModell";
            this.textBoxModell.Size = new System.Drawing.Size(364, 31);
            this.textBoxModell.TabIndex = 8;
            // 
            // textBoxMarke
            // 
            this.textBoxMarke.Location = new System.Drawing.Point(226, 29);
            this.textBoxMarke.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMarke.Name = "textBoxMarke";
            this.textBoxMarke.Size = new System.Drawing.Size(364, 31);
            this.textBoxMarke.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 260);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Wartungsintervall";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 213);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Farbe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Leistung (kW)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Erstzulassung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 308);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kennzeichen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Modell";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marke";
            // 
            // tabPageKosten
            // 
            this.tabPageKosten.BackColor = System.Drawing.Color.Transparent;
            this.tabPageKosten.Controls.Add(this.listViewAllgKosten);
            this.tabPageKosten.Controls.Add(this.menuStrip1);
            this.tabPageKosten.Location = new System.Drawing.Point(8, 39);
            this.tabPageKosten.Margin = new System.Windows.Forms.Padding(6);
            this.tabPageKosten.Name = "tabPageKosten";
            this.tabPageKosten.Padding = new System.Windows.Forms.Padding(6);
            this.tabPageKosten.Size = new System.Drawing.Size(1630, 666);
            this.tabPageKosten.TabIndex = 1;
            this.tabPageKosten.Text = "Fahrzeugkosten";
            // 
            // listViewAllgKosten
            // 
            this.listViewAllgKosten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.listViewAllgKosten.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnKategorie,
            this.columnDatumAllg,
            this.columnKostenAllg,
            this.columnKilometerAllg,
            this.columnZahlweise,
            this.columnBemerkung});
            this.listViewAllgKosten.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewAllgKosten.FullRowSelect = true;
            this.listViewAllgKosten.HideSelection = false;
            this.listViewAllgKosten.Location = new System.Drawing.Point(0, 58);
            this.listViewAllgKosten.Margin = new System.Windows.Forms.Padding(6);
            this.listViewAllgKosten.Name = "listViewAllgKosten";
            this.listViewAllgKosten.Size = new System.Drawing.Size(1626, 610);
            this.listViewAllgKosten.TabIndex = 8;
            this.listViewAllgKosten.UseCompatibleStateImageBehavior = false;
            this.listViewAllgKosten.View = System.Windows.Forms.View.Details;
            this.listViewAllgKosten.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewAllgKosten_MouseDoubleClick);
            // 
            // columnKategorie
            // 
            this.columnKategorie.Text = "Art (z.B. Leasingrate)";
            this.columnKategorie.Width = 120;
            // 
            // columnDatumAllg
            // 
            this.columnDatumAllg.Text = "Datum";
            this.columnDatumAllg.Width = 100;
            // 
            // columnKostenAllg
            // 
            this.columnKostenAllg.Text = "Betrag €";
            this.columnKostenAllg.Width = 100;
            // 
            // columnKilometerAllg
            // 
            this.columnKilometerAllg.Text = "Kilometerstand";
            this.columnKilometerAllg.Width = 100;
            // 
            // columnZahlweise
            // 
            this.columnZahlweise.Text = "Zahlungsweise";
            this.columnZahlweise.Width = 100;
            // 
            // columnBemerkung
            // 
            this.columnBemerkung.Text = "Bemerkung";
            this.columnBemerkung.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.löschenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(178, 42);
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(177, 38);
            this.löschenToolStripMenuItem.Text = "Löschen";
            this.löschenToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripNeueRechnung});
            this.menuStrip1.Location = new System.Drawing.Point(6, 6);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1618, 44);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStripNeueRechnung
            // 
            this.menuStripNeueRechnung.Image = ((System.Drawing.Image)(resources.GetObject("menuStripNeueRechnung.Image")));
            this.menuStripNeueRechnung.Name = "menuStripNeueRechnung";
            this.menuStripNeueRechnung.Size = new System.Drawing.Size(227, 36);
            this.menuStripNeueRechnung.Text = "Neue Rechnung";
            this.menuStripNeueRechnung.Click += new System.EventHandler(this.neueKostenstelleToolStripMenuItem_Click);
            // 
            // tabPageTank
            // 
            this.tabPageTank.Controls.Add(this.listViewTankKosten);
            this.tabPageTank.Controls.Add(this.menuStrip2);
            this.tabPageTank.Location = new System.Drawing.Point(8, 39);
            this.tabPageTank.Margin = new System.Windows.Forms.Padding(6);
            this.tabPageTank.Name = "tabPageTank";
            this.tabPageTank.Size = new System.Drawing.Size(1630, 666);
            this.tabPageTank.TabIndex = 2;
            this.tabPageTank.Text = "Tankkosten";
            this.tabPageTank.UseVisualStyleBackColor = true;
            // 
            // listViewTankKosten
            // 
            this.listViewTankKosten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.listViewTankKosten.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnBetrag,
            this.columnDatum,
            this.columnMenge,
            this.columnKilometer,
            this.columnStreckeGefahren,
            this.columnVerbrauch});
            this.listViewTankKosten.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewTankKosten.FullRowSelect = true;
            this.listViewTankKosten.HideSelection = false;
            this.listViewTankKosten.Location = new System.Drawing.Point(0, 52);
            this.listViewTankKosten.Margin = new System.Windows.Forms.Padding(6);
            this.listViewTankKosten.Name = "listViewTankKosten";
            this.listViewTankKosten.Size = new System.Drawing.Size(1626, 608);
            this.listViewTankKosten.TabIndex = 1;
            this.listViewTankKosten.UseCompatibleStateImageBehavior = false;
            this.listViewTankKosten.View = System.Windows.Forms.View.Details;
            this.listViewTankKosten.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewTankKosten_MouseDoubleClick);
            // 
            // columnBetrag
            // 
            this.columnBetrag.Text = "Betrag";
            this.columnBetrag.Width = 100;
            // 
            // columnDatum
            // 
            this.columnDatum.Text = "Datum";
            this.columnDatum.Width = 100;
            // 
            // columnMenge
            // 
            this.columnMenge.Text = "Menge [Liter]";
            this.columnMenge.Width = 100;
            // 
            // columnKilometer
            // 
            this.columnKilometer.Text = "Kilometerstand";
            this.columnKilometer.Width = 100;
            // 
            // columnStreckeGefahren
            // 
            this.columnStreckeGefahren.Text = "Gefahrene km seit Tankung";
            this.columnStreckeGefahren.Width = 150;
            // 
            // columnVerbrauch
            // 
            this.columnVerbrauch.Text = "Verbrauch [l/100km]";
            this.columnVerbrauch.Width = 120;
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neueTankrechnungToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1630, 40);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // neueTankrechnungToolStripMenuItem
            // 
            this.neueTankrechnungToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("neueTankrechnungToolStripMenuItem.Image")));
            this.neueTankrechnungToolStripMenuItem.Name = "neueTankrechnungToolStripMenuItem";
            this.neueTankrechnungToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.neueTankrechnungToolStripMenuItem.Text = "Neue Tankrechnung";
            this.neueTankrechnungToolStripMenuItem.Click += new System.EventHandler(this.neueTankrechnungToolStripMenuItem_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(1525, 753);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(6);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(150, 44);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(1363, 753);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(150, 44);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormEdit
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(1690, 812);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.tabControlAutoInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1500, 700);
            this.Name = "FormEdit";
            this.Text = "Erfassen und Ändern";
            this.tabControlAutoInfo.ResumeLayout(false);
            this.tabPageAllgemein.ResumeLayout(false);
            this.tabPageAllgemein.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeistung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWartung)).EndInit();
            this.tabPageKosten.ResumeLayout(false);
            this.tabPageKosten.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPageTank.ResumeLayout(false);
            this.tabPageTank.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabControl tabControlAutoInfo;
		private System.Windows.Forms.TabPage tabPageAllgemein;
		private System.Windows.Forms.TabPage tabPageKosten;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxKennz;
        private System.Windows.Forms.TextBox textBoxModell;
        private System.Windows.Forms.TextBox textBoxMarke;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLeistungPS;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStripNeueRechnung;
        private System.Windows.Forms.ComboBox comboBoxFarbe;
        private System.Windows.Forms.NumericUpDown numericUpDownWartung;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPageTank;
        private System.Windows.Forms.ListView listViewTankKosten;
        private System.Windows.Forms.ColumnHeader columnBetrag;
        private System.Windows.Forms.ColumnHeader columnDatum;
        private System.Windows.Forms.ColumnHeader columnMenge;
        private System.Windows.Forms.ColumnHeader columnKilometer;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem neueTankrechnungToolStripMenuItem;
        private System.Windows.Forms.ListView listViewAllgKosten;
        private System.Windows.Forms.ColumnHeader columnKategorie;
        private System.Windows.Forms.ColumnHeader columnDatumAllg;
        private System.Windows.Forms.ColumnHeader columnKostenAllg;
        private System.Windows.Forms.ColumnHeader columnKilometerAllg;
        private System.Windows.Forms.ColumnHeader columnZahlweise;
        private System.Windows.Forms.ColumnHeader columnBemerkung;
        private System.Windows.Forms.ColumnHeader columnStreckeGefahren;
        private System.Windows.Forms.ColumnHeader columnVerbrauch;
        private System.Windows.Forms.NumericUpDown numericUpDownLeistung;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}