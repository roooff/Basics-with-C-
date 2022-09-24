using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Area_of_Figures
{
    internal class Program
    {
// •Ако фигурата е квадрат(square): на следващия ред се чете едно дробно число - дължина на страната му
//•	Ако фигурата е правоъгълник(rectangle): на следващите два реда четат две дробни числа - дължините на страните му
//•	Ако фигурата е кръг(circle): на следващия ред чете едно дробно число - радиусът на кръга
//•	Ако фигурата е триъгълник(triangle): на следващите два реда четат две дробни числа - дължината на страната му и дължината на височината към нея

        static void Main(string[] args)
        {
            string FigureName = Console.ReadLine();
            
            if (FigureName == "square")
            {
                double FigureSide = double.Parse(Console.ReadLine());
                double ResultOfSides = FigureSide * FigureSide;
                Console.WriteLine($"{ResultOfSides:f3}");
            }
            else if (FigureName == "rectangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                double ResultOfSides = (2 * side1) + (2 * side2);
                Console.WriteLine($"{ResultOfSides:f3}");
            }
            else if (FigureName == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double ResultOfSides = (radius * radius) * Math.PI;
                Console.WriteLine($"{ResultOfSides:f3}");
            }
            else if  (FigureName == "triangle")
            {
                double lenght = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double ResultOfSides = (0.5 * lenght) * height;
                Console.WriteLine($"{ResultOfSides:f3}");
            }
        }
    }
}
