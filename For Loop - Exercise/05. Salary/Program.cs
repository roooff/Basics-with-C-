using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.Salary
{
    internal class Program
    {
//Шеф на компания забелязва че все повече служители прекарват време в сайтове, които ги разсейват.
//За да предотврати това, той въвежда изненадващи проверки на отворените табове на браузъра на служителите си. 
//Според отворения сайт в таба се налагат следните глоби:
//•	"Facebook" -> 150 лв.
//•	"Instagram" -> 100 лв.
//•	"Reddit" -> 50 лв.
//От конзолата се четат два реда:
//•	Брой отворени табове в браузъра n - цяло число в интервала [1...10]
//•	Заплата - число в интервала[500...1500]
//След това n – на брой пъти се чете име на уебсайт – текст
//•Ако по време на проверката заплатата стане по-малка или равна на 0 лева, на конзолата се изписва 
//"You have lost your salary." и програмата приключва.
//•противен случай след проверката на конзолата се изписва остатъкът от заплатата(да се изпише като цяло число).


        static void Main(string[] args)
        {
            //step 1 :Inputs from the users
            // opened tabs 
            int tabs = int.Parse(Console.ReadLine());
            // salary
            double salary = int.Parse(Console.ReadLine());
            //Step 3 :reading the names of the cites
            string siteNames = String.Empty;
            // for loop 
            for (int i = 1; i < tabs; i++)
            {
                // starting from the first to the last
                //dependeing on the cite , different fine
                siteNames = Console.ReadLine();
                if (siteNames == "Facebook")
                {
                    salary = salary - 150;
                }
                else if (siteNames == "Instagram")
                {
                    salary = salary - 100;
                }
                else if (siteNames == "Reddit")
                {
                    salary = salary - 50;
                }
                // if the salary end but the tabs are more 
                // print :"You have lost your salary."
                // and we stop the loop using |break|
                if (salary <=0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
               
            }
            // if there is more we print the leftovers using math.round
            if (salary>0)
            {
                Console.WriteLine(Math.Round(salary));
            }
           
            
            

        }
    }
}
