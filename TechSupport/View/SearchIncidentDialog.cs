using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// Partial class for creating a SearchIncidentDialog
    /// </summary>
    public partial class SearchIncidentDialog : Form
    {
        private readonly IncidentController controller;

        /// <summary>
        /// Creates a SearchIncidentDialog
        /// </summary>
        public SearchIncidentDialog(IncidentController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            int customerID = int.Parse(txtCustomerID.Text);
            RefreshDataGrid(customerID);
        }

        private void RefreshDataGrid(int customerID)
        {
            this.gridViewSearchIncident.DataSource = null;
            this.gridViewSearchIncident.DataSource = this.controller.getIncidents(customerID);
        }
    }
}
