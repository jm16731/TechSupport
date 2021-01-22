using System;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
    /// <summary>
    /// Partial Class for the Add an Incident dialog form
    /// </summary>
    public partial class AddIncidentDialog : Form
    {
        private readonly IncidentController controller;

        /// <summary>
        /// Creates the AddIncidentDialog
        /// </summary>
        public AddIncidentDialog()
        {
            InitializeComponent();
            this.controller = new IncidentController();
        }

        private void Add_click(object sender, EventArgs e)
        {
            try
            {
                string title = txtIncidentName.Text;
                string description = txtIncidentDescription.Text;
                int customerID = int.Parse(txtIncidentCustomerID.Text);

                this.controller.Add(new Incident(title, description, customerID));

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bad input." + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel_click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
