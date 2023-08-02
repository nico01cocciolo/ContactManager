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

namespace ContactManager
{
    public partial class UcMitarbeiterStamm : UserControl
    {
        public UcMitarbeiterStamm()
        {
            InitializeComponent();
        }

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
            if (File.Exists("Kunde.xml"))
            { 
            DataSet dataSet = new DataSet();
            //@"H:\ZBW-Studium\PF2\Git\ContactManager\ContactManager\bin\Debug\Kunde1.xml"
            dataSet.ReadXml(Directory.GetCurrentDirectory() + "/Kunde.xml");
            dataGridView1.DataSource = dataSet.Tables[0];
            }
        }

        public string IDGetter()
        {
            string cellValue = ""; 

            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                cellValue = Convert.ToString(selectedRow.Cells["ID"].Value);

                LblTest.Text = cellValue;

            }
            return cellValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CmdGetID_Click(object sender, EventArgs e)
        {
            IDGetter();
        }
    }
}
