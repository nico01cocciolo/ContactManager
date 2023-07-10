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
    public partial class MitarbeiterErfassung : UserControl
    {
        public MitarbeiterErfassung()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            //@"H:\ZBW-Studium\PF2\Git\ContactManager\ContactManager\bin\Debug\Kunde1.xml"
            dataSet.ReadXml(Directory.GetCurrentDirectory() + "/Kunde.xml");
            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}
