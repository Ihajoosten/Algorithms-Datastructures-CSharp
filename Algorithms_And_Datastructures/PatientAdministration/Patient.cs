using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Algorithms_And_Datastructures.PatientAdministration
{
    public class Patient : IComparable<Patient>, IEquatable<Patient>
    {
        public string Name { get; }
        public int Age { get; }
        public double Weight { get; }

        public Patient(string name, int age, double weight)
        {
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
        }

        public int CompareTo(Patient other)
        {
            return Age.CompareTo(other.Age);
        }

        public bool Equals(Patient other)
        {
            return Name.Equals(other.Name) && Age.Equals(other.Age) && Weight.Equals(other.Weight);
        }
        public override string ToString()
        {
            return "name: " + Name + ", age: " + Age + ", weight: " + Weight;
        }
    }
}
