﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSupport.UserControls
{
    public partial class OpenIncidentsAssigned : UserControl
    {
        public OpenIncidentsAssigned()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
