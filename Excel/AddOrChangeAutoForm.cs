using System;
using System.Windows.Forms;

namespace Excel.App
{
    public partial class AddOrChangeAutoForm : Form
    {
        public AddOrChangeAutoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // PutDataCar();
            var fr2 = new CarsInformationForm(null);
            fr2.FormClosed += delegate { Application.Exit(); };
            fr2.Show();
            Hide();
        }

        private void PutDataCar()
        {
            // Отправить данные авто в бд
        }
    }
}