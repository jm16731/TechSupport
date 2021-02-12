using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    /// <summary>
    /// User Control for adding a Display Open Incidents "form" to a Form
    /// </summary>
    public partial class DisplayOpenIncidents : UserControl
    {
        private IncidentController controller;

        /// <summary>
        /// Creates the DisplayOpenIncidents
        /// </summary>
        public DisplayOpenIncidents()
        {
            InitializeComponent();
            this.controller = new IncidentController();
            this.RefreshDataGrid();
        }

        /// <summary>
        /// Refreshes the source data
        /// </summary>
        public void RefreshDataGrid()
        {
            this.listViewIncidentViewer.DataSource = null;
            this.listViewIncidentViewer.DataSource = this.controller.GetOpenIncidents();
        }
    }
}
