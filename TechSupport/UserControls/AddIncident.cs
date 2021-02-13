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
                String message = this.controller.CreateIncident(customerName, productName, title, description);
                MessageBox.Show(message, "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong." + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Clears the data on the form
        /// </summary>
        public void Clear()
        {
            comboIncidentCustomer.SelectedIndex = -1;
            comboIncidentProduct.SelectedIndex = -1;
            txtIncidentTitle.Text = "";
            txtIncidentDescription.Text = "";

            lblDescriptionError.Text = "";
            lblTitleError.Text = "";
            lblProductNameError.Text = "";
            lblCustomerNameError.Text = "";
        }

        private void Clear_click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void LblDescription_TextChanged(object sender, EventArgs e)
        {
            lblDescriptionError.Text = "";
        }

        private void TextTitle_TextChanged(object sender, EventArgs e)
        {
            lblTitleError.Text = "";
        }

        private void ComboProduct_IndexChanged(object sender, EventArgs e)
        {
            lblProductNameError.Text = "";
        }

        private void ComboCustomer_IndexChanged(object sender, EventArgs e)
        {
            lblCustomerNameError.Text = "";
        }
    }
}
