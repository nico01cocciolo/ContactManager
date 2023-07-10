using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ContactManager.Controller
{
    internal class XMLHandler
    {
        public void CreateXML(Guid id, string vorname, string nachname, DateTime dob, string email, string strasse, string wohnort, int plz)
    {
            XDocument xDoc = new XDocument(new XElement("Person",
                new XElement("Mitarbeiter",
                
                //Wichtig
                new XAttribute("ID", id),
                new XAttribute("Status", "aktiv"),
                //Person
                new XElement("Geschlecht", "A"),
                new XElement("Anrede", "A"),
                new XElement("Titel", "A"),
                new XElement("Vorname", vorname),
                new XElement("Nachname", nachname),
                new XElement("Geburtsdatum", dob.ToShortDateString()),
                new XElement("Nationalität", "A"),
                new XElement("AHV-Nummer", "A"),
                //Kontakt
                new XElement("E-Mail", email),
                new XElement("Telefon_Mobil", "A"),
                new XElement("Telefon_Privat", "A"),
                new XElement("Telefon_Arbeit", "A"),
                //Adresse
                new XElement("Strasse", strasse),
                new XElement("Wohnort", wohnort),
                new XElement("Postleitzahl", plz))));
                
            xDoc.Save("Kunde.xml");
    }
    
    }
}
