using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSimpleAuth
{
    public class Authenticate
    {
        public static string Salt = "MsxjVC11";   // This value should be the same as on the php file.

        public static bool isAuthenticated(string php_link, string pattern)
        {
            return new WebClient().DownloadString($"{php_link}?pattern={pattern}").Contains(CreateMD5(Salt + pattern)); 
        }

        public static string CreateMD5(string input)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        } // Credits: stackoverflow.com/questions/11454004/calculate-a-md5-hash-from-a-string
    }
}
