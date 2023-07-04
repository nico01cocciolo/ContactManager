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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MsMenu = new System.Windows.Forms.MenuStrip();
            this.TsmImportieren = new System.Windows.Forms.ToolStripMenuItem();
            this.importierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmImportCSVDatei = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmKunde = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmMitarbeiter = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmMitarbeiterAnlegen = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmMitarbeiterBearbeiten = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmLehrling = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.kundeAnlegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kundeBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.MsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Knopf";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Knopf2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "De Besser Knopf 2";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "De Besser Knopf 3";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(93, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1046, 367);
            this.dataGridView1.TabIndex = 4;
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
            this.MsMenu.Size = new System.Drawing.Size(1264, 24);
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
            // kundeAnlegenToolStripMenuItem
            // 
            this.kundeAnlegenToolStripMenuItem.Name = "kundeAnlegenToolStripMenuItem";
            this.kundeAnlegenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kundeAnlegenToolStripMenuItem.Text = "Kunde anlegen";
            this.kundeAnlegenToolStripMenuItem.Click += new System.EventHandler(this.kundeAnlegenToolStripMenuItem_Click);
            // 
            // kundeBearbeitenToolStripMenuItem
            // 
            this.kundeBearbeitenToolStripMenuItem.Name = "kundeBearbeitenToolStripMenuItem";
            this.kundeBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kundeBearbeitenToolStripMenuItem.Text = "Kunde bearbeiten";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MsMenu);
            this.MainMenuStrip = this.MsMenu;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.MsMenu.ResumeLayout(false);
            this.MsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}

