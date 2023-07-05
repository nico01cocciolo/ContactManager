using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using ContactManager.Model;
using System.Drawing;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Drawing.Text;

namespace ContactManager.Controller
{
    [XmlRootAttribute("Person anlegen", Namespace = "Kunde")]
    internal class PersonAnlegen : KundeAnlegenView
    {
        


        private string Vorname;
        private string Nachname;
        private DateTime Dob;

        public string dataname = "Kunde.xml";
        public bool dirCreated = false;

        private string kunde = "Kunde";
        private string mitarbeiter = "Mitarbeiter";
        private string lehrling = "Lehrling";

        private static int counter = 1;
        
        public void WriteXML(string choose)
        {
            KundeAnlegenView kav = new KundeAnlegenView();
            XmlTextWriter xw = new XmlTextWriter(dataname, new UnicodeEncoding());

            CreateNeededDir();


            xw.WriteStartDocument();
            xw.WriteStartElement(choose);

            xw.WriteStartElement("Persönliche_Daten");
            xw.WriteAttributeString("Titel", null);
            xw.WriteAttributeString("Anrede", null);
            xw.WriteAttributeString("Vorname", Vorname);
            xw.WriteAttributeString("Nachname", Nachname);
            xw.WriteAttributeString("Geburtsdatum", Dob.ToShortDateString());
            xw.WriteAttributeString("Nationalität", null);
            xw.WriteEndElement();

            xw.WriteStartElement("Kontakt_Daten");
            xw.WriteAttributeString("E-Mail", null);
            xw.WriteAttributeString("Telefon_Mobil", null);
            xw.WriteAttributeString("Telefon_Privat", null);
            xw.WriteAttributeString("Telefon_Geschäft", null);
            xw.WriteEndElement();

            xw.WriteStartElement("Adresse");
            xw.WriteAttributeString("Strasse", null);
            xw.WriteAttributeString("Hausnummer", null);
            xw.WriteAttributeString("Postleitzahl", null);
            xw.WriteAttributeString("Wohnort", null);
            xw.WriteEndElement();

            xw.WriteEndElement();
            xw.Close();
            
            counter++;
            Vorname = "";
            Nachname = "";
            

        }

        public void GetKunde(string vorname, string nachname, DateTime dob)
        {
            Vorname = vorname;
            Nachname = nachname;
            Dob = dob;
        }

        private void CreateNeededDir()
        {
            if (Directory.Exists("Kunden") == false && Directory.Exists("Lehrlinge") == false && Directory.Exists("Mitarbeiter") == false)
            {
                Directory.CreateDirectory("Kunden");
                Directory.CreateDirectory("Lehrlinge");
                Directory.CreateDirectory("Mitarbeiter");
            }
        }

    }
}
