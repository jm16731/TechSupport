using System;
using System.Windows.Forms;
using TechSupport.Controller;

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
            this.RefreshData();
        }

        /// <summary>
        /// Refreshes the customer and product data for this user control
        /// </summary>
        public void RefreshData()
        {
            this.comboIncidentCustomer.DataSource = null;
            this.comboIncidentCustomer.DataSource = this.controller.GetCustomers();
            this.comboIncidentCustomer.DisplayMember = "Name";
            this.comboIncidentCustomer.ValueMember = "ID";

            this.comboIncidentProduct.DataSource = null;
            this.comboIncidentProduct.DataSource = this.controller.GetProducts();
            this.comboIncidentProduct.DisplayMember = "Name";
            this.comboIncidentProduct.ValueMember = "ProductCode";
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
            if (DidAddClickHaveErrors()) return;
            try
            {
                int customerID = (int)comboIncidentCustomer.SelectedValue;
                String productCode = (string)comboIncidentProduct.SelectedValue;
                if (!this.controller.IsCustomerRegisteredToProduct(customerID, productCode))
                {
                    MessageBox.Show("Customer not registered to product. Cannot create incident.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                String title = txtIncidentTitle.Text;
                String description = txtIncidentDescription.Text;
                bool ret = this.controller.CreateIncident(new Model.NewIncident(customerID, productCode, title, description));
                if (ret == false)
                {
                    MessageBox.Show("Something went wrong with adding the incident.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Incident successfully created", "Success!!", MessageBoxButtons.OK);
                }

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error with new incident." + Environment.NewLine + ex.Message + Environment.NewLine + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong." + Environment.NewLine + ex.Message + Environment.NewLine + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool DidAddClickHaveErrors()
        {
            Boolean didAddClickHaveErrors = false;
            if (comboIncidentCustomer.SelectedIndex == -1)
            {
                lblCustomerNameError.Text = "Please choose a customer";
                didAddClickHaveErrors = true;
            }
            if (comboIncidentProduct.SelectedIndex == -1)
            {
                lblProductNameError.Text = "Please choose a product";
                didAddClickHaveErrors = true;
            }
            if (String.IsNullOrEmpty(txtIncidentTitle.Text))
            {
                lblTitleError.Text = "Please give a title";
                didAddClickHaveErrors = true;
            }
            if (String.IsNullOrEmpty(txtIncidentDescription.Text))
            {
                lblDescriptionError.Text = "Please describe incident";
                didAddClickHaveErrors = true;
            }
            return didAddClickHaveErrors;
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
