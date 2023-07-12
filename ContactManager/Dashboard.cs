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
    public partial class Dashboard : Form
    {
        public DataGrid dataGridView1 { get; set; }

        public Dashboard()
        {
            InitializeComponent();
        }

        private void TsmMitarbeiterAnlegen_Click(object sender, EventArgs e)
        {
            MitarbeiterAnlegenView mitarbeiterView = new MitarbeiterAnlegenView();
            mitarbeiterView.ShowDialog();
        }

        private void kundeAnlegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KundeAnlegenView kundenView = new KundeAnlegenView();
            kundenView.ShowDialog();
        }

        private void CmdStammMitarbeiter_Click(object sender, EventArgs e)
        {
            //DataSet dataSet = new DataSet();
            //dataSet.ReadXml(@"H:\ZBW-Studium\PF2\Git\ContactManager\ContactManager\bin\Debug\Kunde1.xml");
            //dataGridView1.DataSource = dataSet.Tables[0];

            if (!PnlUCHandler.Controls.Contains(UcMitarbeiterStamm.Instance))
            {
                PnlUCHandler.Controls.Add(UcMitarbeiterStamm.Instance);
                UcMitarbeiterStamm.Instance.Dock = DockStyle.Fill;
                UcMitarbeiterStamm.Instance.BringToFront();
            }
            else 
            {
                UcMitarbeiterStamm.Instance.BringToFront();
            }
        }

    }
}
