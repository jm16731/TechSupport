using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    /// <summary>
    /// User Control for adding a Load All "form" to a Form
    /// </summary>
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
