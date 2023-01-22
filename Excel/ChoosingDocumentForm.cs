using System;
using System.Windows.Forms;
using Excel.Infrastructure;
using System.Drawing;


namespace Excel.App
{
    public partial class ChoosingDocumentForm : Form
    {
        //private readonly AgencyPortfolio _agencyPortfolio;
        private readonly DocumentSettings _documentSettings;
        
        public ChoosingDocumentForm()
        {
            ClientSize = new Size(716, 461);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            //_agencyPortfolio = new AgencyPortfolio("l", "a", "d",
            //"k", "y");
            _documentSettings = new DocumentSettings();
            InitializeComponent();
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

        private void button3_Click(object sender, EventArgs e)
        {
            //_agencyPortfolio.CreateAgencyPortfolio(_documentSettings.ContractTypes[1]);
            var fr2 = new AuthorizationForm();
            fr2.StartPosition = FormStartPosition.Manual;
            fr2.Location = Location;
            fr2.FormClosed += delegate { Application.Exit(); };
            fr2.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //_agencyPortfolio.CreateAgencyPortfolio(_documentSettings.ContractTypes[0]);
            var fr2 = new AuthorizationForm();
            fr2.StartPosition = FormStartPosition.Manual;
            fr2.Location = Location;
            fr2.FormClosed += delegate { Application.Exit(); };
            fr2.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //_agencyPortfolio.CreateAgencyPortfolio(_documentSettings.ContractTypes[2]);
            var fr2 = new AuthorizationForm();
            fr2.StartPosition = FormStartPosition.Manual;
            fr2.Location = Location;
            fr2.FormClosed += delegate { Application.Exit(); };
            fr2.Show();
            Hide();
        }
        private void ChoosingDocumentForm_Load(object sender, EventArgs e)
        {

        }
    }
}