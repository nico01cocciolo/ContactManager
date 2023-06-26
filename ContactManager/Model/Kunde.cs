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
        public string CompanyName { get; set; }
        public string CompanyAdress { get; set; }
        public char CostumerType { get; set; }
        public string CompanyContact { get; set; }
        #endregion

        public Kunde(string f, string n, DateTime dob, string coname, string coadr, char ct, string cc) : base (f,n,dob)
        {
            CompanyName = coname;
            CompanyAdress = coadr;
            CostumerType = ct;
            CompanyContact = cc;
        }
    }
}
