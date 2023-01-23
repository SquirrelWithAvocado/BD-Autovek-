using System;
using System.Text.Json;
using System.Windows.Forms;
using System.Drawing;
using Excel.Domain.Entities;


namespace Excel.App
{
    public partial class ClientAddForm : Form
    {
        public ClientAddForm()
        {
            ClientSize = new Size(716, 461);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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

        private void button1_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text;
            var surname = textBox2.Text;
            var yearBirth = textBox3.Text;
            var passId = textBox4.Text;
            var registration = textBox5.Text;
            PutDataClient(name, surname, yearBirth, passId, registration);

            
            var fr2 = new CarsInformationForm(null);
            fr2.StartPosition = FormStartPosition.Manual;
            fr2.Location = Location;
            fr2.FormClosed += delegate { Application.Exit(); };
            fr2.Show();
            Hide();
        }

        private void PutDataClient(string name, string surname, string yearBirth, string passId, string registration)
        {
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
                    Name = name,
                    Surname = surname,
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
    }
}