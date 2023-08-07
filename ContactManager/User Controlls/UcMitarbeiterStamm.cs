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
            
            UcMitarbeiterStamm mf = new UcMitarbeiterStamm();
            this.Controls.Clear();

            UcMitarbeiterErfassen ucMe = new UcMitarbeiterErfassen();
            ucMe.Dock = DockStyle.Fill;
            this.Controls.Add(ucMe);
        }

        private void CmdMitarbeiterBearbeiten_Click(object sender, EventArgs e)
        {
            
            UcMitarbeiterStamm mf = new UcMitarbeiterStamm();
            this.Controls.Clear();

       
            UcMitarbeiterBearbeiten mb = new UcMitarbeiterBearbeiten();
            mb.id = IDGetter();
            mb.Dock = DockStyle.Fill;
            this.Controls.Add(mb);

        }

        private void UcMitarbeiterStamm_Load(object sender, EventArgs e)
        {
            CmbAnrede.Items.Add("Herr");
            CmbAnrede.Items.Add("Frau");
            LoadFile();
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

            Mitarbeiter m = new Mitarbeiter(id, anrede, vorname, nachname, dob, privat, arbeit, mobil, email, ahv, nationalitaet, strasse, plz, wohnort, ks, abt, arbp, st);


            //xmlHandler.ChangeValuesXML(id, status,anrede, vorname, nachname, dob, email, strasse, wohnort, plz);
            xmlHandler.ChangeValuesMitarbeiterXML(m);
            LoadFile();

        }

        public void LoadFile()
        {
            if (File.Exists("Mitarbeiter.xml"))
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(Directory.GetCurrentDirectory() + "/Mitarbeiter.xml");
                DtgData.DataSource = dataSet.Tables[0];
                DtgData.CurrentCell = DtgData.Rows[index].Cells[0];
               
            }
        }

    }
}
