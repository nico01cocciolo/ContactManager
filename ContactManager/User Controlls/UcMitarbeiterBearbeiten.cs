﻿using ContactManager.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ContactManager.User_Controlls
{
    public partial class UcMitarbeiterBearbeiten : UserControl
    {
        UcMitarbeiterStamm ucm = new UcMitarbeiterStamm();

        public UcMitarbeiterBearbeiten()
        {
            InitializeComponent();
        }
        
        XMLHandler xmlHandler = new XMLHandler();

        public string id { get; set; }

        private void CmdFelderReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }


        private void CmdLaden_Click(object sender, EventArgs e)
        {

            //try
            //{

            //XElement xdoc = XElement.Load("Kunde.xml");

            //LblId.Text = xdoc.Element("Mitarbeiter").Attribute("ID").Value;
            //LblStatus.Text = xdoc.Element("Mitarbeiter").Attribute("Status").Value;

            //TxtVorname.Text = xdoc.Element("Mitarbeiter").Element("Vorname").Value;

            //TxtNachname.Text = xdoc.Element("Mitarbeiter").Element("Nachname").Value;
            //DtpGeburtsdatum.Value = Convert.ToDateTime(xdoc.Element("Mitarbeiter").Element("Geburtsdatum").Value);

            //TxtEmail.Text = xdoc.Element("Mitarbeiter").Element("E-Mail").Value;

            //TxtStrasse.Text = xdoc.Element("Mitarbeiter").Element("Strasse").Value;
            //TxtWohnort.Text = xdoc.Element("Mitarbeiter").Element("Wohnort").Value;
            //TxtPostleitzahl.Text = xdoc.Element("Mitarbeiter").Element("Postleitzahl").Value;
            //}
            //catch 
            //{
            //    MessageBox.Show("Konnte die Werte nicht laden.");
            //}



        }

        private void CmdKundeBearbeiten_Click(object sender, EventArgs e)
        {
            try
            {
                string banane = id;

                string vorname = TxtVorname.Text;
                string nachname = TxtNachname.Text;
                DateTime dob = DtpGeburtsdatum.Value;

                string email = TxtEmail.Text;

                string strasse = TxtStrasse.Text;
                string wohnort = TxtWohnort.Text;
                int postleitzahl = Convert.ToInt16(TxtPostleitzahl.Text);

                string status = PersonenStatus();

                xmlHandler.ChangeValuesXML(id, status, vorname, nachname, dob, email, strasse, wohnort, postleitzahl);
            }

            catch
            {
                MessageBox.Show("Konnte die Werte nicht anpassen.");
            }
        }
        private string PersonenStatus()
        {
            if (!ChkStatus.Checked)
            {
                return "Deaktiviert";
            }
            else
            {
                return "Aktiv";
            }
        }
        private void ClearAll()
        {
            //Personen Daten
            TxtVorname.Clear();
            TxtNachname.Clear();
            TxtAhvNum.Clear();

            //Adresse
            TxtStrasse.Clear();
            TxtHausnummer.Clear();
            TxtWohnort.Clear();
            TxtPostleitzahl.Clear();

            //Kontakt Daten
            TxtTelPriv.Clear();
            TxtTelMobil.Clear();
            TxtTelGesch.Clear();
            TxtEmail.Clear();

            TxtFirmenname.Clear();

            LblId.Text = "...";
            LblStatus.Text = "...";
        }

        private void CmdBack_Click(object sender, EventArgs e)
        {
            UcMitarbeiterBearbeiten mb = new UcMitarbeiterBearbeiten();
            this.Controls.Clear();

            UcMitarbeiterStamm mf = new UcMitarbeiterStamm();
            mf.Dock = DockStyle.Fill;
            this.Controls.Add(mf);


        }

        private void CmdShowID_Click(object sender, EventArgs e)
        {
            
        }

        private void UcMitarbeiterBearbeiten_Load(object sender, EventArgs e)
        {
            XElement xdoc = XElement.Load("Kunde.xml");

            LblId.Text = xdoc.Elements("Mitarbeiter")
                             .Where(x => x.Attribute("ID").Value == id)
                             .FirstOrDefault().Attribute("ID").Value;

            TxtVorname.Text = xdoc.Elements("Mitarbeiter")
                                     .Where(x => x.Attribute("ID").Value == id)
                                     .FirstOrDefault().Element("Vorname").Value;

            TxtNachname.Text = xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Element("Nachname").Value;

            DtpGeburtsdatum.Value = Convert.ToDateTime(xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Element("Geburtsdatum").Value);
            
            TxtEmail.Text = xdoc.Elements("Mitarbeiter")
                                .Where(x => x.Attribute("ID").Value == id)
                                .FirstOrDefault().Element("E-Mail").Value;

            TxtStrasse.Text = xdoc.Elements("Mitarbeiter")
                                .Where(x => x.Attribute("ID").Value == id)
                                .FirstOrDefault().Element("Strasse").Value;

            TxtWohnort.Text = xdoc.Elements("Mitarbeiter")
                                .Where(x => x.Attribute("ID").Value == id)
                                .FirstOrDefault().Element("Wohnort").Value;

            TxtPostleitzahl.Text = xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Element("Postleitzahl").Value;
        }
    }
}
