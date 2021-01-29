using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    public partial class MainDashboard : Form
    {
        readonly LoginForm login;

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
    }
}
