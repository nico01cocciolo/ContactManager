﻿using ContactManager.Controller;
using ContactManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ContactManager.User_Controlls
{
    public partial class UcMitarbeiterErfassen : UserControl
    {
        public UcMitarbeiterErfassen()
        {
            InitializeComponent();
        }

        bool inputOk = false;

        string[] anrede = new string[] { "Herr", "Frau", "Divers" };
        string[] titel = new string[] { "", "Dr.", "Prof.", "Dipl.-Ing." };

        XMLHandler xmlHandler = new XMLHandler();

        private void CmdMitarbeiterAnlegen_Click(object sender, EventArgs e)
        {
            Guid id = Guid.NewGuid();


            string anrede = CmbAnrede.Text;
            string titel = CmbAnrede.Text;
            string vorname = TxtVorname.Text;
            string nachname = TxtNachname.Text;
            DateTime dob = DtpGeburtsdatum.Value;
            string ahv = TxtAhvNum.Text;
            string nationalitaet = CmbNationalitaet.Text;

            string email = TxtEmail.Text;
            string privat = TxtTelPriv.Text;
            string mobil = TxtTelMobil.Text;
            string arbeit = TxtTelGesch.Text;
            
            string strasse = TxtStrasse.Text;
            string wohnort = TxtWohnort.Text;
            int plz = Convert.ToInt16(TxtPostleitzahl.Text);
            string status = "Aktiv";

            int ks = Convert.ToInt16(NumKaderstufe.Value);
            string abt = TxtAbteilung.Text;
            int arbp = Convert.ToInt16(NumArbeitspensum.Value);
            DateTime st = DtpStartdatum.Value;

           // Mitarbeiter m = new Mitarbeiter(id, anrede, vorname, nachname, dob, privat, arbeit, mobil, email, ahv, nationalitaet, strasse, plz, wohnort, ks, abt, arbp, st);


            //if (CheckInputs() == true)
            //{
            //    xmlHandler.CreateMitarbeiterXML(m);
            //    LblId.Text = Convert.ToString(id);
            //    MessageBox.Show($"Der Nutzer {vorname} {nachname} wurde erstellt.");
            //}
        }

        private bool CheckInputs()
        {
            if (TxtVorname.TextLength <= 0)
            {
                ErrVorname.SetError(TxtVorname, "Eingabe darf nicht leer sein");
                return inputOk = false;
            }
            else
            {
                return inputOk = true;
            }
        }

        private void CmdBack_Click(object sender, EventArgs e)
        {
            UcMitarbeiterErfassen ucMe = new UcMitarbeiterErfassen();
            this.Controls.Clear();

            UcMitarbeiterStamm mf = new UcMitarbeiterStamm();
            mf.Dock = DockStyle.Fill;
            this.Controls.Add(mf);
        }
        private void ClearAll()
        {
            //Parameters
            LblId.Text = "...";
            LblStatus.Text = "...";

            //Personen Daten
            CmbAnrede.ResetText();
            CmbTitel.ResetText();
            TxtVorname.Clear();
            TxtNachname.Clear();
            TxtAhvNum.Clear();

            //Adresse
            TxtStrasse.Clear();
            TxtWohnort.Clear();
            TxtPostleitzahl.Clear();

            //Kontakt Daten
            TxtTelPriv.Clear();
            TxtTelMobil.Clear();
            TxtTelGesch.Clear();
            TxtEmail.Clear();

            //Mitarbeiter Daten
            NumKaderstufe.ResetText();
            NumArbeitspensum.ResetText();
            TxtAbteilung.Clear();
            DtpGeburtsdatum.ResetText();


        }

        private void CmdFelderReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void UcMitarbeiterErfassen_Load(object sender, EventArgs e)
        {
            FillCombobox();
        }

        private void FillCombobox()
        {
            CmbAnrede.Items.AddRange(anrede);
            CmbTitel.Items.AddRange(titel);
        }
    }
}

