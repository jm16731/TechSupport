using System;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    /// <summary>
    /// User Control for adding an Add Incident "form" to a Form
    /// </summary>
    public partial class AddIncident : UserControl
    {
        private readonly IncidentController controller;

        /// <summary>
        /// Creates the AddIncident
        /// </summary>
        public AddIncident()
        {
            InitializeComponent();
            this.controller = new IncidentController();
            this.comboIncidentCustomer.DataSource = this.controller.GetCustomers();
            this.comboIncidentProduct.DataSource = this.controller.GetProducts();
        }

        /// <summary>
        /// Returns the Add Button for use by the parent form
        /// </summary>
        /// <returns>The Add Button of this user control</returns>
        public Button GetAddButton()
        {
            return this.btnAdd;
        }

        private void Add_click(object sender, EventArgs e)
        {
            String customerName = comboIncidentCustomer.Text;
            String productName = comboIncidentProduct.Text;
            String title = txtIncidentTitle.Text;
            String description = txtIncidentDescription.Text;
            Boolean passesVerification = true;
            if (String.IsNullOrEmpty(customerName))
            {
                lblCustomerNameError.Text = "Please choose a customer";
                passesVerification = false;
            }
            if (String.IsNullOrEmpty(productName))
            {
                lblProductNameError.Text = "Please choose a product";
                passesVerification = false;
            }
            if (String.IsNullOrEmpty(title))
            {
                lblTitleError.Text = "Please give a title";
                passesVerification = false;
            } if (String.IsNullOrEmpty(description))
            {
                lblDescriptionError.Text = "Please describe incident";
                passesVerification = false;
            }
            if(!passesVerification)
            {
                return;
            }
            try
            {
                this.controller.CreateIncident(customerName, productName, title, description);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bad input." + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clear_click(object sender, EventArgs e)
        {
            comboIncidentCustomer.SelectedIndex = -1;
            comboIncidentProduct.SelectedIndex = -1;
            txtIncidentTitle.Text = "";
            txtIncidentDescription.Text = "";
            lblIDError.Text = "";
        }

        private void LblDescription_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
