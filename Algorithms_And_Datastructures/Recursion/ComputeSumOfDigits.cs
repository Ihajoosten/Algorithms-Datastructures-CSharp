using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_And_Datastructures.Recursion
{
    public class ComputeSumOfDigits
    {
        public static int ComputeSum(int number)
        {
            if (number != 0) { return number + ComputeSum(number - 1); }
            else { return 0; }
        }
    }
}
