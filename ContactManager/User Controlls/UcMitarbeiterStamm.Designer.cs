namespace ContactManager
{
    partial class UcMitarbeiterStamm
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.CmdMitarbeiterBearbeiten = new System.Windows.Forms.Button();
            this.CmdMitarbeiterErstellen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 359);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(925, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(809, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Daten laden";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CmdMitarbeiterBearbeiten
            // 
            this.CmdMitarbeiterBearbeiten.Location = new System.Drawing.Point(116, 330);
            this.CmdMitarbeiterBearbeiten.Name = "CmdMitarbeiterBearbeiten";
            this.CmdMitarbeiterBearbeiten.Size = new System.Drawing.Size(107, 23);
            this.CmdMitarbeiterBearbeiten.TabIndex = 2;
            this.CmdMitarbeiterBearbeiten.Text = "Bearbeiten";
            this.CmdMitarbeiterBearbeiten.UseVisualStyleBackColor = true;
            this.CmdMitarbeiterBearbeiten.Click += new System.EventHandler(this.CmdMitarbeiterBearbeiten_Click);
            // 
            // CmdMitarbeiterErstellen
            // 
            this.CmdMitarbeiterErstellen.Location = new System.Drawing.Point(3, 330);
            this.CmdMitarbeiterErstellen.Name = "CmdMitarbeiterErstellen";
            this.CmdMitarbeiterErstellen.Size = new System.Drawing.Size(107, 23);
            this.CmdMitarbeiterErstellen.TabIndex = 3;
            this.CmdMitarbeiterErstellen.Text = "Erstellen";
            this.CmdMitarbeiterErstellen.UseVisualStyleBackColor = true;
            this.CmdMitarbeiterErstellen.Click += new System.EventHandler(this.CmdMitarbeiterErstellen_Click);
            // 
            // UcMitarbeiterStamm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CmdMitarbeiterErstellen);
            this.Controls.Add(this.CmdMitarbeiterBearbeiten);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UcMitarbeiterStamm";
            this.Size = new System.Drawing.Size(931, 650);
            this.Load += new System.EventHandler(this.UcMitarbeiterStamm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CmdMitarbeiterBearbeiten;
        private System.Windows.Forms.Button CmdMitarbeiterErstellen;
    }
}
