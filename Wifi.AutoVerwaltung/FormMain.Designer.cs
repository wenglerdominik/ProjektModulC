﻿namespace Wifi.AutoVerwaltung
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSpeichern = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNeu = new System.Windows.Forms.ToolStripMenuItem();
            this.fahrzeugLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripLoggedUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripOpenFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.listViewMain = new System.Windows.Forms.ListView();
            this.columnMarke = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnModell = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFarbe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnErstzulassung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGesamtkosten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonNeuesFahrzeug = new System.Windows.Forms.Button();
            this.panelLine = new System.Windows.Forms.Panel();
            this.buttonCloseApp = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelKeinFahrzeug = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelShowButton = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.speichernUnterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelKeinFahrzeug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1449, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOpenFile,
            this.menuItemSpeichern,
            this.speichernUnterToolStripMenuItem});
            this.dateiToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(49, 19);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // menuItemOpenFile
            // 
            this.menuItemOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("menuItemOpenFile.Image")));
            this.menuItemOpenFile.Name = "menuItemOpenFile";
            this.menuItemOpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuItemOpenFile.Size = new System.Drawing.Size(195, 26);
            this.menuItemOpenFile.Text = "Öffnen";
            this.menuItemOpenFile.Click += new System.EventHandler(this.menuItemOpenFile_Click);
            // 
            // menuItemSpeichern
            // 
            this.menuItemSpeichern.Image = ((System.Drawing.Image)(resources.GetObject("menuItemSpeichern.Image")));
            this.menuItemSpeichern.Name = "menuItemSpeichern";
            this.menuItemSpeichern.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuItemSpeichern.Size = new System.Drawing.Size(184, 26);
            this.menuItemSpeichern.Text = "Speichern";
            this.menuItemSpeichern.Click += new System.EventHandler(this.menuItemSpeichern_Click);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNeu,
            this.fahrzeugLöschenToolStripMenuItem});
            this.bearbeitenToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(70, 19);
            this.bearbeitenToolStripMenuItem.Text = "Fahrzeug";
            // 
            // menuItemNeu
            // 
            this.menuItemNeu.Image = ((System.Drawing.Image)(resources.GetObject("menuItemNeu.Image")));
            this.menuItemNeu.Name = "menuItemNeu";
            this.menuItemNeu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuItemNeu.Size = new System.Drawing.Size(211, 26);
            this.menuItemNeu.Text = "Neues Fahrzeug";
            this.menuItemNeu.Click += new System.EventHandler(this.menuItemNeu_Click);
            // 
            // fahrzeugLöschenToolStripMenuItem
            // 
            this.fahrzeugLöschenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fahrzeugLöschenToolStripMenuItem.Image")));
            this.fahrzeugLöschenToolStripMenuItem.Name = "fahrzeugLöschenToolStripMenuItem";
            this.fahrzeugLöschenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.fahrzeugLöschenToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.fahrzeugLöschenToolStripMenuItem.Text = "Fahrzeug Löschen";
            this.fahrzeugLöschenToolStripMenuItem.Click += new System.EventHandler(this.fahrzeugLöschenToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLoggedUser,
            this.toolStripOpenFile});
            this.statusStrip1.Location = new System.Drawing.Point(0, 641);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1449, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripLoggedUser
            // 
            this.toolStripLoggedUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(134)))));
            this.toolStripLoggedUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.toolStripLoggedUser.Margin = new System.Windows.Forms.Padding(0, 3, 15, 2);
            this.toolStripLoggedUser.Name = "toolStripLoggedUser";
            this.toolStripLoggedUser.Size = new System.Drawing.Size(56, 17);
            this.toolStripLoggedUser.Text = "Benutzer:";
            this.toolStripLoggedUser.Visible = false;
            // 
            // toolStripOpenFile
            // 
            this.toolStripOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(134)))));
            this.toolStripOpenFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.toolStripOpenFile.Name = "toolStripOpenFile";
            this.toolStripOpenFile.Size = new System.Drawing.Size(37, 17);
            this.toolStripOpenFile.Text = "Datei:";
            this.toolStripOpenFile.Visible = false;
            // 
            // listViewMain
            // 
            this.listViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.listViewMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMarke,
            this.columnModell,
            this.columnFarbe,
            this.columnErstzulassung,
            this.columnGesamtkosten});
            this.listViewMain.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewMain.FullRowSelect = true;
            this.listViewMain.HideSelection = false;
            this.listViewMain.Location = new System.Drawing.Point(0, 0);
            this.listViewMain.Margin = new System.Windows.Forms.Padding(4);
            this.listViewMain.MultiSelect = false;
            this.listViewMain.Name = "listViewMain";
            this.listViewMain.ShowItemToolTips = true;
            this.listViewMain.Size = new System.Drawing.Size(834, 589);
            this.listViewMain.TabIndex = 4;
            this.listViewMain.UseCompatibleStateImageBehavior = false;
            this.listViewMain.View = System.Windows.Forms.View.Details;
            this.listViewMain.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewMain_ItemSelectionChanged);
            this.listViewMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewMain_MouseDoubleClick);
            // 
            // columnMarke
            // 
            this.columnMarke.Text = "Marke";
            this.columnMarke.Width = 120;
            // 
            // columnModell
            // 
            this.columnModell.Text = "Modell";
            this.columnModell.Width = 120;
            // 
            // columnFarbe
            // 
            this.columnFarbe.Text = "Farbe";
            this.columnFarbe.Width = 120;
            // 
            // columnErstzulassung
            // 
            this.columnErstzulassung.Text = "Erstzulassung";
            this.columnErstzulassung.Width = 120;
            // 
            // columnGesamtkosten
            // 
            this.columnGesamtkosten.Text = "Fahrzeugkosten [€]";
            this.columnGesamtkosten.Width = 187;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.löschenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 26);
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.löschenToolStripMenuItem.Text = "Löschen";
            this.löschenToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
            // 
            // buttonNeuesFahrzeug
            // 
            this.buttonNeuesFahrzeug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.buttonNeuesFahrzeug.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.buttonNeuesFahrzeug.FlatAppearance.BorderSize = 0;
            this.buttonNeuesFahrzeug.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.buttonNeuesFahrzeug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNeuesFahrzeug.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.buttonNeuesFahrzeug.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonNeuesFahrzeug.Image = ((System.Drawing.Image)(resources.GetObject("buttonNeuesFahrzeug.Image")));
            this.buttonNeuesFahrzeug.Location = new System.Drawing.Point(0, 33);
            this.buttonNeuesFahrzeug.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNeuesFahrzeug.Name = "buttonNeuesFahrzeug";
            this.buttonNeuesFahrzeug.Size = new System.Drawing.Size(176, 111);
            this.buttonNeuesFahrzeug.TabIndex = 6;
            this.buttonNeuesFahrzeug.UseVisualStyleBackColor = false;
            this.buttonNeuesFahrzeug.Click += new System.EventHandler(this.buttonNeuesFahrzeug_Click);
            // 
            // panelLine
            // 
            this.panelLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.panelLine.Location = new System.Drawing.Point(181, 33);
            this.panelLine.Margin = new System.Windows.Forms.Padding(4);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(13, 599);
            this.panelLine.TabIndex = 9;
            // 
            // buttonCloseApp
            // 
            this.buttonCloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCloseApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.buttonCloseApp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.buttonCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.buttonCloseApp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCloseApp.Location = new System.Drawing.Point(0, 520);
            this.buttonCloseApp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCloseApp.Name = "buttonCloseApp";
            this.buttonCloseApp.Size = new System.Drawing.Size(179, 109);
            this.buttonCloseApp.TabIndex = 10;
            this.buttonCloseApp.Text = "Programm\r\nBeenden";
            this.buttonCloseApp.UseVisualStyleBackColor = false;
            this.buttonCloseApp.Click += new System.EventHandler(this.buttonCloseApp_Click);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Controls.Add(this.panelKeinFahrzeug);
            this.panelMain.Controls.Add(this.listViewMain);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(832, 588);
            this.panelMain.TabIndex = 12;
            // 
            // panelKeinFahrzeug
            // 
            this.panelKeinFahrzeug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.panelKeinFahrzeug.Controls.Add(this.label1);
            this.panelKeinFahrzeug.Location = new System.Drawing.Point(12, 27);
            this.panelKeinFahrzeug.Margin = new System.Windows.Forms.Padding(4);
            this.panelKeinFahrzeug.Name = "panelKeinFahrzeug";
            this.panelKeinFahrzeug.Size = new System.Drawing.Size(679, 345);
            this.panelKeinFahrzeug.TabIndex = 8;
            this.panelKeinFahrzeug.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(0, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kein Fahrzeug vorhanden.\r\nNeues Fahrzeug anlegen oder vorhandene Datei öffnen.\r\n\r" +
    "\n";
            // 
            // panelShowButton
            // 
            this.panelShowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.panelShowButton.Location = new System.Drawing.Point(181, 33);
            this.panelShowButton.Margin = new System.Windows.Forms.Padding(4);
            this.panelShowButton.Name = "panelShowButton";
            this.panelShowButton.Size = new System.Drawing.Size(13, 107);
            this.panelShowButton.TabIndex = 10;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(201, 40);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelMain);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanelMain);
            this.splitContainer1.Size = new System.Drawing.Size(1241, 590);
            this.splitContainer1.SplitterDistance = 835;
            this.splitContainer1.TabIndex = 15;
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.AutoScroll = true;
            this.flowLayoutPanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMain.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Padding = new System.Windows.Forms.Padding(2, 2, 291, 2);
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(400, 588);
            this.flowLayoutPanelMain.TabIndex = 10;
            // 
            // speichernUnterToolStripMenuItem
            // 
            this.speichernUnterToolStripMenuItem.Name = "speichernUnterToolStripMenuItem";
            this.speichernUnterToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.speichernUnterToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.speichernUnterToolStripMenuItem.Text = "Speichern unter";
            this.speichernUnterToolStripMenuItem.Click += new System.EventHandler(this.speichernUnterToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(1449, 663);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelShowButton);
            this.Controls.Add(this.buttonCloseApp);
            this.Controls.Add(this.buttonNeuesFahrzeug);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelLine);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1339, 680);
            this.Name = "FormMain";
            this.Text = "Autoverwaltung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_Closing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelKeinFahrzeug.ResumeLayout(false);
            this.panelKeinFahrzeug.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemSpeichern;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemNeu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLoggedUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripOpenFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpenFile;
		private System.Windows.Forms.ListView listViewMain;
		private System.Windows.Forms.ColumnHeader columnMarke;
		private System.Windows.Forms.ColumnHeader columnModell;
		private System.Windows.Forms.ColumnHeader columnFarbe;
		private System.Windows.Forms.ColumnHeader columnErstzulassung;
		private System.Windows.Forms.ColumnHeader columnGesamtkosten;
        private System.Windows.Forms.Button buttonNeuesFahrzeug;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Button buttonCloseApp;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelShowButton;
        private System.Windows.Forms.Panel panelKeinFahrzeug;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem fahrzeugLöschenToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
        private System.Windows.Forms.ToolStripMenuItem speichernUnterToolStripMenuItem;
    }
}

