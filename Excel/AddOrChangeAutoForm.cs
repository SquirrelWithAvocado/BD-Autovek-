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
            var fr2 = new CarsInformationForm();
            fr2.Show();
            Hide();
        }

        private void PutDataCar()
        {
            // Отправить данные авто в бд
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}