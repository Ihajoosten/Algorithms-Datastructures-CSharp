using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_And_Datastructures.HolidayCare
{
    public class Cat : Pet
    {
        public Cat(string name, int weight) : base(name, weight)
        {
        }

        public override void Defecate()
        {
            Console.WriteLine("Cat is pooping on the grass");
        }

        public override void Eat()
        {
            Console.WriteLine("Cat is now eating");
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Cat is making loud noises");
        }
    }
}
