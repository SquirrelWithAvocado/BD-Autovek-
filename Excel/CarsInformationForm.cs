using System;
using System.Windows.Forms;
using System.Drawing;


namespace Excel.App
{
    public partial class CarsInformationForm : Form
    {
        private readonly ChoosingDocumentForm _choosingDocumentForm;
        private Client _curClient;

        public CarsInformationForm(Client curClient)
        {
            ClientSize = new Size(716, 461);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            _curClient = curClient;
            _choosingDocumentForm = new ChoosingDocumentForm();
            _choosingDocumentForm.FormClosed += delegate { Application.Exit(); };
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
            fr2.FormClosed += delegate { Application.Exit(); };
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
            fr2.FormClosed += delegate { Application.Exit(); };
            fr2.Show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var fr2 = new AuthorizationForm();
            fr2.StartPosition = FormStartPosition.Manual;
            fr2.Location = Location;
            fr2.FormClosed += delegate { Application.Exit(); };
            fr2.Show();
            Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}