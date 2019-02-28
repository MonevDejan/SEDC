using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Not_devisibe_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(5%3);
            Console.WriteLine("please enter number");
            int n = int.Parse(Console.ReadLine());

            if (n >= 1)
            {
                for (int i = 0; i <= n; i++)
                {
                    if (i % 3 != 0 && i % 7 != 0)
                    {
                        Console.Write("{0} ", i);
                    }
                }
            }
            else
            {
                Console.WriteLine("PLease enter valid positive natural number");
            }

        }
    }
}
