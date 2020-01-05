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
            this.contextMenuStripFlowPanel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bildLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripTabPage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
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
            this.tabPageKosten = new System.Windows.Forms.TabPage();
            this.listViewAllgKosten = new System.Windows.Forms.ListView();
            this.columnKategorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKostenAllg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDatumAllg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKilometerAllg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnZahlweise = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBemerkung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStripNeueRechnung = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageAllgemein = new System.Windows.Forms.TabPage();
            this.groupBoxPicture = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxKfzData = new System.Windows.Forms.GroupBox();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.comboBoxCarModel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownLeistung = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownWartung = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxFarbe = new System.Windows.Forms.ComboBox();
            this.textBoxKennz = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelLeistungPS = new System.Windows.Forms.Label();
            this.pictureBoxBrand = new System.Windows.Forms.PictureBox();
            this.tabControlAutoInfo = new System.Windows.Forms.TabControl();
            this.toolTipCarModel = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStripFlowPanel.SuspendLayout();
            this.contextMenuStripTabPage.SuspendLayout();
            this.tabPageTank.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.tabPageKosten.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPageAllgemein.SuspendLayout();
            this.groupBoxPicture.SuspendLayout();
            this.groupBoxKfzData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeistung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWartung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrand)).BeginInit();
            this.tabControlAutoInfo.SuspendLayout();
            this.SuspendLayout();
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
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.Location = new System.Drawing.Point(752, 532);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(86, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Speichern";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(662, 532);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(85, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // tabPageTank
            // 
            this.tabPageTank.Controls.Add(this.listViewTankKosten);
            this.tabPageTank.Controls.Add(this.menuStrip2);
            this.tabPageTank.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageTank.Location = new System.Drawing.Point(4, 24);
            this.tabPageTank.Name = "tabPageTank";
            this.tabPageTank.Size = new System.Drawing.Size(823, 492);
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
            this.listViewTankKosten.Size = new System.Drawing.Size(823, 468);
            this.listViewTankKosten.TabIndex = 1;
            this.listViewTankKosten.UseCompatibleStateImageBehavior = false;
            this.listViewTankKosten.View = System.Windows.Forms.View.Details;
            this.listViewTankKosten.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewTankKosten_MouseDoubleClick);
            // 
            // columnBetrag
            // 
            this.columnBetrag.Text = "Betrag €";
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
            this.menuStrip2.Size = new System.Drawing.Size(823, 28);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // neueTankrechnungToolStripMenuItem
            // 
            this.neueTankrechnungToolStripMenuItem.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neueTankrechnungToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("neueTankrechnungToolStripMenuItem.Image")));
            this.neueTankrechnungToolStripMenuItem.Name = "neueTankrechnungToolStripMenuItem";
            this.neueTankrechnungToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.neueTankrechnungToolStripMenuItem.Text = "Neue Tankrechnung";
            this.neueTankrechnungToolStripMenuItem.Click += new System.EventHandler(this.neueTankrechnungToolStripMenuItem_Click);
            // 
            // tabPageKosten
            // 
            this.tabPageKosten.BackColor = System.Drawing.Color.Transparent;
            this.tabPageKosten.Controls.Add(this.listViewAllgKosten);
            this.tabPageKosten.Controls.Add(this.menuStrip1);
            this.tabPageKosten.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageKosten.Location = new System.Drawing.Point(4, 24);
            this.tabPageKosten.Name = "tabPageKosten";
            this.tabPageKosten.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKosten.Size = new System.Drawing.Size(823, 492);
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
            this.columnKostenAllg,
            this.columnDatumAllg,
            this.columnKilometerAllg,
            this.columnZahlweise,
            this.columnBemerkung});
            this.listViewAllgKosten.ContextMenuStrip = this.contextMenuStripTabPage;
            this.listViewAllgKosten.FullRowSelect = true;
            this.listViewAllgKosten.HideSelection = false;
            this.listViewAllgKosten.Location = new System.Drawing.Point(0, 30);
            this.listViewAllgKosten.Name = "listViewAllgKosten";
            this.listViewAllgKosten.Size = new System.Drawing.Size(823, 468);
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
            // columnKostenAllg
            // 
            this.columnKostenAllg.Text = "Betrag €";
            this.columnKostenAllg.Width = 100;
            // 
            // columnDatumAllg
            // 
            this.columnDatumAllg.Text = "Datum";
            this.columnDatumAllg.Width = 100;
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripNeueRechnung});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(817, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStripNeueRechnung
            // 
            this.menuStripNeueRechnung.Checked = true;
            this.menuStripNeueRechnung.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.menuStripNeueRechnung.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripNeueRechnung.Image = ((System.Drawing.Image)(resources.GetObject("menuStripNeueRechnung.Image")));
            this.menuStripNeueRechnung.Name = "menuStripNeueRechnung";
            this.menuStripNeueRechnung.Size = new System.Drawing.Size(142, 24);
            this.menuStripNeueRechnung.Text = "Neue Rechnung";
            this.menuStripNeueRechnung.Click += new System.EventHandler(this.neueKostenstelleToolStripMenuItem_Click);
            // 
            // tabPageAllgemein
            // 
            this.tabPageAllgemein.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tabPageAllgemein.Controls.Add(this.groupBoxPicture);
            this.tabPageAllgemein.Controls.Add(this.groupBoxKfzData);
            this.tabPageAllgemein.Controls.Add(this.pictureBoxBrand);
            this.tabPageAllgemein.Location = new System.Drawing.Point(4, 24);
            this.tabPageAllgemein.Name = "tabPageAllgemein";
            this.tabPageAllgemein.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAllgemein.Size = new System.Drawing.Size(823, 492);
            this.tabPageAllgemein.TabIndex = 0;
            this.tabPageAllgemein.Text = "Allgemeine Daten";
            // 
            // groupBoxPicture
            // 
            this.groupBoxPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPicture.AutoSize = true;
            this.groupBoxPicture.Controls.Add(this.flowLayoutPanel1);
            this.groupBoxPicture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxPicture.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPicture.Location = new System.Drawing.Point(12, 216);
            this.groupBoxPicture.Name = "groupBoxPicture";
            this.groupBoxPicture.Size = new System.Drawing.Size(804, 271);
            this.groupBoxPicture.TabIndex = 30;
            this.groupBoxPicture.TabStop = false;
            this.groupBoxPicture.Text = "Fahrzeugbilder";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.ContextMenuStrip = this.contextMenuStripFlowPanel;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(798, 0);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // groupBoxKfzData
            // 
            this.groupBoxKfzData.Controls.Add(this.comboBoxBrand);
            this.groupBoxKfzData.Controls.Add(this.comboBoxCarModel);
            this.groupBoxKfzData.Controls.Add(this.label2);
            this.groupBoxKfzData.Controls.Add(this.label3);
            this.groupBoxKfzData.Controls.Add(this.label4);
            this.groupBoxKfzData.Controls.Add(this.label5);
            this.groupBoxKfzData.Controls.Add(this.numericUpDownLeistung);
            this.groupBoxKfzData.Controls.Add(this.label6);
            this.groupBoxKfzData.Controls.Add(this.label14);
            this.groupBoxKfzData.Controls.Add(this.label7);
            this.groupBoxKfzData.Controls.Add(this.numericUpDownWartung);
            this.groupBoxKfzData.Controls.Add(this.label8);
            this.groupBoxKfzData.Controls.Add(this.comboBoxFarbe);
            this.groupBoxKfzData.Controls.Add(this.textBoxKennz);
            this.groupBoxKfzData.Controls.Add(this.dateTimePicker1);
            this.groupBoxKfzData.Controls.Add(this.labelLeistungPS);
            this.groupBoxKfzData.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxKfzData.Location = new System.Drawing.Point(12, 6);
            this.groupBoxKfzData.Name = "groupBoxKfzData";
            this.groupBoxKfzData.Size = new System.Drawing.Size(316, 204);
            this.groupBoxKfzData.TabIndex = 29;
            this.groupBoxKfzData.TabStop = false;
            this.groupBoxKfzData.Text = "Fahrzeugdaten";
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBoxBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxBrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxBrand.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboBoxBrand.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(120, 16);
            this.comboBoxBrand.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(184, 23);
            this.comboBoxBrand.Sorted = true;
            this.comboBoxBrand.TabIndex = 0;
            this.comboBoxBrand.TextChanged += new System.EventHandler(this.comboBoxBrand_TextChanged);
            // 
            // comboBoxCarModel
            // 
            this.comboBoxCarModel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBoxCarModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCarModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCarModel.FormattingEnabled = true;
            this.comboBoxCarModel.Location = new System.Drawing.Point(120, 42);
            this.comboBoxCarModel.Name = "comboBoxCarModel";
            this.comboBoxCarModel.Size = new System.Drawing.Size(183, 23);
            this.comboBoxCarModel.Sorted = true;
            this.comboBoxCarModel.TabIndex = 1;
            this.toolTipCarModel.SetToolTip(this.comboBoxCarModel, "Modelle werden automatisch\r\nnach Benutzereingaben erweitert");
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marke";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Modell";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kennzeichen";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Erstzulassung";
            // 
            // numericUpDownLeistung
            // 
            this.numericUpDownLeistung.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericUpDownLeistung.Location = new System.Drawing.Point(120, 94);
            this.numericUpDownLeistung.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownLeistung.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownLeistung.Name = "numericUpDownLeistung";
            this.numericUpDownLeistung.Size = new System.Drawing.Size(85, 23);
            this.numericUpDownLeistung.TabIndex = 3;
            this.numericUpDownLeistung.TextChanged += new System.EventHandler(this.numericLeistungChanged_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Leistung (kW)";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(217, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 15);
            this.label14.TabIndex = 18;
            this.label14.Text = "x1000 km";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Farbe";
            // 
            // numericUpDownWartung
            // 
            this.numericUpDownWartung.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericUpDownWartung.Location = new System.Drawing.Point(120, 146);
            this.numericUpDownWartung.Name = "numericUpDownWartung";
            this.numericUpDownWartung.Size = new System.Drawing.Size(85, 23);
            this.numericUpDownWartung.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 150);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Wartungsintervall";
            // 
            // comboBoxFarbe
            // 
            this.comboBoxFarbe.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBoxFarbe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxFarbe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxFarbe.FormattingEnabled = true;
            this.comboBoxFarbe.Items.AddRange(new object[] {
            "Blau",
            "Gelb",
            "Grau",
            "Grün",
            "Rot",
            "Schwarz",
            "Sonstige",
            "Weiß"});
            this.comboBoxFarbe.Location = new System.Drawing.Point(120, 120);
            this.comboBoxFarbe.Name = "comboBoxFarbe";
            this.comboBoxFarbe.Size = new System.Drawing.Size(184, 23);
            this.comboBoxFarbe.Sorted = true;
            this.comboBoxFarbe.TabIndex = 4;
            // 
            // textBoxKennz
            // 
            this.textBoxKennz.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxKennz.Location = new System.Drawing.Point(120, 172);
            this.textBoxKennz.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKennz.Name = "textBoxKennz";
            this.textBoxKennz.Size = new System.Drawing.Size(184, 23);
            this.textBoxKennz.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 68);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(87, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // labelLeistungPS
            // 
            this.labelLeistungPS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelLeistungPS.AutoSize = true;
            this.labelLeistungPS.Location = new System.Drawing.Point(214, 98);
            this.labelLeistungPS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLeistungPS.Name = "labelLeistungPS";
            this.labelLeistungPS.Size = new System.Drawing.Size(23, 15);
            this.labelLeistungPS.TabIndex = 14;
            this.labelLeistungPS.Text = "PS";
            // 
            // pictureBoxBrand
            // 
            this.pictureBoxBrand.Location = new System.Drawing.Point(338, 16);
            this.pictureBoxBrand.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxBrand.Name = "pictureBoxBrand";
            this.pictureBoxBrand.Size = new System.Drawing.Size(138, 112);
            this.pictureBoxBrand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBrand.TabIndex = 25;
            this.pictureBoxBrand.TabStop = false;
            // 
            // tabControlAutoInfo
            // 
            this.tabControlAutoInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlAutoInfo.Controls.Add(this.tabPageAllgemein);
            this.tabControlAutoInfo.Controls.Add(this.tabPageKosten);
            this.tabControlAutoInfo.Controls.Add(this.tabPageTank);
            this.tabControlAutoInfo.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAutoInfo.Location = new System.Drawing.Point(4, 6);
            this.tabControlAutoInfo.Name = "tabControlAutoInfo";
            this.tabControlAutoInfo.SelectedIndex = 0;
            this.tabControlAutoInfo.Size = new System.Drawing.Size(831, 520);
            this.tabControlAutoInfo.TabIndex = 1;
            // 
            // toolTipCarModel
            // 
            this.toolTipCarModel.IsBalloon = true;
            // 
            // FormEdit
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(845, 561);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.tabControlAutoInfo);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(758, 600);
            this.Name = "FormEdit";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Fahrzeudaten erfassen/bearbeiten";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEdit_FormClosing);
            this.Load += new System.EventHandler(this.FormEdit_Load);
            this.contextMenuStripFlowPanel.ResumeLayout(false);
            this.contextMenuStripTabPage.ResumeLayout(false);
            this.tabPageTank.ResumeLayout(false);
            this.tabPageTank.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabPageKosten.ResumeLayout(false);
            this.tabPageKosten.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPageAllgemein.ResumeLayout(false);
            this.tabPageAllgemein.PerformLayout();
            this.groupBoxPicture.ResumeLayout(false);
            this.groupBoxPicture.PerformLayout();
            this.groupBoxKfzData.ResumeLayout(false);
            this.groupBoxKfzData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeistung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWartung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrand)).EndInit();
            this.tabControlAutoInfo.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTabPage;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFlowPanel;
        private System.Windows.Forms.ToolStripMenuItem bildLöschenToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageTank;
        private System.Windows.Forms.ListView listViewTankKosten;
        private System.Windows.Forms.ColumnHeader columnBetrag;
        private System.Windows.Forms.ColumnHeader columnDatum;
        private System.Windows.Forms.ColumnHeader columnMenge;
        private System.Windows.Forms.ColumnHeader columnKilometer;
        private System.Windows.Forms.ColumnHeader columnStreckeGefahren;
        private System.Windows.Forms.ColumnHeader columnVerbrauch;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem neueTankrechnungToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageKosten;
        private System.Windows.Forms.ListView listViewAllgKosten;
        private System.Windows.Forms.ColumnHeader columnKategorie;
        private System.Windows.Forms.ColumnHeader columnKostenAllg;
        private System.Windows.Forms.ColumnHeader columnDatumAllg;
        private System.Windows.Forms.ColumnHeader columnKilometerAllg;
        private System.Windows.Forms.ColumnHeader columnZahlweise;
        private System.Windows.Forms.ColumnHeader columnBemerkung;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStripNeueRechnung;
        private System.Windows.Forms.TabPage tabPageAllgemein;
        private System.Windows.Forms.GroupBox groupBoxPicture;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxKfzData;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.ComboBox comboBoxCarModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownLeistung;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownWartung;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxFarbe;
        private System.Windows.Forms.TextBox textBoxKennz;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelLeistungPS;
        private System.Windows.Forms.PictureBox pictureBoxBrand;
        private System.Windows.Forms.TabControl tabControlAutoInfo;
        private System.Windows.Forms.ToolTip toolTipCarModel;
    }
}