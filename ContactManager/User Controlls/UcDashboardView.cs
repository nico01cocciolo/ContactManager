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

        /// <summary>
        /// Die Strings werden hier als Statisch abgelegt da sich der Name der Datei nicht ändert
        /// So kann für die Charts auf den Teil zugegriffen werden
        /// </summary>
        #region Parameters

        private string mitarbeiter = "Mitarbeiter";
        private string kunde = "Kunde";

        #endregion
        
        #region Instances
        private XDocument xDoc = new XDocument();

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

        /// <summary>
        /// Lädt beim Laden des Dashboards das PieChart für die Mitarbeiter wie auch für die Kunden
        /// </summary>
        private void UcDashboardView_Load(object sender, EventArgs e)
        {
            Reload();
        }
        
        /// <summary>
        /// Wir benötigt um beim Wechseln des Usercontrolls die Piecharts erneut zu bestücken
        /// </summary>
        public void Reload()
        {
            LoadMitarbeiterChart(mitarbeiter);
            LoadKundeChart(kunde);
        }
        /// <summary>
        /// Durch den Input von den Strings kann die Funktion unabhängig verwendet werden
        /// Der Dateipfad wird in der Funktion erstellt und danach geladen
        /// </summary>
        private void GetChartValues(string data, out int activeAccountCount, out int inactiveAccountCount)
        {   
            string path = $"{data}.xml";
            
            if(File.Exists(path))
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
        
        /// <summary>
        /// Lädt die Werte von der Funktion GetChartValues in die dazugehörige Chart (ChtMitarbeiter)
        /// Es wird eine Serie erstellt mit Aktiven Accounts und eine Ohne Aktive Accounts
        /// Das Pie-Chart wird am Anfang mittels Clear gelert und erneut bestückt
        /// </summary>
        public void LoadMitarbeiterChart(string data)
        {
            int activeAccountCount, inactiveAccountCount;
            GetChartValues(data, out activeAccountCount, out inactiveAccountCount);

            ChtMitarbeiter.Series.Clear();

            ChtMitarbeiter.Titles.Add("Status: Mitarbeiter");
            ChtMitarbeiter.Series.Add(new Series());

            ChtMitarbeiter.Series[0].Points.Add(activeAccountCount);
            ChtMitarbeiter.Series[0].Points[0].LegendText = "Aktive Accounts";
            ChtMitarbeiter.Series[0].Points[0].Label = activeAccountCount.ToString();

            ChtMitarbeiter.Series[0].Points.Add(inactiveAccountCount);
            ChtMitarbeiter.Series[0].Points[1].LegendText = "Deaktivierte Accounts";
            ChtMitarbeiter.Series[0].Points[1].Label = inactiveAccountCount.ToString();

            ChtMitarbeiter.Series[0].ChartType = SeriesChartType.Pie;
        }
        
        /// <summary>
        /// Lädt die Werte von der Funktion GetChartValues in die dazugehörige Chart (ChtKunde)
        /// Es wird eine Serie erstellt mit Aktiven Accounts und eine Ohne Aktive Accounts
        /// Das Pie-Chart wird am Anfang mittels Clear gelert und erneut bestückt
        /// </summary>
        public void LoadKundeChart(string data)
        {
            int activeAccountCount, inactiveAccountCount;
            GetChartValues(data, out activeAccountCount, out inactiveAccountCount);

            ChtKunde.Series.Clear();

            ChtKunde.Titles.Add("Status: Kunden");
            ChtKunde.Series.Add(new Series());

            ChtKunde.Series[0].Points.Add(activeAccountCount);
            ChtKunde.Series[0].Points[0].LegendText = "Aktive Accounts";
            ChtKunde.Series[0].Points[0].Label = activeAccountCount.ToString();

            ChtKunde.Series[0].Points.Add(inactiveAccountCount);
            ChtKunde.Series[0].Points[1].LegendText = "Deaktivierte Accounts";
            ChtKunde.Series[0].Points[1].Label = inactiveAccountCount.ToString();

            ChtKunde.Series[0].ChartType = SeriesChartType.Pie;
        }
    }
}
