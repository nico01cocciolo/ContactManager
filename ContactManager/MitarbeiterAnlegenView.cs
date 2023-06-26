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
    public partial class MitarbeiterAnlegenView : Form
    {
        public MitarbeiterAnlegenView()
        {
            InitializeComponent();
        }

        private void ChkLehrling_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkLehrling.Checked)
            {
                LblAktLehrjahr.Enabled = true;
                LblLehrjahre.Enabled = true;
                TxtAktLehrjahr.Enabled = true;
                TxtLehrjahre.Enabled = true;
            }
            else
            {
                LblAktLehrjahr.Enabled = false;
                LblLehrjahre.Enabled = false;
                TxtAktLehrjahr.Enabled = false;
                TxtLehrjahre.Enabled = false;
            }
        }

        private void MitarbeiterAnlegenView_Load(object sender, EventArgs e)
        {
            string[] anrede = { "Herr", "Frau", "neutral" };
            string[] titel = { "Dr.", "Dipl.- Ing." };
            string[] gender = { "männlich", "weiblich", "trans", "Kampfhelikopter" };

            string[] kaderstufe = { "0", "1", "2", "3", "4", "5" };

            CmbAnrede.Items.AddRange(anrede);
            CmbKaderstufe.Items.AddRange(kaderstufe);
            CmbTitel.Items.AddRange(titel);
        }
    }
}
