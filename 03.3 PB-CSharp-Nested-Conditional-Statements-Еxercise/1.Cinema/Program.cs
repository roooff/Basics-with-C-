using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double income = 0.0;
            switch(type)
            {
                case "Premiere":
                    income = 12.50;
                    break;
                case "Normal":
                    income = 7.50;
                    break;
                case "Discount":
                    income = 5;
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            double TotalSum = income * rows * columns;
            Console.WriteLine($"{TotalSum:f2}");

        }
    }
}
