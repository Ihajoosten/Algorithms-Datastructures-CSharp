using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Algorithms_And_Datastructures.HolidayCare
{
    public abstract class Pet : IPet
    {
        private readonly string Name;
        private readonly double Weight;

        public Pet(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        string IPet.Name => this.Name;

        double IPet.Weight => this.Weight;

        public int CompareTo(IPet other)
        {
            return Weight.CompareTo(other.Weight);
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            Console.WriteLine("overriden Equals(object obj) called");
            Console.WriteLine("this: " + this);
            Console.WriteLine("obj: " + obj);

            var other = obj as Pet;
            if (other == null)
            {
                return false;
            }

            Console.WriteLine("overriden Equals(object obj) returns: " + Name.Equals(other.Name));
            return Name.Equals(other.Name);
        }

        public override int GetHashCode()
        {
            Console.WriteLine("GetHashCode called: " + Name.GetHashCode());
            return Name.GetHashCode();
        }


        public abstract void Defecate();
        public abstract void Eat();
        public abstract void MakeNoise();
        public bool Equals(IPet other)
        {
            return Name.Equals(other);
        }
    }
}
