using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    /// <summary>
    /// User Control for adding a Display Open Incidents "form" to a Form
    /// </summary>
    public partial class DisplayOpenIncidents : UserControl
    {
        private IncidentController controller;

        /// <summary>
        /// Creates the DisplayOpenIncidents
        /// </summary>
        public DisplayOpenIncidents()
        {
            InitializeComponent();
            this.controller = new IncidentController();
            this.RefreshDataGrid();
        }

        /// <summary>
        /// Refreshes the source data
        /// </summary>
        public void RefreshDataGrid()
        {
            List<OpenIncident> incidentList;
            try
            {
                incidentList = this.controller.GetOpenIncidents();
                if (incidentList.Count > 0)
                {
                    OpenIncident incident;
                    for (int i = 0; i < incidentList.Count; i++)
                    {
                        incident = incidentList[i];
                        listViewIncidentViewer.Items.Add(incident.Title);
                        listViewIncidentViewer.Items[i].SubItems.Add(incident.ProductCode.ToString());
                        listViewIncidentViewer.Items[i].SubItems.Add(incident.DateOpened.ToShortDateString());
                        listViewIncidentViewer.Items[i].SubItems.Add(incident.CustomerName.ToString());
                        listViewIncidentViewer.Items[i].SubItems.Add(incident.TechnicianName.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No open incidents.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
