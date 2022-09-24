using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дадени са n цели числа в интервала[1…1000].
            //От тях някакъв процент p1 са под 200,
            //друг процент p2 са от 200 до 399,
            //друг процент p3 са от 400 до 599,
            //друг процент p4 са от 600 до 799
            //и останалите p5 процента са от 800 нагоре.
            //Да се напише програма, която изчислява и отпечатва процентите p1, p2, p3, p4 и p5.
            //Пример: имаме n = 20 числа: 53, 7, 56, 180, 450, 920, 12, 7,
            //150, 250, 680, 2, 600, 200, 800, 799, 199, 46, 128, 65.
            //Получаваме следното разпределение и визуализация:
            //Диапазон      Числа в диапазона                                   Брой числа  Процент
            //< 200         |5   3, 7, 56, 180, 12, 7, 150, 2, 199, 46, 128, 65 |12         p1 = 12 / 20 * 100 = 60.00 %
            //200 … 399     |250, 200|                                          |2          p2 = 2 / 20 * 100 = 10.00 %
            //400 … 599     |450 |                                              |1          p3 = 1 / 20 * 100 = 5.00 %
            //600 … 799     |680, 600, 799|                                     |3          p4 = 3 / 20 * 100 = 15.00 %
            //≥ 800         |920,800|                                           |2          p5 = 2 / 20 * 100 = 10.00 %

            //step 1 : create n (how many numbers we will get to put in the console)
            int n = int.Parse(Console.ReadLine());
            // step 2 : we will crate 5 variables for all the zones 
            //in those variubles we store th quantity of the number in the chosen range
            double p1 = 0; //every number which is smaller than 200// ||<200||
            double p2 = 0;// every number bigger or equal to 200 and be smaller than 399 at the same time// ||>=200 && <=399|
            double p3 = 0;// every number bigger than and being smaller or equal than 599 |>400 && <=599|
            double p4 = 0;// every number bigger ot equal from 600 and smaller or equal to 799|>=600 && <=799|
            double p5 = 0;// every number bbigger or equal to 800|>=800|
            //example if we the user puts 500 ; num = 500 then our p4 will be 1 .|+1|
            // if the user puts 550 ; then our p4 will be 2 , cause there are two numbers in the same range 
            //step 3: a viruble for the for loop to wcich will be red everytime we the for lopp start again
            int num = 0;
            //step 4: a for lopp from the first number to the last one
            for (int i = 1; i <= n; i++)
            {
                // num will be the number inputed from the user 
                // and will start again and again
                //till i>n
                num = int.Parse(Console.ReadLine());
                //trying to recognize which number gets in its range for all the 5 p's;
                if (num < 200)
                {
                    p1 = p1 + 1;
                    //p1 +=1;
                    //p1++
                }
                else if (num < 400)
                {
                    p2 = p2 + 1;
                    //p2 +=1;
                    //p2++
                }
                else if (num < 600)
                {
                    p3 = p3 + 1;
                    //p3 +=1;
                    //p3++
                }
                else if (num <800)
                {
                    p4 = p4 + 1;
                    //p4 +=1;
                    //p4++
                }
                else
                {
                    p5 = p5 + 1;
                    //p5 +=1;
                    //p5++
                }

            }
            //step 5 : we need to see how many number are in each category but presented in procent for every p:
            p1 = p1 / n * 100;
            p2= p2 / n * 100;
            p3 = p3 / n * 100;
            p4 = p4 / n * 100;
            p5 = p5 / n * 100;
            // after these calculations now we dont store how many number are stored
            // in each ranger but now we store in procent how much % of n is in each p
            // steap 5 : finally we just need to print the procent stored in all these p 
            // presenting the number after the second coma
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");

        }
    }
}
