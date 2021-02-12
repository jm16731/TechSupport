using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    /// <summary>
    /// User Control for adding a Search Incident "form" to a Form
    /// </summary>
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

        /// <summary>
        /// Returns the Search Button for use by parent Form
        /// </summary>
        /// <returns>The Search Button of his User Control</returns>
        public Button GetSearchButton()
        {
            return this.btnSearch;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            int customerID;
            if (int.TryParse(txtCustomerID.Text, out customerID))
            {
                RefreshDataGrid(customerID);
            }
            else
            {
                lblIDError.Text = "ID must be a number";
                lblIDError.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void RefreshDataGrid(int customerID)
        {
            this.gridViewSearchIncident.DataSource = null;
            this.gridViewSearchIncident.DataSource = this.controller.GetIncidents(customerID);
        }

        private void TxtSearchCustomerID_TextChanged(object sender, EventArgs e)
        {
            lblIDError.Text = "";
        }
    }
}
