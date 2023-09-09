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
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ContactManager
{
    public partial class UcMitarbeiterStamm : UserControl
    {
        private XDocument mitarbeiter = new XDocument();
        private string URL_XML_FILE = "Directory.GetCurrentDirectory() + \"/Mitarbeiter.xml\"";

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
            CmdMitarbeiterErstellen.Visible = false;
            CmdMitarbeiterSpeichernErstellen.Visible = true;
            DtgData.Enabled = false;

        }

        private void UcMitarbeiterStamm_Load(object sender, EventArgs e)
        {
            FillCombobox();
            LoadFile();
            Kill.Visible = false;
            CmbReset.Visible = false;
        }

        private void CmdWerteSpeichern_Click(object sender, EventArgs e)
        {

            CmdWerteSpeichern.Visible = false;
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
            CmdMitarbeiterErstellen.Visible = true;
            CmdCancel.Visible = false;
            DataGridZeileBearbeiten();


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

            LoadFile();


        }

        private void CmdMitarbeiterSpeichern_Click(object sender, EventArgs e)
        {
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
            Kill.Visible = true;
            DtgData.Enabled = true;
            CmbReset.Visible = true;
            CmdCancel.Visible = false;

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
                mitarbeiter = XDocument.Load(Directory.GetCurrentDirectory() + "/Mitarbeiter.xml");

                var data = mitarbeiter.Descendants("Mitarbeiter").Select(m => new
                {
                    Id = m.Attribute("ID").Value,
                    Anrede = m.Element("Anrede").Value,
                    Vorname = m.Element("Vorname").Value,
                    Nachname = m.Element("Nachname").Value,
                    Postleitzahl = m.Element("Postleitzahl").Value,
                    Status = m.Attribute("Status").Value,
                    Lehrling = m.Attribute("Lehrling").Value
                }).OrderBy(m => m.Id).ToList();

                LblId.DataBindings.Clear();
                CmbAnrede.DataBindings.Clear();
                TxtVorname.DataBindings.Clear();
                TxtNachname.DataBindings.Clear();
                TxtPostleitzahl.DataBindings.Clear();
                ChkStatus.DataBindings.Clear();
                ChkLehrling.DataBindings.Clear();

                LblId.DataBindings.Add("text", data, "ID");
                CmbAnrede.DataBindings.Add("text", data, "Anrede");
                TxtVorname.DataBindings.Add("text", data, "Vorname");
                TxtNachname.DataBindings.Add("text", data, "Nachname");
                TxtPostleitzahl.DataBindings.Add("text", data, "Postleitzahl");
                ChkStatus.DataBindings.Add("Checked", data, "Status");
                ChkLehrling.DataBindings.Add("Checked", data, "Lehrling");


                DtgData.DataSource = data;
                
            }
            else
            {
                DtgData.DataSource = null;
            }

        }

        public void DataGridNeueZeile()
        {
            LoadFile();
        }

        public void DataGridZeileBearbeiten()
        {
            DtgData.SelectedRows[0].Cells[0].Value = LblId.Text;
            DtgData.SelectedRows[0].Cells[1].Value = CmbAnrede.Text;
            DtgData.SelectedRows[0].Cells[2].Value = TxtNachname.Text;
            DtgData.SelectedRows[0].Cells[3].Value = TxtVorname.Text;
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

            LoadFile();
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

        public bool filterStatusTrue { get; set; }
        public bool filterStatusFalse { get; set; }

        public void ApplyXmlFilter()
        {

        }

        private void CmdSuchfilter_Click_1(object sender, EventArgs e)
        {
            FilterDashboard filterDashboard = new FilterDashboard();
            filterDashboard.ShowDialog();
        }

        private void TxtVorname_TextChanged(object sender, EventArgs e)
        {
            if (CmdMitarbeiterErstellen.Visible == true)
            {
                string textVorname = TxtVorname.Text;

                if (DtgData.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = DtgData.SelectedRows[0].Index;

                    string dtgdataValue = DtgData.Rows[selectedRowIndex].Cells["Vorname"].Value.ToString();

                    if (textVorname != dtgdataValue)
                    {
                        CmdWerteSpeichern.Visible = true;
                        CmdMitarbeiterErstellen.Visible = false;
                        CmdCancel.Visible = true;
                    }
                }
            }
        }

        private void DtgData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DtgData.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
