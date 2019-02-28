using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(10/3);

            double a = 10 / 3;
            double b = 10 % 3;

            Console.WriteLine("{0:F5}", a+a%3);
            Console.WriteLine(b);

        }
    }
}
