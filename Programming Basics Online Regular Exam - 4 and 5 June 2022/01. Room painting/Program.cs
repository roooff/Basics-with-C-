using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Room_painting
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int paint = int.Parse(Console.ReadLine());
            int wallpaper = int .Parse(Console.ReadLine());
            double gloves = double.Parse(Console.ReadLine());
            double brushes = double.Parse(Console.ReadLine());
            double paintprice = 21.50;
            double wallpaperprice = 5.20;
            double glovesneeded = wallpaper * 35 / 100;
            double brushesneeded = paint * 45 / 100;
            glovesneeded = glovesneeded * 2.20;
            brushesneeded =brushesneeded * 5;
            paintprice = paintprice * paint;
            wallpaperprice = wallpaperprice * wallpaper;
            double totalSum = paintprice+ wallpaperprice +Math.Ceiling(glovesneeded) +   Math.Floor(brushesneeded);
            totalSum = totalSum / 15;
            Console.WriteLine($"This delivery will cost {totalSum} lv.");
            
            
        }
    }
}
