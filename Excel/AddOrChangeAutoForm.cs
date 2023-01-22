using System;
using System.Windows.Forms;
using System.Drawing;


namespace Excel.App
{
    public partial class AddOrChangeAutoForm : Form
    {
        public AddOrChangeAutoForm()
        {
            ClientSize = new Size(810, 470);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // PutDataCar();
            var fr2 = new CarsInformationForm(null);
            fr2.FormClosed += delegate { Application.Exit(); };
            fr2.StartPosition = FormStartPosition.Manual;
            fr2.Location = Location;
            fr2.Show();
            Hide();
        }

        private void PutDataCar()
        {
            // Отправить данные авто в бд
        }
    }
}