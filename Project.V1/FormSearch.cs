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
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void buttonGoSearch_GSA_Click(object sender, EventArgs e)
        {
            DataBank.text = textBoxSearch_GSA.Text;
            this.Close();
        }

        private void buttonGoSearch_GSA_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
