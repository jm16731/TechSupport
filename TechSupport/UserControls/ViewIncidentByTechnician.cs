using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    /// <summary>
    /// User Control for viewing a list of incidents associated with a given technician
    /// </summary>
    public partial class ViewIncidentByTechnician : UserControl
    {
        private readonly IncidentController controller;

        /// <summary>
        /// Creates the User Control
        /// </summary>
        public ViewIncidentByTechnician()
        {
            InitializeComponent();
            this.controller = new IncidentController();
            viewIncidents.DataSource = null;
            this.RefreshData();
        }

        /// <summary>
        /// Refreshes the dataGridView of incidents
        /// </summary>
        public void RefreshData()
        {
            this.comboTechnicians.DataSource = null;
            this.comboTechnicians.DataSource = this.controller.GetTechniciansWhoHaveHandledOrAreHandlingIncidents();
            this.comboTechnicians.DisplayMember = "Name";
            this.comboTechnicians.ValueMember = "ID";
        }

        private void PopulateData(object sender, EventArgs e)
        {
            if (this.comboTechnicians.SelectedIndex == -1)
            {
                txtEmail.Text = "";
                txtPhone.Text = "";
                viewIncidents.DataSource = null;
                return;
            }
            try
            {
                Technician tech = this.controller.GetTechnician((int)this.comboTechnicians.SelectedValue);
                txtEmail.Text = tech.Email;
                txtPhone.Text = tech.Phone;
                viewIncidents.DataSource = null;
                viewIncidents.DataSource = this.controller.GetIncidentsByTechnician(tech.ID);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error communicating with database." +
                    Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.StackTrace,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
