using System;
using System.Windows.Forms;

namespace TechSupport.View
{
    /// <summary>
    /// Partial class for defining a LoginForm for a tech supporter login to the main TechSupport
    /// </summary>
    public partial class LoginForm : Form
    {
        /// <summary>
        /// Initializes a LoginForm
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Returns the Username as a String
        /// </summary>
        /// <returns></returns>
        public String GetUsername()
        {
            return txtUsername.Text;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "Jane" || txtPassword.Text != "test1234")
            {
                lblError.Text = "invalid username/password";
                lblError.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                this.Hide();
                MainDashboard main = new MainDashboard(this);
                main.Show();
            }
        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        private void CloseAll(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
