using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
//Напишете програма, която до получаване на командата "Stop", чете цели числа, въведени от потребителя и намира най-голямото измежду тях.
//Въвежда се по едно число на ред.
        {
            int max = int.MinValue; //-2.146.00000000
            //input from the user 
            string input = Console.ReadLine();
            while (input != "Stop")
            {
                int number = int.Parse(input);
                if (number >max)
                {
                    max = number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(max);
        }
    }
}
