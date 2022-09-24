using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //step 1 : make a viruble the n times iputs from the user
            int n = int.Parse(Console.ReadLine());
            //step 2: make an for loop for check
            // making a variuble for the sum of the inputet numbers
            int sum = 0;
            // a viriiuble  which stores the max number in integer
            int max = int.MinValue;
            //a variuble for the nnumber of loops put in from the user 
            //the user tells us how many times he wants for the loop to loop around with whole number // int//
            int num = 0;
             
            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum = sum + max;
                //we need to check if our number is not bigger than our max number
                // if its true than our new number becomes the new max number in this loop and programm
                if (num >max)
                {
                    max = num;
                }
            }
            //we make a variuble to see the left of sum - max 
            int sumWithoutMaxNumber = sum - max;
            // we check if . if the max number is equal to our sum- max 
            //then there is no difference so the sum needs to be shown to the user
            if (max == sumWithoutMaxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + max);
            }
            else
            //if not we need to show te user the difference between sum and max 
            // imediate eexecution
            {
                int diff = Math.Abs(max - sumWithoutMaxNumber);
                Console.WriteLine("No");
                Console.WriteLine("Diff = "+diff);
            }
        }
    }
}
