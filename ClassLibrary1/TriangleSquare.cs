using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSquareLibrary
{
    public class TriangleSquare
    {
        public static double calculateSquare(int a, int b, int c)
        {
            double p = (a + b + c) / 2.0;

            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            
            return s;
        }
        public static double calculateSquare(float a, float b, float c)
        {
            double p = (a + b + c) / 2.0;

            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            
            return s;
        }
    }
}
