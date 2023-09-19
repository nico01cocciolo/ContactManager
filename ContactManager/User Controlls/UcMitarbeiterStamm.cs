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
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
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
        public UcMitarbeiterStamm()
        {
            InitializeComponent();
        }

        #region Combobox Fill
        string[] anrede = new string[] { "Herr", "Frau", "Divers" };
        string[] titel = new string[] { "", "Dr.", "Prof.", "Dipl.-Ing." };
        string[] geschlecht = new string[] { "Männlich", "Weiblich", "Divers" };
        string[] nations = new string[] {"Afghanistan","Ägypten","Albanien","Algerien","Andorra","Angola","Antigua und Barbuda","Äquatorialguinea","Argentinien","Armenien","Aserbaidschan","Äthiopien","Australien",
                                         "Bahamas","Bahrain","Bangladesch","Barbados","Belarus","Belgien","Belize","Benin","Bhutan","Bolivien","Bosnien und Herzegowina","Botsuana","Brasilien","Brunei Darussalam","Bulgarien","Burkina Faso","Burundi",
                                         "Cabo Verde","Chile","China","Costa Rica","Cookinseln","Côte d'Ivoire","Dänemark","Deutschland","Dominica","Dominikanische Republik","Dschibuti","Ecuador","El Salvador","Eritrea","Estland","Eswatini",
                                         "Fidschi","Finnland","Frankreich","Gabun","Gambia","Georgien","Ghana","Grenada","Griechenland","Grossbritannien","Guatemala","Guinea","Guinea-Bissau","Guyana","Haiti","Heiliger Stuhl - Vatikanstadt","Honduras",
                                         "Indien","Indonesien","Irak","Iran","Irland","Island","Israel","Italien","Jamaika","Japan","Jemen","Jordanien","Jugoslawien","Kambodscha","Kamerun","Kanada","Kasachstan","Katar","Kenia",
                                         "Kirgisistan","Kiribati","Kolumbien","Komoren","Kongo (Brazzaville)","Kongo (Kinshasa)","Korea (Nord-)","Korea (Süd-)","Kosovo","Kroatien","Kuba","Kuwait","Laos","Lesotho","Lettland","Libanon",
                                         "Liberia","Libyen","Liechtenstein","Litauen","Luxemburg","Madagaskar","Malawi","Malaysia","Malediven","Mali","Malta","Marokko","Marshallinseln","Mauretanien","Mauritius","Mexiko","Mikronesien",
                                         "Moldau","Monaco","Mongolei","Montenegro","Mosambik","Myanmar","Namibia","Nauru","Nepal","Neuseeland","Nicaragua","Niederlande","Niger","Nigeria","Nordmazedonien","Norwegen","Oman","Österreich",
                                         "Pakistan","Palau","Panama","Papua-Neuguinea","Paraguay","Peru","Philippinen","Polen","Portugal","Ruanda","Rumänien","Russland","Salomoninseln","Sambia","Samoa","San Marino","São Tomé und Príncipe",
                                         "Saudi-Arabien","Schweden","Schweiz","Senegal","Serbien","Seychellen","Sierra Leone","Simbabwe","Singapur","Slowakei","Slowenien","Somalia","Spanien","Sri Lanka","St. Kitts und Nevis","St. Lucia","St. Vincent und die Grenadinen",
                                         "Südafrika","Sudan","Südsudan","Suriname","Syrien","Tadschikistan","Taiwan","Tansania","Thailand","Timor-Leste","Togo","Tonga","Trinidad und Tobago","Tschad","Tschechien","Tunesien","Türkiye",
                                         "Turkmenistan","Tuvalu","Uganda","Ukraine","Ungarn","Uruguay","Usbekistan","Vanuatu","Venezuela","Vereinigte Arabische Emirate","Vereinigte Staaten","Vereinigtes Königreich","Vietnam","Zentralafrikanische Republik","Zypern"};
        #endregion

        #region Params
        private int rowIndex { get; set; }
        public CheckState statusMitarbeiter { get; set; }
        public CheckState statusLehrling { get; set; }

        #endregion

        #region Instances

        private XDocument mitarbeiter = new XDocument();
        XMLHandler xmlHandler = new XMLHandler();
        Validator val = new Validator();

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
            CmdCancel.Visible = true;
            CmdMitarbeiterErstellen.Visible = false;
            CmdMitarbeiterSpeichernErstellen.Visible = true;
            CmdMitarbeiterChangesSpeichern.Visible = false;
            DtgData.Enabled = false;

            CmbAnrede.ResetText();
            TxtVorname.ResetText();
            TxtNachname.ResetText();

            CmbTitel.ResetText();
            CmbGeschlecht.ResetText();
            DtpGeburtsdatum.ResetText();
            CmbNationalitaet.ResetText();
            TxtAhvNum.ResetText();

            TxtEmail.ResetText();
            TxtTelGesch.ResetText();
            TxtTelMobil.ResetText();
            TxtTelPriv.ResetText();

            TxtStrasse.ResetText();
            TxtWohnort.ResetText();
            NumPostleitzahl.ResetText();

            NumKaderstufe.ResetText();
            TxtAbteilung.ResetText();
            TxtRolle.ResetText();
            NumArbeitspensum.ResetText();
            DtpStartdatum.ResetText();
            DtpEnddatum.ResetText();
            NumAktLehrjahr.ResetText();
            NumLehrjahr.ResetText();

        }

        /// <summary>
        /// Sobald UcMitarbeiterStamm geladen wird werden die Comboboxen gefüllt, die LoadFile funktion ausgeführt und der Reset & Delete Button deaktiviert.
        /// </summary>
        private void UcMitarbeiterStamm_Load(object sender, EventArgs e)
        {
            FillCombobox();
            LoadFile();
            CmdDelete.Visible = false;
        }
        private void CmdMitarbeiterSpeichern_Click(object sender, EventArgs e)
        {
            string vorname = "";
            string nachname = "";

            try
            {
                var isVaild = val.ValidateString(TxtVorname.Text) && val.ValidateString(TxtNachname.Text);
                if (isVaild)
                {
                    CmdMitarbeiterErstellen.Visible = true;
                    CmdMitarbeiterSpeichernErstellen.Visible = false;
                    CmdDelete.Visible = true;
                    DtgData.Enabled = true;
                    CmdCancel.Visible = false;

                    bool status = Status();

                    string anrede = CmbAnrede.Text;
                    string titel = CmbTitel.Text;
                    string geschlecht = CmbGeschlecht.Text;

                    //Benötigte Felder
                    vorname = TxtVorname.Text;
                    nachname = TxtNachname.Text;

                    DateTime dob = DtpGeburtsdatum.Value;
                    string ahv = TxtAhvNum.Text;
                    string nationalitaet = CmbNationalitaet.Text;

                    string email = TxtEmail.Text;
                    string privat = TxtTelPriv.Text;
                    string mobil = TxtTelMobil.Text;
                    string arbeit = TxtTelGesch.Text;

                    string strasse = TxtStrasse.Text;
                    string wohnort = TxtWohnort.Text;
                    int plz = Convert.ToInt16(NumPostleitzahl.Value);

                    int ks = Convert.ToInt16(NumKaderstufe.Value);
                    string rolle = TxtRolle.Text;
                    string abt = TxtAbteilung.Text;
                    int arbp = Convert.ToInt16(NumArbeitspensum.Value);
                    DateTime st = DtpStartdatum.Value;
                    DateTime et = DtpEnddatum.Value;
                    int lehrjahre = Convert.ToInt16(NumLehrjahr.Value);
                    int aktLehrjahr = Convert.ToInt16(NumAktLehrjahr.Value);

                    Guid id = Guid.NewGuid();

                    NumLehrjahr.Enabled = false;
                    NumAktLehrjahr.Enabled = false;

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

                    CmdMitarbeiterChangesSpeichern.Visible = true;

                    LblId.Text = Convert.ToString(id);
                    LoadFile();

                    MessageBox.Show($"Der Nutzer {vorname} {nachname} wurde erstellt.");
                }
                else 
                {
                    MessageBox.Show($"Die Pflichtfelder: Vorname, Nachname dürfen keine Zahlen enthalten oder leer sein");
                }

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

        private void CmdMitarbeiterChangesSpeichern_Click(object sender, EventArgs e)
        {
            string vorname = "";
            string nachname = "";

            try
            {
                var isVaild = val.ValidateString(TxtVorname.Text) && val.ValidateString(TxtNachname.Text);
                if (isVaild)
                {
                    CmdMitarbeiterErstellen.Visible = true;
                    CmdMitarbeiterSpeichernErstellen.Visible = false;
                    CmdDelete.Visible = true;
                    DtgData.Enabled = true;
                    CmdCancel.Visible = false;

                    bool status = Status();

                    string anrede = CmbAnrede.Text;
                    string titel = CmbTitel.Text;
                    string geschlecht = CmbGeschlecht.Text;

                    //Benötigte Felder
                    vorname = TxtVorname.Text;
                    nachname = TxtNachname.Text;

                    DateTime dob = DtpGeburtsdatum.Value;
                    string ahv = TxtAhvNum.Text;
                    string nationalitaet = CmbNationalitaet.Text;

                    string email = TxtEmail.Text;
                    string privat = TxtTelPriv.Text;
                    string mobil = TxtTelMobil.Text;
                    string arbeit = TxtTelGesch.Text;

                    string strasse = TxtStrasse.Text;
                    string wohnort = TxtWohnort.Text;
                    int plz = Convert.ToInt16(NumPostleitzahl.Value);

                    int ks = Convert.ToInt16(NumKaderstufe.Value);
                    string rolle = TxtRolle.Text;
                    string abt = TxtAbteilung.Text;
                    int arbp = Convert.ToInt16(NumArbeitspensum.Value);
                    DateTime st = DtpStartdatum.Value;
                    DateTime et = DtpEnddatum.Value;
                    int lehrjahre = Convert.ToInt16(NumLehrjahr.Value);
                    int aktLehrjahr = Convert.ToInt16(NumAktLehrjahr.Value);

                    string eid = IDGetter();
                    Guid id = Guid.Parse(eid);

                    bool istrainee = TraineChecker();

                    NumLehrjahr.Enabled = false;
                    NumAktLehrjahr.Enabled = false;

                    if (ChkLehrling.Checked == true)
                    {
                        Lehrling l = new Lehrling(id, status, istrainee, anrede, titel, geschlecht, vorname, nachname, dob, privat, arbeit, mobil, email, ahv, nationalitaet, strasse, plz, wohnort, ks, rolle, abt, arbp, st, et, lehrjahre, aktLehrjahr);
                        xmlHandler.ChangeValuesLehrlingXML(l);
                    }
                    else if (ChkLehrling.Checked == false)
                    {
                        Mitarbeiter m = new Mitarbeiter(id, status, istrainee, anrede, titel, geschlecht, vorname, nachname, dob, privat, arbeit, mobil, email, ahv, nationalitaet, strasse, plz, wohnort, ks, rolle, abt, arbp, st, et);
                        xmlHandler.ChangeValuesMitarbeiterXML(m);
                    }

                    LoadFile();
                }
                else
                {
                    MessageBox.Show($"Die Pflichtfelder: Vorname, Nachname dürfen keine Zahlen enthalten oder leer sein");
                }

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
                bool filterStatusIsTrue = true;
                bool filterStatusIsFalse = true;
                bool filterLehrlingIsTrue = true;
                bool filterLehrlingIsFalse = true;
                string filterVorname = "";
                string filterNachname = "";



                XMLtoDatagrid(filterStatusIsTrue, filterStatusIsFalse, filterLehrlingIsTrue, filterLehrlingIsFalse, filterVorname, filterNachname);

                if (DtgData.RowCount >= 0)
                {
                    if (rowIndex > 1)
                    {
                        DtgData.CurrentCell = DtgData.Rows[rowIndex].Cells[0];
                        DtgData.Rows[rowIndex].Selected = true;
                    }
                    
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
                cellValue = Convert.ToString(selectedRow.Cells["Mitarbeiternummer"].Value);

            }
            return cellValue;
        }

        /// <summary>
        /// Überprüft im Datagrid wenn die Zeile selektiert wie das Lehrlingsattribut gesetzt ist und gibt dieses wieder zurück.
        /// </summary>
        private bool TraineChecker()
        {

            if (!ChkLehrling.Checked)
            {
                ChkLehrling.Text = "Aktivieren";
                return false;
            }
            else
            {
                ChkLehrling.Text = "Deaktivieren";
                return true;
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

                IndexDeleteUpdate();
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
            CmbNationalitaet.Items.AddRange(nations);
        }

        /// <summary>
        /// Deaktiviert die Buttons CmdWerteSpeichern & CmdMitarbeiterErstellen
        /// Aktiviert wieder das DataGrid
        /// Lädt die Daten erneut
        /// </summary>
        private void CmdCancel_Click(object sender, EventArgs e)
        {
            CmdMitarbeiterSpeichernErstellen.Visible = true;
            CmdMitarbeiterChangesSpeichern.Visible = true;
            DtgData.Enabled = true;

            LoadFile();
        }

        /// <summary>
        /// Ändert sich der Status von ChkLehrling werden die Optionen vom Lehrling aktiviert oder deaktiviert.
        /// </summary>
        private void ChkLehrling_CheckedChanged(object sender, EventArgs e)
        {
            TraineChecker();
            NumLehrjahr.Enabled = true;
            NumAktLehrjahr.Enabled = true;
        }
        public void ApplyXmlFilter(string filterVorname, string filterNachname)
        {
            CmdFilterReset.Visible = true;


            if (statusMitarbeiter == CheckState.Unchecked)
            {
                //DtgData.CurrentCell = DtgData.Rows[rowIndex].Cells[0];
                if (statusLehrling == CheckState.Unchecked)
                {
                    bool filterStatusIsTrue = false;
                    bool filterStatusIsFalse = true;

                    bool statusLehrlingIsTrue = false;
                    bool statusLehrlingIsFalse = true;

                    XMLtoDatagrid(filterStatusIsTrue, filterStatusIsFalse, statusLehrlingIsTrue, statusLehrlingIsFalse, filterVorname, filterNachname);

                    HideButtons();
                }
                else if(statusLehrling == CheckState.Checked)
                {
                    bool filterStatusIsTrue = false;
                    bool filterStatusIsFalse = true;

                    bool statusLehrlingIsTrue = true;
                    bool statusLehrlingIsFalse = false;

                    XMLtoDatagrid(filterStatusIsTrue, filterStatusIsFalse, statusLehrlingIsTrue, statusLehrlingIsFalse, filterVorname, filterNachname);

                    HideButtons();
                }
                else
                {
                    bool filterStatusIsTrue = false;
                    bool filterStatusIsFalse = true;

                    bool statusLehrlingIsTrue = true;
                    bool statusLehrlingIsFalse = true;

                    XMLtoDatagrid(filterStatusIsTrue, filterStatusIsFalse, statusLehrlingIsTrue, statusLehrlingIsFalse, filterVorname, filterNachname);

                    HideButtons();
                }
            }
            else if (statusMitarbeiter == CheckState.Checked)
            {
                if (statusLehrling == CheckState.Unchecked)
                {
                    bool filterStatusIsTrue = true;
                    bool filterStatusIsFalse = false;

                    bool statusLehrlingIsTrue = false;
                    bool statusLehrlingIsFalse = true;

                    XMLtoDatagrid(filterStatusIsTrue, filterStatusIsFalse, statusLehrlingIsTrue, statusLehrlingIsFalse, filterVorname, filterNachname);

                    HideButtons();
                }
                else if (statusLehrling == CheckState.Checked)
                {
                    bool filterStatusIsTrue = true;
                    bool filterStatusIsFalse = false;

                    bool statusLehrlingIsTrue = true;
                    bool statusLehrlingIsFalse = false;

                    XMLtoDatagrid(filterStatusIsTrue, filterStatusIsFalse, statusLehrlingIsTrue, statusLehrlingIsFalse, filterVorname, filterNachname);

                    HideButtons();
                }
                else
                {
                    bool filterStatusIsTrue = true;
                    bool filterStatusIsFalse = false;

                    bool statusLehrlingIsTrue = true;
                    bool statusLehrlingIsFalse = true;

                    XMLtoDatagrid(filterStatusIsTrue, filterStatusIsFalse, statusLehrlingIsTrue, statusLehrlingIsFalse, filterVorname, filterNachname);

                    HideButtons();
                }
            }
            else
            {
                if (statusLehrling == CheckState.Unchecked)
                {
                    bool filterStatusIsTrue = true;
                    bool filterStatusIsFalse = true;

                    bool statusLehrlingIsTrue = false;
                    bool statusLehrlingIsFalse = true;

                    XMLtoDatagrid(filterStatusIsTrue, filterStatusIsFalse, statusLehrlingIsTrue, statusLehrlingIsFalse, filterVorname, filterNachname);

                    HideButtons();
                }
                else if (statusLehrling == CheckState.Checked)
                {
                    bool filterStatusIsTrue = true;
                    bool filterStatusIsFalse = true;

                    bool statusLehrlingIsTrue = true;
                    bool statusLehrlingIsFalse = false;

                    XMLtoDatagrid(filterStatusIsTrue, filterStatusIsFalse, statusLehrlingIsTrue, statusLehrlingIsFalse, filterVorname, filterNachname);

                    HideButtons();
                }
                else
                {
                    bool filterStatusIsTrue = true;
                    bool filterStatusIsFalse = true;

                    bool statusLehrlingIsTrue = true;
                    bool statusLehrlingIsFalse = true;

                    XMLtoDatagrid(filterStatusIsTrue, filterStatusIsFalse, statusLehrlingIsTrue, statusLehrlingIsFalse, filterVorname, filterNachname);

                    HideButtons();
                }
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
        }

        public void XMLtoDatagrid(bool statusIsTrue, bool statusIsFalse, bool statusLehrlingIsTrue, bool statusLehrlingIsFalse, string filterVorname, string filterNachname)
        {
            mitarbeiter = XDocument.Load(Directory.GetCurrentDirectory() + "/Mitarbeiter.xml");

            var data = mitarbeiter.Descendants("Mitarbeiter")
                .Where(m => ((bool)m.Attribute("Status") == statusIsTrue ||
                             (bool)m.Attribute("Status") == !statusIsFalse) &&
                             ((bool)m.Attribute("Lehrling") == statusLehrlingIsTrue ||
                             (bool)m.Attribute("Lehrling") == !statusLehrlingIsFalse) &&
                             m.Element("Vorname").Value.Contains(filterVorname) &&
                             m.Element("Nachname").Value.Contains(filterNachname)
                )
                .Select(m =>
                {
                    bool Angestelt = Convert.ToBoolean(m.Attribute("Status").Value);
                    bool Lehrling = Convert.ToBoolean(m.Attribute("Lehrling").Value);

                    return new
                    {
                        Mitarbeiternummer = m.Attribute("ID").Value,
                        Anrede = m.Element("Anrede").Value,
                        Vorname = m.Element("Vorname").Value,
                        Nachname = m.Element("Nachname").Value,
                        Nationalität = m.Element("Nationalität").Value,
                        Wohnadresse = m.Element("Strasse").Value,
                        Wohnort = m.Element("Wohnort").Value,
                        Postleitzahl = m.Element("Postleitzahl").Value,
                        TelPrivat = m.Element("Telefon_Privat").Value,
                        Angestelt,
                        Lehrling
                };
                })
                .OrderBy(m => m.Mitarbeiternummer).ToList();

            ClearDataBindings();

            DtgData.DataSource = data;

            LblId.DataBindings.Add("text", data, "Mitarbeiternummer");
            CmbAnrede.DataBindings.Add("text", data, "Anrede");
            TxtVorname.DataBindings.Add("text", data, "Vorname");
            TxtNachname.DataBindings.Add("text", data, "Nachname");
            TxtStrasse.DataBindings.Add("text", data, "Wohnadresse");
            TxtWohnort.DataBindings.Add("text", data, "Wohnort");
            NumPostleitzahl.DataBindings.Add("text", data, "Postleitzahl");
            TxtTelPriv.DataBindings.Add("text", data, "Postleitzahl");
            ChkStatus.DataBindings.Add("Checked", data, "Angestelt");
            ChkLehrling.DataBindings.Add("Checked", data, "Lehrling");

            LblAnzahlZeilenGeladen.Text = Convert.ToString(DtgData.Rows.Count);
        }

        private void CmdSuchfilter_Click_1(object sender, EventArgs e)
        {
            ClearDataBindings();

            FilterDashboard filterDashboard = new FilterDashboard();
            filterDashboard.ShowDialog();
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

            string id = IDGetter();

            CmdDelete.Visible = true;

            if (DtgData.SelectedRows.Count >= 2)
            {
                if (ChkLehrling.Checked == false)
                {
                    Mitarbeiter m = xmlHandler.RetriveValuesMitarbeiter(id);

                    //Anrede, Vorname, Nachname, Postleitzahl, Status, Lehrling

                    CmbTitel.Text = m.Title;
                    CmbGeschlecht.Text = m.Gender;
                    DtpGeburtsdatum.Value = m.Geburtsdatum;
                    CmbNationalitaet.Text = m.Nationalität;
                    TxtAhvNum.Text = m.AhvNumber;

                    TxtEmail.Text = m.Email;
                    TxtTelGesch.Text = m.TelefonArbeit;
                    TxtTelMobil.Text = m.TelefonMobil;
                    TxtTelPriv.Text = m.TelefonPrivat;

                    TxtStrasse.Text = m.Strasse;

                    NumKaderstufe.Value = m.KaderStufe;
                    TxtAbteilung.Text = m.Abteilung;
                    TxtRolle.Text = m.Rolle;
                    NumArbeitspensum.Value = m.Arbeitspensum;
                    DtpStartdatum.Value = m.StartDate;
                    DtpEnddatum.Value = m.EndDate;
                    NumAktLehrjahr.Value = 1;
                    NumLehrjahr.Value = 1;

                    NumLehrjahr.Enabled = false;
                    NumAktLehrjahr.Enabled = false;
                }
                else
                {

                    Lehrling l = xmlHandler.RetriveValueLehrling(id);

                    CmbTitel.Text = l.Title;
                    CmbGeschlecht.Text = l.Gender;
                    DtpGeburtsdatum.Value = l.Geburtsdatum;
                    CmbNationalitaet.Text = l.Nationalität;
                    TxtAhvNum.Text = l.AhvNumber;

                    TxtEmail.Text = l.Email;
                    TxtTelGesch.Text = l.TelefonArbeit;
                    TxtTelMobil.Text = l.TelefonMobil;
                    TxtTelPriv.Text = l.TelefonPrivat;

                    TxtStrasse.Text = l.Strasse;

                    NumKaderstufe.Value = l.KaderStufe;
                    TxtAbteilung.Text = l.Abteilung;
                    TxtRolle.Text = l.Rolle;
                    NumArbeitspensum.Value = l.Arbeitspensum;
                    DtpStartdatum.Value = l.StartDate;
                    DtpEnddatum.Value = l.EndDate;

                    NumLehrjahr.Value = l.TraineeYears;
                    NumAktLehrjahr.Value = l.ActualTraineeYear;

                    NumLehrjahr.Enabled = true;
                    NumAktLehrjahr.Enabled = true;
                }
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
            TxtStrasse.DataBindings.Clear();
            TxtWohnort.DataBindings.Clear();
            NumPostleitzahl.DataBindings.Clear();
            TxtTelPriv.DataBindings.Clear();
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
        private void IndexDeleteUpdate()
        {
            if (rowIndex != 0)
                rowIndex = rowIndex - 1;
            else
                rowIndex = 0;
        }
        private void EnableFields()
        {
            ChkStatus.Enabled = true;
        }
    }
}
