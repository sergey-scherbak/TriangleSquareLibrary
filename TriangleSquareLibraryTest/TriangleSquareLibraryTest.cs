using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleSquareLibrary;

namespace TriangleSquareLibraryTest
{
    [TestClass]
    public class TriangleSquareLibraryTest
    {
        [TestMethod]
        public void Square_a3_b4_c5_return_6()
        {
            //arrange
            int a = 3;
            int b = 4;
            int c = 5;
            double expected = 6;

            //act
            double s = TriangleSquare.calculateSquare(a, b, c);

            //assert
            Assert.AreEqual(expected, s);
        }

        [TestMethod]
        public void SquareF_a3_b4_c5_return_6()
        {
            //arrange
            float a = 3.0F;
            float b = 4.0F;
            float c = 5.0F;
            double expected = 6.0;

            //act
            double s = TriangleSquare.calculateSquare(a, b, c);

            //assert
            Assert.AreEqual(expected, s);
        }

    }
}
