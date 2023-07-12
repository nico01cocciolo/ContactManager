﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class Dashboard : Form
    {
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

            if (!PnlUCHandler.Controls.Contains(MitarbeiterStamm.Instance))
            {
                PnlUCHandler.Controls.Add(MitarbeiterStamm.Instance);
                MitarbeiterStamm.Instance.Dock = DockStyle.Fill;
                MitarbeiterStamm.Instance.BringToFront();
            }
            else 
            {
                MitarbeiterStamm.Instance.BringToFront();
            }
        }
    }
}
