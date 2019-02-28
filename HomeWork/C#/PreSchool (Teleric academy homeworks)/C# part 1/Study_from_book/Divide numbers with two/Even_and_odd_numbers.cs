using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_and_odd_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int? somenumber;



            Console.WriteLine(TakeNumberAndAddTwo(x));

            PrintsNumber(TakeNumberAndAddTwo(x));

            NaDeanMetodo();
        }

        static void NaDeanMetodo()
        {
            Console.WriteLine("Please enter number:");
            string input = Console.ReadLine();
            int number;
            if (int.TryParse(input, out number))
            {
                if ((number & 1) != 0)
                {
                    Console.WriteLine("Your number is odd");
                }
                else
                {
                    Console.WriteLine("Your number is even");
                }
            }
            else
            {
                Console.WriteLine("You didn't enter nuber!!");

            }
        }

        static int TakeNumberAndAddTwo(int dean)
        {
            dean += 2;
            return dean;
        }

        static void PrintsNumber(int nekojInt)
        {
            Console.WriteLine(nekojInt);
        }
    }
}
