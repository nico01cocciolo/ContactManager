namespace ContactManager
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmdFastLogin = new System.Windows.Forms.Button();
            this.CmdClearFields = new System.Windows.Forms.Button();
            this.CmdLogin = new System.Windows.Forms.Button();
            this.ChkPWShowHide = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(121, 99);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(177, 20);
            this.TxtUsername.TabIndex = 0;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(121, 125);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(177, 20);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // CmdFastLogin
            // 
            this.CmdFastLogin.Location = new System.Drawing.Point(121, 180);
            this.CmdFastLogin.Name = "CmdFastLogin";
            this.CmdFastLogin.Size = new System.Drawing.Size(75, 23);
            this.CmdFastLogin.TabIndex = 4;
            this.CmdFastLogin.Text = "Fast LOGIN";
            this.CmdFastLogin.UseVisualStyleBackColor = true;
            this.CmdFastLogin.Click += new System.EventHandler(this.CmdFastLogin_Click);
            // 
            // CmdClearFields
            // 
            this.CmdClearFields.Location = new System.Drawing.Point(223, 180);
            this.CmdClearFields.Name = "CmdClearFields";
            this.CmdClearFields.Size = new System.Drawing.Size(75, 23);
            this.CmdClearFields.TabIndex = 5;
            this.CmdClearFields.Text = "Clear";
            this.CmdClearFields.UseVisualStyleBackColor = true;
            this.CmdClearFields.Click += new System.EventHandler(this.CmdClearFields_Click);
            // 
            // CmdLogin
            // 
            this.CmdLogin.Location = new System.Drawing.Point(121, 210);
            this.CmdLogin.Name = "CmdLogin";
            this.CmdLogin.Size = new System.Drawing.Size(177, 54);
            this.CmdLogin.TabIndex = 6;
            this.CmdLogin.Text = "LOGIN";
            this.CmdLogin.UseVisualStyleBackColor = true;
            this.CmdLogin.Click += new System.EventHandler(this.CmdLogin_Click);
            // 
            // ChkPWShowHide
            // 
            this.ChkPWShowHide.AutoSize = true;
            this.ChkPWShowHide.Location = new System.Drawing.Point(121, 158);
            this.ChkPWShowHide.Name = "ChkPWShowHide";
            this.ChkPWShowHide.Size = new System.Drawing.Size(102, 17);
            this.ChkPWShowHide.TabIndex = 7;
            this.ChkPWShowHide.Text = "Show Password";
            this.ChkPWShowHide.UseVisualStyleBackColor = true;
            this.ChkPWShowHide.CheckedChanged += new System.EventHandler(this.ChkPWShowHide_CheckedChanged);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(411, 408);
            this.Controls.Add(this.ChkPWShowHide);
            this.Controls.Add(this.CmdLogin);
            this.Controls.Add(this.CmdClearFields);
            this.Controls.Add(this.CmdFastLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.DoubleBuffered = true;
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CmdFastLogin;
        private System.Windows.Forms.Button CmdClearFields;
        private System.Windows.Forms.Button CmdLogin;
        private System.Windows.Forms.CheckBox ChkPWShowHide;
    }
}