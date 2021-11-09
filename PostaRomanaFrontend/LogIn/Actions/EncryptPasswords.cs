using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LogIn.Actions
{
    public class EncryptPasswords
    {
        public static string GetRandomUppercaseAlphaNumericValue(int ofLength)
        {

            var builder = new StringBuilder();

            for (int i = 1; i <= ofLength; i++)
            {
                builder.Append(GetRandomUppercaseAphanumericCharacter());
            }
            return builder.ToString();
        }



        public static char GetRandomUppercaseAphanumericCharacter()
        {
            var possibleAlphaNumericValues =
                new char[]{'A','B','C','D','E','F','G','H','I','J','K','L',
                'M','N','O','P','Q','R','S','T','U','V','W','X','Y',
                'Z','0','1','2','3','4','5','6','7','8','9'};
            Random rnd = new Random();
            return possibleAlphaNumericValues[rnd.Next(0, possibleAlphaNumericValues.Length - 1)];
        }

        public static string GenerateHash(string input, string salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input + salt);
            SHA256Managed sHA256ManagedString = new SHA256Managed();
            byte[] hash = sHA256ManagedString.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        public static string CreateSalt(int size)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        public bool AreEqual(string plainTextInput, string hashedInput, string salt)
        {
            string newHashedPin = GenerateHash(plainTextInput, salt);
            return newHashedPin.Equals(hashedInput);
        }
    }
}
