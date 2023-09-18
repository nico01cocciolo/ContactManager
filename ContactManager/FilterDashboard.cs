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

        private void CmdFilterSuchen_Click(object sender, EventArgs e)
        {
            UcMitarbeiterStamm.Instance.statusMitarbeiter = CkStatus.CheckState;
            UcMitarbeiterStamm.Instance.ApplyXmlFilter();
            this.Close();
        }
    }
}
