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
            this.techniciansWhoHaveHandledOrAreHandlingIncidentsTableAdapter.GetData();
            this.techniciansWhoHaveHandledOrAreHandlingIncidentsTableAdapter.Fill(this.techSupportDataSet.TechniciansWhoHaveHandledOrAreHandlingIncidents);
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

                this.openIncidentsByTechnicianBindingSource = new BindingSource();
                this.openIncidentsByTechnicianBindingSource.DataSource = this.techSupportDataSet.OpenIncidentsByTechnician;
                this.openIncidentsByTechnicianTableAdapter.GetData(tech.ID);
                this.openIncidentsByTechnicianTableAdapter.Fill(this.techSupportDataSet.OpenIncidentsByTechnician, tech.ID);
                viewIncidents.DataSource = this.openIncidentsByTechnicianBindingSource.DataSource;
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
