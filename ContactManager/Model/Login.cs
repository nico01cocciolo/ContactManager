using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.Model
{
    internal class Login
    {
        #region Parameters
        private string username { get; set; }
        private string password { get; set; }
        public bool loginOk = false;

        #endregion
        public Login(string u, string p)
        {
            username = u;
            password = p;
        }

        //Funktion für die Kontrolle vom Login
        public void CheckLoginData(string u, string p)
        {
            if (u == username && p == password)
            {
                loginOk = true;
            }
            else
            {
                MessageBox.Show("Username oder Password falsch.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
