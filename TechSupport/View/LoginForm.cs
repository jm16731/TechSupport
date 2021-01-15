using System;
using System.Windows.Forms;

namespace TechSupport.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

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
                MainForm main = new MainForm(this);
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
