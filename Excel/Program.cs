using System;
using System.Windows.Forms;

namespace Excel.App
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var authForm = new AuthorizationForm();
            authForm.FormClosed += delegate { Application.Exit(); };
            authForm.Show();
            Application.Run();
        }
    }
}
