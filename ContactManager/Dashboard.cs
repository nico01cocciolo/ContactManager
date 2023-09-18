
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
    public partial class Dashboard : Form
    { 
        public Dashboard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Wenn das Dashboard keine Instance vom UcMitarbeiterStamm hat wird eine erstellt. 
        /// Besteht jedoch bereits eine Instance wird diese einfach angezeigt mit BringToFront
        /// </summary>
        private void CmdStammMitarbeiter_Click(object sender, EventArgs e)
        {

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

        /// <summary>
        /// Wenn das Dashboard keine Instance vom UcKundeStamm hat wird eine erstellt. 
        /// Besteht jedoch bereits eine Instance wird diese einfach angezeigt mit BringToFront
        /// </summary>
        private void CmdStammKunden_Click(object sender, EventArgs e)
        {

            if (!PnlUCHandler.Controls.Contains(UcKundeStamm.Instance))
            {
                PnlUCHandler.Controls.Add(UcKundeStamm.Instance);
                UcKundeStamm.Instance.Dock = DockStyle.Fill;
                UcKundeStamm.Instance.BringToFront();
            }
            else
            {
                UcKundeStamm.Instance.BringToFront();
            }
        }

        /// <summary>
        /// Wenn das Dashboard keine Instance vom UcDashboardView hat wird eine erstellt. 
        /// Besteht jedoch bereits eine Instance wird diese einfach angezeigt mit BringToFront
        /// </summary>
        private void CmdDashboard_Click(object sender, EventArgs e)
        {

                if (!PnlUCHandler.Controls.Contains(UcDashboardView.Instance))
                {
                    PnlUCHandler.Controls.Add(UcDashboardView.Instance);
                    UcDashboardView.Instance.Dock = DockStyle.Fill;
                    UcDashboardView.Instance.BringToFront();
                }
                else
                {
                    UcDashboardView.Instance.BringToFront();
                    UcDashboardView.Instance.Reload();
                }
        }

        /// <summary>
        /// Der Import wurde nicht angeschaut und Funktioniert aus diesem Grund auch nicht
        /// </summary>
        private void CmdImportCsv_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Der Import von CSV Dateien ist vorübergehend deaktiviert.");
        }
    }
}
