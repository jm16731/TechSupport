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
        private readonly IncidentController controller;

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
            listViewIncidentViewer.Items.Clear();

            listViewIncidentViewer.Columns.Add("Product Code", -2);
            listViewIncidentViewer.Columns.Add("Title", -2);
            listViewIncidentViewer.Columns.Add("Date Opened", -2);
            listViewIncidentViewer.Columns.Add("Customer", -2);
            listViewIncidentViewer.Columns.Add("Technician", -2);

            List<OpenIncident> incidentList;
            try
            {
                incidentList = this.controller.GetOpenIncidents();
                if (incidentList.Count > 0)
                {
                    foreach (OpenIncident incident in incidentList)
                    {
                        string[] row = { incident.ProductCode, incident.Title, 
                            incident.DateOpened.ToShortDateString(),
                            incident.CustomerName, incident.TechnicianName };
                        ListViewItem lvi = new ListViewItem(row);
                        listViewIncidentViewer.Items.Add(lvi);
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
