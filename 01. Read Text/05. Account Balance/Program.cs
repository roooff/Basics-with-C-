using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.Account_Balance
{
    internal class Program
    {
//Напишете програма, която пресмята колко общо пари има в сметката, след като направите определен брой вноски
//На всеки ред ще получавате сумата, която трябва да внесете в сметката, до получаване на команда "NoMoreMoney" .
//При всяка получена сума на конзолата трябва да се извежда "Increase: " + сумата и тя да се прибавя в сметката. 
//Ако получите число по-малко от 0 на конзолата трябва да се изведе "Invalid operation!" и програмата да приключи.
//Когато програмата приключи трябва да се принтира "Total: " + общата сума в сметката 
//форматирана до втория знак след десетичната запетая.
        static void Main(string[] args)
        {
            string inputWord = Console.ReadLine();
            double totalAmount = 0;
            while (inputWord != "NoMoreMoney" )
            {
                double currentAmount = double.Parse(inputWord);
                if (currentAmount <0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {currentAmount:f2}");
                totalAmount = totalAmount + currentAmount;
                inputWord = Console.ReadLine();
            }
            Console.WriteLine($"Total: {totalAmount:f2} ");
        }
    }
}
