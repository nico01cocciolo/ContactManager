using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.Controller
{
    internal class Validator
    {
        //Überprüft den String auf Zahlen
        string pattern = @"^[^\d]+$";

        public bool ValidateString(string input)
        {
            if (Regex.IsMatch(pattern, input))
            {
                return true;
            }
            else
            {
                MessageBox.Show($"{input}darf keine Zahl enthalten");
                return false;
            }
        }

    }
}
