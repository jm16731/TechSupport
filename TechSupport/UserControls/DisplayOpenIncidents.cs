using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    public partial class DisplayOpenIncidents : UserControl
    {
        private IncidentController controller;
        public DisplayOpenIncidents()
        {
            InitializeComponent();
            this.controller = new IncidentController();
        }

        /// <summary>
        /// Refreshes the source data
        /// </summary>
        public void RefreshDataGrid()
        {
            this.gridViewIncidentViewer.DataSource = null;
            this.gridViewIncidentViewer.DataSource = this.controller.getIncidents();
        }
    }
}
