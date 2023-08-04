using ContactManager.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ContactManager.Controller
{
    internal class XMLHandler
    {
        public void CreateXML(Guid id, string status,string anrede, string vorname, string nachname, DateTime dob, string email, string strasse, string wohnort, int plz)
        {
            if (File.Exists("Kunde.xml") == false)
            {
                XDocument xDoc = new XDocument(new XDeclaration("1.0", "UTF-16", "yes"),
                    new XElement("Person",
                    new XElement("Mitarbeiter",

                    //Wichtig
                    new XAttribute("ID", id),
                    new XAttribute("Status", status),
                    //Person
                    new XElement("Geschlecht", "A"),
                    new XElement("Anrede", anrede),
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
            else
            {
                XElement xEleo = XElement.Load("Kunde.xml");

                xEleo.Add(new XElement("Mitarbeiter",
                    //Wichtig
                    new XAttribute("ID", id),
                    new XAttribute("Status", status),
                    //Person
                    new XElement("Geschlecht", "A"),
                    new XElement("Anrede", anrede),
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
                    new XElement("Postleitzahl", plz)));
                xEleo.Save("Kunde.xml");
            }
        }

        public void ChangeValuesXML(string id, string status, string anrede, string vorname, string nachname, DateTime dob, string email, string strasse, string wohnort, int plz)
        {
            UcMitarbeiterStamm ucm = new UcMitarbeiterStamm();

            
            XElement xdoc = XElement.Load("Kunde.xml");

            //Wichtig
            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetAttributeValue("Status", status);

            //Person
            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Anrede", anrede);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Vorname", vorname);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Nachname", nachname);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Geburtsdatum", dob.ToShortDateString());

            //Kontakt
            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("E-Mail", email);

            //Adresse
            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Strasse", strasse);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Wohnort", wohnort);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Postleitzahl", plz);

            xdoc.Save("Kunde.xml");
            

        }
    }
}
