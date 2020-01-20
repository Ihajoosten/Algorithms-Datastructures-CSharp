using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_And_Datastructures
{
    public class FindMaximumInsideArray
    {
        public static int FindMaximum(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }
    }
}
