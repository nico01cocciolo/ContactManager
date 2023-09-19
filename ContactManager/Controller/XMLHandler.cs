using ContactManager.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        #region Create

        /// <summary>
        /// Zuerst wird Überprüft ob die Datei für Kunden ("Kunde.xml") bereits exisitert.
        /// Sollte die Datei nicht existieren so wird die Datei inkl. dem Kunden erstellt.
        /// 
        /// Existiert die Datei bereits wird der Kunde per Add eingefügt.
        /// </summary>
        public void CreateKundeXML(Kunde k)
        {
            if (!File.Exists("Kunde.xml"))
            {
                XDocument xDoc = new XDocument(new XDeclaration("1.0", "UTF-16", "yes"),
                    new XElement("Person",
                    new XElement("Kunde",

                    //Wichtig
                    new XAttribute("ID", k.Id),
                    new XAttribute("Status", k.isActive),

                    //Person
                    new XElement("Anrede", k.Anrede),
                    new XElement("Titel", k.Title),
                    new XElement("Geschlecht", k.Gender),
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
                    new XAttribute("Status", k.isActive),

                    //Person
                    new XElement("Anrede", k.Anrede),
                    new XElement("Titel", k.Title),
                    new XElement("Geschlecht", k.Gender),
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
        /// <summary>
        /// Zuerst wird Überprüft ob die Datei für Mitarbeiter ("Mitarbeiter.xml") bereits exisitert.
        /// Sollte die Datei nicht existieren so wird die Datei inkl. dem Mitarbeiter erstellt.
        /// 
        /// Existiert die Datei bereits wird der Mitarbeiter per Add eingefügt.
        /// </summary>
        public void CreateMitarbeiterXML(Mitarbeiter m)
        {
            if (!File.Exists("Mitarbeiter.xml"))
            {
                XDocument xDoc = new XDocument(new XDeclaration("1.0", "UTF-16", "yes"),
                    new XElement("Person",
                    new XElement("Mitarbeiter",

                    //Wichtig
                    new XAttribute("ID", m.Id),
                    new XAttribute("Status", m.isActive),
                    new XAttribute("Lehrling", m.isTrainee),

                    //Person
                    new XElement("Anrede", m.Anrede),
                    new XElement("Titel", m.Title),
                     new XElement("Geschlecht", m.Gender),
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
                    new XElement("Rolle", m.Rolle),
                    new XElement("Startdatum", m.StartDate.ToShortDateString()),
                    new XElement("Enddatum", m.EndDate.ToShortDateString()),
                    new XElement("Arbeitspensum", m.Arbeitspensum))));

                xDoc.Save("Mitarbeiter.xml");
            }
            else
            {
                XElement xEle = XElement.Load("Mitarbeiter.xml");

                xEle.Add(new XElement("Mitarbeiter",

                    //Wichtig
                    new XAttribute("ID", m.Id),
                    new XAttribute("Status", m.isActive),
                    new XAttribute("Lehrling", m.isTrainee),

                    //Person
                    new XElement("Anrede", m.Anrede),
                    new XElement("Titel", m.Title),
                    new XElement("Geschlecht", m.Gender),
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
                    new XElement("Rolle", m.Rolle),
                    new XElement("Startdatum", m.StartDate.ToShortDateString()),
                    new XElement("Enddatum", m.EndDate.ToShortDateString()),
                    new XElement("Arbeitspensum", m.Arbeitspensum)));

                xEle.Save("Mitarbeiter.xml");
            }
        }

        /// <summary>
        /// Zuerst wird Überprüft ob die Datei für Lehrling ("Mitarbeiter.xml") bereits exisitert.
        /// Sollte die Datei nicht existieren so wird die Datei inkl. dem Mitarbeiter erstellt.
        /// 
        /// Existiert die Datei bereits wird der Mitarbeiter per Add eingefügt.
        /// Beim Lehrling werden noch drei Weitere Werte hinzugefügt (Lehrjahre, aktuelles Lehrjahr und der Status ob es ein Lehrling ist)
        /// </summary>
        public void CreateLehrlingXML(Lehrling l)
        {
            if (!File.Exists("Mitarbeiter.xml"))
            {
                XDocument xDoc = new XDocument(new XDeclaration("1.0", "UTF-16", "yes"),
                    new XElement("Person",
                    new XElement("Mitarbeiter",

                    //Wichtig
                    new XAttribute("ID", l.Id),
                    new XAttribute("Status", l.isActive),
                    new XAttribute("Lehrling", l.isTrainee),

                    //Person
                    new XElement("Anrede", l.Anrede),
                    new XElement("Titel", l.Title),
                    new XElement("Geschlecht", l.Gender),
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
                    new XElement("Abteilung", l.Abteilung),
                    new XElement("Rolle", l.Rolle),
                    new XElement("Startdatum", l.StartDate.ToShortDateString()),
                    new XElement("Enddatum", l.EndDate.ToShortDateString()),
                    new XElement("Arbeitspensum", l.Arbeitspensum),
                    
                    //Lehrlingspezifisch
                    new XElement("Lehrjahre", l.TraineeYears),
                    new XElement("Aktuelles_Lehrjahr", l.ActualTraineeYear))));

                xDoc.Save("Mitarbeiter.xml");
            }
            else
            {
                XElement xEle = XElement.Load("Mitarbeiter.xml");

                xEle.Add(new XElement("Mitarbeiter",

                    //Wichtig
                    new XAttribute("ID", l.Id),
                    new XAttribute("Status", l.isActive),
                    new XAttribute("Lehrling", l.isTrainee),

                    //Person

                    new XElement("Anrede", l.Anrede),
                    new XElement("Titel", l.Title),
                    new XElement("Geschlecht", l.Gender),
                    new XElement("Vorname", l.Vorname),
                    new XElement("Nachname", l.Nachname),
                    new XElement("Geburtsdatum", l.Geburtsdatum.ToShortDateString()),
                    new XElement("Enddatum", l.EndDate.ToShortDateString()),
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
                    new XElement("Abteilung", l.Abteilung),
                    new XElement("Rolle", l.Rolle),
                    new XElement("Startdatum", l.StartDate.ToShortDateString()),
                    new XElement("Arbeitspensum", l.Arbeitspensum),

                    //Lehrlingspezifisch
                    new XElement("Lehrjahre", l.TraineeYears),
                    new XElement("Aktuelles_Lehrjahr", l.ActualTraineeYear)));

                xEle.Save("Mitarbeiter.xml");
            }
        }
        #endregion

        #region Update

        /// <summary>
        /// Das Objekt Mitarbeiter "m" gibt die ganzen Werte welche die enthalten sind wieder in die Felder ein und speicher diese danach.
        /// </summary>
        public void ChangeValuesMitarbeiterXML(Mitarbeiter m)
        {
            XElement xdoc = XElement.Load("Mitarbeiter.xml");

            string id = Convert.ToString(m.Id);

            //Wichtig
            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetAttributeValue("Status", m.isActive);
            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetAttributeValue("Lehrling", m.isTrainee);

            //Person
            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Titel", m.Title);
           
            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Anrede", m.Anrede);
            
            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Geschlecht", m.Gender);

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
            
            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Postleitzahl", m.Plz);

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

        /// <summary>
        /// Das Objekt Kunde "k" gibt die ganzen Werte welche die enthalten sind wieder in die Felder ein und speicher diese danach.
        /// </summary>
        public void ChangeValuesKundeXML(Kunde k)
        {
            XElement xdoc = XElement.Load("Kunde.xml");

            string id = Convert.ToString(k.Id);

            //Attribute
            xdoc.Elements("Kunde")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetAttributeValue("Status", k.isActive);

            //Persönliche Daten
            xdoc.Elements("Kunde")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Titel", k.Title);

            xdoc.Elements("Kunde")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Anrede", k.Anrede);

            xdoc.Elements("Kunde")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Geschlecht", k.Gender);

            xdoc.Elements("Kunde")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Vorname", k.Vorname);

            xdoc.Elements("Kunde")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Nachname", k.Nachname);

            xdoc.Elements("Kunde")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Geburtsdatum", k.Geburtsdatum.ToShortDateString());

            xdoc.Elements("Kunde")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Nationalität", k.Nationalität);

            xdoc.Elements("Kunde")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("AHV-Nummer", k.AhvNumber);

            //Kontaktdaten

            xdoc.Elements("Kunde")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("E-Mail", k.Email);

            xdoc.Elements("Kunde")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Telefon_Mobil", k.TelefonMobil);

            xdoc.Elements("Kunde")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Telefon_Privat", k.TelefonPrivat);

            xdoc.Elements("Kunde")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Telefon_Arbeit", k.TelefonArbeit);

            //Adresse
            xdoc.Elements("Kunde")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Strasse", k.Strasse);

            xdoc.Elements("Kunde")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Wohnort", k.Wohnort);

            xdoc.Elements("Kunde")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Postleitzahl", k.Plz);

            //Kundenspezifische Parameter
            xdoc.Elements("Kunde")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Firmenname", k.Firmenname);

            xdoc.Elements("Kunde")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Firmenadresse", k.Firmenadresse);

            xdoc.Elements("Kunde")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Kundentyp", k.Kundentyp);

            xdoc.Elements("Kunde")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Kundenkontakt", k.Kundenkontakt);

            xdoc.Save("Kunde.xml");
        }

        /// <summary>
        /// Das Objekt Lehrling "l" gibt die ganzen Werte welche die enthalten sind wieder in die Felder ein und speicher diese danach.
        /// </summary>
        public void ChangeValuesLehrlingXML(Lehrling l)
        {
            XElement xdoc = XElement.Load("Mitarbeiter.xml");

            string id = Convert.ToString(l.Id);

            //Wichtig
            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetAttributeValue("Status", l.isActive);
            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetAttributeValue("Lehrling", l.isTrainee);

            //Person
            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Titel", l.Title);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Anrede", l.Anrede);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Geschlecht", l.Gender);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Vorname", l.Vorname);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Nachname", l.Nachname);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Geburtsdatum", l.Geburtsdatum.ToShortDateString());

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Nationalität", l.Nationalität);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("AHV-Nummer", l.AhvNumber);

            //Kontakt
            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("E-Mail", l.Email);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Telefon_Mobil", l.TelefonMobil);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Telefon_Privat", l.TelefonPrivat);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Telefon_Arbeit", l.TelefonArbeit);

            //Adresse
            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Strasse", l.Strasse);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Wohnort", l.Wohnort);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Wohnort", l.Plz);

            //Kunde
            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Kaderstufe", l.KaderStufe);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Abteilung", l.Abteilung);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Startdatum", l.StartDate);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Arbeitspensum", l.Arbeitspensum);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Lehrjahre", l.TraineeYears);

            xdoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .SetElementValue("Aktuelles_Lehrjahr", l.ActualTraineeYear);

            xdoc.Save("Mitarbeiter.xml");
        }
        #endregion

        #region Read

        /// <summary>
        /// Liest die ganzen Werte aus dem XML-File aus anhand der ID welche über den string id erhalten wird.
        /// Die ganzen Werte werden danach in das Objekt Mitarbeiter m gecastet und danach per return wieder ausgegeben.
        /// </summary>
        public Mitarbeiter RetriveValuesMitarbeiter(string id)
        {
            XElement xdoc = XElement.Load("Mitarbeiter.xml");

            Guid ide = Guid.Parse(id);

            bool status = Convert.ToBoolean(xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Attribute("Status").Value);

            bool isTrainee = Convert.ToBoolean(xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Attribute("Lehrling").Value);

            string anrede =     xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Element("Anrede").Value;

            string title =      xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Element("Titel").Value;

            string geschlecht = xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Element("Geschlecht").Value;

            string vorname =    xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Element("Vorname").Value;
           
            string nachname =   xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Element("Nachname").Value;
            
            DateTime geburtsdatum = Convert.ToDateTime(xdoc.Elements("Mitarbeiter")
                                           .Where(x => x.Attribute("ID").Value == id)
                                           .FirstOrDefault().Element("Geburtsdatum").Value);

            string ahv =        xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Element("AHV-Nummer").Value;

            string nationalitaet =  xdoc.Elements("Mitarbeiter")
                                        .Where(x => x.Attribute("ID").Value == id)
                                        .FirstOrDefault().Element("Nationalität").Value;

            string email = xdoc.Elements("Mitarbeiter")
                               .Where(x => x.Attribute("ID").Value == id)
                               .FirstOrDefault().Element("E-Mail").Value;

            string arbeit = xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Element("Telefon_Arbeit").Value;

            string mobil = xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Element("Telefon_Mobil").Value;

            string privat = xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Element("Telefon_Privat").Value;

            string strasse = xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Element("Strasse").Value;

            string wohnort = xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Element("Wohnort").Value;

            int plz = Convert.ToInt16(xdoc.Elements("Mitarbeiter")
                                        .Where(x => x.Attribute("ID").Value == id)
                                        .FirstOrDefault().Element("Postleitzahl").Value);

            int kaderstufe = Convert.ToInt16(xdoc.Elements("Mitarbeiter")
                                            .Where(x => x.Attribute("ID").Value == id)
                                            .FirstOrDefault().Element("Kaderstufe").Value);

            string abteilung = xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Element("Abteilung").Value;

            string rolle = xdoc.Elements("Mitarbeiter")
                                            .Where(x => x.Attribute("ID").Value == id)
                                            .FirstOrDefault().Element("Rolle").Value;

            DateTime start = Convert.ToDateTime(xdoc.Elements("Mitarbeiter")
                                            .Where(x => x.Attribute("ID").Value == id)
                                            .FirstOrDefault().Element("Startdatum").Value);
            
            DateTime end = Convert.ToDateTime(xdoc.Elements("Mitarbeiter")
                                            .Where(x => x.Attribute("ID").Value == id)
                                            .FirstOrDefault().Element("Enddatum").Value);

            int arbeitspensum = Convert.ToInt16(xdoc.Elements("Mitarbeiter")
                                            .Where(x => x.Attribute("ID").Value == id)
                                            .FirstOrDefault().Element("Arbeitspensum").Value);

            Mitarbeiter m = new Mitarbeiter(ide, status, isTrainee, anrede, title, geschlecht,vorname, nachname, geburtsdatum, privat, arbeit, mobil, email, ahv, nationalitaet, strasse, plz, wohnort, kaderstufe, rolle, abteilung, arbeitspensum, start, end);
            return m;

        }

        /// <summary>
        /// Liest die ganzen Werte aus dem XML-File aus anhand der ID welche über den string id erhalten wird.
        /// Die ganzen Werte werden danach in das Objekt Kunde k gecastet und danach per return wieder ausgegeben.
        /// </summary>
        public Kunde RetriveValuesKunde(string id)
        {
            XElement xDoc = XElement.Load("Kunde.xml");

            Guid ide = Guid.Parse(id);

            bool status = Convert.ToBoolean(xDoc.Elements("Kunde")
                                .Where(x => x.Attribute("ID").Value == id)
                                .FirstOrDefault().Attribute("Status").Value);

            string anrede = xDoc.Elements("Kunde")
                                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                                .Element("Anrede").Value;

            string title = xDoc.Elements("Kunde")
                                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                                .Element("Titel").Value;

            string geschlecht = xDoc.Elements("Kunde")
                                .Where(x => x.Attribute("ID").Value == id)
                                .FirstOrDefault().Element("Geschlecht").Value;

            string vorname = xDoc.Elements("Kunde")
                                 .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                                 .Element("Vorname").Value;

            string nachname = xDoc.Elements("Kunde")
                                  .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                                  .Element("Nachname").Value;

            DateTime geburtsdatum = Convert.ToDateTime(xDoc.Elements("Kunde")
                                           .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                                           .Element("Geburtsdatum").Value);

            string nationalitaet = xDoc.Elements("Kunde")
                                       .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                                       .Element("Nationalität").Value;

            string ahv = xDoc.Elements("Kunde")
                             .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                             .Element("AHV-Nummer").Value;

            string email = xDoc.Elements("Kunde")
                               .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                               .Element("E-Mail").Value;

            string mobil = xDoc.Elements("Kunde")
                               .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                               .Element("Telefon_Mobil").Value;
            
            string arbeit = xDoc.Elements("Kunde")
                                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                                .Element("Telefon_Arbeit").Value;

            string privat = xDoc.Elements("Kunde")
                                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                                .Element("Telefon_Privat").Value;

            string strasse = xDoc.Elements("Kunde")
                                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                                .Element("Strasse").Value;
            
            string wohnort = xDoc.Elements("Kunde")
                                 .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                                 .Element("Wohnort").Value;
            
            int plz = Convert.ToInt16(xDoc.Elements("Kunde")
                          .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                          .Element("Postleitzahl").Value);

            string firmenname = xDoc.Elements("Kunde")
                                    .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                                    .Element("Firmenname").Value;

            string firmenadresse = xDoc.Elements("Kunde")
                                       .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                                       .Element("Firmenadresse").Value;

            char kundentyp = Convert.ToChar(xDoc.Elements("Kunde")
                                    .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                                    .Element("Kundentyp").Value);

            string kundenkontakt = xDoc.Elements("Kunde")
                                       .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                                       .Element("Kundenkontakt").Value;

            Kunde k = new Kunde(ide, status, anrede, title, geschlecht, vorname, nachname, geburtsdatum, privat, arbeit, mobil, email, ahv, nationalitaet, strasse, plz, wohnort, firmenname, firmenadresse, kundentyp, kundenkontakt);

            return k;

        }

        /// <summary>
        /// Liest die ganzen Werte aus dem XML-File aus anhand der ID welche über den string id erhalten wird.
        /// Die ganzen Werte werden danach in das Objekt Lehrling l gecastet und danach per return wieder ausgegeben.
        /// </summary>
        public Lehrling RetriveValueLehrling(string id)
        {
            XElement xdoc = XElement.Load("Mitarbeiter.xml");

            Guid ide = Guid.Parse(id);

            bool status = Convert.ToBoolean(xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Attribute("Status").Value);

            bool istrainee = Convert.ToBoolean(xdoc.Elements("Mitarbeiter")
                        .Where(x => x.Attribute("ID").Value == id)
                        .FirstOrDefault().Attribute("Lehrling").Value);

            string anrede = xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Element("Anrede").Value;

            string title = xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Element("Titel").Value;

            string geschlecht = xdoc.Elements("Mitarbeiter")
                        .Where(x => x.Attribute("ID").Value == id)
                        .FirstOrDefault().Element("Geschlecht").Value;

            string vorname = xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Element("Vorname").Value;

            string nachname = xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Element("Nachname").Value;

            DateTime geburtsdatum = Convert.ToDateTime(xdoc.Elements("Mitarbeiter")
                                           .Where(x => x.Attribute("ID").Value == id)
                                           .FirstOrDefault().Element("Geburtsdatum").Value);

            string ahv = xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Element("AHV-Nummer").Value;

            string nationalitaet = xdoc.Elements("Mitarbeiter")
                                        .Where(x => x.Attribute("ID").Value == id)
                                        .FirstOrDefault().Element("Nationalität").Value;

            string email = xdoc.Elements("Mitarbeiter")
                               .Where(x => x.Attribute("ID").Value == id)
                               .FirstOrDefault().Element("E-Mail").Value;

            string arbeit = xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Element("Telefon_Arbeit").Value;

            string mobil = xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Element("Telefon_Mobil").Value;

            string privat = xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Element("Telefon_Privat").Value;

            string strasse = xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Element("Strasse").Value;

            string wohnort = xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Element("Wohnort").Value;

            int plz = Convert.ToInt16(xdoc.Elements("Mitarbeiter")
                                        .Where(x => x.Attribute("ID").Value == id)
                                        .FirstOrDefault().Element("Postleitzahl").Value);

            int kaderstufe = Convert.ToInt16(xdoc.Elements("Mitarbeiter")
                                            .Where(x => x.Attribute("ID").Value == id)
                                            .FirstOrDefault().Element("Kaderstufe").Value);

            string abteilung = xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Element("Abteilung").Value;

            string rolle = xdoc.Elements("Mitarbeiter")
                                            .Where(x => x.Attribute("ID").Value == id)
                                            .FirstOrDefault().Element("Rolle").Value;

            DateTime start = Convert.ToDateTime(xdoc.Elements("Mitarbeiter")
                                            .Where(x => x.Attribute("ID").Value == id)
                                            .FirstOrDefault().Element("Startdatum").Value);

            DateTime end = Convert.ToDateTime(xdoc.Elements("Mitarbeiter")
                                            .Where(x => x.Attribute("ID").Value == id)
                                            .FirstOrDefault().Element("Enddatum").Value);

            int arbeitspensum = Convert.ToInt16(xdoc.Elements("Mitarbeiter")
                                            .Where(x => x.Attribute("ID").Value == id)
                                            .FirstOrDefault().Element("Arbeitspensum").Value);

            int lehrjahre = Convert.ToInt16(xdoc.Elements("Mitarbeiter").Where(x => x.Attribute("ID").Value == id).FirstOrDefault().Element("Lehrjahre").Value);

            int aktlehrjahr = Convert.ToInt16(xdoc.Elements("Mitarbeiter").Where(x => x.Attribute("ID").Value == id).FirstOrDefault().Element("Aktuelles_Lehrjahr").Value);


            Lehrling l = new Lehrling(ide, status, istrainee, anrede, title, geschlecht, vorname, nachname, geburtsdatum, privat, arbeit, mobil, email, ahv, nationalitaet, strasse, plz, wohnort, kaderstufe, rolle, abteilung, arbeitspensum, start, end, lehrjahre, aktlehrjahr);

            return l;
        }
        #endregion

        #region Delete

        /// <summary>
        /// Die ID wird in die Löschfunktion eingefügt, diese löscht danach den Kunden welcher die ID besitzen.
        /// </summary>
        public void DeleteValuesKunde(string id)
        {
            XElement xDoc = XElement.Load("Kunde.xml");

            xDoc.Elements("Kunde")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .Remove();

            xDoc.Save("Kunde.xml");
        }

        /// <summary>
        /// Die ID wird in die Löschfunktion eingefügt, diese löscht danach den Mitarbeiter/Lehrling welcher die ID besitzen.
        /// </summary>
        public void DeleteValuesMitarbeiter(string id)
        {
            XElement xDoc = XElement.Load("Mitarbeiter.xml");

            xDoc.Elements("Mitarbeiter")
                .Where(x => x.Attribute("ID").Value == id).FirstOrDefault()
                .Remove();

            xDoc.Save("Mitarbeiter.xml");
        }
        #endregion
    }
}
