using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_And_Datastructures.Recursion
{
    public class CountNumbersRecursive
    {
        public static int CountDigits(int number)
        {
            int count = 0;
            if (number == 0) return count;
            else
            {
                return CountDigits(number/10) + ++count;
            }
        }
    }
}
