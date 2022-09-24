using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Password
{
    internal class Program
    {
//Напишете програма, която първоначално прочита име и парола на потребителски профил.След това чете парола за вход.
//•	при въвеждане на грешна парола: потребителя да се подкани да въведе нова парола.
//•	при въвеждане на правилна парола: отпечатваме "Welcome {username}!".

        static void Main(string[] args)
        {
            //Step one : inputs
            //type string
            string username = Console.ReadLine();
            string password = Console.ReadLine();  
            string ipassword= Console.ReadLine();
            while (ipassword !=password)
            {
                ipassword = Console.ReadLine();
                
            }
            Console.WriteLine($"Welcome {username}!");
        }
    }
}
