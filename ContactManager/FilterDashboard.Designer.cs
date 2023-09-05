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
            this.SuspendLayout();
            // 
            // CkStatus
            // 
            this.CkStatus.AutoSize = true;
            this.CkStatus.Checked = true;
            this.CkStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CkStatus.Location = new System.Drawing.Point(12, 12);
            this.CkStatus.Name = "CkStatus";
            this.CkStatus.Size = new System.Drawing.Size(101, 20);
            this.CkStatus.TabIndex = 0;
            this.CkStatus.Text = "Status: Aktiv";
            this.CkStatus.UseVisualStyleBackColor = true;
            // 
            // CmdFilterSuchen
            // 
            this.CmdFilterSuchen.Location = new System.Drawing.Point(264, 517);
            this.CmdFilterSuchen.Name = "CmdFilterSuchen";
            this.CmdFilterSuchen.Size = new System.Drawing.Size(75, 23);
            this.CmdFilterSuchen.TabIndex = 1;
            this.CmdFilterSuchen.Text = "Suchen";
            this.CmdFilterSuchen.UseVisualStyleBackColor = true;
            this.CmdFilterSuchen.Click += new System.EventHandler(this.CmdFilterSuchen_Click);
            // 
            // FilterDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 596);
            this.Controls.Add(this.CmdFilterSuchen);
            this.Controls.Add(this.CkStatus);
            this.Name = "FilterDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "FilterDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CkStatus;
        private System.Windows.Forms.Button CmdFilterSuchen;
    }
}