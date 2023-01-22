using System;
using System.Net.Http;
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
            fr2.FormClosed += delegate { Application.Exit(); };
            fr2.StartPosition = FormStartPosition.Manual;
            fr2.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = textBox1.Text;
            var (response, client) = SearchClient(id);


            if (response.IsSuccessStatusCode)
            {
                var fr2 = new CarsInformationForm(client);
                fr2.StartPosition = FormStartPosition.Manual;
                fr2.FormClosed += delegate { Application.Exit(); };

                fr2.Show();
                Hide();
            }
        }

        private (HttpResponseMessage, Client) SearchClient(string id)
        {
            Client client = null;
            var (response, text) = HttpRequester.Get(@$"/clients/{id}");


            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Нашёл!");
                client = JsonSerializer.Deserialize<Client>(text);
            }
            else
                MessageBox.Show("не найден клиент");

            return (response, client);
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