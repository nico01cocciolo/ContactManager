using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Model
{
    internal class Kunde : Person
    {
        //ADD
        /*  Firmenname, 
         *  Geschäftsadresse, 
         *  Kundentyp (A-E), 
         *  Firmenkontakt 
         */

        #region Parameters
        public string Firmenname { get; set; }
        public string Firmenadresse { get; set; }
        public char Kundentyp { get; set; }
        public string Kundenkontakt { get; set; }
        #endregion

        public Kunde(Guid id, bool isa, string anrede, string title, string vorname, string nachname, DateTime dob, string privat, string arbeit, string mobil, string email, string ahv, string nationalitaet, string strasse, int plz, string wohnort,
                     string firmenname, string firmenadresse, char kt, string kk) : base (id, isa, anrede, title, vorname, nachname, dob, privat, arbeit, mobil, email, ahv, nationalitaet, strasse, plz, wohnort)
        {
            Firmenname = firmenname;
            Firmenadresse = firmenadresse;
            Kundentyp = kt;
            Kundenkontakt = kk;
        }
    }
}
