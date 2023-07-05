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

namespace ContactManager.Controller
{
    [XmlRootAttribute("Person anlegen", Namespace = "Kunde")]
    internal class PersonAnlegen : KundeAnlegenView
    {
        


        private string Vorname;
        private string Nachname;
        private DateTime Dob;



        public void WriteXML()
        {
            KundeAnlegenView kav = new KundeAnlegenView();
            XmlTextWriter xw = new XmlTextWriter("Text.xml", new UnicodeEncoding());
           

            xw.WriteStartDocument();
            xw.WriteStartElement("Kunde");

            xw.WriteStartElement("Persönliche Daten");
            xw.WriteAttributeString("Vorname", Vorname);
            xw.WriteAttributeString("Nachname", Nachname);
            xw.WriteAttributeString("Geburtsdatum", Dob.ToShortDateString());

            //xw.WriteStartElement("Kontakt Daten");
            //xw.WriteAttributeString("E-Mail:", );
            //xw.WriteAttributeString("Telefon Mobil", );
            //xw.WriteAttributeString("Telefon Privat", );
            //xw.WriteAttributeString("Telefon Geschäft", );


            xw.WriteEndElement();
            xw.Close();

            Vorname = "";
            Nachname = "";
            

        }

        public void GetKunde(string vorname, string nachname, DateTime dob)
        {
            Vorname = vorname;
            Nachname = nachname;
            Dob = dob;
        }
    }
}
