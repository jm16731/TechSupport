using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    public partial class ViewIncidentByTechnician : UserControl
    {
        private readonly IncidentController controller;
        public ViewIncidentByTechnician()
        {
            InitializeComponent();
            this.controller = new IncidentController();
        }
    }
}
