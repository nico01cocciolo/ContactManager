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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
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
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.CmdImportCsv);
            this.panel1.Controls.Add(this.CmdStammLehrlinge);
            this.panel1.Controls.Add(this.CmdStammKunden);
            this.panel1.Controls.Add(this.CmdStammMitarbeiter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 825);
            this.panel1.TabIndex = 7;
            // 
            // CmdImportCsv
            // 
            this.CmdImportCsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdImportCsv.BackColor = System.Drawing.SystemColors.InfoText;
            this.CmdImportCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdImportCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdImportCsv.ForeColor = System.Drawing.SystemColors.Control;
            this.CmdImportCsv.Location = new System.Drawing.Point(0, 124);
            this.CmdImportCsv.Margin = new System.Windows.Forms.Padding(0);
            this.CmdImportCsv.Name = "CmdImportCsv";
            this.CmdImportCsv.Size = new System.Drawing.Size(154, 34);
            this.CmdImportCsv.TabIndex = 3;
            this.CmdImportCsv.Text = "Import";
            this.CmdImportCsv.UseVisualStyleBackColor = false;
            // 
            // CmdStammLehrlinge
            // 
            this.CmdStammLehrlinge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdStammLehrlinge.BackColor = System.Drawing.SystemColors.InfoText;
            this.CmdStammLehrlinge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdStammLehrlinge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdStammLehrlinge.ForeColor = System.Drawing.SystemColors.Control;
            this.CmdStammLehrlinge.Location = new System.Drawing.Point(0, 84);
            this.CmdStammLehrlinge.Margin = new System.Windows.Forms.Padding(0);
            this.CmdStammLehrlinge.Name = "CmdStammLehrlinge";
            this.CmdStammLehrlinge.Size = new System.Drawing.Size(154, 40);
            this.CmdStammLehrlinge.TabIndex = 2;
            this.CmdStammLehrlinge.Text = "Lehrlinge";
            this.CmdStammLehrlinge.UseVisualStyleBackColor = false;
            // 
            // CmdStammKunden
            // 
            this.CmdStammKunden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdStammKunden.BackColor = System.Drawing.SystemColors.InfoText;
            this.CmdStammKunden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdStammKunden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdStammKunden.ForeColor = System.Drawing.SystemColors.Control;
            this.CmdStammKunden.Location = new System.Drawing.Point(0, 42);
            this.CmdStammKunden.Margin = new System.Windows.Forms.Padding(0);
            this.CmdStammKunden.Name = "CmdStammKunden";
            this.CmdStammKunden.Size = new System.Drawing.Size(154, 41);
            this.CmdStammKunden.TabIndex = 1;
            this.CmdStammKunden.Text = "Kunden";
            this.CmdStammKunden.UseVisualStyleBackColor = false;
            this.CmdStammKunden.Click += new System.EventHandler(this.CmdStammKunden_Click);
            // 
            // CmdStammMitarbeiter
            // 
            this.CmdStammMitarbeiter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdStammMitarbeiter.BackColor = System.Drawing.SystemColors.InfoText;
            this.CmdStammMitarbeiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdStammMitarbeiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdStammMitarbeiter.ForeColor = System.Drawing.SystemColors.Control;
            this.CmdStammMitarbeiter.Location = new System.Drawing.Point(0, -6);
            this.CmdStammMitarbeiter.Margin = new System.Windows.Forms.Padding(0);
            this.CmdStammMitarbeiter.Name = "CmdStammMitarbeiter";
            this.CmdStammMitarbeiter.Size = new System.Drawing.Size(154, 49);
            this.CmdStammMitarbeiter.TabIndex = 0;
            this.CmdStammMitarbeiter.Text = "Mitarbeiter";
            this.CmdStammMitarbeiter.UseVisualStyleBackColor = false;
            this.CmdStammMitarbeiter.Click += new System.EventHandler(this.CmdStammMitarbeiter_Click);
            // 
            // PnlUCHandler
            // 
            this.PnlUCHandler.BackColor = System.Drawing.Color.Transparent;
            this.PnlUCHandler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlUCHandler.BackgroundImage")));
            this.PnlUCHandler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PnlUCHandler.Location = new System.Drawing.Point(158, 3);
            this.PnlUCHandler.Name = "PnlUCHandler";
            this.PnlUCHandler.Size = new System.Drawing.Size(914, 816);
            this.PnlUCHandler.TabIndex = 9;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1079, 825);
            this.Controls.Add(this.PnlUCHandler);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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

