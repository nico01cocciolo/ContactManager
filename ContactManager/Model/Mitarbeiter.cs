using System;
using System.Collections.Generic;
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
        public int kaderStufe { get; set; }
        public string department { get; set; }
        public int arbeitspensum { get; set; }
        public DateTime startDate { get; set; }
        public DateTime dateTime { get; set; }
        public Guid employeeNumber { get; set; }
        #endregion

    }
}
