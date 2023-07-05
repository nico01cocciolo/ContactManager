namespace ContactManager
{
    partial class Dashboard
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.MsMenu = new System.Windows.Forms.MenuStrip();
            this.TsmImportieren = new System.Windows.Forms.ToolStripMenuItem();
            this.importierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmImportCSVDatei = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmKunde = new System.Windows.Forms.ToolStripMenuItem();
            this.kundeAnlegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kundeBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmMitarbeiter = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmMitarbeiterAnlegen = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmMitarbeiterBearbeiten = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmLehrling = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CmdStammMitarbeiter = new System.Windows.Forms.Button();
            this.CmdStammKunden = new System.Windows.Forms.Button();
            this.CmdStammLehrlinge = new System.Windows.Forms.Button();
            this.CmdImportCsv = new System.Windows.Forms.Button();
            this.mitarbeiterErfassung1 = new ContactManager.MitarbeiterErfassung();
            this.MsMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MsMenu
            // 
            this.MsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmImportieren,
            this.TsmKunde,
            this.TsmMitarbeiter,
            this.TsmLehrling,
            this.TsmStatus});
            this.MsMenu.Location = new System.Drawing.Point(0, 0);
            this.MsMenu.Name = "MsMenu";
            this.MsMenu.Size = new System.Drawing.Size(1183, 24);
            this.MsMenu.TabIndex = 5;
            this.MsMenu.Text = "menuStrip1";
            // 
            // TsmImportieren
            // 
            this.TsmImportieren.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importierenToolStripMenuItem});
            this.TsmImportieren.Name = "TsmImportieren";
            this.TsmImportieren.Size = new System.Drawing.Size(46, 20);
            this.TsmImportieren.Text = "Datei";
            // 
            // importierenToolStripMenuItem
            // 
            this.importierenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmImportCSVDatei});
            this.importierenToolStripMenuItem.Name = "importierenToolStripMenuItem";
            this.importierenToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.importierenToolStripMenuItem.Text = "Importieren";
            // 
            // TsmImportCSVDatei
            // 
            this.TsmImportCSVDatei.Name = "TsmImportCSVDatei";
            this.TsmImportCSVDatei.Size = new System.Drawing.Size(127, 22);
            this.TsmImportCSVDatei.Text = "CSV-Datei";
            // 
            // TsmKunde
            // 
            this.TsmKunde.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kundeAnlegenToolStripMenuItem,
            this.kundeBearbeitenToolStripMenuItem});
            this.TsmKunde.Name = "TsmKunde";
            this.TsmKunde.Size = new System.Drawing.Size(53, 20);
            this.TsmKunde.Text = "Kunde";
            // 
            // kundeAnlegenToolStripMenuItem
            // 
            this.kundeAnlegenToolStripMenuItem.Name = "kundeAnlegenToolStripMenuItem";
            this.kundeAnlegenToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.kundeAnlegenToolStripMenuItem.Text = "Kunde anlegen";
            this.kundeAnlegenToolStripMenuItem.Click += new System.EventHandler(this.kundeAnlegenToolStripMenuItem_Click);
            // 
            // kundeBearbeitenToolStripMenuItem
            // 
            this.kundeBearbeitenToolStripMenuItem.Name = "kundeBearbeitenToolStripMenuItem";
            this.kundeBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.kundeBearbeitenToolStripMenuItem.Text = "Kunde bearbeiten";
            // 
            // TsmMitarbeiter
            // 
            this.TsmMitarbeiter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmMitarbeiterAnlegen,
            this.TsmMitarbeiterBearbeiten});
            this.TsmMitarbeiter.Name = "TsmMitarbeiter";
            this.TsmMitarbeiter.Size = new System.Drawing.Size(77, 20);
            this.TsmMitarbeiter.Text = "Mitarbeiter";
            // 
            // TsmMitarbeiterAnlegen
            // 
            this.TsmMitarbeiterAnlegen.Name = "TsmMitarbeiterAnlegen";
            this.TsmMitarbeiterAnlegen.Size = new System.Drawing.Size(191, 22);
            this.TsmMitarbeiterAnlegen.Text = "Mitarbeiter anlegen";
            this.TsmMitarbeiterAnlegen.Click += new System.EventHandler(this.TsmMitarbeiterAnlegen_Click);
            // 
            // TsmMitarbeiterBearbeiten
            // 
            this.TsmMitarbeiterBearbeiten.Name = "TsmMitarbeiterBearbeiten";
            this.TsmMitarbeiterBearbeiten.Size = new System.Drawing.Size(191, 22);
            this.TsmMitarbeiterBearbeiten.Text = "Mitarbeiter bearbeiten";
            // 
            // TsmLehrling
            // 
            this.TsmLehrling.Name = "TsmLehrling";
            this.TsmLehrling.Size = new System.Drawing.Size(62, 20);
            this.TsmLehrling.Text = "Lehrling";
            // 
            // TsmStatus
            // 
            this.TsmStatus.Name = "TsmStatus";
            this.TsmStatus.Size = new System.Drawing.Size(51, 20);
            this.TsmStatus.Text = "Status";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.CmdImportCsv);
            this.panel1.Controls.Add(this.CmdStammLehrlinge);
            this.panel1.Controls.Add(this.CmdStammKunden);
            this.panel1.Controls.Add(this.CmdStammMitarbeiter);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 651);
            this.panel1.TabIndex = 7;
            // 
            // CmdStammMitarbeiter
            // 
            this.CmdStammMitarbeiter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdStammMitarbeiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdStammMitarbeiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdStammMitarbeiter.ForeColor = System.Drawing.SystemColors.Control;
            this.CmdStammMitarbeiter.Location = new System.Drawing.Point(0, 0);
            this.CmdStammMitarbeiter.Margin = new System.Windows.Forms.Padding(0);
            this.CmdStammMitarbeiter.Name = "CmdStammMitarbeiter";
            this.CmdStammMitarbeiter.Size = new System.Drawing.Size(246, 97);
            this.CmdStammMitarbeiter.TabIndex = 0;
            this.CmdStammMitarbeiter.Text = "Mitarbeiter";
            this.CmdStammMitarbeiter.UseVisualStyleBackColor = true;
            this.CmdStammMitarbeiter.Click += new System.EventHandler(this.CmdStammMitarbeiter_Click);
            // 
            // CmdStammKunden
            // 
            this.CmdStammKunden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdStammKunden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdStammKunden.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdStammKunden.ForeColor = System.Drawing.SystemColors.Control;
            this.CmdStammKunden.Location = new System.Drawing.Point(0, 97);
            this.CmdStammKunden.Margin = new System.Windows.Forms.Padding(0);
            this.CmdStammKunden.Name = "CmdStammKunden";
            this.CmdStammKunden.Size = new System.Drawing.Size(246, 97);
            this.CmdStammKunden.TabIndex = 1;
            this.CmdStammKunden.Text = "Kunden";
            this.CmdStammKunden.UseVisualStyleBackColor = true;
            // 
            // CmdStammLehrlinge
            // 
            this.CmdStammLehrlinge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdStammLehrlinge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdStammLehrlinge.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdStammLehrlinge.ForeColor = System.Drawing.SystemColors.Control;
            this.CmdStammLehrlinge.Location = new System.Drawing.Point(0, 194);
            this.CmdStammLehrlinge.Margin = new System.Windows.Forms.Padding(0);
            this.CmdStammLehrlinge.Name = "CmdStammLehrlinge";
            this.CmdStammLehrlinge.Size = new System.Drawing.Size(246, 97);
            this.CmdStammLehrlinge.TabIndex = 2;
            this.CmdStammLehrlinge.Text = "Lehrlinge";
            this.CmdStammLehrlinge.UseVisualStyleBackColor = true;
            // 
            // CmdImportCsv
            // 
            this.CmdImportCsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdImportCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdImportCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdImportCsv.ForeColor = System.Drawing.SystemColors.Control;
            this.CmdImportCsv.Location = new System.Drawing.Point(0, 291);
            this.CmdImportCsv.Margin = new System.Windows.Forms.Padding(0);
            this.CmdImportCsv.Name = "CmdImportCsv";
            this.CmdImportCsv.Size = new System.Drawing.Size(246, 45);
            this.CmdImportCsv.TabIndex = 3;
            this.CmdImportCsv.Text = "Import";
            this.CmdImportCsv.UseVisualStyleBackColor = true;
            // 
            // mitarbeiterErfassung1
            // 
            this.mitarbeiterErfassung1.Location = new System.Drawing.Point(287, 52);
            this.mitarbeiterErfassung1.Name = "mitarbeiterErfassung1";
            this.mitarbeiterErfassung1.Size = new System.Drawing.Size(892, 553);
            this.mitarbeiterErfassung1.TabIndex = 8;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 681);
            this.Controls.Add(this.mitarbeiterErfassung1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MsMenu;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.MsMenu.ResumeLayout(false);
            this.MsMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MsMenu;
        private System.Windows.Forms.ToolStripMenuItem TsmImportieren;
        private System.Windows.Forms.ToolStripMenuItem importierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsmKunde;
        private System.Windows.Forms.ToolStripMenuItem TsmMitarbeiter;
        private System.Windows.Forms.ToolStripMenuItem TsmLehrling;
        private System.Windows.Forms.ToolStripMenuItem TsmStatus;
        private System.Windows.Forms.ToolStripMenuItem TsmImportCSVDatei;
        private System.Windows.Forms.ToolStripMenuItem TsmMitarbeiterAnlegen;
        private System.Windows.Forms.ToolStripMenuItem TsmMitarbeiterBearbeiten;
        private System.Windows.Forms.ToolStripMenuItem kundeAnlegenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kundeBearbeitenToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CmdStammMitarbeiter;
        private System.Windows.Forms.Button CmdImportCsv;
        private System.Windows.Forms.Button CmdStammLehrlinge;
        private System.Windows.Forms.Button CmdStammKunden;
        private MitarbeiterErfassung mitarbeiterErfassung1;
    }
}

