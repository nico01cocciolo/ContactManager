using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ContactManager.Model
{
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
        public Guid Id { get; set; }
        public string Anrede { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public DateTime Geburtsdatum { get; set; }
        //public Gender Gender { get; set; }
        public string Title { get; set; }
        public string TelefonPrivat { get; set; }
        public string TelefonArbeit { get; set; }
        public string TelefonMobil { get; set; }
        public string Email { get; set; }
        public string AhvNumber { get; set; }
        public string Nationalität { get; set; }
        public string Strasse { get; set; }
        public int Plz { get; set; }
        public string Wohnort { get; set; }
        public bool isActive {get; set;}

        #endregion

        //ADD 
        //Du muss no meh so Gugus ine aber mag gad nüme *Gähn*

        public Person(Guid id, bool isa,  string anrede, string title, string vorname, string nachname, DateTime dob, string privat, string arbeit, string mobil, string email, string ahv, string nationalitaet, string strasse, int plz, string wohnort)
        {
            Id = id;
            isActive = isa;
            Title = title;
            Anrede = anrede;
            Vorname = vorname;
            Nachname = nachname;
            Geburtsdatum = dob;
            TelefonPrivat = privat;
            TelefonArbeit = arbeit;
            TelefonMobil = mobil;
            Email = email;
            AhvNumber = ahv;
            Nationalität = nationalitaet;
            Strasse = strasse;
            Plz = plz;
            Wohnort = wohnort;

        }
    }
}
