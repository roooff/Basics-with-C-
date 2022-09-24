using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.Trekking_Mania
{
    internal class Program
    {
//Катерачи от цяла България се събират на групи и набелязват следващите върхове за изкачване.
//Според размера на групата, катерачите ще изкачват различни върхове.
//•	Група до 5 човека – изкачват Мусала
//•	Група от 6 до 12 човека – изкачват Монблан
//•	Група от 13 до 25 човека – изкачват Килиманджаро
//•	Група от 26 до 40 човека –  изкачват К2
//•	Група от 41 или повече човека – изкачват Еверест
//Да се напише програма, която изчислява процента на катерачите изкачващи всеки връх.

        static void Main(string[] args)
        {
            int numOfGroups = int.Parse(Console.ReadLine());

            double group1 = 0;
            double group2 = 0;
            double group3 = 0;
            double group4 = 0;
            double group5 = 0;

            int numOfPeople = 0;

            for (int i = 1; i <= numOfGroups; i++)
            {
                numOfPeople = int.Parse(Console.ReadLine());
                if (numOfPeople <= 5)
                {
                    group1 = group1 + numOfPeople;
                }
                else if (numOfPeople >= 6 && numOfPeople <= 12)
                {
                    group2 += numOfPeople;
                }
                else if (numOfPeople >= 13 && numOfPeople <= 25)
                {
                    group3 += numOfPeople;
                }
                else if (numOfPeople >= 26 && numOfPeople <= 40)
                {
                    group4 += numOfPeople;
                }
                else if (numOfPeople >= 41)
                {
                    group5 += numOfPeople;
                }
            }

            double totalSumOfPeoople = group1 + group2 + group3 + group4 + group5;

            group1 = group1 / totalSumOfPeoople * 100;
            group2 = group2 / totalSumOfPeoople * 100;
            group3 = group3 / totalSumOfPeoople * 100;
            group4 = group4 / totalSumOfPeoople * 100;
            group5 = group5 / totalSumOfPeoople * 100;

            Console.WriteLine($"{group1:f2}%");
            Console.WriteLine($"{group2:f2}%");
            Console.WriteLine($"{group3:f2}%");
            Console.WriteLine($"{group4:f2}%");
            Console.WriteLine($"{group5:f2}%");
        }
    }
}
 
        
    

