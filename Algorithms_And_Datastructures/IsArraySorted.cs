using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_And_Datastructures
{
    public class IsArraySorted
    {
        public static bool IsSorted(String[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i - 1].CompareTo(a[i]) > 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
