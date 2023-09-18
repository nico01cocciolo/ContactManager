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
        /// <summary>
        /// Hier sind die Patterns für den Regex definiert
        /// </summary>
        #region Regex Patterns
        //Überprüft den String auf Zahlen
        string numbers = @"^[^\d]+$";
       
        //Überprüft den String au Buchstaben
        string chars  = @"^[A-Za-z]+$";
        #endregion

        /// <summary>
        /// Überprüft den string "input" auf Zahlen und gibt dementsprechend einen boolschen Wert zurück
        /// </summary>
        public bool ValidateString(string input)
        {
            var isMatch = Regex.IsMatch(input, numbers);
            return isMatch;
        }

        /// <summary>
        /// Überprüft den string "input" auf Buchstaben und gibt dementsprechend einen boolschen Wert zurück
        /// </summary>
        public bool ValidateInt(string input)
        {
            var isMatch = Regex.IsMatch(input, chars);
            return isMatch;
        }
    }
}
