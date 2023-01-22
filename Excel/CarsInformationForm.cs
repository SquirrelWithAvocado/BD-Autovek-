using System;
using System.Windows.Forms;
using System.Drawing;


namespace Excel.App
{
    public partial class CarsInformationForm : Form
    {
        private readonly ChoosingDocumentForm _choosingDocumentForm;
        public CarsInformationForm()
        {
            ClientSize = new Size(810, 470);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            _choosingDocumentForm = new ChoosingDocumentForm();
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _choosingDocumentForm.StartPosition = FormStartPosition.Manual;
            _choosingDocumentForm.Location = Location;
            _choosingDocumentForm.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fr2 = new AddOrChangeAutoForm();
            fr2.StartPosition = FormStartPosition.Manual;
            fr2.Location = Location;
            fr2.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var fr2 = new AddOrChangeAutoForm();
            fr2.StartPosition = FormStartPosition.Manual;
            fr2.Location = Location;
            fr2.Show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var fr2 = new AuthorizationForm();
            fr2.StartPosition = FormStartPosition.Manual;
            fr2.Location = Location;
            fr2.Show();
            Hide();
        }
    }
}