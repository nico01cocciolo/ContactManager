using ContactManager.Model;
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
    public partial class FilterDashboardKunde : Form
    {

        public FilterDashboardKunde()
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
            string filterFirmenname = TxtFilterFirmenname.Text;
            UcKundeStamm.Instance.statusKunde = ChkStatus.CheckState;
            UcKundeStamm.Instance.ApplyXmlFilter(filterVorname, filterNachname, filterFirmenname);
            this.Close();
        }
    }
}
