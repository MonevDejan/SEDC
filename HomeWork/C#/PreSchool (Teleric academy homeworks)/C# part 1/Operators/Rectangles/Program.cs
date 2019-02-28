using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLease inesrt the height and width of the rectangle");
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("The area is {0 : 0.00}, and the perimetar is {1 : 0.00} ", width*height, 2*(width+height));
        }
    }
}
