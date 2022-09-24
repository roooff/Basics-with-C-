using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.Puppy_Care
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine()) * 1000;
            string foodPerDay = Console.ReadLine();
            int total = 0;

            while (foodPerDay != "Adopted")
            {
                total += int.Parse(foodPerDay);
                foodPerDay = Console.ReadLine();
            }

            if (total <= food)
            {
                Console.WriteLine($"Food is enough! Leftovers: {food - total} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {total - food} grams more.");
            }
        }
    }
}
    

