using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_And_Datastructures.Recursion
{
    public class PrintNumbersRecursive
    {
        public static string PrintNumber(int number)
        {
            if (number == 1) return "1";
            else
            {
                string line = "";
                for (int i = 1; i < number; i++)
                {
                    line = " " + $"{number}";
                }
                return PrintNumber(number - 1) + line;
            }
        }

        public static string PrintNumberReverse(int number)
        {
            if (number == 1) return "1";
            else
            {
                string line = "";
                for (int i = 1; i < number; i++)
                {
                    line = $"{number}" + " "; 
                }
                return line + PrintNumberReverse(number - 1);
            }
        }
    }
}
