using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Лили вече е на N години. За всеки свой рожден ден тя получава подарък. 
            //•	За нечетните рождени дни(1, 3, 5...n) получава играчки.
            //•	За четните рождени дни(2, 4, 6...n) получава пари. 
            //За втория рожден ден получава 10.00 лв, като сумата се увеличава с 10.00 лв.,
            //за всеки следващ четен рожден ден(2-> 10, 4-> 20, 6-> 30...и т.н.).
            //През годините Лили тайно е спестявала парите.
            //Братът на Лили, в годините, които тя получава пари, взима по 1.00 лев от тях
            //Лили продала играчките получени през годините, всяка за P лева и добавила сумата към спестените пари
            //С парите искала да си купи пералня за X лева. Напишете програма, която да пресмята, колко пари е
            //събрала и дали ѝ стигат да си купи пералня.

            //step 1 :
            //We need Lily's age from the user int
            //How much is the laundry machine she wants to buy double
            // Every toy individual price or how much cash she was gifted double
            int age = int.Parse(Console.ReadLine());
            double laundry = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            //Step 2: We need to see what is the combined ammount of the money and toys
            // from that amount we need to take away the money she stoled from her brother |per 1 leva for every even bd
            // a variuble which stores her savings
            double money = 0;

            for (int i = 1; i <= age; i++)
            {
                // we need to see if the bd is even
                // 2 y she gets 10 , when 4 she gets 20 , when 6 she gets 30
                // every year she gets 5 leva * here age
                // if even 
                // i %2== 
                //i * 5 - 1 // for the 1 leva taken away from her brother 
                if (i % 2 == 0)
                {
                    money = money + i * 5 - 1;
                }
                else
                {
                    money = money + toyPrice;
                }

               

            }
            //Step 4 : With all the info we need to check if the money is enough for the laundry machine
            if (money >= laundry)
            {
                Console.WriteLine($"Yes! {money - laundry:f2}");
            }
            else
            {
                Console.WriteLine($"No! {laundry - money:f2}");
            }
        }
    }
}
