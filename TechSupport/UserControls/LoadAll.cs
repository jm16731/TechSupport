using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.View;

namespace TechSupport.UserControls
{
    public partial class LoadAll : UserControl
    {
        private IncidentController controller;
        /// <summary>
        /// Creates an instance of LoadAll
        /// </summary>
        public LoadAll()
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
            this.gridViewIncidentViewer.DataSource = null;
            this.gridViewIncidentViewer.DataSource = this.controller.getIncidents();
        }

    }
}
