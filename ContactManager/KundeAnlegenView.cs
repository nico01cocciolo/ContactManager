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

namespace ContactManager
{
    public partial class KundeAnlegenView : Form
    {
        public KundeAnlegenView()
        {
            InitializeComponent();
        }

        Person[] pers = new Person[10];

        bool inputOk = false;

        private void CmdKundeAnlegen_Click(object sender, EventArgs e)
        {
            PersonAnlegen persAn = new PersonAnlegen();
            string Vorname = TxtVorname.Text;
            string Nachname = TxtNachname.Text;
            DateTime dob = DtpGeburtsdatum.Value;

            Person person = new Person(Vorname, Nachname, dob);
            pers[0] = person;


            if (CheckInputs() == true)
            {

            string gaggi = $"Kunde erstellt: \r\n Vorname: {Vorname} \r\n Nachname: {Nachname} \r\n Geburtstag: {dob.ToShortDateString()}";
            string personalien = $"Kunde \r\n {pers[0].Firstname} {pers[0].Lastname} ";

            TxtNotizen.Text += gaggi + "\r\n";
            TxtNotizen.Text += personalien;

            persAn.GetKunde(Vorname, Nachname, dob);
            persAn.WriteXML();

            TxtVorname.Clear();
            TxtNachname.Clear();
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
