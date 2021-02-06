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

        private void Add_click(object sender, EventArgs e)
        {
            try
            {
                string title = txtIncidentName.Text;
                string description = txtIncidentDescription.Text;
                int customerID = int.Parse(txtIncidentCustomerID.Text);

                this.controller.Add(new Incident(title, description, customerID));

                lblMessage.Text = "Incident added";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bad input." + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clear_click(object sender, EventArgs e)
        {
            txtIncidentName.Text = "";
            txtIncidentDescription.Text = "";
            txtIncidentCustomerID.Text = "";
        }
    }
}
