# DotNetSimpleAuth
Easy-to-use .NET authentication library with PHP server-side checks.

# Example
```C#
using System;
using System.Security.Principal;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string whitelist_id = WindowsIdentity.GetCurrent().User.Value;

            if (DotNetSimpleAuth.Authenticate.isAuthenticated("https://ataxyle.com/lypd/github_tests/DNSA.php", whitelist_id))
            {
                Console.WriteLine("Authenticated.");
            }
            else
            {
                Console.WriteLine("You are NOT authenticated.");
            }

            Console.ReadLine();
        }
    }
}
```
