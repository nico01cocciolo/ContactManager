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
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Title Title { get; set; }
        public string PhoneNumberPrivat { get; set; }
        public string PhoneNumberWork { get; set; }
        public string PhoneNumberMobile { get; set; }
        public string Email { get; set; }
        public string AhvNumber { get; set; }
        public string Nationality { get; set; }
        public bool inUse { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public int PostalCode { get; set; }
        public string Wohnort { get; set; }
        public bool isActive {get; set;}

        #endregion

        //ADD 
        //Du muss no meh so Gugus ine aber mag gad nüme *Gähn*

        public Person(string f, string n, DateTime dob)
        {
            Firstname = f;
            Lastname = n;
            DateOfBirth = dob;
        }

    }
}
