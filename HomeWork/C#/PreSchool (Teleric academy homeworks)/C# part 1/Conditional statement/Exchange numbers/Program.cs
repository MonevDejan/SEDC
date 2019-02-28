using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers"); 
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c;

            if (a>b)
            {
                c = b;
                b = a;
                a = c;

            }
            Console.WriteLine("{0}, {1}", a,b);

        }
    }
}
