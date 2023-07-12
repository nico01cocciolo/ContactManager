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
    public partial class MitarbeiterStamm : UserControl
    {
        public MitarbeiterStamm()
        {
            InitializeComponent();
        }

        private static MitarbeiterStamm instance;

        public static MitarbeiterStamm Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new MitarbeiterStamm();
                   
                }
                return instance;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            //@"H:\ZBW-Studium\PF2\Git\ContactManager\ContactManager\bin\Debug\Kunde1.xml"
            dataSet.ReadXml(Directory.GetCurrentDirectory() + "/Kunde.xml");
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void CmdMitarbeiterErstellen_Click(object sender, EventArgs e)
        {
            MitarbeiterStamm mf = new MitarbeiterStamm();
            this.Controls.Clear();

            UcMitarbeiterErfassen ucMe = new UcMitarbeiterErfassen();
            ucMe.Dock = DockStyle.Fill;
            this.Controls.Add(ucMe);
        }

        private void CmdMitarbeiterBearbeiten_Click(object sender, EventArgs e)
        {
            MitarbeiterStamm mf = new MitarbeiterStamm();
            this.Controls.Clear();

            MitarbeiterBearbeiten mb = new MitarbeiterBearbeiten();
            mb.Dock = DockStyle.Fill;
            this.Controls.Add(mb);
            
        }
    }
}
