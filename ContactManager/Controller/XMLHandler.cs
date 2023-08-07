using ContactManager.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ContactManager.Controller
{
    internal class XMLHandler
    {
        public void CreateXML(Guid id, string status, string anrede, string vorname, string nachname, DateTime dob, string email, string strasse, string wohnort, int plz)
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

        public void CreateKundeXML(Kunde k)
        {
            if (!File.Exists("Kunde.xml"))
            {
                XDocument xDoc = new XDocument(new XDeclaration("1.0", "UTF-16", "yes"),
                    new XElement("Person",
                    new XElement("Kunde",

                    //Wichtig
                    new XAttribute("ID", k.Id),
                    new XAttribute("Status", "K"),

                    //Person
                    new XElement("Geschlecht", "A"),
                    new XElement("Anrede", k.Anrede),
                    new XElement("Titel", "A"),
                    new XElement("Vorname", k.Vorname),
                    new XElement("Nachname", k.Nachname),
                    new XElement("Geburtsdatum", k.Geburtsdatum.ToShortDateString()),
                    new XElement("Nationalität", k.Nationalität),
                    new XElement("AHV-Nummer", k.AhvNumber),

                    //Kontakt
                    new XElement("E-Mail", k.Email),
                    new XElement("Telefon_Mobil", k.TelefonMobil),
                    new XElement("Telefon_Privat", k.TelefonPrivat),
                    new XElement("Telefon_Arbeit", k.TelefonArbeit),

                    //Adresse
                    new XElement("Strasse", k.Strasse),
                    new XElement("Wohnort", k.Wohnort),
                    new XElement("Postleitzahl", k.Plz),

                    //Kundenspezifisch
                    new XElement("Firmenname", k.Firmenname),
                    new XElement("Firmenadresse", k.Firmenadresse),
                    new XElement("Kundentyp", k.Kundentyp),
                    new XElement("Kundenkontakt", k.Kundenkontakt))));

                xDoc.Save("Kunde.xml");
            }
            else
            {
                XElement xEleo = XElement.Load("Kunde.xml");

                xEleo.Add(new XElement("Kunde",

                    //Wichtig
                    new XAttribute("ID", k.Id),
                    new XAttribute("Status", "K"),

                    //Person
                    new XElement("Geschlecht", "A"),
                    new XElement("Anrede", k.Anrede),
                    new XElement("Titel", "A"),
                    new XElement("Vorname", k.Vorname),
                    new XElement("Nachname", k.Nachname),
                    new XElement("Geburtsdatum", k.Geburtsdatum.ToShortDateString()),
                    new XElement("Nationalität", k.Nationalität),
                    new XElement("AHV-Nummer", k.AhvNumber),

                    //Kontakt
                    new XElement("E-Mail", k.Email),
                    new XElement("Telefon_Mobil", k.TelefonMobil),
                    new XElement("Telefon_Privat", k.TelefonPrivat),
                    new XElement("Telefon_Arbeit", k.TelefonArbeit),

                    //Adresse
                    new XElement("Strasse", k.Strasse),
                    new XElement("Wohnort", k.Wohnort),
                    new XElement("Postleitzahl", k.Plz),

                    //Kundenspezifisch
                    new XElement("Firmenname", k.Firmenname),
                    new XElement("Firmenadresse", k.Firmenadresse),
                    new XElement("Kundentyp", k.Kundentyp),
                    new XElement("Kundenkontakt", k.Kundenkontakt)));

                xEleo.Save("Kunde.xml");
            }

        }

        public void CreateMitarbeiterXML(Mitarbeiter m)
        {
            if (!File.Exists("Mitarbeiter.xml"))
            {
                XDocument xDoc = new XDocument(new XDeclaration("1.0", "UTF-16", "yes"),
                    new XElement("Person",
                    new XElement("Mitarbeiter",

                    //Wichtig
                    new XAttribute("ID", m.Id),
                    new XAttribute("Status", "A"),

                    //Person
                    new XElement("Geschlecht", "A"),
                    new XElement("Anrede", m.Anrede),
                    new XElement("Titel", "A"),
                    new XElement("Vorname", m.Vorname),
                    new XElement("Nachname", m.Nachname),
                    new XElement("Geburtsdatum", m.Geburtsdatum.ToShortDateString()),
                    new XElement("Nationalität", m.Nationalität),
                    new XElement("AHV-Nummer", m.AhvNumber),

                    //Kontakt
                    new XElement("E-Mail", m.Email),
                    new XElement("Telefon_Mobil", m.TelefonMobil),
                    new XElement("Telefon_Privat", m.TelefonPrivat),
                    new XElement("Telefon_Arbeit", m.TelefonArbeit),

                    //Adresse
                    new XElement("Strasse", m.Strasse),
                    new XElement("Wohnort", m.Wohnort),
                    new XElement("Postleitzahl", m.Plz),

                    //Mitarbeiterspezifisch
                    new XElement("Kaderstufe", m.KaderStufe),
                    new XElement("Abteilung", m.Abteilung),
                    new XElement("Startdatum", m.StartDate.ToShortDateString()),
                    new XElement("Arbeitspensum", m.Arbeitspensum))));

                xDoc.Save("Mitarbeiter.xml");
            }
            else
            {
                XElement xEle = XElement.Load("Mitarbeiter.xml");

                xEle.Add(new XElement("Mitarbeiter",

                    //Wichtig
                    new XAttribute("ID", m.Id),
                    new XAttribute("Status", "A"),

                    //Person
                    new XElement("Geschlecht", "A"),
                    new XElement("Anrede", m.Anrede),
                    new XElement("Titel", "A"),
                    new XElement("Vorname", m.Vorname),
                    new XElement("Nachname", m.Nachname),
                    new XElement("Geburtsdatum", m.Geburtsdatum.ToShortDateString()),
                    new XElement("Nationalität", m.Nationalität),
                    new XElement("AHV-Nummer", m.AhvNumber),

                    //Kontakt
                    new XElement("E-Mail", m.Email),
                    new XElement("Telefon_Mobil", m.TelefonMobil),
                    new XElement("Telefon_Privat", m.TelefonPrivat),
                    new XElement("Telefon_Arbeit", m.TelefonArbeit),

                    //Adresse
                    new XElement("Strasse", m.Strasse),
                    new XElement("Wohnort", m.Wohnort),
                    new XElement("Postleitzahl", m.Plz),

                    //Mitarbeiterspezifisch
                    new XElement("Kaderstufe", m.KaderStufe),
                    new XElement("Abteilung", m.Abteilung),
                    new XElement("Startdatum", m.StartDate.ToShortDateString()),
                    new XElement("Arbeitspensum", m.Arbeitspensum)));

                xEle.Save("Mitarbeiter.xml");
            }
        }

        public void CreateLehrlingXML(Lehrling l)
        {
            if (!File.Exists("Mitarbeiter.xml"))
            {
                XDocument xDoc = new XDocument(new XDeclaration("1.0", "UTF-16", "yes"),
                    new XElement("Person",
                    new XElement("Mitarbeiter",

                    //Wichtig
                    new XAttribute("ID", l.Id),
                    new XAttribute("Status", "A"),

                    //Person
                    new XElement("Geschlecht", "A"),
                    new XElement("Anrede", l.Anrede),
                    new XElement("Titel", "A"),
                    new XElement("Vorname", l.Vorname),
                    new XElement("Nachname", l.Nachname),
                    new XElement("Geburtsdatum", l.Geburtsdatum.ToShortDateString()),
                    new XElement("Nationalität", l.Nationalität),
                    new XElement("AHV-Nummer", l.AhvNumber),

                    //Kontakt
                    new XElement("E-Mail", l.Email),
                    new XElement("Telefon_Mobil", l.TelefonMobil),
                    new XElement("Telefon_Privat", l.TelefonPrivat),
                    new XElement("Telefon_Arbeit", l.TelefonArbeit),

                    //Adresse
                    new XElement("Strasse", l.Strasse),
                    new XElement("Wohnort", l.Wohnort),
                    new XElement("Postleitzahl", l.Plz),

                    //Mitarbeiterspezifisch
                    new XElement("Kaderstufe", l.KaderStufe),
                    new XElement("Abteilung", l.KaderStufe),
                    new XElement("Startdatum", l.StartDate),
                    new XElement("Arbeitspensum", l.Arbeitspensum),
                    
                    //Lehrlingspezifisch
                    new XElement("Lehrjahre", l.TraineeYears),
                    new XElement("Aktuelles Lehrjahr", l.ActualTraineeYear))));

                xDoc.Save("Mitarbeiter.xml");
            }
            else
            {
                XElement xEle = XElement.Load("Mitarbeiter.xml");

                xEle.Add(new XElement("Mitarbeiter",
                    new XElement("Mitarbeiter",

                    //Wichtig
                    new XAttribute("ID", l.Id),
                    new XAttribute("Status", "A"),

                    //Person
                    new XElement("Geschlecht", "A"),
                    new XElement("Anrede", l.Anrede),
                    new XElement("Titel", "A"),
                    new XElement("Vorname", l.Vorname),
                    new XElement("Nachname", l.Nachname),
                    new XElement("Geburtsdatum", l.Geburtsdatum.ToShortDateString()),
                    new XElement("Nationalität", l.Nationalität),
                    new XElement("AHV-Nummer", l.AhvNumber),

                    //Kontakt
                    new XElement("E-Mail", l.Email),
                    new XElement("Telefon_Mobil", l.TelefonMobil),
                    new XElement("Telefon_Privat", l.TelefonPrivat),
                    new XElement("Telefon_Arbeit", l.TelefonArbeit),

                    //Adresse
                    new XElement("Strasse", l.Strasse),
                    new XElement("Wohnort", l.Wohnort),
                    new XElement("Postleitzahl", l.Plz),

                    //Mitarbeiterspezifisch
                    new XElement("Kaderstufe", l.KaderStufe),
                    new XElement("Abteilung", l.KaderStufe),
                    new XElement("Startdatum", l.StartDate),
                    new XElement("Arbeitspensum", l.Arbeitspensum),

                    //Lehrlingspezifisch
                    new XElement("Lehrjahre", l.TraineeYears),
                    new XElement("Aktuelles Lehrjahr", l.ActualTraineeYear))));

                xEle.Save("Mitarbeiter.xml");
            }
        }

        public void ChangeValuesMitarbeiterXML(Mitarbeiter m)
        {
            XElement xdoc = XElement.Load("Mitarbeiter.xml");

            string id = Convert.ToString(m.Id);

            //Wichtig
            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetAttributeValue("Status", "A");

            //Person
            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Anrede", m.Anrede);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Vorname", m.Vorname);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Nachname", m.Nachname);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Geburtsdatum", m.Geburtsdatum.ToShortDateString());

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Nationalität", m.Nationalität);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("AHV-Nummer", m.AhvNumber);

            //Kontakt
            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("E-Mail", m.Email);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Telefon_Mobil", m.TelefonMobil);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Telefon_Privat", m.TelefonPrivat);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Telefon_Arbeit", m.TelefonArbeit);

            //Adresse
            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Strasse", m.Strasse);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Wohnort", m.Wohnort);

            //Kunde
            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Kaderstufe", m.KaderStufe);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Abteilung", m.Abteilung);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Startdatum", m.StartDate);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Arbeitspensum", m.Arbeitspensum);

            xdoc.Save("Mitarbeiter.xml");
        }
    }
}
