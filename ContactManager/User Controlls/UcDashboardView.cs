using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.User_Controlls
{
    public partial class UcDashboardView : UserControl
    {
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
        public UcDashboardView()
        {
            InitializeComponent();
        }
    }
}
