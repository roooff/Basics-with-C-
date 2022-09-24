using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Sequence_2k_1
{
    internal class Program
    {
//Напишете програма, която чете число n, въведено от потребителя, и отпечатва всички числа ≤ n от редицата: 1, 3, 7, 15, 31, …. 
//Всяко следващо число се изчислява като умножим предишното с 2 и добавим 1.
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int k = 0;
            while (k<=input)
            {
                k = k * 2 + 1;
                // k=*2+1
                if (k <= input)
                {
                    Console.WriteLine(k);
                }
            }
        }
    }
}
