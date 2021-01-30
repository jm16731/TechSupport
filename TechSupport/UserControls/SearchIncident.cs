using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    public partial class SearchIncident : UserControl
    {
        private readonly IncidentController controller;
        /// <summary>
        /// Creates an instance of SearchIncident
        /// </summary>
        public SearchIncident()
        {
            InitializeComponent();
            this.controller = new IncidentController();
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
