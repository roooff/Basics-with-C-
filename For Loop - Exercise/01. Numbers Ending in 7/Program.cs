﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Numbers_Ending_in_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 7; i < 997; i++)
            {
                if (i%10==7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
