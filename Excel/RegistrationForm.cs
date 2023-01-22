using System;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;
using System.Drawing;


namespace Excel.App
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            ClientSize = new Size(716, 461);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            var fr2 = new AuthorizationForm();
            fr2.FormClosed += delegate { Application.Exit(); };
            fr2.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fr2 = new AuthorizationForm();
            fr2.FormClosed += delegate { Application.Exit(); };
            fr2.Show();
            Hide();
        }

        
        

    }
}