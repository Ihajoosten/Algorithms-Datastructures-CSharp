using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_And_Datastructures
{
    public class ReverseArray
    {
        public static T[] ReverseTheArray<T>(T[] a)
        {
            int N = a.Length;
            for (int i = 0; i < N / 2; i++)
            {
                T temp = a[i]; 
                a[i] = a[N - 1 - i]; 
                a[N - i - 1] = temp;
            }
            return a;
        }
    }
}
