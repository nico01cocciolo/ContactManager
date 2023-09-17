using ContactManager.Model;
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
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace ContactManager.User_Controlls
{
    public partial class UcDashboardView : UserControl
    {
        private string data1 = "Mitarbeiter";
        private string data2 = "Kunde";

        #region Instances
        private static UcDashboardView instance;

        public static UcDashboardView Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UcDashboardView();

                }
                return instance;
            }
        }
        #endregion

        public UcDashboardView()
        {
            InitializeComponent();
        }

        private XDocument xDoc = new XDocument();

        private void UcDashboardView_Load(object sender, EventArgs e)
        {
            LoadMitarbeiterChart(data1);
            LoadKundeChart(data2);
        }
        private void GetChartValues(string data, out int activeAccountCount, out int inactiveAccountCount)
        {
            string path = $"{data}.xml";
            xDoc = XDocument.Load(path);

            var activeAccount = xDoc.Descendants(data)
                .Where(d => d.Attribute("Status").Value == "true")
                .ToList();

            var inactiveAccount = xDoc.Descendants(data)
                .Where(d => d.Attribute("Status").Value == "false")
                .ToList();

            activeAccountCount = activeAccount.Count;
            inactiveAccountCount = inactiveAccount.Count;
        }

        public void LoadMitarbeiterChart(string data)
        {
            int activeAccountCount, inactiveAccountCount;
            GetChartValues(data, out activeAccountCount, out inactiveAccountCount);

            ChtMitarbeiter.Titles.Add("Statusaktivität");
            ChtMitarbeiter.Series.Add(new Series());

            ChtMitarbeiter.Series[0].Points.Add(activeAccountCount);
            ChtMitarbeiter.Series[0].Points[0].LegendText = "Active Accounts";
            ChtMitarbeiter.Series[0].Points[0].Label = activeAccountCount.ToString();

            ChtMitarbeiter.Series[0].Points.Add(inactiveAccountCount);
            ChtMitarbeiter.Series[0].Points[1].LegendText = "Inactive Accounts";
            ChtMitarbeiter.Series[0].Points[1].Label = inactiveAccountCount.ToString();

            ChtMitarbeiter.Series[0].ChartType = SeriesChartType.Pie;
        }

        public void LoadKundeChart(string data)
        {
            string path = $"{data}.xml";
            xDoc = XDocument.Load(path);

            var activeAccount = xDoc.Descendants(data)
                .Where(d => d.Attribute("Status").Value == "true")
                .ToList();

            var inactiveAccount = xDoc.Descendants(data)
                .Where(d => d.Attribute("Status").Value == "false")
                .ToList();

            int activeAccountCount = activeAccount.Count;
            int inactiveAccountCount = inactiveAccount.Count;

            ChtKunde.Titles.Add("Statusaktivität");
            ChtKunde.Series.Add(new Series());

            ChtKunde.Series[0].Points.Add(activeAccountCount);
            ChtKunde.Series[0].Points[0].LegendText = "Active Accounts";
            ChtKunde.Series[0].Points[0].Label = activeAccountCount.ToString();

            ChtKunde.Series[0].Points.Add(inactiveAccountCount);
            ChtKunde.Series[0].Points[1].LegendText = "Inactive Accounts";
            ChtKunde.Series[0].Points[1].Label = inactiveAccountCount.ToString();

            ChtKunde.Series[0].ChartType = SeriesChartType.Pie;
        }
    }
}
