using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.Min_Number
{
    internal class Program
    {
//Напишете програма, която до получаване на командата "Stop", чете цели числа, въведени от потребителя и намира най-малкото измежду тях.
//Въвежда се по едно число на ред.
        static void Main(string[] args)
        {
            int min = int.MaxValue; //-2.146.00000000
            //input from the user 
            string input = Console.ReadLine();
            while (input != "Stop")
            {
                int number = int.Parse(input);
                if (number < min)
                {
                    min = number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(min);
        }
    }
}
