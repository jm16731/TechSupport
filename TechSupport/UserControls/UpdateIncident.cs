using System;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    public partial class UpdateIncident : UserControl
    {
        private readonly IncidentController controller;
        public UpdateIncident()
        {
            InitializeComponent();
            this.controller = new IncidentController();

            this.btnUpdate.Enabled = false;
            this.btnClose.Enabled = false;
            this.txtTextToAdd.Enabled = false;

            this.RefreshData();
        }

        /// <summary>
        /// Refreshes the various data for this user control
        /// </summary>
        public void RefreshData()
        {
            this.comboTechnician.DataSource = null;
            this.comboTechnician.DataSource = this.controller.GetTechnicians();
            this.comboTechnician.DisplayMember = "Name";
            this.comboTechnician.ValueMember = "ID";
        }

        private void SearchButton_Search(object sender, EventArgs e)
        {
            try
            {
                int incidentID = Int32.Parse(this.txtIncidentID.Text);
                if (this.controller.IsIncidentOpen(incidentID))
                {
                    OpenIncident incident = this.controller.GetIncident(incidentID);
                    this.txtTitle.Text = incident.Title;
                    this.txtCustomer.Text = incident.CustomerName;
                    this.txtProductCode.Text = incident.ProductCode;
                    this.txtDateOpened.Text = incident.DateOpened.ToString();
                    this.txtDescription.Text = incident.Description;
                    this.comboTechnician.SelectedIndex = this.comboTechnician.FindStringExact(incident.TechnicianName);

                    this.btnUpdate.Enabled = true;
                    this.btnClose.Enabled = true;
                    this.txtTextToAdd.Enabled = true;
                }
                else
                {
                    this.btnUpdate.Enabled = false;
                    this.btnClose.Enabled = false;
                    this.txtTextToAdd.Enabled = false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Incident ID must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Clear(object sender, EventArgs e)
        {
            this.txtIncidentID.Text = "";
            this.txtTitle.Text = "";
            this.txtCustomer.Text = "";
            this.txtProductCode.Text = "";
            this.txtDateOpened.Text = "";
            this.txtDescription.Text = "";
            this.comboTechnician.SelectedIndex = -1;
        }

        private void UpdateButton_Update(object sender, EventArgs e)
        {

        }

        private void CloseIncidentButton_CloseIncident(object sender, EventArgs e)
        {

        }
    }
}
