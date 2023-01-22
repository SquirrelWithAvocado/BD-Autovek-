using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Excel.App
{
    public partial class AuthorizationForm : Form
    {
        
        private readonly ClientActionForm _clientActionForm;
        private Thread th;
        public AuthorizationForm()
        {
            ClientSize = new Size(810, 470);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            _clientActionForm = new ClientActionForm();
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }


        
        private void button1_Click(object sender, EventArgs e)
        {
            
            var login = textBox1.Text;
            var password = textBox2.Text;
            _clientActionForm.StartPosition = FormStartPosition.Manual;
            _clientActionForm.Location = Location;
            _clientActionForm.Show();
            Hide();
            var managerPasswordLogin = GetManagerPasswordLogin();
            if (login == managerPasswordLogin[0] 
                && password == managerPasswordLogin[1])
            {
                _clientActionForm.Show();
                this.Hide();
                
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