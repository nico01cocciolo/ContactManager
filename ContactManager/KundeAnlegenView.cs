using ContactManager.Controller;
using ContactManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class KundeAnlegenView : Form
    {
        public KundeAnlegenView()
        {
            InitializeComponent();
        }

        string filepath = "Notiz.txt";

        Person[] pers = new Person[20];

        bool inputOk = false;
        private static int counter = 0;

        XMLHandler xmlHandler = new XMLHandler();
        NotizController nc = new NotizController();

        private void CmdKundeAnlegen_Click(object sender, EventArgs e)
        {
            PersonAnlegen persAn = new PersonAnlegen();
            Guid id =  Guid.NewGuid();
            string vorname = TxtVorname.Text;
            string nachname = TxtNachname.Text;
            DateTime dob = DtpGeburtsdatum.Value;
            string email = TxtEmail.Text;
            string strasse = TxtStrasse.Text;
            string wohnort = TxtWohnort.Text;
            int plz = Convert.ToInt16(TxtPostleitzahl.Text);

            Person person = new Person(vorname, nachname, dob);
            pers[counter] = person;


            if (CheckInputs() == true && counter < pers.Length)
            {
                //(Guid id, string vorname, string nachname, DateTime dob, string email, string strasse, string wohnort, int plz)
                xmlHandler.CreateXML(id, vorname, nachname, dob, email, strasse, wohnort, plz);
                MessageBox.Show($"Der Nutzer {vorname} {nachname} wurde erstellt.");
            }
        }
        private void CmdNotizErfassen_Click(object sender, EventArgs e)
        {
            if (TxtNotizInput.TextLength < 0)
            nc.NotizErfassen(filepath, TxtNotizInput.Text);
            
            else
            MessageBox.Show("Eingabe darf nicht leer sein!");
   
        }
        private void CmdLesen_Click(object sender, EventArgs e)
        {
            TxtNotizen.Clear();
            TxtNotizen.Text = nc.NotizLaden(filepath);

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
    }
}
