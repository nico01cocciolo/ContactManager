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
        public void CreateXML(Guid id, string status, string vorname, string nachname, DateTime dob, string email, string strasse, string wohnort, int plz)
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
            else
            {
                XElement xEleo = XElement.Load("Kunde.xml");

                xEleo.Add(new XElement("Mitarbeiter",
                    //Wichtig
                    new XAttribute("ID", id),
                    new XAttribute("Status", status),
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
                    new XElement("Postleitzahl", plz)));
                xEleo.Save("Kunde.xml");
            }
        }

        public void ChangeValuesXML(string status, string vorname, string nachname, DateTime dob, string email, string strasse, string wohnort, int plz)
        {
            UcMitarbeiterStamm ucm = new UcMitarbeiterStamm();

            string id =  ucm.IDGetter();
            XElement xdoc = XElement.Load("Kunde.xml");
           
            //Wichtig
            xdoc.Element("Mitarbeiter").Attribute("Status").SetValue(status);

            //Person
            xdoc.Element("Mitarbeiter").Element("Vorname").SetValue(vorname);
            xdoc.Element("Mitarbeiter").Element("Nachname").SetValue(nachname);
            xdoc.Element("Mitarbeiter").Element("Geburtsdatum").SetValue(dob.ToShortDateString());
            
            //Kontakt
            xdoc.Element("Mitarbeiter").Element("E-Mail").SetValue(email);
            
            //Adresse
            xdoc.Element("Mitarbeiter").Element("Strasse").SetValue(strasse);
            xdoc.Element("Mitarbeiter").Element("Wohnort").SetValue(wohnort);
            xdoc.Element("Mitarbeiter").Element("Postleitzahl").SetValue(plz);

            xdoc.Save("Kunde.xml");
            

        }
    }
}
