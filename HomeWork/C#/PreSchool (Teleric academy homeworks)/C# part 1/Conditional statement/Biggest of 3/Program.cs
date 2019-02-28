using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bigest_of_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert 3 numbers");
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double number3 = double.Parse(Console.ReadLine());
            double bigest;

            if (number1 >= number2)
            {
                bigest = number1;
            }
            else
            {
                bigest = number2;
            }
            if (number3 >= bigest)
            {
                bigest = number3;
            }
            Console.WriteLine(bigest);

        }
    }
}
