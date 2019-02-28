using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_equasion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the coeficient a,b and c in order from interval -1000 to 1000");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double x1;
            double x2;
            double root = (b * b) - (4 * a * c);

            if ((a>=-1000) && (a <= 1000) &&
                (b >= -1000) && (b <= 1000) &&
                (c >= -1000) && (c <= 1000)) 
            {
                if (((b*b-4*a*c)>0)        )
                {
                    x1 = (-b + Math.Sqrt(root)) / (2 * a);
                    x2 = (-b - Math.Sqrt(root)) / (2 * a);
                    Console.WriteLine(x1<x2 ? "{0:F2}, {1:F2}" : "{1:F2}, {0:F2}", x1,x2);
                }
                else
                {
                    Console.WriteLine(((b * b) - (4 * a * c) == 0) ? "{0:F2}" : "There is no real root", x1 = -b / (2 * a));
                }
            }
            else
            {
                Console.WriteLine("Please insert valid number from -1000 to 1000");
            }
        }
    }
}
