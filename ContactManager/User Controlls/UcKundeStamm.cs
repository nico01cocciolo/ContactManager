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
            string path = $"{IDGetter()}.txt" ;

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
            index = DtgData.CurrentRow.Index;

            ShowButtons();

            string id = IDGetter();
            string path = $"{id}.txt";

            Kunde k = xmlHandler.RetriveValuesKunde(id);

            LblId.Text = Convert.ToString(k.Id);

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

            CmbAnrede.Text = k.Anrede;
            CmbTitel.Text = k.Title;
            TxtVorname.Text = k.Vorname;
            TxtNachname.Text = k.Nachname;
            DtpGeburtsdatum.Value = k.Geburtsdatum;
            CmbNationalitaet.Text = k.Nationalität;
            TxtAhvNum.Text = k.AhvNumber;

            TxtEmail.Text = k.Email;
            TxtTelPriv.Text = k.TelefonPrivat;
            TxtTelMobil.Text = k.TelefonMobil;
            TxtTelGesch.Text = k.TelefonArbeit;

            TxtStrasse.Text = k.Strasse;
            TxtWohnort.Text = k.Wohnort;
            NumPostleitzahl.Value = k.Plz;

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
            ErstellenOderSpeichern = true;
            CmdKundeErstellen.Visible = false;
        }

        /// <summary>
        /// Führt beim Klick auf CmdClear die Funktion ClearAll aus.
        /// </summary>
        private void CmdClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        /// <summary>
        /// Beim Klicken auf CmdSave wird die Speicherfunktion ausgeführt.
        /// Hier werden alle Felder ausgelesn und wenn nötig bereits Konvertiert (Kundentyp to char, plz to int)
        /// Die ganzen Werte werden in das Objekt Kunde "k" eingefügt und danach an den XML-Handler ChangeValuesKunde weitergegeben. 
        /// Danach wird die Funktion LoadFile ausgeführt.
        /// </summary>
        private void CmdSave_Click(object sender, EventArgs e)
        {

            if (CmbKundentyp.SelectedIndex > -1)
            {
                bool status = Status();
                string anrede = CmbAnrede.Text;
                string titel = CmbTitel.Text;
                string geschlecht = CmbGeschlecht.Text;
                string vorname = TxtVorname.Text;
                string nachname = TxtNachname.Text;
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

                string firmenname = TxtFirmenname.Text;
                string firmenadresse = TxtFirmenadresse.Text;
                char kundentyp = Convert.ToChar(CmbKundentyp.Text);
                string kundenkontakt = TxtKundenkontakt.Text;

                if (ErstellenOderSpeichern == true)
                {
                    Guid id = Guid.NewGuid();
                    Kunde k = new Kunde(id, status, anrede, titel, geschlecht, vorname, nachname, dob, privat, arbeit, mobil, email, ahv, nationalitaet, strasse, plz, wohnort, firmenname, firmenadresse, kundentyp, kundenkontakt);

                    xmlHandler.CreateKundeXML(k);
                    ErstellenOderSpeichern = false;

                    CmdSave.Visible = false;
                }
                else if (ErstellenOderSpeichern == false)
                {
                    string id = IDGetter();
                    Guid ide = Guid.Parse(id);
                    Kunde k = new Kunde(ide, status, anrede, titel, geschlecht, vorname, nachname, dob, privat, arbeit, mobil, email, ahv, nationalitaet, strasse, plz, wohnort, firmenname, firmenadresse, kundentyp, kundenkontakt);
                    xmlHandler.ChangeValuesKundeXML(k);
                }

                LoadFile();
            }
            else
            {
                MessageBox.Show("Error", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Question);
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
        /// Wenn die Datei "Kunde.xml" exisiter und mehr oder gleich 60 Zeichen enthält (Aufgrund der Codierung und Angaben welche eine XML Datei enthält) wird die Datei geladen.
        /// Ansonsten bleibt das DataGrid leer.
        /// </summary>
        private void LoadFile()
        {
            if (File.Exists("Kunde.xml") && new FileInfo("Kunde.xml").Length >= 60)
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(Directory.GetCurrentDirectory() + "/Kunde.xml");
                DtgData.DataSource = dataSet.Tables[0];

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

            if(File.Exists(path))
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
    }
}
