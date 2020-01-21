using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_And_Datastructures.Recursion
{
    public class FactorialNumberRecursive
    {
        public static int GetFactorial(int n)
        {
            if (n == 1) return n;
            else return n * GetFactorial(n -1);
        }
    }
}
