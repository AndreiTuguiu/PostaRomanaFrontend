using LogIn.Actions;
using LogIn.Pages.MainPageMock;
using PostaRomana.LogIn;
using PostaRomana.RecoverPasswordPage;
using System;
using System.Threading;
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
            /*var sescheck = new SessionChecker();
            DateTime FourSecondsLater = DateTime.Now.AddSeconds(4);*/


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Uhh());


           /* Thread.Sleep(5000);
            if (SessionChecker.CheckSessionValidity(FourSecondsLater)) { Application.Exit(); }*/



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
