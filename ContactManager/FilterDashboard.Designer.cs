namespace ContactManager
{
    partial class FilterDashboard
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
            this.CkStatus = new System.Windows.Forms.CheckBox();
            this.CmdFilterSuchen = new System.Windows.Forms.Button();
            this.TxtFilterVorname = new System.Windows.Forms.TextBox();
            this.CkLehrling = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFilterNachname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CkStatus
            // 
            this.CkStatus.AutoSize = true;
            this.CkStatus.Checked = true;
            this.CkStatus.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.CkStatus.Location = new System.Drawing.Point(12, 12);
            this.CkStatus.Name = "CkStatus";
            this.CkStatus.Size = new System.Drawing.Size(69, 20);
            this.CkStatus.TabIndex = 0;
            this.CkStatus.Text = "Status:";
            this.CkStatus.ThreeState = true;
            this.CkStatus.UseVisualStyleBackColor = true;
            // 
            // CmdFilterSuchen
            // 
            this.CmdFilterSuchen.Location = new System.Drawing.Point(264, 517);
            this.CmdFilterSuchen.Name = "CmdFilterSuchen";
            this.CmdFilterSuchen.Size = new System.Drawing.Size(75, 23);
            this.CmdFilterSuchen.TabIndex = 5;
            this.CmdFilterSuchen.Text = "Suchen";
            this.CmdFilterSuchen.UseVisualStyleBackColor = true;
            this.CmdFilterSuchen.Click += new System.EventHandler(this.CmdFilterSuchen_Click);
            // 
            // TxtFilterVorname
            // 
            this.TxtFilterVorname.Location = new System.Drawing.Point(13, 38);
            this.TxtFilterVorname.Name = "TxtFilterVorname";
            this.TxtFilterVorname.Size = new System.Drawing.Size(100, 22);
            this.TxtFilterVorname.TabIndex = 3;
            // 
            // CkLehrling
            // 
            this.CkLehrling.AutoSize = true;
            this.CkLehrling.Checked = true;
            this.CkLehrling.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.CkLehrling.Location = new System.Drawing.Point(151, 12);
            this.CkLehrling.Name = "CkLehrling";
            this.CkLehrling.Size = new System.Drawing.Size(79, 20);
            this.CkLehrling.TabIndex = 2;
            this.CkLehrling.Text = "Lehrling:";
            this.CkLehrling.ThreeState = true;
            this.CkLehrling.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1000;
            this.label1.Text = "Vorname";
            // 
            // TxtFilterNachname
            // 
            this.TxtFilterNachname.Location = new System.Drawing.Point(13, 66);
            this.TxtFilterNachname.Name = "TxtFilterNachname";
            this.TxtFilterNachname.Size = new System.Drawing.Size(100, 22);
            this.TxtFilterNachname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1001;
            this.label2.Text = "Nachname";
            // 
            // FilterDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 596);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtFilterNachname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CkLehrling);
            this.Controls.Add(this.TxtFilterVorname);
            this.Controls.Add(this.CmdFilterSuchen);
            this.Controls.Add(this.CkStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FilterDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilterDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CkStatus;
        private System.Windows.Forms.Button CmdFilterSuchen;
        private System.Windows.Forms.TextBox TxtFilterVorname;
        private System.Windows.Forms.CheckBox CkLehrling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFilterNachname;
        private System.Windows.Forms.Label label2;
    }
}