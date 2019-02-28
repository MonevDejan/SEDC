using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_Common_Divisor
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter two number");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a<0)
            {
                a *= -1;         
            }
            if (b < 0)
            {
                b *= -1;
            }
            while (a != b)
            {
                if (a>b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            Console.WriteLine(a);
        }
    }
}
