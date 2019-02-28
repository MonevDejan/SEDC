using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_number_to_N
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter valid integer number N=");
            int number = int.Parse(Console.ReadLine());

            if ((number >= 1) && (number <= 1000))
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.Write("{0},", i);
                }
            }
            else
            {
                Console.WriteLine("Please enter valid number");
            }
        }
    }
}
