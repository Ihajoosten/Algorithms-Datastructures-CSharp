using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_And_Datastructures
{
    public class Routes
    {
        public static bool IsRoute(int xStart, int yStart, int xEnd, int yEnd)
        {
            if (xStart == xEnd && yStart == yEnd)
            {
                return true;
            }
            if ((xStart + yStart) <= yEnd)
            {
                return IsRoute(xStart, (xStart + yStart), xEnd, yEnd);
            }
            else if ((xStart + yStart) <= xEnd)
            {
                return IsRoute((xStart + yStart), yStart, xEnd, yEnd);
            }

            return false;
        }
    }
}
