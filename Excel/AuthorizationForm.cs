using System;
using System.Windows.Forms;

namespace Excel.App
{
    public partial class AuthorizationForm : Form
    {
        private readonly ClientActionForm _clientActionForm;
        public AuthorizationForm()
        {
            _clientActionForm = new ClientActionForm();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = textBox1.Text;
            var password = textBox2.Text;
            
            var successAuth = GetManagerPasswordLogin(login, password);
            if (successAuth)
            {
                _clientActionForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Мы таких не знаем, попробуйте ещё раз");
            }
        }

        private bool GetManagerPasswordLogin(string login, string password)
        {
            var authContent = $"{login}={password}";
            HttpRequester.AuthHeader = authContent;
            var response = HttpRequester.Get("/");
            
            return response.Item1.IsSuccessStatusCode;
        }
    }
}