using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("PLease insert one nuber from 1 to 50 including");
            int num = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c = 0;

            Console.Write("0, 1, ");
            if ((num<=50) && (num>=1))
            {
                for (int i = 1; i <= num; i++)
                {
                    c = a + b;
                    Console.Write("{0}, ", c);
                    a = b;
                    b = c;
                }
            }
            else
            {
                Console.WriteLine("PLease inser valid number");
            }
        }
    }
}
