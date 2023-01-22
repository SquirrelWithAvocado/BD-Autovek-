using System;
using System.Windows.Forms;
using System.Drawing;


namespace Excel.App
{
    public partial class CarsInformationForm : Form
    {
        private Client _curClient;
        private int rowIndex = 0;

        public CarsInformationForm(Client curClient)
        {
            ClientSize = new Size(810, 470);
            _curClient = curClient;
            InitializeComponent();
            ListClientCars();
        }

        private void ListClientCars()
        {
            CarsGrid.DataSource = _curClient.Cars;
        }

        public void UpdateAll()
        {
            CarsGrid.DataSource = _curClient.Cars;
            CarsGrid.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var _choosingDocumentForm = new ChoosingDocumentForm();
            _choosingDocumentForm.FormClosed += delegate { Application.Exit(); };
            _choosingDocumentForm.StartPosition = FormStartPosition.Manual;
            _choosingDocumentForm.Location = Location;
            _choosingDocumentForm.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fr2 = new AddOrChangeAutoForm(_curClient, this, _curClient.Cars.Count);
            fr2.FormClosed += delegate { Application.Exit(); };
            fr2.StartPosition = FormStartPosition.Manual;
            fr2.Location = Location;
            fr2.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var fr2 = new AddOrChangeAutoForm(_curClient, this, rowIndex);
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

        private void CarsGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowIndex = e.RowIndex;
        }
    }
}