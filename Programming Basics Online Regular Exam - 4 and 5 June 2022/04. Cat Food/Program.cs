using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Cat_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cats  = int.Parse(Console.ReadLine());
            double price = 12.45;
            int eat = 0;
            int cat1 = 0;
            int cat2 = 0;
            int cat3 = 0;
            double sum = 0;
            for (int i = 0; i < cats; i++)
            {
                eat = int.Parse(Console.ReadLine());
                if (eat >= 100 && eat <200)
                {
                    sum = sum + eat;
                    cat1++;
                }
                else if (eat >=200 && eat <300)
                {
                    sum = sum + eat;
                    cat2++;
                }
                else if (eat >=300 && eat <400)
                {
                    sum = sum + eat;
                    cat3++;
                }

            }
            sum = sum / 1000;
            Console.WriteLine($"Group 1: {cat1} cats.");
            Console.WriteLine($"Group 2: {cat2} cats.");
            Console.WriteLine($"Group 3: {cat3} cats.");
            Console.WriteLine($"Price for food per day: {sum*price:f2} lv.");


        }
    }
}
