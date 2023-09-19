using ContactManager.Controller;
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
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ContactManager
{
    public partial class UcKundeStamm : UserControl
    {
        public UcKundeStamm()
        {
            InitializeComponent();
        }

        #region Parameters
        private int index { get; set; }
        private bool ErstellenOderSpeichern = false;
        public CheckState statusKunde { get; set; }
        #endregion

        #region Instances
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
        private XDocument kunden = new XDocument();
        XMLHandler xmlHandler = new XMLHandler();
        Validator val = new Validator();
        #endregion

        #region Combobox
        string[] kundentyp = new string[] { "A", "B", "C", "D", "E" };
        string[] anrede = new string[] { "Herr", "Frau", "Divers" };
        string[] geschlecht = new string[] { "Männlich", "Weiblich", "Divers" };
        string[] titel = new string[] { "", "Dr.", "Prof.", "Dipl.-Ing." };
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

        #region Buttons and Clickevents

        /// <summary>
        /// Die Eingabe in TxtNotizInput wird in den string Notiz eingefügt.
        /// Der Dateipfad wird über den ID-Getter geholt. 
        /// 
        /// Path & notiz werden danach in die NotizErfassen Funktion weitergegeben vom NotizController
        /// </summary>
        private void CmdNotizErfassen_Click(object sender, EventArgs e)
        {
            string notiz = TxtNotizInput.Text;
            string path = $"{IDGetter()}.txt";

            nc.NotizErfassen(path, notiz);
            TxtNotizInput.Clear();
            LoadNotes();

        }

        /// <summary>
        /// Beim laden des UcKundenStamm werden die Comboboxen sowie die Datei geladen.
        /// </summary>
        private void UcKundeStamm_Load(object sender, EventArgs e)
        {
            FillCombobox();
            LoadFile();

            HideButtons();
        }

        /// <summary>
        /// Beim Click auf eine Zelle wird die ID ausgelesen und in den string-path gecastet.
        /// Durch dies werden alle Textfelder mit den Werten der selektierten ID geladen sowie mit "path" die Textdatei welche als Notiz dient geladen (insofern bereits eine Datei existiert)
        /// </summary>
        private void DtgData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowButtons();

            CmdDelete.Visible = true;
            index = DtgData.CurrentRow.Index;

            string id = IDGetter();
            string path = $"{id}.txt";

            Kunde k = xmlHandler.RetriveValuesKunde(id);

            if (k.isActive)
            {
                LblStatus.Text = "Aktiviert";
                ChkStatus.Checked = true;
            }
            else
            {
                LblStatus.Text = "Deaktiviert";
                ChkStatus.Checked = false;
            }


            CmbTitel.Text = k.Title;
            DtpGeburtsdatum.Value = k.Geburtsdatum;
            CmbNationalitaet.Text = k.Nationalität;
            TxtAhvNum.Text = k.AhvNumber;

            TxtEmail.Text = k.Email;
            TxtTelPriv.Text = k.TelefonPrivat;
            TxtTelMobil.Text = k.TelefonMobil;
            TxtTelGesch.Text = k.TelefonArbeit;

            TxtStrasse.Text = k.Strasse;
            TxtWohnort.Text = k.Wohnort;

            CmbKundentyp.Text = Convert.ToString(k.Kundentyp);
            TxtKundenkontakt.Text = k.Kundenkontakt;
            TxtFirmenadresse.Text = k.Firmenadresse;
            TxtFirmenname.Text = k.Firmenname;

            CheckingForNotes(path);
        }

        /// <summary>
        /// Überprüft ob Notizen existieren und zeigt diese an oder gibt einen Text aus
        /// </summary>
        private void CheckingForNotes(string path)
        {
            if (File.Exists(path))
            {
                TxtNotizOutput.Text = nc.NotizLaden(path);
            }
            else
            {
                TxtNotizOutput.Text = "Keine Notizen vorhanden";
            }
        }

        /// <summary>
        /// Erstellt den Kunden und Überprüft die Eingaben
        /// </summary>
        private void CmdKundeErstellen_Click(object sender, EventArgs e)
        {
            CmdKundeErstellen.Visible = false;
            CmdSaveChanges.Visible = false;
            CmdSave.Visible = true;
            CmdCancel.Visible = true;
        }

        /// <summary>
        /// Führt beim Klick auf CmdClear die Funktion ClearAll aus.
        /// </summary>
        private void CmdClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        /// <summary>
        /// Beim Klicken auf CmdSave wird die Erstellen-Funktion ausgeführt.
        /// Hier werden alle Felder ausgelesn und wenn nötig bereits Konvertiert (Kundentyp to char, plz to int)
        /// Die ganzen Werte werden in das Objekt Kunde "k" eingefügt und danach an den XML-Handler CreateKundeXML weitergegeben. 
        /// Danach wird die Funktion LoadFile ausgeführt.
        /// </summary>
        private void CmdSave_Click(object sender, EventArgs e)
        {
            string vorname = "";
            string nachname = "";
            string firmenname = "";

            CmdSave.Visible = false;
            CmdSaveChanges.Visible = true;
            CmdCancel.Visible = false;
            try
            {
                var isValid = val.ValidateString(TxtVorname.Text) && val.ValidateString(TxtNachname.Text) && val.ValidateString(TxtFirmenname.Text);
                if (isValid)
                {
                bool status = Status();
                string anrede = CmbAnrede.Text;
                string titel = CmbTitel.Text;
                string geschlecht = CmbGeschlecht.Text;
                 vorname = TxtVorname.Text;
                nachname = TxtNachname.Text;
                DateTime dob = DtpGeburtsdatum.Value;
                string nationalitaet = CmbNationalitaet.Text;
                string ahv = TxtAhvNum.Text;

                string email = TxtEmail.Text;
                string privat = TxtTelPriv.Text;
                string arbeit = TxtTelGesch.Text;
                string mobil = TxtTelMobil.Text;

                string strasse = TxtStrasse.Text;
                string wohnort = TxtWohnort.Text;
                int plz = Convert.ToInt16(NumPostleitzahl.Value);

                firmenname = TxtFirmenname.Text;
                string firmenadresse = TxtFirmenadresse.Text;
                char kundentyp = Convert.ToChar(CmbKundentyp.Text);
                string kundenkontakt = TxtKundenkontakt.Text;

                Guid id = Guid.NewGuid();
                Kunde k = new Kunde(id, status, anrede, titel, geschlecht, vorname, nachname, dob, privat, arbeit, mobil, email, ahv, nationalitaet, strasse, plz, wohnort, firmenname, firmenadresse, kundentyp, kundenkontakt);

                xmlHandler.CreateKundeXML(k);
                ErstellenOderSpeichern = false;

                CmdSave.Visible = false;

                LoadFile();
            }
            else
            {
            MessageBox.Show($"Die Pflichtfelder: Vorname, Nachname, Firmename, Kundentyp dürfen keine Zahlen enthalten oder leer sein");
            }
            
            }              
            catch (FormatException ex)
            {
                MessageBox.Show("Format stimmt nicht " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }

        /// <summary>
        /// Beim Klicken auf CmdSave wird die Speicherfunktion ausgeführt.
        /// Hier werden alle Felder ausgelesn und wenn nötig bereits Konvertiert (Kundentyp to char, plz to int)
        /// Die ganzen Werte werden in das Objekt Kunde "k" eingefügt und danach an den XML-Handler ChangeValuesKunde weitergegeben. 
        /// Danach wird die Funktion LoadFile ausgeführt.
        /// </summary>
        private void CmdSaveChanges_Click(object sender, EventArgs e)
        {
            string vorname = "";
            string nachname = "";
            string firmenname = "";
            try { 
                var isValid = val.ValidateString(TxtVorname.Text) && val.ValidateString(TxtNachname.Text) && val.ValidateString(TxtFirmenname.Text);
                if (isValid)
                {
                    bool status = Status();
                    string anrede = CmbAnrede.Text;
                    string titel = CmbTitel.Text;
                    string geschlecht = CmbGeschlecht.Text;
                    vorname = TxtVorname.Text;
                    nachname = TxtNachname.Text;
                    DateTime dob = DtpGeburtsdatum.Value;
                    string nationalitaet = CmbNationalitaet.Text;
                    string ahv = TxtAhvNum.Text;

                    string email = TxtEmail.Text;
                    string privat = TxtTelPriv.Text;
                    string arbeit = TxtTelGesch.Text;
                    string mobil = TxtTelMobil.Text;

                    string strasse = TxtStrasse.Text;
                    string wohnort = TxtWohnort.Text;
                    int plz = Convert.ToInt16(NumPostleitzahl.Value);

                    firmenname = TxtFirmenname.Text;
                    string firmenadresse = TxtFirmenadresse.Text;
                    char kundentyp = Convert.ToChar(CmbKundentyp.Text);
                    string kundenkontakt = TxtKundenkontakt.Text;

                    string id = IDGetter();
                    Guid ide = Guid.Parse(id);
                    Kunde k = new Kunde(ide, status, anrede, titel, geschlecht, vorname, nachname, dob, privat, arbeit, mobil, email, ahv, nationalitaet, strasse, plz, wohnort, firmenname, firmenadresse, kundentyp, kundenkontakt);
                    xmlHandler.ChangeValuesKundeXML(k);

                    LoadFile();
                }
                else

                {
                MessageBox.Show($"Die Pflichtfelder: Vorname, Nachname, Firmename, Kundentyp dürfen keine Zahlen enthalten oder leer sein");
                }
              }
            catch (FormatException ex)
            {
                MessageBox.Show("Format stimmt nicht " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }
        /// <summary>
        /// Mit dem ID-Getter wird die ID der aktuellen Zelle geholt und löscht darauf mit der Funktion DeleteValuesKunde den Kunde und die dazugehörige Textdatei.
        /// </summary>
        private void Kill_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Benutzer löschen?", "Achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                string id = IDGetter();

                File.Delete($"{id}.txt");
                xmlHandler.DeleteValuesKunde(id);

                IndexDeleteUpdate();

                LoadFile();
            }
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
            if (index != 0)
                index = index - 1;
            else
                index = 0;
        }

        /// <summary>
        /// Führt bei jeder Änderung von ChkStatus die Funktion Status aus.
        /// </summary>
        private void ChkStatus_CheckedChanged(object sender, EventArgs e)
        {
            Status();
        }

        #endregion


        /// <summary>
        /// Gibt von der selektierten Zeile im DataGrid die ID aus und gibt diese wieder zurück.
        /// </summary>
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

        /// <summary>
        /// Wenn der Status der Checkbox sich ändert ändert sich auch der Text.
        /// </summary>
        private bool Status()
        {
            if (ChkStatus.Checked)
            {
                ChkStatus.Text = "Aktiviert";
                return true;
            }
            else
            {
                ChkStatus.Text = "Deaktiviert";
                return false;
            }
        }

        /// <summary>
        /// Hier sind alle Comoboxen verlinkt und in dieser Funktion untergebracht.
        /// </summary>
        private void FillCombobox()
        {
            CmbKundentyp.Items.AddRange(kundentyp);
            CmbAnrede.Items.AddRange(anrede);
            CmbTitel.Items.AddRange(titel);
            CmbGeschlecht.Items.AddRange(geschlecht);
            CmbNationalitaet.Items.AddRange(nations);
        }

        /// <summary>
        /// Erstellt das Datagrid, hier kommt auch der Hauptteil des Filters ins Spiel
        /// Zudem sind hier die wichtigen Felder welche im DataGrid angezeigt werden hinterlegt
        /// </summary>
        public void XMLtoDatagrid(bool statusIsTrue, bool statusIsFalse, string filterVorname, string filterNachname, string filterFirmenname)
        {
            kunden = XDocument.Load(Directory.GetCurrentDirectory() + "/Kunde.xml");

            var data = kunden.Descendants("Kunde")
                .Where(k => (bool)k.Attribute("Status") == statusIsTrue ||
                             (bool)k.Attribute("Status") == !statusIsFalse &&
                             k.Element("Vorname").Value.Contains(filterVorname) &&
                             k.Element("Nachname").Value.Contains(filterNachname) &&
                             k.Element("Firmenname").Value.Contains(filterFirmenname)

                )
                .Select(k =>
                {
                    string kStatus = k.Attribute("Status").Value;
                    bool Status = Convert.ToBoolean(kStatus);

                    foreach (var zeile in kunden.Descendants())
                    {
                        if (Status == true)
                            kStatus = "Aktiv";
                        else
                            kStatus = "Inaktiv";
                    }

                    return new
                    {
                        ID = k.Attribute("ID").Value,
                        Anrede = k.Element("Anrede").Value,
                        Vorname = k.Element("Vorname").Value,
                        Nachname = k.Element("Nachname").Value,
                        Postleitzahl = k.Element("Postleitzahl").Value,
                        Status,
                    };
                })
                .OrderBy(m => m.ID).ToList();

            ClearDataBindings();

            DtgData.DataSource = data;

            LblId.DataBindings.Add("text", data, "ID");
            CmbAnrede.DataBindings.Add("text", data, "Anrede");
            TxtVorname.DataBindings.Add("text", data, "Vorname");
            TxtNachname.DataBindings.Add("text", data, "Nachname");
            NumPostleitzahl.DataBindings.Add("text", data, "Postleitzahl");
            ChkStatus.DataBindings.Add("Checked", data, "Status");
            
            LblAnzahlZeilenGeladen.Text = Convert.ToString(DtgData.Rows.Count);
        }

        /// <summary>
        /// Wenn die Datei "Kunde.xml" exisiter und mehr oder gleich 60 Zeichen enthält (Aufgrund der Codierung und Angaben welche eine XML Datei enthält) wird die Datei geladen.
        /// Ansonsten bleibt das DataGrid leer.
        /// </summary>
        private void LoadFile()
        {
            if (File.Exists("Kunde.xml") && new FileInfo("Kunde.xml").Length >= 60)
            {
                bool filterStatusIsTrue = true;
                bool filterStatusIsFalse = true;
                string filterVorname = "";
                string filterNachname = "";
                string filterFirmenname = "";

                XMLtoDatagrid(filterStatusIsTrue, filterStatusIsFalse, filterVorname, filterNachname, filterFirmenname);

                LoadNotes();

                if (DtgData.CurrentCell.RowIndex >= 0)
                {
                    DtgData.CurrentCell = DtgData.Rows[index].Cells[0];
                }
            }
            else
            {
                DtgData.DataSource = null;
            }
            HideButtons();
        }

        /// <summary>
        /// Hier werden alle Felder zurückgesetzt auf ihren Standart.
        /// </summary>
        private void ClearAll()
        {
            LblId.Text = "...";
            LblStatus.Text = "...";

            CmbAnrede.ResetText();
            CmbTitel.ResetText();
            CmbGeschlecht.ResetText();

            TxtVorname.Clear();
            TxtNachname.Clear();
            DtpGeburtsdatum.ResetText();
            CmbNationalitaet.ResetText();
            TxtAhvNum.Clear();

            TxtEmail.Clear();
            TxtTelPriv.Clear();
            TxtTelGesch.Clear();
            TxtTelMobil.Clear();

            TxtStrasse.Clear();
            TxtWohnort.Clear();
            NumPostleitzahl.ResetText();

            TxtFirmenname.Clear();
            TxtFirmenadresse.Clear();
            CmbKundentyp.ResetText();
            TxtKundenkontakt.Clear();
        }

        /// <summary>
        /// Lädt die Notizen sobald die Datei existiert in das Feld TxtNotizenOutput
        /// </summary>
        private void LoadNotes()
        {
            string path = $"{IDGetter()}.txt";

            if (File.Exists(path))
            {
                TxtNotizOutput.Text = nc.NotizLaden(path);
            }

        }

        /// <summary>
        /// Versteckt Buttons
        /// </summary>
        private void HideButtons()
        {
            CmdDelete.Visible = false;
            CmdSave.Visible = false;

            CmdNotizErfassen.Enabled = false;
        }

        /// <summary>
        /// Zeigt Buttons an
        /// </summary>
        private void ShowButtons()
        {
            CmdDelete.Visible = true;
            CmdSave.Visible = true;

            CmdNotizErfassen.Enabled = true;
        }

        /// <summary>
        /// Mit dem Filter kann überprüft werden ob der Status Aktiv/Inaktiv ist oder ob es sich um einen Lehrling handelt
        /// Zudem kann nach dem Vornamen und Nachnamen gesucht werden
        /// </summary>
        public void ApplyXmlFilter(string filterVorname, string filterNachname, string filterFirmenname)
        {
            CmdFilterReset.Visible = true;

            if (statusKunde == CheckState.Unchecked)
            {
                bool filterStatusIsTrue = false;
                bool filterStatusisFalse = true;

                XMLtoDatagrid(filterStatusIsTrue, filterStatusisFalse, filterVorname, filterNachname, filterFirmenname);

                HideButtons();
            }
            else if (statusKunde == CheckState.Checked)
            {
                bool filterStatusIsTrue = true;
                bool filterStatusisFalse = false;

                XMLtoDatagrid(filterStatusIsTrue, filterStatusisFalse, filterVorname, filterNachname, filterFirmenname);

                HideButtons();
            }
            else 
            {
                bool filterStatusIsTrue = true;
                bool filterStatusisFalse = true;

                XMLtoDatagrid(filterStatusIsTrue, filterStatusisFalse, filterVorname, filterNachname, filterFirmenname);

                HideButtons();
            }
        }


        /// <summary>
        /// Löscht die DataBindings
        /// </summary>
        private void ClearDataBindings()
        {
            LblId.DataBindings.Clear();
            CmbAnrede.DataBindings.Clear();
            TxtVorname.DataBindings.Clear();
            TxtNachname.DataBindings.Clear();
            NumPostleitzahl.DataBindings.Clear();
            ChkStatus.DataBindings.Clear();
        }
        /// <summary>
        /// Schaltet Buttons Visible/Invisible
        /// </summary>
        private void CmdCancel_Click(object sender, EventArgs e)
        {
            CmdSave.Visible = false;
            CmdSaveChanges.Visible = true;
            CmdKundeErstellen.Visible = true;
            DtgData.Enabled = true;
            CmdCancel.Visible = false;

            LoadFile();
        }

        /// <summary>
        /// Setzt den Suchfilter
        /// </summary>
        private void CmdSuchfilter_Click(object sender, EventArgs e)
        {
            ClearDataBindings();

            FilterDashboardKunde filterDashboard = new FilterDashboardKunde();
            filterDashboard.ShowDialog();
        }

        /// <summary>
        /// Resetet den Filter
        /// </summary>
        private void CmdFilterReset_Click(object sender, EventArgs e)
        {
            CmdFilterReset.Visible = false;
            LoadFile();
        }
    }
}
