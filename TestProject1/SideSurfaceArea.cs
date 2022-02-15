using System;
using Xunit;
using TestProject1;

namespace TestProject1
{

    public class SideSurfaceArea
    {
        public static double GetSideSurfaceArea(double r, double h)
        {
            return 2 * Math.PI * r * h;
        }
    }

}
