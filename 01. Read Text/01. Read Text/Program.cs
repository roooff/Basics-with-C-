using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Read_Text
{
    internal class Program
    {
        //Напишете програма, която чете текст от конзолата(стринг) и го принтира, докато не получи командата "Stop".
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            while (word != "Stop")
            {
                Console.WriteLine(word);
                word = Console.ReadLine();
            }
            
           
        }
    }
}
