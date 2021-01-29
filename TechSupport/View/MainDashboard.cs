using System;
using System.Windows.Forms;

namespace TechSupport.View
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
        }

        private void close_All(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

    }
}
