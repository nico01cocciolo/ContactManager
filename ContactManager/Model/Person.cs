using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ContactManager.Model
{
    enum Gender
    {
        Männlich,
        Weiblich,
        Trans,
        Kampfhelikopter
    }

    enum  Title
    { 
       Dr,
       Dipl, 
    }

    internal class Person
    {
        //ADD
        /*   Anrede                      x
         *   Vorname                     x
         *   Nachname                    x
         *   Geburtstdatum               x
         *   Geschlecht                  x
         *   Titel                       x 
         *   Telefonnummer               x
         *   Geschäft                    x
         *   Mobiltelefonnummer          x
         *   E-Mail                      x
         *   Telefonnummer Geschäft      x
         *   Status (aktiv,passiv)
         *   Wohnort
         *   Nationalität                x
         *   AHV-Nummer                  x
         */

        #region Parameters
        public string salutation { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public DateTime dateOfBirth { get; set; }
        public Gender gender { get; set; }
        public Title title { get; set; } 
        public string phoneNumberPrivat { get; set; }
        public string phoneNumberWork { get; set; }
        public string phoneNumberMobile { get; set; }
        public string email { get; set; }
        public string ahvNumber { get; set; }
        public string nationality { get; set; }
        public bool inUse { get; set; }
        public string street { get; set;  }
        public int streetNumber { get; set; }
        public int postalCode { get; set; }
        public string wohnort { get; set; }
        #endregion
    }
}
