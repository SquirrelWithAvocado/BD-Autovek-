using System;
using System.Drawing;
using System.Windows.Forms;


namespace Excel.App
{
    public partial class AuthorizationForm : Form
    {
        
        private readonly ClientActionForm _clientActionForm;

        public AuthorizationForm()
        {

            ClientSize = new Size(716, 461);
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
                MessageBox.Show("Мы таких не знаем, попробуйте ещё раз");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var fr2 = new RegistrationForm();
            fr2.FormClosed += delegate { Application.Exit(); };
            fr2.StartPosition = FormStartPosition.Manual;
            fr2.Location = Location;
            fr2.Show();
            Hide();
            
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
        
    }
}