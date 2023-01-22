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
            _clientActionForm.Show();
            Hide();
            var managerPasswordLogin = GetManagerPasswordLogin();
            if (login == managerPasswordLogin[0] 
                && password == managerPasswordLogin[1])
            {
                _clientActionForm.Show();
                Hide();
            }
        }

        private string[] GetManagerPasswordLogin()
        {
            // Получить логин и пароль сотрудника из бд
            return new[] {"Иванов", "123"};
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}