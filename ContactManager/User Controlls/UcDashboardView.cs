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

        private XDocument mitarbeiter = new XDocument();

        private void UcDashboardView_Load(object sender, EventArgs e)
        {
            LoadCharts();
        }

        public void LoadCharts()
        {
            mitarbeiter = XDocument.Load(Directory.GetCurrentDirectory() + "/Mitarbeiter.xml");

            var activeAccount = mitarbeiter.Descendants("Mitarbeiter")
                .Where(d => d.Attribute("Status").Value == "true")
                .ToList();

            var inactiveAccount = mitarbeiter.Descendants("Mitarbeiter")
                .Where(d => d.Attribute("Status").Value == "false")
                .ToList();

            int activeAccountCount = activeAccount.Count;
            int inactiveAccountCount = inactiveAccount.Count;

            chart1.Titles.Add("Statusaktivität");
            chart1.Series.Add(new Series());

            chart1.Series[0].Points.Add(activeAccountCount);
            chart1.Series[0].Points[0].LegendText = "Active Accounts";
            chart1.Series[0].Points[0].Label = activeAccountCount.ToString();

            chart1.Series[0].Points.Add(inactiveAccountCount);
            chart1.Series[0].Points[1].LegendText = "Inactive Accounts";
            chart1.Series[0].Points[1].Label = inactiveAccountCount.ToString();

            chart1.Series[0].ChartType = SeriesChartType.Pie;
        }
    }
}
