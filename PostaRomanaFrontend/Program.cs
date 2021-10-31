
using PostaRomana.AddEditEvent;
using PostaRomana.LogIn;
using PostaRomanaFrontend.SignUp;
using System;
using System.Windows.Forms;

namespace PostaRomanaFrontend
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPage.MainPage());
        }
    }
}
