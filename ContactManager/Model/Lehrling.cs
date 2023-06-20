using System;
using System.Collections.Generic;
using System.Linq;
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
        public int traineeYears { get; set; }
        public int actualTraineeYear { get; set; }
        #endregion
    }
}
