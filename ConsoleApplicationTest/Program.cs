using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSquareLibrary;

namespace ConsoleApplicationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TriangleSquare.calculateSquare(3, 4, 5));
            Console.WriteLine(TriangleSquare.calculateSquare(3.0f,4.0F,5.0F));
            Console.ReadLine();
        }
    }
}
