using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;




namespace Tracker.Domain
{
    public class UserManager
    {
     
        public static bool loggedIn(string username,string password)
        {
            if (validateInput(username, password))
            {
                if(Persistance.UserRepository.VerifyCredentials(username, generateHash(password)))
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        private static string generateHash(string password)
        { 
            using (SHA256 sHA256Hash = SHA256.Create())
            {
                byte[] bytes = sHA256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++){builder.Append(bytes[i].ToString("x2"));}
                return builder.ToString();
            }
        }
        private static bool validateInput(string username, string password)
        {
            if (username.Length <= 0){return false;}
            if (password.Length <= 0){return false;}
            return true;
        }

    }
}
