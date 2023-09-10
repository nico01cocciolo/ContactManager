using ContactManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class LoginView : Form
    {
        #region Login Data
        private Login user = new Login("admin", "admin");
        #endregion

        public LoginView()
        {
            InitializeComponent();
        }

        #region Login Funktionen
        private void CmdLogin_Click(object sender, EventArgs e)
        {
            string username = TxtUsername.Text;
            string password = TxtPassword.Text;

            user.CheckLoginData(username, password);

            if(user.loginOk)
            {
                SwitchToDashboard();
            }
        }

        private void CmdFastLogin_Click(object sender, EventArgs e)
        {
            SwitchToDashboard();
        }

        private void CmdClearFields_Click(object sender, EventArgs e)
        {
            TxtUsername.Clear();
            TxtPassword.Clear();
        }

        private void ChkPWShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkPWShowHide.Checked)
            {
                TxtPassword.UseSystemPasswordChar = false;
                ChkPWShowHide.Text = "Hide Password";
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
                ChkPWShowHide.Text = "Show Password";
            }
        }
        #endregion

        private void SwitchToDashboard()
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
            this.Close();
        }
    }
}
