using System;
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
            UcMitarbeiterStamm.Instance.statusMitarbeiter = CkStatus.CheckState;
            UcMitarbeiterStamm.Instance.statusLehrling = CkLehrling.CheckState;
            UcMitarbeiterStamm.Instance.ApplyXmlFilter(filterVorname, filterNachname);
            this.Close();
        }
    }
}