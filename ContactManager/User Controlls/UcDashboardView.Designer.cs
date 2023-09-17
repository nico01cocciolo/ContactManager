namespace ContactManager.User_Controlls
{
    partial class UcDashboardView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.ChtMitarbeiter = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChtKunde = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ChtMitarbeiter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChtKunde)).BeginInit();
            this.SuspendLayout();
            // 
            // ChtMitarbeiter
            // 
            chartArea1.Name = "ChartArea1";
            this.ChtMitarbeiter.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChtMitarbeiter.Legends.Add(legend1);
            this.ChtMitarbeiter.Location = new System.Drawing.Point(22, 19);
            this.ChtMitarbeiter.Name = "ChtMitarbeiter";
            this.ChtMitarbeiter.Size = new System.Drawing.Size(418, 334);
            this.ChtMitarbeiter.TabIndex = 0;
            this.ChtMitarbeiter.Text = "chart1";
            // 
            // ChtKunde
            // 
            chartArea2.Name = "ChartArea1";
            this.ChtKunde.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChtKunde.Legends.Add(legend2);
            this.ChtKunde.Location = new System.Drawing.Point(22, 359);
            this.ChtKunde.Name = "ChtKunde";
            this.ChtKunde.Size = new System.Drawing.Size(418, 334);
            this.ChtKunde.TabIndex = 1;
            this.ChtKunde.Text = "chart1";
            // 
            // UcDashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChtKunde);
            this.Controls.Add(this.ChtMitarbeiter);
            this.Name = "UcDashboardView";
            this.Size = new System.Drawing.Size(926, 791);
            this.Load += new System.EventHandler(this.UcDashboardView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChtMitarbeiter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChtKunde)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChtMitarbeiter;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChtKunde;
    }
}
