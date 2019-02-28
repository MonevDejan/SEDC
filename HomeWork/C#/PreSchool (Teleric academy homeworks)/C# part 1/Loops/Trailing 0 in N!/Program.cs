using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trailing_0_in_N_
{
    class Program
    {
        static void Main(string[] args)
        {
            //This program will calculate how many 0 has faktoriel from one number

            Console.WriteLine("Please enter one number ");
            int N = int.Parse(Console.ReadLine());
            int trailing_zeroes = 0;
            int pow = 5;

            // It will use method of finding how many power of 5 containt the number

            while (N>=pow)
            {
                trailing_zeroes += N / pow;
                pow *= 5;
            }
            Console.WriteLine(trailing_zeroes);

        }
    }
}
