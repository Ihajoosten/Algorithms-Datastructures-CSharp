using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_And_Datastructures.Recursion
{
    public class OddOrEvenNumbers
    {
        public static string PrintOddNumbers(int n)
        {
            if ((n & 1) == 0) n--;
            if (n < 1) return "";
            return PrintOddNumbers(n - 1) + $" {n}";
        }

        public static string PrintEvenNumbers(int n)
        {
            if (n % 2 == 0) n -= 2;
            if (n == 1 || n == 0) return "";
            return PrintEvenNumbers(n) + $" {n}";
        }
    }
}
