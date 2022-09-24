using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _03.Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
//Напишете програма, която чете цяло число от конзолата и на всеки следващ ред цели числа, 
//докато тяхната сума стане по-голяма или равна на първоначалното число.След приключване да се отпечата сумата на въведените числа.
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            while (n >sum)
            {
                int input = int.Parse(Console.ReadLine());
                sum = sum + input;
            }
            Console.WriteLine(sum);
        }
    }
}
