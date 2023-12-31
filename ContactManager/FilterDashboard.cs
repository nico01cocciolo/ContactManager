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
    public partial class FilterDashboard : Form
    {
        public FilterDashboard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Aktiviert die Filterfunktion und Checkt Status von den Checkboxen ab
        /// </summary>
        private void CmdFilterSuchen_Click(object sender, EventArgs e)
        {
            string filterVorname = TxtFilterVorname.Text;
            string filterNachname = TxtFilterNachname.Text;
            string filterArbeitspensum = NumFilterArbeitspensum.Value.ToString();
            UcMitarbeiterStamm.Instance.statusMitarbeiter = ChkStatus.CheckState;
            UcMitarbeiterStamm.Instance.statusLehrling = ChkLehrling.CheckState;
            UcMitarbeiterStamm.Instance.ApplyXmlFilter(filterVorname, filterNachname, filterArbeitspensum);
            this.Close();
        }

        private void NumFilterArbeitspensum_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}