using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_And_Datastructures.PatientAdministration
{
    public class Patient
    {
        public readonly string Name;
        public readonly int Age;
        public readonly double Weight;

        public Patient(string name, int age, double weight)
        {
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
        }
    }
}
