using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            Console.Write("Enter password again: ");
            string samePassword = Console.ReadLine();

            if (!password.Equals(string.Empty))
            {
                if (!samePassword.Equals(string.Empty)) {
                    if (password.Equals(samePassword))
                    {
                        Console.WriteLine("Passwords match.");
                    }
                    else
                    {
                        Console.WriteLine("Passwords do not match.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a password confirmation.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a password.");
            }

            Console.ReadLine();
        }
    }
}
