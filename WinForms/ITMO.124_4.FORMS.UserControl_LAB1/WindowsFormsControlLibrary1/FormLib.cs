﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class FormLib : Form
    {
        public FormLib()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userControl11.TimeEnabled1 == true)
                userControl11.TimeEnabled1 = false;
            else
                userControl11.TimeEnabled1 = true;
        }


    }
}
