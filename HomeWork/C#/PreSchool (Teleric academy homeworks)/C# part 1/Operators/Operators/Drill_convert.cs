using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Operators
{
    class Drill_convert
    {
        static void Main(string[] args)

         
        {
            int a = 5;
            int max = int.MaxValue;
            int overflow = max + a;
            bool try_1 = true;
            Console.WriteLine(1<<4);
            // Console.WriteLine(checked(max+a));
            //Console.WriteLine((1.7 * a++).GetType());
            //Console.WriteLine(a);
            //Console.WriteLine(Convert.ToString(int.MaxValue, 16).PadLeft(32,'0'));
            //Console.WriteLine(try_1);
            //Console.WriteLine(Convert.ToString(4090, 16).PadLeft(10, 'A'));
            //Console.WriteLine(Convert.ToString(14, 10));
            //Console.WriteLine(Convert.ToUInt32("FFA", 16));
            for (BigInteger i = 0; i < 60; i++)
            {
                Console.WriteLine(1<<i);
            }
        }
    }
}
