using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    class Program
    {
        static class TriangleInformation
        {
            public static short angles;
            public static byte insadeSumOfAngles;
          
            public static double Area(double a, double h)
            {
                return (a * h) / 2;
            }

            public static double Perimetar(double a, double b, double c)
            {
                return a + b + c;
            }

            static TriangleInformation()
            {
                angles = 3;
                insadeSumOfAngles = 180;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(TriangleInformation.angles);
            Console.WriteLine(TriangleInformation.insadeSumOfAngles);
            Console.WriteLine(TriangleInformation.Area(12, 6));
            Console.WriteLine(TriangleInformation.Perimetar(4,7,2));

            Console.ReadLine();
        }
    }
}
