using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_And_Datastructures
{
    public class SavingInterestsRecursive
    {
        public static decimal CalculateInterests(decimal begin, int percentage, int years)
        {
            if (years == 0) { return begin; }
            return CalculateInterests(begin * (1 + (percentage / 100)), percentage, years - 1);
        }
    }
}
