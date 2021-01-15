using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSupport.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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
                //this.Hide();
                MainForm main = new MainForm();
                main.ShowDialog();
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
    }
}
