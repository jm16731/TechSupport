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
            int customerID;
            if (int.TryParse(txtIncidentCustomerID.Text, out customerID))
            {
                try
                {
                    string title = txtIncidentName.Text;
                    string description = txtIncidentDescription.Text;

                    this.controller.Add(new Incident(title, description, customerID));

                    lblMessage.Text = "Incident added";
                    lblIDError.ForeColor = System.Drawing.Color.Blue;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bad input." + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                lblIDError.Text = "ID must be a number";
                lblIDError.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void Clear_click(object sender, EventArgs e)
        {
            txtIncidentName.Text = "";
            txtIncidentDescription.Text = "";
            txtIncidentCustomerID.Text = "";
            lblMessage.Text = "";
            lblIDError.Text = "";
        }

        private void LblCustomerID_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            lblIDError.Text = "";
        }

        private void LblDescription_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void LblName_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }
    }
}
