using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.Gold_Mine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int location = int.Parse(Console.ReadLine());

            for (int i = 0; i < location; i++)
            {
                double averageGold = double.Parse(Console.ReadLine());
                int dayDigging = int.Parse(Console.ReadLine());
                double goldSum = 0;

                for (int j = i + 1; j <= dayDigging + i; j++)
                {
                    goldSum += double.Parse(Console.ReadLine()); ;
                }

                if ((goldSum / dayDigging) >= averageGold)
                {
                    Console.WriteLine($"Good job! Average gold per day: { goldSum / dayDigging:f2}.");
                }
                else
                {
                    Console.WriteLine($"You need {averageGold - (goldSum / dayDigging):f2} gold.");
                }
            }
        }

    }
    }

