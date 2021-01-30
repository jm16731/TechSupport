using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.View;

namespace TechSupport.UserControls
{
    public partial class LoadAll : UserControl
    {
        private readonly IncidentController controller;
        public LoadAll()
        {
            InitializeComponent();
            this.controller = new IncidentController();
            this.RefreshDataGrid();
        }

        public void RefreshDataGrid()
        {
            this.gridViewIncidentViewer.DataSource = null;
            this.gridViewIncidentViewer.DataSource = this.controller.getIncidents();
        }

    }
}
