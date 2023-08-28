using ContactManager.Controller;
using ContactManager.Model;
using ContactManager.User_Controlls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace ContactManager
{
    public partial class UcMitarbeiterStamm : UserControl
    {
        public UcMitarbeiterStamm()
        {
            InitializeComponent();
        }

        string[] anrede = new string[] { "Herr", "Frau", "Divers" };
        string[] titel = new string[] { "", "Dr.", "Prof.", "Dipl.-Ing." };
        string[] geschlecht = new string[] { "Männlich", "Weiblich", "Divers" };

        private int index { get; set; }

        XMLHandler xmlHandler = new XMLHandler();

        private static UcMitarbeiterStamm instance;

        public static UcMitarbeiterStamm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UcMitarbeiterStamm();

                }
                return instance;
            }
        }

        private void CmdMitarbeiterErstellen_Click(object sender, EventArgs e)
        {
            Kill.Visible = false;
            CmbReset.Visible = false;
            CmdCancel.Visible = true;
            ChangeTxtValuesAllow();
            ClearAll();
            CmdMitarbeiterErstellen.Visible = false;
            CmdMitarbeiterSpeichernErstellen.Visible = true;
            CmdMitarbeiterBearbeiten.Visible = false;
            DtgData.Enabled = false;

        }

        private void CmdMitarbeiterBearbeiten_Click(object sender, EventArgs e)
        {
            Kill.Visible = false;
            CmbReset.Visible = false;
            CmdCancel.Visible = true;
            ChangeTxtValuesAllow();
            CmdWerteSpeichern.Visible = true;
            CmdMitarbeiterBearbeiten.Visible = false;
            CmdMitarbeiterErstellen.Visible = false;
            DtgData.Enabled = false;

        }

        private void UcMitarbeiterStamm_Load(object sender, EventArgs e)
        {
            ChangeTxtValuesDeny();
            FillCombobox();
            LoadFile();
            Kill.Visible = false;
            CmbReset.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DtgData.SelectedCells.Count > 0)
            {
                index = DtgData.CurrentRow.Index;

                CmdMitarbeiterBearbeiten.Visible = true;
                DtgData.CurrentRow.Selected = true;
                Kill.Visible = true;
                CmbReset.Visible = true;

                string id = IDGetter();
                bool istrainee = TraineChecker();

                if (istrainee == false)
                {
                    Mitarbeiter m = xmlHandler.RetriveValuesMitarbeiter(id);
                    LblId.Text = Convert.ToString(m.Id);
                    CmbAnrede.Text = m.Anrede;
                    TxtVorname.Text = m.Vorname;
                    TxtNachname.Text = m.Nachname;
                    DtpGeburtsdatum.Value = m.Geburtsdatum;
                    TxtAhvNum.Text = m.AhvNumber;
                    CmbNationalitaet.Text = m.Nationalität;
                    TxtEmail.Text = m.Email;
                    TxtTelGesch.Text = m.TelefonArbeit;
                    TxtTelMobil.Text = m.TelefonMobil;
                    TxtTelPriv.Text = m.TelefonPrivat;
                    TxtStrasse.Text = m.Strasse;
                    TxtWohnort.Text = m.Wohnort;
                    TxtPostleitzahl.Text = Convert.ToString(m.Plz);
                    NumKaderstufe.Value = Convert.ToDecimal(m.KaderStufe);
                    TxtAbteilung.Text = m.Abteilung;
                    DtpStartdatum.Value = m.StartDate;
                    NumArbeitspensum.Value = Convert.ToDecimal(m.Arbeitspensum);
                    ChkLehrling.Checked = false;
                }

                else if (istrainee == true)
                {
                    Lehrling l = xmlHandler.RetriveValueLehrling(id);
                    LblId.Text = Convert.ToString(l.Id);
                    CmbAnrede.Text = l.Anrede;
                    TxtVorname.Text = l.Vorname;
                    TxtNachname.Text = l.Nachname;
                    DtpGeburtsdatum.Value = l.Geburtsdatum;
                    TxtAhvNum.Text = l.AhvNumber;
                    CmbNationalitaet.Text = l.Nationalität;
                    TxtEmail.Text = l.Email;
                    TxtTelGesch.Text = l.TelefonArbeit;
                    TxtTelMobil.Text = l.TelefonMobil;
                    TxtTelPriv.Text = l.TelefonPrivat;
                    TxtStrasse.Text = l.Strasse;
                    TxtWohnort.Text = l.Wohnort;
                    TxtPostleitzahl.Text = Convert.ToString(l.Plz);
                    NumKaderstufe.Value = Convert.ToDecimal(l.KaderStufe);
                    TxtAbteilung.Text = l.Abteilung;
                    DtpStartdatum.Value = l.StartDate;
                    NumArbeitspensum.Value = Convert.ToDecimal(l.Arbeitspensum);
                    NumLehrjahr.Value = Convert.ToDecimal(l.TraineeYears);
                    NumAktLehrjahr.Value = Convert.ToDecimal(l.ActualTraineeYear);
                    ChkLehrling.Checked = true;
                }
            }
        }


        private void CmdWerteSpeichern_Click(object sender, EventArgs e)
        {

            CmdWerteSpeichern.Visible = false;
            CmdMitarbeiterBearbeiten.Visible = true;
            DtgData.Enabled = true;

            string eid = IDGetter();

            bool status = Status();
            bool istrainee = TraineChecker();

            Guid id = Guid.Parse(eid);

            string anrede = CmbAnrede.Text;
            string title = CmbTitel.Text;
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

            int ks = Convert.ToInt16(NumKaderstufe.Value);
            string abt = TxtAbteilung.Text;
            string rolle = TxtRolle.Text;
            int arbp = Convert.ToInt16(NumArbeitspensum.Value);
            DateTime st = DtpStartdatum.Value;
            DateTime end = DtpEnddatum.Value;


            Mitarbeiter m = new Mitarbeiter(id, status, istrainee, anrede, title, vorname, nachname, dob, privat, arbeit, mobil, email, ahv, nationalitaet, strasse, plz, wohnort, ks, rolle, abt, arbp, st, end);

            CmdMitarbeiterBearbeiten.Visible = false;
            Kill.Visible = true;
            CmbReset.Visible = true;
            CmdCancel.Visible = false;
            DataGridZeileBearbeiten();
            ChangeTxtValuesDeny();


            if (ChkLehrling.Checked == true)
            {
                int lehrjahre = Convert.ToInt16(NumLehrjahr.Value);
                int aktLehrjahr = Convert.ToInt16(NumAktLehrjahr.Value);
                Lehrling l = new Lehrling(id, status, istrainee, anrede, title, vorname, nachname, dob, privat, arbeit, mobil, email, ahv, nationalitaet, strasse, plz, wohnort, ks, rolle, abt, arbp, st, end, lehrjahre, aktLehrjahr);
                xmlHandler.ChangeValuesLehrlingXML(l);
            }
            else if (ChkLehrling.Checked == false)
            {
                xmlHandler.ChangeValuesMitarbeiterXML(m);
            }


        }

        private void CmdMitarbeiterSpeichern_Click(object sender, EventArgs e)
        {
            //try
            //{

            Guid id = Guid.NewGuid();

            bool status = Status();

            string anrede = CmbAnrede.Text;
            string titel = CmbTitel.Text;
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

            int ks = Convert.ToInt16(NumKaderstufe.Value);
            string rolle = TxtRolle.Text;
            string abt = TxtAbteilung.Text;
            int arbp = Convert.ToInt16(NumArbeitspensum.Value);
            DateTime st = DtpStartdatum.Value;
            DateTime et = DtpEnddatum.Value;
            int lehrjahre = Convert.ToInt16(NumLehrjahr.Value);
            int aktLehrjahr = Convert.ToInt16(NumAktLehrjahr.Value);



            if (ChkLehrling.Checked == true)
            {
                bool istrainee = true;
                //Für Lehrlinge

                Lehrling l = new Lehrling(id, status, istrainee, anrede, titel, vorname, nachname, dob, privat, arbeit, mobil, email, ahv, nationalitaet, strasse, plz, wohnort, ks, rolle, abt, arbp, st, et, lehrjahre, aktLehrjahr);
                xmlHandler.CreateLehrlingXML(l);
            }
            else if (ChkLehrling.Checked == false)
            {
                bool istrainee = false;
                Mitarbeiter m = new Mitarbeiter(id, status, istrainee, anrede, titel, vorname, nachname, dob, privat, arbeit, mobil, email, ahv, nationalitaet, strasse, plz, wohnort, ks, rolle, abt, arbp, st, et);
                xmlHandler.CreateMitarbeiterXML(m);
            }


            LblId.Text = Convert.ToString(id);
            DataGridNeueZeile();
            CmdMitarbeiterErstellen.Visible = true;
            CmdMitarbeiterSpeichernErstellen.Visible = false;
            CmdMitarbeiterBearbeiten.Visible = false;
            Kill.Visible = true;
            DtgData.Enabled = true;
            CmbReset.Visible = true;
            CmdCancel.Visible = false;
            ChangeTxtValuesDeny();
            MessageBox.Show($"Der Nutzer {vorname} {nachname} wurde erstellt.");

            //}
            //catch
            //{
            //    MessageBox.Show("Überprüfen Sie Ihre eingetragenen Felder", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        public void LoadFile()
        {
            if (File.Exists("Mitarbeiter.xml") && new FileInfo("Mitarbeiter.xml").Length >= 60)
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(Directory.GetCurrentDirectory() + "/Mitarbeiter.xml");

                foreach (DataRow item in dataSet.Tables["Mitarbeiter"].Rows)
                {

                    int n = DtgData.Rows.Add();
                    DtgData.Rows[n].Cells[0].Value = item[21];
                    DtgData.Rows[n].Cells[1].Value = item[1];
                    DtgData.Rows[n].Cells[2].Value = item[4];
                    DtgData.Rows[n].Cells[3].Value = item[3];
                    DtgData.Rows[n].Cells[4].Value = item[5];
                    DtgData.Rows[n].Cells[5].Value = item[8];
                    DtgData.Rows[n].Cells[6].Value = item[9];
                    DtgData.Rows[n].Cells[7].Value = item[10];
                    DtgData.Rows[n].Cells[8].Value = item[11];
                    DtgData.Rows[n].Cells[9].Value = item[23];
                }

            }
            else
            {
                DtgData.DataSource = null;
            }

        }

        public void DataGridNeueZeile()
        {
            int n = DtgData.Rows.Add();
            DtgData.Rows[n].Cells[0].Value = LblId.Text;
            DtgData.Rows[n].Cells[1].Value = CmbAnrede.Text;
            DtgData.Rows[n].Cells[2].Value = TxtNachname.Text;
            DtgData.Rows[n].Cells[3].Value = TxtVorname.Text;
            DtgData.Rows[n].Cells[4].Value = DtpGeburtsdatum.Text;
            DtgData.Rows[n].Cells[5].Value = TxtEmail.Text;
            DtgData.Rows[n].Cells[6].Value = TxtTelMobil.Text;
            DtgData.Rows[n].Cells[7].Value = TxtTelPriv.Text;
            DtgData.Rows[n].Cells[8].Value = TxtTelGesch.Text;
            DtgData.Rows[n].Cells[9].Value = ChkLehrling.Checked;
        }

        public void DataGridZeileBearbeiten()
        {
            DtgData.SelectedRows[0].Cells[0].Value = LblId.Text;
            DtgData.SelectedRows[0].Cells[1].Value = CmbAnrede.Text;
            DtgData.SelectedRows[0].Cells[2].Value = TxtNachname.Text;
            DtgData.SelectedRows[0].Cells[3].Value = TxtVorname.Text;
            DtgData.SelectedRows[0].Cells[4].Value = DtpGeburtsdatum.Text;
            DtgData.SelectedRows[0].Cells[5].Value = TxtEmail.Text;
            DtgData.SelectedRows[0].Cells[6].Value = TxtTelMobil.Text;
            DtgData.SelectedRows[0].Cells[7].Value = TxtTelPriv.Text;
            DtgData.SelectedRows[0].Cells[8].Value = TxtTelGesch.Text;
            DtgData.SelectedRows[0].Cells[9].Value = ChkLehrling.Checked;
        }

        public string IDGetter()
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

        public bool TraineChecker()
        {
            {
                bool lehrling = false;

                if (DtgData.SelectedCells.Count > 0)
                {
                    int selectedrowindex = DtgData.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = DtgData.Rows[selectedrowindex];
                    lehrling = Convert.ToBoolean(selectedRow.Cells["Lehrling"].Value);

                }
                return lehrling;
            }
        }

        private bool Status()
        {
            if (!ChkStatus.Checked)
            {
                ChkStatus.Text = "Aktivieren";
                return false;
            }
            else
            {
                ChkStatus.Text = "Deaktivieren";
                return true;
            }
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

            //Lehrlinge
            NumLehrjahr.ResetText();
            NumAktLehrjahr.ResetText();
            ChkLehrling.Checked = false;

        }

        private void ChangeTxtValuesDeny()
        {
            ChkLehrling.Enabled = false;
            CmbAnrede.Enabled = false;
            TxtWohnort.Enabled = false;
            TxtTelPriv.Enabled = false;
            TxtTelMobil.Enabled = false;
            TxtTelGesch.Enabled = false;
            TxtEmail.Enabled = false;
            LblId.Enabled = false;
            LblStatus.Enabled = false;
            TxtStrasse.Enabled = false;
            TxtNachname.Enabled = false;
            TxtVorname.Enabled = false;
            TxtAhvNum.Enabled = false;
            TxtAbteilung.Enabled = false;
            TxtPostleitzahl.Enabled = false;
        }

        private void ChangeTxtValuesAllow()
        {
            ChkLehrling.Enabled = true;
            CmbAnrede.Enabled = true;
            TxtWohnort.Enabled = true;
            TxtTelPriv.Enabled = true;
            TxtTelMobil.Enabled = true;
            TxtTelGesch.Enabled = true;
            TxtEmail.Enabled = true;
            LblId.Enabled = true;
            LblStatus.Enabled = false;
            TxtStrasse.Enabled = true;
            TxtNachname.Enabled = true;
            TxtVorname.Enabled = true;
            TxtAhvNum.Enabled = true;
            TxtAbteilung.Enabled = true;
            TxtPostleitzahl.Enabled = true;
        }

        public void BenutzererstellungFehler()
        {
            if (CmdMitarbeiterErstellen.Visible == false)
            {
                DialogResult dialogResult = MessageBox.Show("Benutzer Speichern?", "Achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        Guid id = Guid.NewGuid();
                        bool status = Status();
                        bool istrainee = TraineChecker();

                        string anrede = CmbAnrede.Text;
                        string title = CmbTitel.Text;
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

                        int ks = Convert.ToInt16(NumKaderstufe.Value);
                        string abt = TxtAbteilung.Text;
                        string rolle = TxtRolle.Text;
                        int arbp = Convert.ToInt16(NumArbeitspensum.Value);
                        DateTime st = DtpStartdatum.Value;
                        DateTime et = DtpEnddatum.Value;

                        Mitarbeiter m = new Mitarbeiter(id, status, istrainee, anrede, title, vorname, nachname, dob, privat, arbeit, mobil, email, ahv, nationalitaet, strasse, plz, wohnort, ks, rolle, abt, arbp, st, et);


                        xmlHandler.CreateMitarbeiterXML(m);
                        LblId.Text = Convert.ToString(id);
                        DataGridNeueZeile();
                        CmdMitarbeiterErstellen.Visible = true;
                        CmdMitarbeiterSpeichernErstellen.Visible = false;
                        DtgData.Enabled = true;
                        MessageBox.Show($"Der Nutzer {vorname} {nachname} wurde erstellt.");

                    }
                    catch
                    {
                        MessageBox.Show("Überprüfen Sie Ihre eingetragenen Felder", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    CmdMitarbeiterErstellen.Visible = true;
                }
                else
                {
                    CmdMitarbeiterErstellen.Visible = true;
                }
            }
        }

        private void Kill_Click(object sender, EventArgs e)
        {
            string id = IDGetter();

            DialogResult dialogResult = MessageBox.Show("Benutzer löschen?", "Achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                xmlHandler.DeleteValuesMitarbeiter(id);
                DtgData.Rows.RemoveAt(DtgData.SelectedRows[0].Index);
            }
        }

        private void ChkStatus_CheckedChanged(object sender, EventArgs e)
        {
            Status();
        }

        private void CmbReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void FillCombobox()
        {
            CmbTitel.Items.AddRange(titel);
            CmbAnrede.Items.AddRange(anrede);
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            CmdMitarbeiterSpeichernErstellen.Visible = false;
            CmdWerteSpeichern.Visible = false;
            CmdCancel.Visible = false;
            CmdMitarbeiterErstellen.Visible = true;
            DtgData.Enabled = true;
            ChangeTxtValuesDeny();
        }

        private void ChkLehrling_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkLehrling.Checked)
            {
                NumLehrjahr.Enabled = true;
                NumAktLehrjahr.Enabled = true;
            }
            else
            {
                NumAktLehrjahr.Enabled = false;
                NumLehrjahr.Enabled = false;
            }
        }
    }
}
