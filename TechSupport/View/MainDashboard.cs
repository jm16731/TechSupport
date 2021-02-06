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

        private void close_All(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            lblMainUsername.Text = login.getUsername();
        }

        private void linklblLogout_linkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            this.login.Show();
        }

        private void tabSelectedIndex(object sender, TabControlEventArgs e)
        {
            if (tabCntrlIncidents.SelectedTab == tabLoadAll)
            {
                usrCntrlLoadAll.RefreshDataGrid();
            }
            else if (tabCntrlIncidents.SelectedTab == tabDisplayOpenIncidents)
            {
                usrCntrlDisplayOpenIncidents.RefreshDataGrid();
            }
        }
    }
}
