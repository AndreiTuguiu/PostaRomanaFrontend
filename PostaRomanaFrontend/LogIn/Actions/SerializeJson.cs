using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading.Tasks;

namespace LogIn
{
    public class UserCredentials
    {
        public string Username { get; set; }
        public string Password { get; set; }

    }

    //public class SerializeJson
    //{
    //    public static string Serialize(UserCredentials userCredentials)
    //    {
    //         userCredentials = new UserCredentials
    //        {
    //            Username = "TestUsername",
    //            Password = "TestPassword"
            
    //        };

    //        string jsonString = JsonSerializer.Serialize(userCredentials);

    //        return jsonString;
    //    }
    //}
}