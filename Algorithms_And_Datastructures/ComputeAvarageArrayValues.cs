using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_And_Datastructures
{
    public class ComputeAvarageArrayValues
    {
        public static double ComputeAverage(int[] a)
        {
            int N = a.Length;
            double sum = 0.0;
            for (int i = 0; i < N; i++)
            {
                sum += a[i];
            }
            double average = sum / N;
            return average;
        }
    }
}
