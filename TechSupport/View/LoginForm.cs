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
        public String getUsername()
        {
            return txtUsername.Text;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "Jane" || txtPassword.Text != "test1234")
            {
                txtError.Text = "invalid username/password";
                txtError.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                this.Hide();
                MainDashboard main = new MainDashboard();
                main.Show();
                //this.Close();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtError.Text = "";
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtError.Text = "";
        }

        private void closeAll(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
