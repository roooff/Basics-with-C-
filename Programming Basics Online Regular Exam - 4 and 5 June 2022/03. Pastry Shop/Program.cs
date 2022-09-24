using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Pastry_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int date = int.Parse(Console.ReadLine());
            double price = 0;

            if (date <= 15)
            {
                if (type == "Cake")
                {
                    price = 24.0;
                }
                else if (type == "Souffle")
                {
                    price = 6.66;
                }
                else if (type == "Baklava")
                {
                    price = 12.60;
                }
            }
            else if (date > 15)
            {
                if (type == "Cake")
                {
                    price = 28.7;
                }
                else if (type == "Souffle")
                {
                    price = 9.8;
                }
                else if (type == "Baklava")
                {
                    price = 16.98;
                }
            }
            double sum = (double)quantity * price;

            if (date <= 22 && sum >= 100 && sum <= 200)
            {
                sum -= sum * 0.15;
            }
            else if (date <= 22 && sum > 200)
            {
                sum -= sum * 0.25;
            }
            if (date <= 15)
            {
                sum -= sum * 0.1;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
} 