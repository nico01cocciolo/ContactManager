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
using System.IO;
using ContactManager.Model;

namespace ContactManager
{
    public partial class UcKundeStamm : UserControl
    {
        public UcKundeStamm()
        {
            InitializeComponent();
        }

        private static UcKundeStamm instance;

        public static UcKundeStamm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UcKundeStamm();
                }
                return instance;
            }
        }

        NotizController nc = new NotizController();
        XMLHandler xmlHandler = new XMLHandler();

        string[] kundentyp = new string[] { "A", "B", "C", "D", "E", "F" };
        string[] anrede = new string[] { "Herr", "Frau", "Divers" };

        private void CmdNotizErfassen_Click(object sender, EventArgs e)
        {
            NotizController nc = new NotizController();

            string notiz = TxtNotizInput.Text;
            string path = $"{IDGetter()}.txt" ;

            nc.NotizErfassen(path, notiz);
        }

        private string IDGetter()
        {
            string cellValue = "";

            if (DtgData.SelectedCells.Count > 0)
            {
                int selectedrowindex = DtgData.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = DtgData.Rows[selectedrowindex];
                cellValue = Convert.ToString(selectedRow.Cells["ID"].Value);

            }
            return cellValue;
        }

        private void UcKundeStamm_Load(object sender, EventArgs e)
        {
            FillCombobox();

            if (File.Exists("Kunde.xml"))
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(Directory.GetCurrentDirectory() + "/Kunde.xml");
                DtgData.DataSource = dataSet.Tables[0];
            }
        }

        private void DtgData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = IDGetter();
            string path = $"{id}.txt";

            Kunde k = xmlHandler.RetriveValuesKunde(id);

            LblId.Text = Convert.ToString(k.Id);
            TxtVorname.Text = k.Vorname;
            TxtNachname.Text = k.Nachname;

            if (File.Exists(path))
            {
                TxtNotizOutput.Text = nc.NotizLaden(path);
            }
            else 
            {
                TxtNotizOutput.Text = "Keine Notizen vorhanden";
            }
        }

        private void Knöpgke_Click(object sender, EventArgs e)
        {
            Guid id = Guid.NewGuid();

            string vorname = "";

            string anrede = CmbAnrede.Text;
            
            if (!String.IsNullOrWhiteSpace(TxtVorname.Text))
            {
                string vor = TxtVorname.Text;
                vorname = vor;
            }
            else 
            {
                ErrVorname.SetError(this.TxtVorname, "Eingabe darf nicht leer sein");
            }

            if (CmbKundentyp.SelectedIndex > -1 && TxtPostleitzahl.TextLength > 0)
            {
                string nachname = TxtNachname.Text;
                DateTime dob = DtpGeburtsdatum.Value;
                string nationalitaet = CmbNationalitaet.Text;
                string ahv = TxtAhvNum.Text;

                string email = TxtEmail.Text;
                string mobil = TxtTelMobil.Text;
                string arbeit = TxtTelGesch.Text;
                string privat = TxtTelPriv.Text;

                string strasse = TxtStrasse.Text;
                string wohnort = TxtWohnort.Text;
                int plz = Convert.ToInt16(TxtPostleitzahl.Text);

                string firmenname = TxtFirmenname.Text;
                string firmenadresse = TxtFirmenadresse.Text;
                string kundekontakt = TxtKundenkontakt.Text;

                char kundentyp = Convert.ToChar(CmbKundentyp.Text);


                Kunde k = new Kunde(id, anrede, vorname, nachname, dob, privat, arbeit, mobil, email, ahv, nationalitaet, strasse, plz, wohnort, firmenname, firmenadresse, kundentyp, kundekontakt);

                xmlHandler.CreateKundeXML(k);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void FillCombobox()
        {
            CmbKundentyp.Items.AddRange(kundentyp);
            CmbAnrede.Items.AddRange(anrede);
        }
    }
}
