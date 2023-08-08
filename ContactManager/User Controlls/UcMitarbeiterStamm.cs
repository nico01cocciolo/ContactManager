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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ContactManager
{
    public partial class UcMitarbeiterStamm : UserControl
    {
        public UcMitarbeiterStamm()
        {
            InitializeComponent(); 
        }

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
            ClearAll();
            CmdMitarbeiterErstellen.Visible = false;
            CmdMitarbeiterSpeichern.Visible = true;
            DtgData.Enabled = false;
            ChangeTxtValues();
        }

        private void CmdMitarbeiterBearbeiten_Click(object sender, EventArgs e)
        {

            ChangeTxtValues();
            CmdWerteSpeichern.Visible = true;
            CmdMitarbeiterBearbeiten.Visible = false;
            DtgData.Enabled = false;

        }

        private void UcMitarbeiterStamm_Load(object sender, EventArgs e)
        {
            CmbAnrede.Items.Add("Herr");
            CmbAnrede.Items.Add("Frau");
            LoadFile();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                index = DtgData.CurrentRow.Index;
                
                string id = IDGetter();

                XElement xdoc = XElement.Load("Mitarbeiter.xml");

                LblId.Text = xdoc.Elements("Mitarbeiter")
                                 .Where(x => x.Attribute("ID").Value == id)
                                 .FirstOrDefault().Attribute("ID").Value;

                CmbAnrede.Text = xdoc.Elements("Mitarbeiter")
                                     .Where(x => x.Attribute("ID").Value == id)
                                     .FirstOrDefault().Element("Anrede").Value;

                TxtVorname.Text = xdoc.Elements("Mitarbeiter")
                                      .Where(x => x.Attribute("ID").Value == id)
                                      .FirstOrDefault().Element("Vorname").Value;

                TxtNachname.Text = xdoc.Elements("Mitarbeiter")
                                       .Where(x => x.Attribute("ID").Value == id)
                                       .FirstOrDefault().Element("Nachname").Value;

                DtpGeburtsdatum.Value = Convert.ToDateTime(xdoc.Elements("Mitarbeiter")
                                               .Where(x => x.Attribute("ID").Value == id)
                                               .FirstOrDefault().Element("Geburtsdatum").Value);

                TxtAhvNum.Text = xdoc.Elements("Mitarbeiter")
                                     .Where(x => x.Attribute("ID").Value == id)
                                     .FirstOrDefault().Element("AHV-Nummer").Value;

                CmbNationalitaet.Text = xdoc.Elements("Mitarbeiter")
                                     .Where(x => x.Attribute("ID").Value == id)
                                     .FirstOrDefault().Element("Nationalität").Value;

                TxtEmail.Text = xdoc.Elements("Mitarbeiter")
                                    .Where(x => x.Attribute("ID").Value == id)
                                    .FirstOrDefault().Element("E-Mail").Value;

                TxtTelGesch.Text = xdoc.Elements("Mitarbeiter")
                                       .Where(x => x.Attribute("ID").Value == id)
                                       .FirstOrDefault().Element("Telefon_Arbeit").Value;
                
                TxtTelMobil.Text = xdoc.Elements("Mitarbeiter")
                                       .Where(x => x.Attribute("ID").Value == id)
                                       .FirstOrDefault().Element("Telefon_Mobil").Value;
                
                TxtTelMobil.Text = xdoc.Elements("Mitarbeiter")
                                       .Where(x => x.Attribute("ID").Value == id)
                                       .FirstOrDefault().Element("Telefon_Privat").Value;

                TxtStrasse.Text = xdoc.Elements("Mitarbeiter")
                                      .Where(x => x.Attribute("ID").Value == id)
                                      .FirstOrDefault().Element("Strasse").Value;

                TxtWohnort.Text = xdoc.Elements("Mitarbeiter")
                                      .Where(x => x.Attribute("ID").Value == id)
                                      .FirstOrDefault().Element("Wohnort").Value;

                TxtPostleitzahl.Text = xdoc.Elements("Mitarbeiter")
                                           .Where(x => x.Attribute("ID").Value == id)
                                           .FirstOrDefault().Element("Postleitzahl").Value;
                
                NumKaderstufe.Value = Convert.ToDecimal(xdoc.Elements("Mitarbeiter")
                                             .Where(x => x.Attribute("ID").Value == id)
                                             .FirstOrDefault().Element("Kaderstufe").Value);

                TxtAbteilung.Text = xdoc.Elements("Mitarbeiter")
                                        .Where(x => x.Attribute("ID").Value == id)
                                        .FirstOrDefault().Element("Abteilung").Value;

                DtpStartdatum.Value = Convert.ToDateTime(xdoc.Elements("Mitarbeiter")
                                             .Where(x => x.Attribute("ID").Value == id)
                                             .FirstOrDefault().Element("Startdatum").Value);

                NumArbeitspensum.Value = Convert.ToDecimal(xdoc.Elements("Mitarbeiter")
                                             .Where(x => x.Attribute("ID").Value == id)
                                             .FirstOrDefault().Element("Arbeitspensum").Value);

            

        }

        private void CmdWerteSpeichern_Click(object sender, EventArgs e)
        {

            CmdWerteSpeichern.Visible = false;
            CmdMitarbeiterBearbeiten.Visible = true;
            DtgData.Enabled = true;

            string eid = IDGetter();

            string status = PersonenStatus();

            Guid id = Guid.Parse(eid);

            string anrede = CmbAnrede.Text;
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
            int arbp = Convert.ToInt16(NumArbeitspensum.Value);
            DateTime st = DtpStartdatum.Value;

            DataGridZeileBearbeiten();
            Mitarbeiter m = new Mitarbeiter(id, anrede, vorname, nachname, dob, privat, arbeit, mobil, email, ahv, nationalitaet, strasse, plz, wohnort, ks, abt, arbp, st);

            xmlHandler.ChangeValuesMitarbeiterXML(m);

        }

        private void CmdMitarbeiterSpeichern_Click(object sender, EventArgs e)
        {
            try
            {
                Guid id = Guid.NewGuid();

                string anrede = CmbAnrede.Text;
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
                string status = "Aktiv";

                int ks = Convert.ToInt16(NumKaderstufe.Value);
                string abt = TxtAbteilung.Text;
                int arbp = Convert.ToInt16(NumArbeitspensum.Value);
                DateTime st = DtpStartdatum.Value;

                Mitarbeiter m = new Mitarbeiter(id, anrede, vorname, nachname, dob, privat, arbeit, mobil, email, ahv, nationalitaet, strasse, plz, wohnort, ks, abt, arbp, st);


                xmlHandler.CreateMitarbeiterXML(m);
                LblId.Text = Convert.ToString(id);
                DataGridNeueZeile();
                CmdMitarbeiterErstellen.Visible = true;
                CmdMitarbeiterSpeichern.Visible = false;
                DtgData.Enabled = true;
                MessageBox.Show($"Der Nutzer {vorname} {nachname} wurde erstellt.");

            }
            catch
            {
                MessageBox.Show("Überprüfen Sie Ihre eingetragenen Felder", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadFile()
        {
            if (File.Exists("Mitarbeiter.xml"))
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(Directory.GetCurrentDirectory() + "/Mitarbeiter.xml");

                foreach (DataRow item in dataSet.Tables["Mitarbeiter"].Rows)
                {
                    int n = DtgData.Rows.Add();
                    DtgData.Rows[n].Cells[0].Value = item[19];
                    DtgData.Rows[n].Cells[1].Value = item[1];
                    DtgData.Rows[n].Cells[2].Value = item[4];
                    DtgData.Rows[n].Cells[3].Value = item[3];
                    DtgData.Rows[n].Cells[4].Value = item[5];
                    DtgData.Rows[n].Cells[5].Value = item[8];
                    DtgData.Rows[n].Cells[6].Value = item[9];
                    DtgData.Rows[n].Cells[7].Value = item[10];
                    DtgData.Rows[n].Cells[8].Value = item[11];
                }

                //DtgData.DataSource = dataSet.Tables[0];
                //DtgData.CurrentCell = DtgData.Rows[index].Cells[0];

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
        }

        public void DataGridZeileBearbeiten()
        {
            DtgData.SelectedCells[0].Value = TxtVorname.Text;

            DtgData.SelectedRows[0].Cells[0].Value = LblId.Text;
            DtgData.SelectedRows[0].Cells[1].Value = CmbAnrede.Text;
            DtgData.SelectedRows[0].Cells[2].Value = TxtNachname.Text;
            DtgData.SelectedRows[0].Cells[3].Value = TxtVorname.Text;
            DtgData.SelectedRows[0].Cells[4].Value = DtpGeburtsdatum.Text;
            DtgData.SelectedRows[0].Cells[5].Value = TxtEmail.Text;
            DtgData.SelectedRows[0].Cells[6].Value = TxtTelMobil.Text;
            DtgData.SelectedRows[0].Cells[7].Value = TxtTelPriv.Text;
            DtgData.SelectedRows[0].Cells[8].Value = TxtTelGesch.Text;
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

        private string PersonenStatus()
        {
            if (!ChkStatus.Checked)
            {
                ChkStatus.Text = "Aktivieren";
                return "Deaktiviert";
            }
            else
            {
                ChkStatus.Text = "Deaktivieren";
                return "Aktiv";
            }
        }

        private void ClearAll()
        {
            //Personen Daten
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

            LblId.Text = "...";
            LblStatus.Text = "...";
        }

        private void ChangeTxtValues()
        {
            TxtWohnort.ReadOnly = false;
            TxtTelPriv.ReadOnly = false;
            TxtTelMobil.ReadOnly = false;
            TxtTelGesch.ReadOnly = false;
            TxtEmail.ReadOnly = false;
            LblId.Enabled = true;
            LblStatus.Enabled = true;
            TxtStrasse.ReadOnly = false;
            TxtNachname.ReadOnly = false;
            TxtVorname.ReadOnly = false;
            TxtAhvNum.ReadOnly = false;
            TxtAbteilung.ReadOnly = false;
            TxtPostleitzahl.ReadOnly = false;
        }

        public void BenutzererstellungFehler()
        {
            if (CmdMitarbeiterErstellen.Visible == false)
            {
                DialogResult dialogResult = MessageBox.Show("Benutzer Speichern?", "Achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {

                    CmdMitarbeiterErstellen.Visible = true;
                }
                else
                {
                    CmdMitarbeiterErstellen.Visible = true;
                }
            }
        }
    }
}
