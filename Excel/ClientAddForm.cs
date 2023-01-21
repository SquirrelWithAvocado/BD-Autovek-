using System;
using System.Windows.Forms;
using Excel;

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
            // var completedFields = false;
            // while (!completedFields)
            // {
            //     var name = textBox1.Text;
            //     var surname = textBox2.Text;
            //     var yearBirth = textBox3.Text;
            //     var passId = textBox4.Text;
            //     var registration = textBox5.Text;
            //     completedFields = PutDataClient(name, surname, yearBirth, passId, registration);
            // }
            var name = textBox1.Text;
            var surname = textBox2.Text;
            var yearBirth = textBox3.Text;
            var passId = textBox4.Text;
            var registration = textBox5.Text;
            PutDataClient(name, surname, yearBirth, passId, registration);

            var temporaryName = "Олег";
            var temporarySurname = "Олегович";
            var temporaryYearBirth = "17.02.2000";
            var temporaryPassId = "222";
            var temporaryRegistration = "г. Екб ул. ыы";
            var fr2 = new CarsInformationForm(temporaryName, temporarySurname, 
                temporaryYearBirth, temporaryPassId, temporaryRegistration);
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
                // button1_Click(null,null);
                // return false;
            }
            // return true;
        }
    }
}