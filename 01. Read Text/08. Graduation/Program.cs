using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
//Напишете програма, която изчислява средната оценка на ученик от цялото му обучение.
//На първия ред ще получите името на ученика, а на всеки следващ ред неговите годишни оценки.
//Ученикът преминава в следващия клас, ако годишната му оценка е по-голяма или равна на 4.00. 
//Ако ученикът бъде скъсан повече от един път, то той бива изключен и програмата приключва, 
//като се отпечатва името на ученика и в кой клас бива изключен.
//При успешно завършване на 12-ти клас да се отпечата : 
//"{име на ученика} graduated. Average grade: {средната оценка от цялото обучение}"
//В случай, че ученикът е изключен от училище, да се отпечата:
//"{име на ученика} has been excluded at {класа, в който е бил изключен} grade"
//Стойността трябва да бъде форматирана до втория знак след десетичната запетая.
        {
            // input from the user 
            string student = Console.ReadLine();
            // rating for every subjects and class year for the student
            double rating = double.Parse(Console.ReadLine());
            // the max grades 
            // sum of all ratings o each year = 0
            double totalRating = 0;
            // the average grade 
            // sum of all ratimgs
            double averageRating = 0;
            // which class he is in
            // initiall grade is one
            int currentClass = 1;
            // how many times has he failed 
            int fails = 0;
            while (currentClass <=12)
            {
                if (rating < 4.00)
                {
                    fails++;
                }
                if(fails == 2)
                {
                    currentClass--;
                    Console.WriteLine($"{student} has been excluded at {currentClass} grade");
                    break;
                }
                totalRating = totalRating + rating;
                averageRating = totalRating / currentClass;
                currentClass++;
                if (currentClass >12)
                {
                    Console.WriteLine($"{student} graduated. Average grade: {averageRating:f2}");
                    break;
                }
                rating = double.Parse(Console.ReadLine());
            }

        }
    }
}
