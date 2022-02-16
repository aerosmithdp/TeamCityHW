using System;
using Xunit;

//test 4

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 4, 25.132741228718345)]
        [InlineData(2, 5, 62.83185307179586)]
        [InlineData(3, 6, 113.09733552923255)]
        [InlineData(7, 1, 43.982297150257104)]
        [InlineData(8, 2, 100.53096491487338)]
        [InlineData(9, 3, 169.64600329384882)]
        [InlineData(3, 7, 131.94689145077132)]
        [InlineData(9, 1, 56.548667764616276)]
        [InlineData(57, 36, 12893.09625033251)]
        [InlineData(41, 98, 25245.838564247577)]
        [InlineData(32, 58, 11661.591930125313)]
        [InlineData(88, 22, 12164.246754699678)]
        [InlineData(66, 77, 31931.147731086658)]
        [InlineData(44, 11, 3041.0616886749194)]
        [InlineData(52, 57, 18623.361250480295)]
        [InlineData(65, 32, 13069.025438933539)]
        [InlineData(174, 587, 641751.9809047085)]
        [InlineData(789, 547, 2711715.9644284877)]
        [InlineData(123, 456, 352411.29750908865)]
        [InlineData(789, 321, 1591336.0595640666)]




        public void Test1(double a, double b, double expected)
        {
            double actual = SideSurfaceArea.GetSideSurfaceArea(a,b);
            Assert.Equal(expected, actual);
        }
    }
}
