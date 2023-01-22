using System;
using System.Windows.Forms;
using System.Drawing;


namespace Excel.App
{
    public partial class ClientActionForm : Form
    {
        public ClientActionForm()
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
            var fr2 = new ClientSearchForm();
            fr2.StartPosition = FormStartPosition.Manual;
            fr2.Location = Location;
            fr2.FormClosed += delegate { Application.Exit(); };
            fr2.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var fr2 = new ClientAddForm();
            fr2.StartPosition = FormStartPosition.Manual;
            fr2.Location = Location;
            fr2.FormClosed += delegate { Application.Exit(); };
            fr2.Show();
            Hide();
        }

        private void ClientActionForm_Load(object sender, EventArgs e)
        {
            
        }

    }
}