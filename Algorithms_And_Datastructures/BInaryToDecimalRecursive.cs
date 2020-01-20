using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_And_Datastructures.ProefTentamen_1
{
    public class BinaryToDecimalRecursive
    {
        public static double BinToDec(string binaryString)
        {
            if (binaryString.Length <= 1)
            {
                if (binaryString[0] == '1')
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                char x = binaryString[0];
                double total = 0.0;
                if (x == '0')
                {
                    total = 0;
                }
                else
                {
                    total = Math.Pow(2, binaryString.Length - 1);
                }

                return BinToDec(binaryString.Substring(1, binaryString.Length - 1)) + total;
            }
        }
    }
}
