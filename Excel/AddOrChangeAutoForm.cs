﻿using System;
using System.Windows.Forms;

namespace Excel.App
{
    public partial class AddOrChangeAutoForm : Form
    {
        public AddOrChangeAutoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fr2 = new CarsInformationForm();
            fr2.Show();
            Hide();
        }
    }
}