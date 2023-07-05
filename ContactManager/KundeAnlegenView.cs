using ContactManager.Controller;
using ContactManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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

        Person[] pers = new Person[20];

        bool inputOk = false;
        private static int counter = 0;

        private void CmdKundeAnlegen_Click(object sender, EventArgs e)
        {
            PersonAnlegen persAn = new PersonAnlegen();
            string Vorname = TxtVorname.Text;
            string Nachname = TxtNachname.Text;
            DateTime dob = DtpGeburtsdatum.Value;

            Person person = new Person(Vorname, Nachname, dob);
            pers[counter] = person;


            if (CheckInputs() == true && counter < pers.Length)
            {
            string kunde = "Kunde";
            
            string gaggi = $"Kunde erstellt: \r\n Vorname: {Vorname} \r\n Nachname: {Nachname} \r\n Geburtstag: {dob.ToShortDateString()}";
            string personalien = $"Kunde \r\n {pers[counter].Firstname} {pers[counter].Lastname} ";

            TxtNotizen.Text += gaggi + "\r\n";
            TxtNotizen.Text += personalien + "\r\n";

            persAn.GetKunde(Vorname, Nachname, dob);
            persAn.WriteXML(kunde);

            TxtVorname.Clear();
            TxtNachname.Clear();
            
            counter++;
            inputOk = false;
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
    
    }

}
