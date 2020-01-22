using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_And_Datastructures.Recursion
{
    public class RecursiveTree
    {
        public static string BuildTree(string value, IList<string> items, int index)
        {
            // "index" variable value checking helps call recursive function finite number of times.
            if (items.Count == index)
            {
                return value;
            }

            // Add node.
            value += " " + items[index] + " <-";

            // Actual recursion: call function itself once more time.
            return BuildTree(value, items, index + 1);
        }
    }
}
