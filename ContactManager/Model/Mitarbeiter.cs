using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Model
{
    internal class Mitarbeiter : Person
    {
        //ADD
        /*
         *   Kaderstufe (0-5)                    x
         *   Rolle (Tätigkeitenbereich)          x
         *   Beschäftigungsgrad (zb. 80%)        x
         *   Austrittsdatum                      x
         *   Eintrittsdatum                      x
         *   Mitarbeiternummer                   x
         */

        #region Parameters
        public bool isTrainee { get; set; }
        public int KaderStufe { get; set; }
        public string Rolle { get; set; }
        public string Abteilung { get; set; }
        public int Arbeitspensum { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        #endregion

        public Mitarbeiter(Guid id, bool isa, bool istrainee, string anrede, string title, string gender,string vorname, string nachname, DateTime dob, string privat, string arbeit, string mobil, string email, string ahv, string nationalitaet, string strasse, int plz, string wohnort,
                           int ks, string rolle, string abt, int arbp, DateTime start, DateTime end) : base(id, isa, anrede, title, gender, vorname, nachname, dob, privat, arbeit, mobil, email, ahv, nationalitaet, strasse, plz, wohnort)
        {
            KaderStufe = ks;
            Rolle = rolle;
            Abteilung = abt;
            Arbeitspensum = arbp;
            StartDate = start;
            EndDate = end;
            isTrainee = istrainee;
        }
    }
}
