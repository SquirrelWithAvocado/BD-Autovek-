using System;
using System.Text.Json;
using System.Windows.Forms;

namespace Excel.App
{
    public partial class ClientAddForm : Form
    {
        public ClientAddForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var fr2 = new AuthorizationForm();
            fr2.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text;
            var surname = textBox2.Text;
            var yearBirth = textBox3.Text;
            var passId = textBox4.Text;
            var registration = textBox5.Text;
            PutDataClient(name, surname, yearBirth, passId, registration);

            var fr2 = new CarsInformationForm();
            fr2.Show();
            Hide();
        }

        private void PutDataClient(string name, string surname, string yearBirth, string passId, string registration)
        {
            // Отправить данные клиента в бд
            // Проверить поля, если не заполнили, то на след окно не переходим
            if (name == "" || surname == "" || yearBirth == ""
                || passId == "" || registration == "")
            {
                MessageBox.Show("Одно из полей не заполнено!");
            }
            else
            {
                var client = new Client
                {
                    Id = passId,
                    BirthDate = yearBirth,
                    Name = name,
                    Surname = surname,
                    Registration = registration
                };
                
                var respMsg = HttpRequester.SendPost(
                    JsonSerializer.Serialize(client),
                    @"clients"
                );

                if (respMsg.IsSuccessStatusCode)
                {
                    MessageBox.Show("Client is added!");
                }
                else
                {
                    MessageBox.Show($"Operation failed, status code: {respMsg.StatusCode}");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}