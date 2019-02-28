using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchanging_values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c;

            c = a;
            a = b;
            b = c;

            Console.WriteLine(a);
            Console.WriteLine(b);

            int d = 15;
            int e = 23;

            d ^= e;
            e ^= d;
            d ^= e;

            Console.WriteLine(d);
            Console.WriteLine(e);

            int? novalue1 = null;
            int? noValue2 = 5;

            int k = novalue1 ?? noValue2 ?? -1;
            Console.WriteLine(k);

            int m = (int)noValue2;
            Console.WriteLine(m);
            Console.ReadLine();
        }
    }
}
