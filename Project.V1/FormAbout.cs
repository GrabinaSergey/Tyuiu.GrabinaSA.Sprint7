﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.V1
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();

        }

        private void buttonHelpOK_GSA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}