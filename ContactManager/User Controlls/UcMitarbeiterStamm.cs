using ContactManager.Controller;
using ContactManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;
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

        #region Combobox Fill
        string[] anrede = new string[] { "Herr", "Frau", "Divers" };
        string[] titel = new string[] { "", "Dr.", "Prof.", "Dipl.-Ing." };
        string[] geschlecht = new string[] { "Männlich", "Weiblich", "Divers" };
        #endregion

        #region Params
        private int rowIndex { get; set; }
        public CheckState statusMitarbeiter { get; set; }
        #endregion

        #region Instances
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
        #endregion

        /// <summary>
        /// Schaltet beim Klick die Benötigten Buttons Visible und umgekehrt
        /// </summary>
        private void CmdMitarbeiterErstellen_Click(object sender, EventArgs e)
        {
            CmdDelete.Visible = false;
            CmbReset.Visible = false;
            CmdCancel.Visible = true;
            CmdMitarbeiterErstellen.Visible = false;
            CmdMitarbeiterSpeichernErstellen.Visible = true;
            DtgData.Enabled = false;

        }

        /// <summary>
        /// Sobald UcMitarbeiterStamm geladen wird werden die Comboboxen gefüllt, die LoadFile funktion ausgeführt und der Reset & Delete Button deaktiviert.
        /// </summary>
        private void UcMitarbeiterStamm_Load(object sender, EventArgs e)
        {
            FillCombobox();
            LoadFile();
            CmdDelete.Visible = false;
            CmbReset.Visible = false;
        }

        /// <summary>
        /// Die Funktion Deaktiviert den Knopf CmdWerteSpeicher und Enabled das DataGrid.
        /// Der ID-Getter holt sich die ID und führt einen Parse aus.
        /// Status sowohl auch der TraineChecker holen sich den Status der Parameter.
        /// Ist der "istrainee"-Bool auf True wird die die If-Schleife ausgeführt und speichert die Werte als Lehrling.
        /// Ist der "istrainee"-Bool auf false werden die Werte als Mitarbeiter gespeichert.
        /// </summary>
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
            string geschlecht = CmbGeschlecht.Text;
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


            Mitarbeiter m = new Mitarbeiter(id, status, istrainee, anrede, title, geschlecht,vorname, nachname, dob, privat, arbeit, mobil, email, ahv, nationalitaet, strasse, plz, wohnort, ks, rolle, abt, arbp, st, end);
            CmdMitarbeiterErstellen.Visible = true;
            CmdCancel.Visible = false;


            if (ChkLehrling.Checked == true)
            {
                int lehrjahre = Convert.ToInt16(NumLehrjahr.Value);
                int aktLehrjahr = Convert.ToInt16(NumAktLehrjahr.Value);
                Lehrling l = new Lehrling(id, status, istrainee, anrede, title, geschlecht,vorname, nachname, dob, privat, arbeit, mobil, email, ahv, nationalitaet, strasse, plz, wohnort, ks, rolle, abt, arbp, st, end, lehrjahre, aktLehrjahr);
                xmlHandler.ChangeValuesLehrlingXML(l);
            }
            else if (ChkLehrling.Checked == false)
            {
                xmlHandler.ChangeValuesMitarbeiterXML(m);
            }

            LoadFile();


        }

        /// <summary>
        /// Erstellt den Mitarbeiter mit einer ID und gibt bei der Erstellung eine Meldung aus wenn erfolgreich.
        /// Der Mitarbeiter erhält die Lehrlingsparameter wenn die Checkbox "ChkLehrling" den Status Checked hat.
        /// </summary>
        private void CmdMitarbeiterSpeichern_Click(object sender, EventArgs e)
        {
            try
            {
                Guid id = Guid.NewGuid();

                bool status = Status();

                string anrede = CmbAnrede.Text;
                string titel = CmbTitel.Text;
                string geschlecht = CmbGeschlecht.Text;
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

                    Lehrling l = new Lehrling(id, status, istrainee, anrede, titel, geschlecht, vorname, nachname, dob, privat, arbeit, mobil, email, ahv, nationalitaet, strasse, plz, wohnort, ks, rolle, abt, arbp, st, et, lehrjahre, aktLehrjahr);
                    xmlHandler.CreateLehrlingXML(l);
                }
                else if (ChkLehrling.Checked == false)
                {
                    bool istrainee = false;
                    Mitarbeiter m = new Mitarbeiter(id, status, istrainee, anrede, titel, geschlecht, vorname, nachname, dob, privat, arbeit, mobil, email, ahv, nationalitaet, strasse, plz, wohnort, ks, rolle, abt, arbp, st, et);
                    xmlHandler.CreateMitarbeiterXML(m);
                }


                LblId.Text = Convert.ToString(id);
                LoadFile();
                CmdMitarbeiterErstellen.Visible = true;
                CmdMitarbeiterSpeichernErstellen.Visible = false;
                CmdDelete.Visible = true;
                DtgData.Enabled = true;
                CmbReset.Visible = true;
                CmdCancel.Visible = false;

                MessageBox.Show($"Der Nutzer {vorname} {nachname} wurde erstellt.");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Format stimmt nicht" + ex);
            }
        }

        /// <summary>
        /// Hier läuft der ganze Prozess vom Laden der Datei ab.
        /// Alle Mitarbeiter werden in der Datei Mitarbeiter.xml gespeichert (Mitarbeiter & Lehrlinge)
        /// Sollte die Datei existieren und der vorgegbene Zeichensatz grösser oder gleich 60 sein werden die Filtereigenschaften zurückgesetzt und die Datei geladen.
        /// Existiert die Datei nicht wird die DataSource vom DataGrid auf "null" gesetzt.
        /// </summary>
        public void LoadFile()
        {

            if (File.Exists("Mitarbeiter.xml") && new FileInfo("Mitarbeiter.xml").Length >= 60)
            {
                XMLtoDatagrid();

                if (DtgData.RowCount >= 1)
                {
                    LblAnzahlZeilenGeladen.Text = Convert.ToString(DtgData.Rows.Count);
                    DtgData.CurrentCell = DtgData.Rows[rowIndex].Cells[0];
                    DtgData.Rows[rowIndex].Selected = true;
                }


                }
                else
                {
                    DtgData.DataSource = null;
                }

            HideButtons();


        }

        /// <summary>
        /// Gibt von der selektierten Zeile im DataGrid die ID aus und gibt diese wieder zurück.
        /// </summary>
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

        /// <summary>
        /// Überprüft im Datagrid wenn die Zeile selektiert wie das Lehrlingsattribut gesetzt ist und gibt dieses wieder zurück.
        /// </summary>
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

        /// <summary>
        /// Wenn der Status der Checkbox sich ändert ändert sich auch der Text.
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        //public void BenutzererstellungFehler()
        //{
        //    if (CmdMitarbeiterErstellen.Visible == false)
        //    {
        //        DialogResult dialogResult = MessageBox.Show("Benutzer Speichern?", "Achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //        if (dialogResult == DialogResult.Yes)
        //        {
        //            try
        //            {
        //                Guid id = Guid.NewGuid();
        //                bool status = Status();
        //                bool istrainee = TraineChecker();

        //                string anrede = CmbAnrede.Text;
        //                string title = CmbTitel.Text;
        //                string geschlecht = CmbGeschlecht.Text;
        //                string vorname = TxtVorname.Text;
        //                string nachname = TxtNachname.Text;
        //                DateTime dob = DtpGeburtsdatum.Value;
        //                string ahv = TxtAhvNum.Text;
        //                string nationalitaet = CmbNationalitaet.Text;

        //                string email = TxtEmail.Text;
        //                string privat = TxtTelPriv.Text;
        //                string mobil = TxtTelMobil.Text;
        //                string arbeit = TxtTelGesch.Text;

        //                string strasse = TxtStrasse.Text;
        //                string wohnort = TxtWohnort.Text;
        //                int plz = Convert.ToInt16(TxtPostleitzahl.Text);

        //                int ks = Convert.ToInt16(NumKaderstufe.Value);
        //                string abt = TxtAbteilung.Text;
        //                string rolle = TxtRolle.Text;
        //                int arbp = Convert.ToInt16(NumArbeitspensum.Value);
        //                DateTime st = DtpStartdatum.Value;
        //                DateTime et = DtpEnddatum.Value;

        //                Mitarbeiter m = new Mitarbeiter(id, status, istrainee, anrede, title, geschlecht,vorname, nachname, dob, privat, arbeit, mobil, email, ahv, nationalitaet, strasse, plz, wohnort, ks, rolle, abt, arbp, st, et);


        //                xmlHandler.CreateMitarbeiterXML(m);
        //                LblId.Text = Convert.ToString(id);
        //                LoadFile();
        //                CmdMitarbeiterErstellen.Visible = true;
        //                CmdMitarbeiterSpeichernErstellen.Visible = false;
        //                DtgData.Enabled = true;
        //                MessageBox.Show($"Der Nutzer {vorname} {nachname} wurde erstellt.");

        //            }
        //            catch
        //            {
        //                MessageBox.Show("Überprüfen Sie Ihre eingetragenen Felder", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }

        //            CmdMitarbeiterErstellen.Visible = true;
        //        }
        //        else
        //        {
        //            CmdMitarbeiterErstellen.Visible = true;
        //        }
        //    }
        //}

        /// <summary>
        /// Löscht den Selektierten User der über den ID-Getter ausgewählt wurde.
        /// Die Löschung ist nach der Messagebox engültig.
        /// </summary>
        private void Kill_Click(object sender, EventArgs e)
        {
            string id = IDGetter();

            DialogResult dialogResult = MessageBox.Show("Benutzer löschen?", "Achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                ClearDataBindings();

                xmlHandler.DeleteValuesMitarbeiter(id);

                LoadFile();
            }
        }

        /// <summary>
        /// Ruft beim wechseln des ChkStatus die Funktion Status auf
        /// </summary>
        private void ChkStatus_CheckedChanged(object sender, EventArgs e)
        {
            Status();
        }

        /// <summary>
        /// Füllt die Comboboxen mit Vorgegebenen Werten welche in der Region "Combobox definiert sind."
        /// </summary>
        private void FillCombobox()
        {
            CmbTitel.Items.AddRange(titel);
            CmbAnrede.Items.AddRange(anrede);
            CmbGeschlecht.Items.AddRange(geschlecht);
        }

        /// <summary>
        /// Deaktiviert die Buttons CmdWerteSpeichern & CmdMitarbeiterErstellen
        /// Aktiviert wieder das DataGrid
        /// Lädt die Daten erneut
        /// </summary>
        private void CmdCancel_Click(object sender, EventArgs e)
        {
            CmdMitarbeiterSpeichernErstellen.Visible = false;
            CmdWerteSpeichern.Visible = false;
          
            DtgData.Enabled = true;

            LoadFile();
        }

        /// <summary>
        /// Ändert sich der Status von ChkLehrling werden die Optionen vom Lehrling aktiviert oder deaktiviert.
        /// </summary>
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
        public void ApplyXmlFilter()
        {
            CmdFilterReset.Visible = true;

            if (statusMitarbeiter == CheckState.Unchecked)
            {
                mitarbeiter = XDocument.Load(Directory.GetCurrentDirectory() + "/Mitarbeiter.xml");

                var data = mitarbeiter.Descendants("Mitarbeiter")
                    .Where(mitarbeiterfilter => (bool)mitarbeiterfilter.Attribute("Status") == false)
                    .Select(m =>
                    {
                        string mStatus = m.Attribute("Status").Value;
                        string mLehrling = m.Attribute("Lehrling").Value;

                        bool Status = Convert.ToBoolean(mStatus);
                        bool Lehrling = Convert.ToBoolean(mLehrling);

                        foreach (var zeile in mitarbeiter.Descendants())
                        {
                            if (Status == true)
                                mStatus = "Aktiv";
                            else
                                mStatus = "Inaktiv";
                        }

                        return new
                        {
                            ID = m.Attribute("ID").Value,
                            Anrede = m.Element("Anrede").Value,
                            Vorname = m.Element("Vorname").Value,
                            Nachname = m.Element("Nachname").Value,
                            Postleitzahl = m.Element("Postleitzahl").Value,
                            Status,
                            Lehrling
                        };
                    })
                .OrderBy(m => m.ID).ToList();

                HideButtons();

                //DtgData.CurrentCell = DtgData.Rows[rowIndex].Cells[0];

                DtgData.DataSource = data;
            }
            else if (statusMitarbeiter == CheckState.Checked)
            {
                mitarbeiter = XDocument.Load(Directory.GetCurrentDirectory() + "/Mitarbeiter.xml");

                var data = mitarbeiter.Descendants("Mitarbeiter")
                    .Where(mitarbeiterfilter => (bool)mitarbeiterfilter.Attribute("Status") == true)
                    .Select(m =>
                    {
                        string mStatus = m.Attribute("Status").Value;
                        string mLehrling = m.Attribute("Lehrling").Value;

                        bool Status = Convert.ToBoolean(mStatus);
                        bool Lehrling = Convert.ToBoolean(mLehrling);

                        foreach (var zeile in mitarbeiter.Descendants())
                        {
                            if (Status == true)
                                mStatus = "Aktiv";
                            else
                                mStatus = "Inaktiv";
                        }

                        return new
                        {
                            ID = m.Attribute("ID").Value,
                            Anrede = m.Element("Anrede").Value,
                            Vorname = m.Element("Vorname").Value,
                            Nachname = m.Element("Nachname").Value,
                            Postleitzahl = m.Element("Postleitzahl").Value,
                            Status,
                            Lehrling
                        };
                    })
                .OrderBy(m => m.ID).ToList();

                HideButtons();

                //DtgData.CurrentRow = DtgData.Rows[index];

                DtgData.DataSource = data;
            }
            else
            {
                mitarbeiter = XDocument.Load(Directory.GetCurrentDirectory() + "/Mitarbeiter.xml");

                var data = mitarbeiter.Descendants("Mitarbeiter")
                    .Select(m =>
                    {
                        string mStatus = m.Attribute("Status").Value;
                        string mLehrling = m.Attribute("Lehrling").Value;

                        bool Status = Convert.ToBoolean(mStatus);
                        bool Lehrling = Convert.ToBoolean(mLehrling);

                        foreach (var zeile in mitarbeiter.Descendants())
                        {
                            if (Status == true)
                                mStatus = "Aktiv";
                            else
                                mStatus = "Inaktiv";
                        }

                        return new
                        {
                            ID = m.Attribute("ID").Value,
                            Anrede = m.Element("Anrede").Value,
                            Vorname = m.Element("Vorname").Value,
                            Nachname = m.Element("Nachname").Value,
                            Postleitzahl = m.Element("Postleitzahl").Value,
                            Status,
                            Lehrling
                        };
                    })
                .OrderBy(m => m.ID).ToList();

                //DtgData.CurrentCell = DtgData.Rows[index].Cells[0];

                DtgData.DataSource = data;
            }
        }

        /// <summary>
        /// Versteckt Buttons
        /// </summary>
        private void HideButtons()
        {
            CmdMitarbeiterErstellen.Visible = true;
            CmdCancel.Visible = false;
            CmdMitarbeiterSpeichernErstellen.Visible = false;
            CmdWerteSpeichern.Visible = false;
        }

        public void XMLtoDatagrid()
        {
            mitarbeiter = XDocument.Load(Directory.GetCurrentDirectory() + "/Mitarbeiter.xml");

            var data = mitarbeiter.Descendants("Mitarbeiter")
                .Select(m =>
                {
                    string mStatus = m.Attribute("Status").Value;
                    string mLehrling = m.Attribute("Lehrling").Value;

                    bool Status = Convert.ToBoolean(mStatus);
                    bool Lehrling = Convert.ToBoolean(mLehrling);

                    foreach (var zeile in mitarbeiter.Descendants())
                    {
                        if (Status == true)
                            mStatus = "Aktiv";
                        else
                            mStatus = "Inaktiv";
                    }

                    return new
                    {
                        ID = m.Attribute("ID").Value,
                        Anrede = m.Element("Anrede").Value,
                        Vorname = m.Element("Vorname").Value,
                        Nachname = m.Element("Nachname").Value,
                        Postleitzahl = m.Element("Postleitzahl").Value,
                        Status,
                        Lehrling
                    };
                })
                .OrderBy(m => m.ID).ToList();

            ClearDataBindings();

            LblId.DataBindings.Add("text", data, "ID");
            CmbAnrede.DataBindings.Add("text", data, "Anrede");
            TxtVorname.DataBindings.Add("text", data, "Vorname");
            TxtNachname.DataBindings.Add("text", data, "Nachname");
            TxtPostleitzahl.DataBindings.Add("text", data, "Postleitzahl");
            ChkStatus.DataBindings.Add("Checked", data, "Status");
            ChkLehrling.DataBindings.Add("Checked", data, "Lehrling");

            DtgData.DataSource = data;
        }


        private void CmdSuchfilter_Click_1(object sender, EventArgs e)
        {
            ClearDataBindings();

            FilterDashboard filterDashboard = new FilterDashboard();
            filterDashboard.ShowDialog();
        }

        /// <summary>
        /// Braucht noch Info oder wird ehh gelöscht
        /// </summary>
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

        /// <summary>
        /// Beim Klicken auf eine Zelle im DataGrid wird der Index gesetzt
        /// Dieser wird benötigt um die Position nach dem Bearbeiten eines Users nicht wieder an den Anfang der Tabelle zu setzen
        /// 
        /// Um einen Index out of range Fehler vorzubeugen wird nach dem löschen 1 vom Index abgezogen
        /// Ansonsten wird der Index auf 0 gesetzt
        /// </summary>
        private void DtgData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = DtgData.CurrentRow.Index;

            if (e.RowIndex == DtgData.CurrentRow.Index)
            {
                DtgData.Rows[e.RowIndex].Selected = true;
                rowIndex = e.RowIndex;
                CmdDelete.Visible = true;
            }
        }
       
        /// <summary>
        /// Funktion um den Filter zurückzusetzen und erneut die Daten zu laden
        /// </summary>
        private void CmdFilterReset_Click(object sender, EventArgs e)
        {
            CmdFilterReset.Visible = false;
            LoadFile();
        }
        
        /// <summary>
        /// Wird benötigt um Fehlern mit DataBindings vorzubeugen
        /// </summary>
        private void ClearDataBindings()
        {
            LblId.DataBindings.Clear();
            CmbAnrede.DataBindings.Clear();
            TxtVorname.DataBindings.Clear();
            TxtNachname.DataBindings.Clear();
            TxtPostleitzahl.DataBindings.Clear();
            ChkStatus.DataBindings.Clear();
            ChkLehrling.DataBindings.Clear();
        }
       
        /// <summary>
        /// Beim Klicken auf eine Zelle im DataGrid wird der Index gesetzt
        /// Dieser wird benötigt um die Position nach dem Bearbeiten eines Users nicht wieder an den Anfang der Tabelle zu setzen
        /// 
        /// Um einen Index out of range Fehler vorzubeugen wird nach dem löschen 1 vom Index abgezogen
        /// Ansonsten wird der Index auf 0 gesetzt
        /// </summary>
    }
}
