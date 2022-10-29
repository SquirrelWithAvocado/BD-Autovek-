using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ClientActionForm : Form
    {
        public ClientActionForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var fr2 = new AuthorizationForm();
            fr2.Show();
            Hide();
        }
    }
}