using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_And_Datastructures.HolidayCare
{
    public class Dog : Pet
    {
        public Dog(string name, int weight) : base(name, weight)
        {
        }

        public override void Defecate()
        {
            Console.WriteLine("Dog is pooping on the grass");
        }

        public override void Eat()
        {
            Console.WriteLine("Dog is now eating");
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Dog is making loud noises");
        }
    }
}
