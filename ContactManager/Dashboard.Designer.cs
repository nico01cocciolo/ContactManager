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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CmdImportCsv = new System.Windows.Forms.Button();
            this.CmdStammLehrlinge = new System.Windows.Forms.Button();
            this.CmdStammKunden = new System.Windows.Forms.Button();
            this.CmdStammMitarbeiter = new System.Windows.Forms.Button();
            this.PnlUCHandler = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.CmdImportCsv);
            this.panel1.Controls.Add(this.CmdStammLehrlinge);
            this.panel1.Controls.Add(this.CmdStammKunden);
            this.panel1.Controls.Add(this.CmdStammMitarbeiter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 853);
            this.panel1.TabIndex = 7;
            // 
            // CmdImportCsv
            // 
            this.CmdImportCsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdImportCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdImportCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdImportCsv.ForeColor = System.Drawing.SystemColors.Control;
            this.CmdImportCsv.Location = new System.Drawing.Point(0, 384);
            this.CmdImportCsv.Margin = new System.Windows.Forms.Padding(0);
            this.CmdImportCsv.Name = "CmdImportCsv";
            this.CmdImportCsv.Size = new System.Drawing.Size(328, 55);
            this.CmdImportCsv.TabIndex = 3;
            this.CmdImportCsv.Text = "Import";
            this.CmdImportCsv.UseVisualStyleBackColor = true;
            // 
            // CmdStammLehrlinge
            // 
            this.CmdStammLehrlinge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdStammLehrlinge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdStammLehrlinge.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdStammLehrlinge.ForeColor = System.Drawing.SystemColors.Control;
            this.CmdStammLehrlinge.Location = new System.Drawing.Point(0, 265);
            this.CmdStammLehrlinge.Margin = new System.Windows.Forms.Padding(0);
            this.CmdStammLehrlinge.Name = "CmdStammLehrlinge";
            this.CmdStammLehrlinge.Size = new System.Drawing.Size(328, 119);
            this.CmdStammLehrlinge.TabIndex = 2;
            this.CmdStammLehrlinge.Text = "Lehrlinge";
            this.CmdStammLehrlinge.UseVisualStyleBackColor = true;
            // 
            // CmdStammKunden
            // 
            this.CmdStammKunden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdStammKunden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdStammKunden.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdStammKunden.ForeColor = System.Drawing.SystemColors.Control;
            this.CmdStammKunden.Location = new System.Drawing.Point(0, 145);
            this.CmdStammKunden.Margin = new System.Windows.Forms.Padding(0);
            this.CmdStammKunden.Name = "CmdStammKunden";
            this.CmdStammKunden.Size = new System.Drawing.Size(328, 119);
            this.CmdStammKunden.TabIndex = 1;
            this.CmdStammKunden.Text = "Kunden";
            this.CmdStammKunden.UseVisualStyleBackColor = true;
            // 
            // CmdStammMitarbeiter
            // 
            this.CmdStammMitarbeiter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdStammMitarbeiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdStammMitarbeiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdStammMitarbeiter.ForeColor = System.Drawing.SystemColors.Control;
            this.CmdStammMitarbeiter.Location = new System.Drawing.Point(0, 26);
            this.CmdStammMitarbeiter.Margin = new System.Windows.Forms.Padding(0);
            this.CmdStammMitarbeiter.Name = "CmdStammMitarbeiter";
            this.CmdStammMitarbeiter.Size = new System.Drawing.Size(328, 119);
            this.CmdStammMitarbeiter.TabIndex = 0;
            this.CmdStammMitarbeiter.Text = "Mitarbeiter";
            this.CmdStammMitarbeiter.UseVisualStyleBackColor = true;
            this.CmdStammMitarbeiter.Click += new System.EventHandler(this.CmdStammMitarbeiter_Click);
            // 
            // PnlUCHandler
            // 
            this.PnlUCHandler.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlUCHandler.Location = new System.Drawing.Point(332, 0);
            this.PnlUCHandler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PnlUCHandler.Name = "PnlUCHandler";
            this.PnlUCHandler.Size = new System.Drawing.Size(1282, 853);
            this.PnlUCHandler.TabIndex = 9;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1614, 853);
            this.Controls.Add(this.PnlUCHandler);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CmdStammMitarbeiter;
        private System.Windows.Forms.Button CmdImportCsv;
        private System.Windows.Forms.Button CmdStammLehrlinge;
        private System.Windows.Forms.Button CmdStammKunden;
        private System.Windows.Forms.Panel PnlUCHandler;
    }
}

