using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Beer_And_Chips
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            double beers = double.Parse(Console.ReadLine()) * 1.2;
            double chips = double.Parse(Console.ReadLine()) * beers * 0.45;

            double sum = beers + Math.Ceiling(chips);

            if (budget < sum)
            {
                Console.WriteLine($"{ name} needs { sum - budget:f2} more leva!");
            }
            else
            {
                Console.WriteLine($"{ name} bought a snack and has { budget - sum:f2} leva left.");
            }
        }
    }
    }

