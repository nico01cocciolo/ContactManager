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

namespace ContactManager
{
    public partial class UcKundeStamm : UserControl
    {
        public UcKundeStamm()
        {
            InitializeComponent();
        }

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

        string[] kundentyp = new string[] { "A", "B", "C", "D", "E" };
        string[] anrede = new string[] { "Herr", "Frau", "Divers" };
        string[] titel = new string[] { "", "Dr.", "Prof.", "Dipl.-Ing." };

        private void CmdNotizErfassen_Click(object sender, EventArgs e)
        {
            NotizController nc = new NotizController();

            string notiz = TxtNotizInput.Text;
            string path = $"{IDGetter()}.txt" ;

            nc.NotizErfassen(path, notiz);
        }

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

        private void UcKundeStamm_Load(object sender, EventArgs e)
        {
            FillCombobox();
            LoadData();
        }

        private void DtgData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = IDGetter();
            string path = $"{id}.txt";

            Kunde k = xmlHandler.RetriveValuesKunde(id);

            LblId.Text = Convert.ToString(k.Id);
            TxtVorname.Text = k.Vorname;
            TxtNachname.Text = k.Nachname;

            if (File.Exists(path))
            {
                TxtNotizOutput.Text = nc.NotizLaden(path);
            }
            else 
            {
                TxtNotizOutput.Text = "Keine Notizen vorhanden";
            }
        }

        private void Knöpgke_Click(object sender, EventArgs e)
        {
            Guid id = Guid.NewGuid();

            string vorname = "";

            string anrede = CmbAnrede.Text;
            
            if (!String.IsNullOrWhiteSpace(TxtVorname.Text))
            {
                string vor = TxtVorname.Text;
                vorname = vor;
            }
            else 
            {
                ErrVorname.SetError(this.TxtVorname, "Eingabe darf nicht leer sein");
            }

            if (CmbKundentyp.SelectedIndex > -1 && TxtPostleitzahl.TextLength > 0)
            {
                bool status = Status();
                string title = CmbTitel.Text;
                string nachname = TxtNachname.Text;
                DateTime dob = DtpGeburtsdatum.Value;
                string nationalitaet = CmbNationalitaet.Text;
                string ahv = TxtAhvNum.Text;

                string email = TxtEmail.Text;
                string mobil = TxtTelMobil.Text;
                string arbeit = TxtTelGesch.Text;
                string privat = TxtTelPriv.Text;

                string strasse = TxtStrasse.Text;
                string wohnort = TxtWohnort.Text;
                int plz = Convert.ToInt16(TxtPostleitzahl.Text);

                string firmenname = TxtFirmenname.Text;
                string firmenadresse = TxtFirmenadresse.Text;
                string kundekontakt = TxtKundenkontakt.Text;

                char kundentyp = Convert.ToChar(CmbKundentyp.Text);


                Kunde k = new Kunde(id, status, anrede, title, vorname, nachname, dob, privat, arbeit, mobil, email, ahv, nationalitaet, strasse, plz, wohnort, firmenname, firmenadresse, kundentyp, kundekontakt);

                xmlHandler.CreateKundeXML(k);
                LoadData();

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private bool Status()
        {
            if (ChkStatus.Checked)
            {
                ChkStatus.Text = "Aktiviert";
                return false;
            }
            else 
            {
                ChkStatus.Text = "Deaktiviert";
                return true;
            }
        }

        private void FillCombobox()
        {
            CmbKundentyp.Items.AddRange(kundentyp);
            CmbAnrede.Items.AddRange(anrede);
            CmbTitel.Items.AddRange(titel);
        }

        private void Kill_Click(object sender, EventArgs e)
        {
            string id = IDGetter();

            File.Delete($"{id}.txt");
            xmlHandler.DeleteValuesKunde(id);
            LoadData();

        }

        private void LoadData()
        {
            if (File.Exists("Kunde.xml") && new FileInfo("Kunde.xml").Length >= 60)
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(Directory.GetCurrentDirectory() + "/Kunde.xml");
                DtgData.DataSource = dataSet.Tables[0];
            }
            else 
            {
                DtgData.DataSource = null;
            }
        }

        private void ChkStatus_CheckedChanged(object sender, EventArgs e)
        {
            Status();
        }
    }
}
