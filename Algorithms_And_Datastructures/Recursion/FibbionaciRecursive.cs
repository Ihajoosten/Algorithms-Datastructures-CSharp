using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_And_Datastructures.Recursion
{
    public class FibbionaciRecursive
    {
        public static int Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }
    }
}
