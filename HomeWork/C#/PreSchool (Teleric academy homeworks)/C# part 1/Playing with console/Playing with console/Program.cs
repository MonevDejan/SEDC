using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_3_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 3 numbers from -1000 to 1000");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (((a <= 1000) && (a >= -1000)) && ((b <= 1000) && (b >= -1000)) && ((c <= 1000) && (c >= -1000)))
            {
                Console.WriteLine("Sum is equal to {0, -6 : 0.00}", a+b+c);
            }
            else
            {
                Console.WriteLine("Please enter valid number");
            }    
        }
    }
}
