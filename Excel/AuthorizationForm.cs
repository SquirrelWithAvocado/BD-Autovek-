using System;
using System.Drawing;
using System.Windows.Forms;


namespace Excel.App
{
    public partial class AuthorizationForm : Form
    {
        private bool textBox1HasClicked;
        private bool textBox2HasClicked;
        private readonly ClientActionForm _clientActionForm;

        public AuthorizationForm()
        {
            textBox1HasClicked = false;
            textBox2HasClicked = false;
            ClientSize = new Size(810, 470);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            _clientActionForm = new ClientActionForm();
            _clientActionForm.FormClosed += delegate { Application.Exit(); };

            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var login = textBox1.Text;
            var password = textBox2.Text;
            _clientActionForm.StartPosition = FormStartPosition.Manual;
            _clientActionForm.Location = Location;

            var successAuth = GetManagerPasswordLogin(login, password);
            if (successAuth)
            {
                _clientActionForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private bool GetManagerPasswordLogin(string login, string password)
        {
            var authContent = $"{login}={password}";
            HttpRequester.AuthHeader = authContent;
            var response = HttpRequester.Get("/");
            
            return response.Item1.IsSuccessStatusCode;
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!textBox1HasClicked)
            {
                textBox1.Clear();
                textBox1HasClicked = true;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (!textBox2HasClicked)
            {
                textBox2.Clear();
                textBox2HasClicked = true;
            }
        }
    }
}