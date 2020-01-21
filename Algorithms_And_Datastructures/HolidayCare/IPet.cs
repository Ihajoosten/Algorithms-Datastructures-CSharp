using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_And_Datastructures.HolidayCare
{
    public interface IPet : IComparable<IPet>, IEquatable<IPet>
    {
        string Name { get; }
        double Weight { get; }

        void Eat();
        void Defecate();
        void MakeNoise();

    }
}
