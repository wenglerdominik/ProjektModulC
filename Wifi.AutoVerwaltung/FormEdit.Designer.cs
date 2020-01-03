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
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.pictureBoxBrand = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStripFlowPanel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bildLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDownLeistung = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDownWartung = new System.Windows.Forms.NumericUpDown();
            this.comboBoxFarbe = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelLeistungPS = new System.Windows.Forms.Label();
            this.textBoxKennz = new System.Windows.Forms.TextBox();
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
            this.contextMenuStripTabPage = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.comboBoxCarModel = new System.Windows.Forms.ComboBox();
            this.tabControlAutoInfo.SuspendLayout();
            this.tabPageAllgemein.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrand)).BeginInit();
            this.contextMenuStripFlowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeistung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWartung)).BeginInit();
            this.tabPageKosten.SuspendLayout();
            this.contextMenuStripTabPage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPageTank.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAutoInfo
            // 
            this.tabControlAutoInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlAutoInfo.Controls.Add(this.tabPageAllgemein);
            this.tabControlAutoInfo.Controls.Add(this.tabPageKosten);
            this.tabControlAutoInfo.Controls.Add(this.tabPageTank);
            this.tabControlAutoInfo.Location = new System.Drawing.Point(12, 11);
            this.tabControlAutoInfo.Name = "tabControlAutoInfo";
            this.tabControlAutoInfo.SelectedIndex = 0;
            this.tabControlAutoInfo.Size = new System.Drawing.Size(823, 371);
            this.tabControlAutoInfo.TabIndex = 1;
            // 
            // tabPageAllgemein
            // 
            this.tabPageAllgemein.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tabPageAllgemein.Controls.Add(this.comboBoxCarModel);
            this.tabPageAllgemein.Controls.Add(this.comboBoxBrand);
            this.tabPageAllgemein.Controls.Add(this.pictureBoxBrand);
            this.tabPageAllgemein.Controls.Add(this.flowLayoutPanel1);
            this.tabPageAllgemein.Controls.Add(this.numericUpDownLeistung);
            this.tabPageAllgemein.Controls.Add(this.label14);
            this.tabPageAllgemein.Controls.Add(this.numericUpDownWartung);
            this.tabPageAllgemein.Controls.Add(this.comboBoxFarbe);
            this.tabPageAllgemein.Controls.Add(this.dateTimePicker1);
            this.tabPageAllgemein.Controls.Add(this.labelLeistungPS);
            this.tabPageAllgemein.Controls.Add(this.textBoxKennz);
            this.tabPageAllgemein.Controls.Add(this.label8);
            this.tabPageAllgemein.Controls.Add(this.label7);
            this.tabPageAllgemein.Controls.Add(this.label6);
            this.tabPageAllgemein.Controls.Add(this.label5);
            this.tabPageAllgemein.Controls.Add(this.label4);
            this.tabPageAllgemein.Controls.Add(this.label3);
            this.tabPageAllgemein.Controls.Add(this.label2);
            this.tabPageAllgemein.Location = new System.Drawing.Point(4, 22);
            this.tabPageAllgemein.Name = "tabPageAllgemein";
            this.tabPageAllgemein.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAllgemein.Size = new System.Drawing.Size(815, 345);
            this.tabPageAllgemein.TabIndex = 0;
            this.tabPageAllgemein.Text = "Allgemeine Daten";
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxBrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(113, 25);
            this.comboBoxBrand.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(184, 21);
            this.comboBoxBrand.TabIndex = 26;
            this.comboBoxBrand.TextChanged += new System.EventHandler(this.comboBoxBrand_TextChanged);
            // 
            // pictureBoxBrand
            // 
            this.pictureBoxBrand.Location = new System.Drawing.Point(341, 25);
            this.pictureBoxBrand.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxBrand.Name = "pictureBoxBrand";
            this.pictureBoxBrand.Size = new System.Drawing.Size(138, 112);
            this.pictureBoxBrand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBrand.TabIndex = 25;
            this.pictureBoxBrand.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.ContextMenuStrip = this.contextMenuStripFlowPanel;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 204);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(795, 135);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // contextMenuStripFlowPanel
            // 
            this.contextMenuStripFlowPanel.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStripFlowPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bildLöschenToolStripMenuItem});
            this.contextMenuStripFlowPanel.Name = "contextMenuStripFlowPanel";
            this.contextMenuStripFlowPanel.Size = new System.Drawing.Size(139, 26);
            // 
            // bildLöschenToolStripMenuItem
            // 
            this.bildLöschenToolStripMenuItem.Name = "bildLöschenToolStripMenuItem";
            this.bildLöschenToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.bildLöschenToolStripMenuItem.Text = "Bild löschen";
            this.bildLöschenToolStripMenuItem.Click += new System.EventHandler(this.bildLöschenToolStripMenuItem_Click);
            // 
            // numericUpDownLeistung
            // 
            this.numericUpDownLeistung.Location = new System.Drawing.Point(113, 96);
            this.numericUpDownLeistung.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownLeistung.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownLeistung.Name = "numericUpDownLeistung";
            this.numericUpDownLeistung.Size = new System.Drawing.Size(85, 20);
            this.numericUpDownLeistung.TabIndex = 3;
            this.numericUpDownLeistung.ValueChanged += new System.EventHandler(this.numericLeistungChanged_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(210, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "x1000 km";
            // 
            // numericUpDownWartung
            // 
            this.numericUpDownWartung.Location = new System.Drawing.Point(113, 145);
            this.numericUpDownWartung.Name = "numericUpDownWartung";
            this.numericUpDownWartung.Size = new System.Drawing.Size(85, 20);
            this.numericUpDownWartung.TabIndex = 5;
            // 
            // comboBoxFarbe
            // 
            this.comboBoxFarbe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxFarbe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxFarbe.FormattingEnabled = true;
            this.comboBoxFarbe.Items.AddRange(new object[] {
            "Blau",
            "Grau",
            "Grün",
            "Gelb",
            "Rot",
            "Schwarz",
            "Weiß"});
            this.comboBoxFarbe.Location = new System.Drawing.Point(113, 120);
            this.comboBoxFarbe.Name = "comboBoxFarbe";
            this.comboBoxFarbe.Size = new System.Drawing.Size(184, 21);
            this.comboBoxFarbe.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 74);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(87, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // labelLeistungPS
            // 
            this.labelLeistungPS.AutoSize = true;
            this.labelLeistungPS.Location = new System.Drawing.Point(207, 100);
            this.labelLeistungPS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLeistungPS.Name = "labelLeistungPS";
            this.labelLeistungPS.Size = new System.Drawing.Size(21, 13);
            this.labelLeistungPS.TabIndex = 14;
            this.labelLeistungPS.Text = "PS";
            // 
            // textBoxKennz
            // 
            this.textBoxKennz.Location = new System.Drawing.Point(113, 170);
            this.textBoxKennz.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKennz.Name = "textBoxKennz";
            this.textBoxKennz.Size = new System.Drawing.Size(184, 20);
            this.textBoxKennz.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 147);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Wartungsintervall";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Farbe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Leistung (kW)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Erstzulassung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kennzeichen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Modell";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marke";
            // 
            // tabPageKosten
            // 
            this.tabPageKosten.BackColor = System.Drawing.Color.Transparent;
            this.tabPageKosten.Controls.Add(this.listViewAllgKosten);
            this.tabPageKosten.Controls.Add(this.menuStrip1);
            this.tabPageKosten.Location = new System.Drawing.Point(4, 22);
            this.tabPageKosten.Name = "tabPageKosten";
            this.tabPageKosten.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKosten.Size = new System.Drawing.Size(815, 345);
            this.tabPageKosten.TabIndex = 1;
            this.tabPageKosten.Text = "Fahrzeugkosten";
            // 
            // listViewAllgKosten
            // 
            this.listViewAllgKosten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewAllgKosten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.listViewAllgKosten.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnKategorie,
            this.columnDatumAllg,
            this.columnKostenAllg,
            this.columnKilometerAllg,
            this.columnZahlweise,
            this.columnBemerkung});
            this.listViewAllgKosten.ContextMenuStrip = this.contextMenuStripTabPage;
            this.listViewAllgKosten.FullRowSelect = true;
            this.listViewAllgKosten.HideSelection = false;
            this.listViewAllgKosten.Location = new System.Drawing.Point(0, 30);
            this.listViewAllgKosten.Name = "listViewAllgKosten";
            this.listViewAllgKosten.Size = new System.Drawing.Size(815, 319);
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
            // contextMenuStripTabPage
            // 
            this.contextMenuStripTabPage.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStripTabPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.löschenToolStripMenuItem});
            this.contextMenuStripTabPage.Name = "contextMenuStrip1";
            this.contextMenuStripTabPage.Size = new System.Drawing.Size(119, 26);
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.löschenToolStripMenuItem.Text = "Löschen";
            this.löschenToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripNeueRechnung});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(809, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStripNeueRechnung
            // 
            this.menuStripNeueRechnung.Image = ((System.Drawing.Image)(resources.GetObject("menuStripNeueRechnung.Image")));
            this.menuStripNeueRechnung.Name = "menuStripNeueRechnung";
            this.menuStripNeueRechnung.Size = new System.Drawing.Size(124, 24);
            this.menuStripNeueRechnung.Text = "Neue Rechnung";
            this.menuStripNeueRechnung.Click += new System.EventHandler(this.neueKostenstelleToolStripMenuItem_Click);
            // 
            // tabPageTank
            // 
            this.tabPageTank.Controls.Add(this.listViewTankKosten);
            this.tabPageTank.Controls.Add(this.menuStrip2);
            this.tabPageTank.Location = new System.Drawing.Point(4, 22);
            this.tabPageTank.Name = "tabPageTank";
            this.tabPageTank.Size = new System.Drawing.Size(815, 345);
            this.tabPageTank.TabIndex = 2;
            this.tabPageTank.Text = "Tankkosten";
            this.tabPageTank.UseVisualStyleBackColor = true;
            // 
            // listViewTankKosten
            // 
            this.listViewTankKosten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTankKosten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.listViewTankKosten.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnBetrag,
            this.columnDatum,
            this.columnMenge,
            this.columnKilometer,
            this.columnStreckeGefahren,
            this.columnVerbrauch});
            this.listViewTankKosten.ContextMenuStrip = this.contextMenuStripTabPage;
            this.listViewTankKosten.FullRowSelect = true;
            this.listViewTankKosten.HideSelection = false;
            this.listViewTankKosten.Location = new System.Drawing.Point(0, 30);
            this.listViewTankKosten.Name = "listViewTankKosten";
            this.listViewTankKosten.Size = new System.Drawing.Size(815, 319);
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
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neueTankrechnungToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(815, 28);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // neueTankrechnungToolStripMenuItem
            // 
            this.neueTankrechnungToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("neueTankrechnungToolStripMenuItem.Image")));
            this.neueTankrechnungToolStripMenuItem.Name = "neueTankrechnungToolStripMenuItem";
            this.neueTankrechnungToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.neueTankrechnungToolStripMenuItem.Text = "Neue Tankrechnung";
            this.neueTankrechnungToolStripMenuItem.Click += new System.EventHandler(this.neueTankrechnungToolStripMenuItem_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(763, 392);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(681, 392);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxCarModel
            // 
            this.comboBoxCarModel.FormattingEnabled = true;
            this.comboBoxCarModel.Location = new System.Drawing.Point(113, 50);
            this.comboBoxCarModel.Name = "comboBoxCarModel";
            this.comboBoxCarModel.Size = new System.Drawing.Size(183, 21);
            this.comboBoxCarModel.TabIndex = 28;
            // 
            // FormEdit
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(134)))));
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(845, 423);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.tabControlAutoInfo);
            this.MinimumSize = new System.Drawing.Size(758, 384);
            this.Name = "FormEdit";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Erfassen und Ändern";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEdit_FormClosing);
            this.Load += new System.EventHandler(this.FormEdit_Load);
            this.tabControlAutoInfo.ResumeLayout(false);
            this.tabPageAllgemein.ResumeLayout(false);
            this.tabPageAllgemein.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrand)).EndInit();
            this.contextMenuStripFlowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeistung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWartung)).EndInit();
            this.tabPageKosten.ResumeLayout(false);
            this.tabPageKosten.PerformLayout();
            this.contextMenuStripTabPage.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTabPage;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFlowPanel;
        private System.Windows.Forms.ToolStripMenuItem bildLöschenToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.PictureBox pictureBoxBrand;
        private System.Windows.Forms.ComboBox comboBoxCarModel;
    }
}