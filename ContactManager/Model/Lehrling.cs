using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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

        public Lehrling(string f, string n, DateTime dob, int ks, string abt, int arbp, DateTime st, int ty, int aty) : base(f, n, dob, ks, abt, arbp, st)
        {
            TraineeYears = ty;
            ActualTraineeYear = aty;
        }

    }
}
