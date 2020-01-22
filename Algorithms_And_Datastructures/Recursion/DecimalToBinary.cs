using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_And_Datastructures
{
    public class DecimalToBinary
    {
        public static int Dec2Bin(int decimal_number)
        {
            if (decimal_number == 0) { return 0; }
            else { return (decimal_number % 2 + 10 * Dec2Bin(decimal_number / 2)); }
        }
    }
}
