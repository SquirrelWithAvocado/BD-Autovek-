using System;
using System.Windows.Forms;
using Excel.Domain.Models;

namespace Excel.App
{
    public partial class ChoosingDocumentForm : Form
    {
        private enum Contracts
        {
            TradeIN,
            SaleDirect
        }
        private readonly AgencyPortfolio _agencyPortfolio;
        public ChoosingDocumentForm()
        {
            _agencyPortfolio = new AgencyPortfolio();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var fr2 = new AuthorizationForm();
            fr2.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _agencyPortfolio.CreateAgencyPortfolio(((Contracts)(Int32.Parse("1") - 1)).ToString());
            var fr2 = new AuthorizationForm();
            fr2.Show();
            Hide();
        }
    }
}