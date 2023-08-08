using ContactManager.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ContactManager.User_Controlls.Kunde
{
    public partial class UcKundeStamm : UserControl
    {
        private static UcKundeStamm instance;

        public static UcKundeStamm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UcKundeStamm();
                }
                return instance;
            }
        }

        NotizController nc = new NotizController();

        public UcKundeStamm()
        {
            InitializeComponent();
        }

        private void CmdNotizErfassen_Click(object sender, EventArgs e)
        {
            NotizController nc = new NotizController();

            string notiz = TxtNotizInput.Text;
            string path = $"{IDGetter()}.txt" ;

            nc.NotizErfassen(path, notiz);
        }

        private string IDGetter()
        {
            string cellValue = "";

            if (DtgData.SelectedCells.Count > 0)
            {
                int selectedrowindex = DtgData.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = DtgData.Rows[selectedrowindex];
                cellValue = Convert.ToString(selectedRow.Cells["ID"].Value);

            }
            return cellValue;
        }

        private void UcKundeStamm_Load(object sender, EventArgs e)
        {
            if (File.Exists("Kunde.xml"))
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(Directory.GetCurrentDirectory() + "/Kunde.xml");
                DtgData.DataSource = dataSet.Tables[0];
            }
        }

        private void DtgData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string path = $"{IDGetter()}.txt";

            if (File.Exists(path))
            {
               TxtNotizOutput.Text =  nc.NotizLaden(path);
            }
            else
            {
                MessageBox.Show("Error und so");
            }
        }
    }
}
