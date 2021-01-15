using System;
using System.Windows.Forms;

namespace TechSupport.View
{
    public partial class MainForm : Form
    {
        LoginForm login;

        public MainForm(LoginForm login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblMainUsername.Text = login.getUsername();
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
    }
}
