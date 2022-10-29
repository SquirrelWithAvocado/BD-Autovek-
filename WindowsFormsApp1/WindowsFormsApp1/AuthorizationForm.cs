using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AuthorizationForm : Form
    {
        
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = textBox1.Text;
            var password = textBox2.Text;
            var fr2 = new ClientActionForm();
            if (login == "Иванов" && password == "123") //надо добавить бд с логинами и паролями работников 
            {
                fr2.Show();
                Hide();
            }
        }
    }
}