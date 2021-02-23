using System;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    public partial class UpdateIncident : UserControl
    {
        private readonly IncidentController controller;
        int incidentID;
        public UpdateIncident()
        {
            InitializeComponent();
            this.controller = new IncidentController();

            this.btnUpdate.Enabled = false;
            this.btnClose.Enabled = false;
            this.txtTextToAdd.Enabled = false;
            incidentID = -1;

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
                OpenIncident incident = this.controller.GetIncident(incidentID);

                this.txtTitle.Text = incident.Title;
                this.txtCustomer.Text = incident.CustomerName;
                this.txtProductCode.Text = incident.ProductCode;
                this.txtDateOpened.Text = incident.DateOpened.ToString();
                this.txtDescription.Text = incident.Description;
                this.comboTechnician.SelectedIndex = this.comboTechnician.FindStringExact(incident.TechnicianName);
                this.incidentID = incidentID;

                if (this.controller.IsIncidentOpen(incidentID))
                {
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
                this.incidentID = -1;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.incidentID = -1;
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
            if (this.HasIncidentBeenUpdatedSinceRetrieval())
            {
                MessageBox.Show("Incident updated since you retrieved it. Cannot update incident",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.txtDescription.Text.Length > 200 && !string.IsNullOrEmpty(this.txtTextToAdd.Text))
            {
                MessageBox.Show("Description all ready exceeds 200 characters. Cannot update description. Please delete your text to add", 
                    "", MessageBoxButtons.OK);
                return;
            }
            if ((this.txtDescription.Text.Length + this.txtTextToAdd.Text.Length) > 200)
            {
                DialogResult truncate = MessageBox.Show("Text to add will cause description to exceed 200 characters. Text will be truncated. Is this all right?",
                    "", MessageBoxButtons.YesNo);
                if (truncate == DialogResult.No)
                {
                    return;
                }
            }
            this.TrueUpdate();
        }

        private void TrueUpdate()
        {
            string update = this.txtDescription.Text + "\n" + DateTime.Now.ToString("MM/dd/yyyy") + " " + this.txtTextToAdd.Text;
            try
            {
                this.controller.UpdateIncident(this.incidentID, update.Substring(0, 200), int.Parse(this.comboTechnician.ValueMember));
                this.txtTextToAdd.Text = "";
                this.txtDescription.Text = update.Substring(0, 200);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void CloseIncidentButton_CloseIncident(object sender, EventArgs e)
        {
            if (this.HasIncidentBeenUpdatedSinceRetrieval())
            {
                MessageBox.Show("Incident updated since you retrieved it. Cannot close incident",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Incident cannot be changed further once closed. Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.TrueUpdate();
                try
                {
                    this.controller.CloseIncident(this.incidentID);
                    MessageBox.Show("Incident closed", "", MessageBoxButtons.OK);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Something went wrong with closing the incident", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool HasIncidentBeenUpdatedSinceRetrieval()
        {
            return this.controller.HasIncidentBeenUpdatedSinceRetrieval(this.txtDescription.Text);
        }

    }
}
