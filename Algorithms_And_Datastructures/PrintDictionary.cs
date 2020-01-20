using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_And_Datastructures
{
    public class PrintDictionary
    {
        public static void PrintEntries<K, V>(IDictionary<K, V> dictionary)
        {
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
        }
    }
}
