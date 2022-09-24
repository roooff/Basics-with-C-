using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            string outfit ="";
            string shoes = "";
            if (10<= degrees &&  degrees<= 18)
            {
                if (time == "Morning")
                {
                    outfit = "SweatShirt";
                    shoes = "Sneakers";
                }
                else if (time== "Afternoon" || time == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (18 < degrees && degrees <= 24)
                {
                    if (time == "Afternoon")
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else if (time == "Morning" || time == "Evening")
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (degrees > 25)
                    {
                        if (time == "Morning")
                        {
                            outfit = "T-Shirt";
                            shoes = "Sandals";
                        }
                        else if (time == "Afternoon")
                        {
                            outfit = "Swim Suit";
                            shoes = "Barefoot";
                        }
                        else if (time == "Evening")
                        {
                            outfit = "Shirt";
                            shoes = "Moccasins";
                        }

                    }
                }
          
          
           
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }

    }
}
