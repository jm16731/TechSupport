using System;
using System.Windows.Forms;

namespace TechSupport.View
{
    /// <summary>
    /// The main form for TechSupport
    /// </summary>
    public partial class MainDashboard : Form
    {
        readonly LoginForm login;

        /// <summary>
        /// Creates an instance of MainDashboard from the given LoginForm
        /// </summary>
        /// <param name="login">The LoginForm that loaded this MainDashboard</param>
        public MainDashboard(LoginForm login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void Close_All(object sender, FormClosedEventArgs e)
        {
            this.login.Show();
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            lblMainUsername.Text = login.GetUsername();
        }

        private void LinklblLogout_linkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void TabSelectedIndex(object sender, TabControlEventArgs e)
        {
            if (tabCntrlIncidents.SelectedTab == tabAddIncident)
            {
                this.AcceptButton = usrCntrlAddIncident.GetAddButton();
            }
            else if (tabCntrlIncidents.SelectedTab == tabLoadAll)
            {
                usrCntrlLoadAll.RefreshDataGrid();
                this.AcceptButton = null;
            }
            else if (tabCntrlIncidents.SelectedTab == tabSearchIncident)
            {
                this.AcceptButton = usrCntrlSearchIncident.GetSearchButton();
            }
            else
            {
                this.AcceptButton = null;
                usrCntrlDisplayOpenIncidents.RefreshDataGrid();
            }
        }
    }
}
