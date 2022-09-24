using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.Oscars
{
    internal class Program
    {
//Поканени сте от академията да напишете софтуер, който да пресмята точките за актьор/актриса.
//Академията ще ви даде първоначални точки за актьора.
//След това всеки оценяващ ще дава своята оценка.
//Точките, които актьора получава се формират от:
//: дължината на името на оценяващия умножено по точките, които дава делено на две.
//Ако резултатът в някой момент надхвърли 1250.5 програмата 
//трябва да прекъсне и да се отпечата, че дадения актьор е получил номинация.

        static void Main(string[] args)
        {
            //Step 1 : Inputs from the user 
            // Actor name 
            string actorName = Console.ReadLine();
            // points from the academy
            double academyp = double.Parse(Console.ReadLine());
            // and n people who vote
            int voters = int.Parse(Console.ReadLine());
            //voters name
            string assessorName = string.Empty;
            //voter given points
            double assessorNameP = 0;

            //Step 2: For every voter wee need to calculate how many points the actor gets
            for (int i = 1; i <=voters; i++)

            {
                if (academyp >= 1250.5)
                {

                    break;
                }
                // get the info
                assessorName = Console.ReadLine();
                assessorNameP = double.Parse(Console.ReadLine());
                //which is calculated by the lenght of the voter multipied to the points devided by 2
                //      lenght * points / 2
                academyp =  academyp + assessorName.Length * assessorNameP/2;
            }
            if (academyp >= 1250.5)
            {
                // break the loop
                //after that we need to see if the points >= 1250.5
                // if points >= 1250.0
                //and print :
                //"Congratulations, {actor} got a nominee for leading role with {pints}!"
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {academyp:f1}!");

            }
            else
            {

                //if not 
                //"Sorry, {actor name } you need {needed pionts} more!"
                //format to the first digit after the point
                Console.WriteLine($"Sorry, {actorName } you need {1250.5 - academyp:f1} more!");
            }




        }
    }
}
