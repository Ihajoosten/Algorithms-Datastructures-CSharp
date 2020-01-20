using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_And_Datastructures
{
    public class ReturnDuplicates
    {
        // Schrijf een methode om alle waarden die vaker dan 1 keer in een collectie voorkomen terug te geven in een collectie-datastructuur. 

        public static ICollection<T> ReturnDuplicateValues<T>(ICollection<T> collection)
        {
            ICollection<T> duplicates = new List<T>();
            foreach (var item in collection)
            {
                int count = 0;
                foreach (var duplicate in collection)
                {
                    if (item.Equals(duplicate)) count++;
                }
                if (count > 1)
                {
                    if (!duplicates.Contains(item))
                    {
                        duplicates.Add(item);
                    }
                }
            }
            return duplicates;
        }
    }
}
