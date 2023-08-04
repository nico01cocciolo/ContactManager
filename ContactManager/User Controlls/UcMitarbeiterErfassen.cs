using ContactManager.Controller;
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

        Person[] pers = new Person[20];

        bool inputOk = false;
        private static int counter = 0;

        XMLHandler xmlHandler = new XMLHandler();

        private void CmdKundeAnlegen_Click(object sender, EventArgs e)
        {


            PersonAnlegen persAn = new PersonAnlegen();

            Guid id = Guid.NewGuid();

            string anrede = CmbAnrede.Text;
            string vorname = TxtVorname.Text;
            string nachname = TxtNachname.Text;
            DateTime dob = DtpGeburtsdatum.Value;
            string email = TxtEmail.Text;
            string strasse = TxtStrasse.Text;
            string wohnort = TxtWohnort.Text;
            int plz = Convert.ToInt16(TxtPostleitzahl.Text);
            string status = "Aktiv";

            Person person = new Person(vorname, nachname, dob);
            pers[counter] = person;


            if (CheckInputs() == true && counter < pers.Length)
            {


                //(Guid id, string vorname, string nachname, DateTime dob, string email, string strasse, string wohnort, int plz)
                xmlHandler.CreateXML(id, status, anrede, vorname, nachname, dob, email, strasse, wohnort, plz);
                LblId.Text = Convert.ToString(id);
                MessageBox.Show($"Der Nutzer {vorname} {nachname} wurde erstellt.");
            }
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

        private void CmdFelderReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void UcMitarbeiterErfassen_Load(object sender, EventArgs e)
        {
            CmbAnrede.Items.Add("Herr");
            CmbAnrede.Items.Add("Frau");
        }
    }
}

