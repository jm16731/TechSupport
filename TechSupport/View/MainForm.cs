using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// Partial class for defining the MainForm for TechSupport
    /// </summary>
    public partial class MainForm : Form
    {
        readonly LoginForm login;
        private readonly IncidentController controller;

        /// <summary>
        /// Initializes a MainForm with a LoginForm
        /// </summary>
        /// <param name="login"></param>
        public MainForm(LoginForm login)
        {
            InitializeComponent();
            this.login = login;
            this.controller = new IncidentController();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblMainUsername.Text = login.getUsername();
            this.RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            this.gridViewIncidentViewer.DataSource = null;
            this.gridViewIncidentViewer.DataSource = this.controller.getIncidents();
        }

        private void closeAll(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void lnklblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            this.login.Show();
        }

        private void AddBtnIncident_click(object sender, EventArgs e)
        {
            Form AddIncidentDialog = new AddIncidentDialog();
            DialogResult result = AddIncidentDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.RefreshDataGrid();
            }
        }

        private void SearchBtnIncident_click(object sender, EventArgs e)
        {
            Form SearchIncidentDialog = new SearchIncidentDialog(this.controller);
            SearchIncidentDialog.ShowDialog();
        }
    }
}
