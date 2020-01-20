using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_And_Datastructures
{
    public class ReverseStringRecursive
    {
        // reverse the string recursivly

        public static string ReverseRecursive(string line)
        {
            if (line.Length == 0)
            {
                return "";
            } else
            {
                // doe iets
                char y = line[line.Length - 1];
                return y + ReverseRecursive(line.Substring(0, line.Length -1));
            }
        }
    }
}
