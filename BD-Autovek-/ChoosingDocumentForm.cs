using System;
using System.Windows.Forms;

namespace BD_Autovek_
{
    public partial class ChoosingDocumentForm : Form
    {
        public ChoosingDocumentForm()
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