using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ContactManager.Model
{
    internal class Lehrling : Mitarbeiter
    {   
        //ADD
        /*
         *  Lehrjahr
         *  aktuelles Lehrjahr
         */

        #region Parameters
        public int TraineeYears { get; set; }
        public int ActualTraineeYear { get; set; }
        #endregion

        public Lehrling(Guid id, string anrede, string vorname, string nachname, DateTime dob, string privat, string arbeit, string mobil, string email, string ahv, string nationalitaet, string strasse, int plz, string wohnort, int ks, string abt, int arbp, DateTime st,
                        int ty, int aty) 
                       : base(id, anrede, vorname, nachname, dob, privat, arbeit, mobil, email, ahv, nationalitaet, strasse, plz, wohnort, ks, abt, arbp, st)
        {
            TraineeYears = ty;
            ActualTraineeYear = aty;
        }

    }
}
