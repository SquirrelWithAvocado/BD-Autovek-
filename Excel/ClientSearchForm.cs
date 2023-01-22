using System;
using System.Text.Json;
using System.Windows.Forms;

namespace Excel.App
{
    public partial class ClientSearchForm : Form
    {
        public ClientSearchForm()
        {
            InitializeComponent();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            var fr2 = new AuthorizationForm();
            fr2.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = textBox1.Text;
            SearchClient(id);
            var fr2 = new CarsInformationForm();
            fr2.Show();
            Hide();
        }

        private void SearchClient(string id)
        {
            var (response, text) = HttpRequester.Get(@$"/clients/{id}");


            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Нашёл!");
                var client = JsonSerializer.Deserialize<Client>(text);
            }
            else
                MessageBox.Show("не найден клиент");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}