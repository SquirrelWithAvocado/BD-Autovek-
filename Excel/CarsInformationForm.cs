using System;
using System.Windows.Forms;

namespace Excel.App
{
    public partial class CarsInformationForm : Form
    {
        private readonly ChoosingDocumentForm _choosingDocumentForm;
        public CarsInformationForm()
        {
            _choosingDocumentForm = new ChoosingDocumentForm();
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _choosingDocumentForm.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fr2 = new AddOrChangeAutoForm();
            fr2.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var fr2 = new AddOrChangeAutoForm();
            fr2.Show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var fr2 = new AuthorizationForm();
            fr2.Show();
            Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}