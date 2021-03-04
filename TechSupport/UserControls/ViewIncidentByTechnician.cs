using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;

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
    }
}
