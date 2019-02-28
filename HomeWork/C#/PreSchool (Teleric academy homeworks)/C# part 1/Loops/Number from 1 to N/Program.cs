using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_from_1_to_N
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter number");
            int n = int.Parse(Console.ReadLine());

            if (n > 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("{0} ", i);
                }
            }
            else
            {
                Console.WriteLine("PLease enter valid positive natural number");
            }

        }
    }
}
