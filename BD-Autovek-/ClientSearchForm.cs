using System;
using System.Windows.Forms;

namespace BD_Autovek_
{
    public partial class ClientSearchForm : Form
    {
        public ClientSearchForm()
        {
            InitializeComponent();
        }
        
        private void label2_Click_1(object sender, EventArgs e)
        {
            var fr2 = new AuthorizationForm();
            fr2.Show();
            Hide();        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fr2 = new CarsInformationForm();
            fr2.Show();
            Hide();  
        }
    }
}