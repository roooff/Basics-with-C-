using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Password_Guess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretpassword = "s3cr3t!P@ssw0rd";
            string PasswordFromUser = Console.ReadLine();
            if (PasswordFromUser == secretpassword)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
