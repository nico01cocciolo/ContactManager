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
        public string companyName { get; set; }
        public string companyAdress { get; set; }
        public char costumerType { get; set; }
        public string companyContact { get; set; }
        #endregion
    }
}
