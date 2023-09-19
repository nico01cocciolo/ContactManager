namespace ContactManager
{
    partial class FilterDashboardKunde
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFilterNachname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFilterVorname = new System.Windows.Forms.TextBox();
            this.CkStatus = new System.Windows.Forms.CheckBox();
            this.CmdFilterSuchen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFilterFirmenname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1006;
            this.label2.Text = "Nachname";
            // 
            // TxtFilterNachname
            // 
            this.TxtFilterNachname.Location = new System.Drawing.Point(11, 56);
            this.TxtFilterNachname.Margin = new System.Windows.Forms.Padding(2);
            this.TxtFilterNachname.Name = "TxtFilterNachname";
            this.TxtFilterNachname.Size = new System.Drawing.Size(76, 20);
            this.TxtFilterNachname.TabIndex = 1004;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1005;
            this.label1.Text = "Vorname";
            // 
            // TxtFilterVorname
            // 
            this.TxtFilterVorname.Location = new System.Drawing.Point(11, 32);
            this.TxtFilterVorname.Margin = new System.Windows.Forms.Padding(2);
            this.TxtFilterVorname.Name = "TxtFilterVorname";
            this.TxtFilterVorname.Size = new System.Drawing.Size(76, 20);
            this.TxtFilterVorname.TabIndex = 1003;
            // 
            // CkStatus
            // 
            this.CkStatus.AutoSize = true;
            this.CkStatus.Checked = true;
            this.CkStatus.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.CkStatus.Location = new System.Drawing.Point(11, 11);
            this.CkStatus.Margin = new System.Windows.Forms.Padding(2);
            this.CkStatus.Name = "CkStatus";
            this.CkStatus.Size = new System.Drawing.Size(59, 17);
            this.CkStatus.TabIndex = 1002;
            this.CkStatus.Text = "Status:";
            this.CkStatus.ThreeState = true;
            this.CkStatus.UseVisualStyleBackColor = true;
            // 
            // CmdFilterSuchen
            // 
            this.CmdFilterSuchen.Location = new System.Drawing.Point(198, 420);
            this.CmdFilterSuchen.Margin = new System.Windows.Forms.Padding(2);
            this.CmdFilterSuchen.Name = "CmdFilterSuchen";
            this.CmdFilterSuchen.Size = new System.Drawing.Size(56, 19);
            this.CmdFilterSuchen.TabIndex = 1007;
            this.CmdFilterSuchen.Text = "Suchen";
            this.CmdFilterSuchen.UseVisualStyleBackColor = true;
            this.CmdFilterSuchen.Click += new System.EventHandler(this.CmdFilterSuchen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 1009;
            this.label3.Text = "Firmenname";
            // 
            // TxtFilterFirmenname
            // 
            this.TxtFilterFirmenname.Location = new System.Drawing.Point(11, 80);
            this.TxtFilterFirmenname.Margin = new System.Windows.Forms.Padding(2);
            this.TxtFilterFirmenname.Name = "TxtFilterFirmenname";
            this.TxtFilterFirmenname.Size = new System.Drawing.Size(76, 20);
            this.TxtFilterFirmenname.TabIndex = 1008;
            // 
            // FilterDashboardKunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 484);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtFilterFirmenname);
            this.Controls.Add(this.CmdFilterSuchen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtFilterNachname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtFilterVorname);
            this.Controls.Add(this.CkStatus);
            this.Name = "FilterDashboardKunde";
            this.Text = "FilterDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFilterNachname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFilterVorname;
        private System.Windows.Forms.CheckBox CkStatus;
        private System.Windows.Forms.Button CmdFilterSuchen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtFilterFirmenname;
    }
}