using PostaRomana.LogIn;
using PostaRomana.RecoverPasswordPage;
using System;
using System.Windows.Forms;

namespace LogIn
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginMainPage());



            /*var client = new HttpClient();

             async Task<string> ContentGetHello() {
                var content = await client.GetStringAsync("https://localhost:5001/api/Home/GetHello");
                return content;
            }
            Console.WriteLine(ContentGetHello());*/
            //Console.WriteLine(SerializeJson.Serialize());
            //Console.WriteLine("GET");

        }
    }
}
