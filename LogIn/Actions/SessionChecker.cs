using PostaRomana.LogIn;
using PostaRomana.MainPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogIn.Actions
{
    public class SessionChecker
    {
        public static bool CheckSessionValidity(DateTime ValidTo)
        {
            if (ValidTo.CompareTo(DateTime.Now) < 0) 
            {
                //new LoginMainPage().Show();
                return true;
            };

            return false;
        }
    }
}
