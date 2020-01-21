using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_And_Datastructures.HolidayCare
{
    public class HolidayCare<T> where T : IPet
    {
        private readonly Dictionary<string, T> pets = new Dictionary<string, T>();
        private readonly SortedSet<T> sortedPets = new SortedSet<T>();


        public void AddPet(T pet)
        {
            pets.Add(pet.Name, pet);
            sortedPets.Add(pet);    
        }

        public void ShowAllSorted()
        {
            foreach (var item in sortedPets)
            {
                Console.WriteLine(item);
            }
        }

        public void ShowDetails(string name)
        {
            foreach (var item in pets)
            {
                if (item.Key == name)
                {
                    Console.WriteLine(item.Value);
                }
            }
        }
    }
}
