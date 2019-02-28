using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biggest_of_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please insert 5 numbers");
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double number3 = double.Parse(Console.ReadLine());
            double number4 = double.Parse(Console.ReadLine());
            double number5 = double.Parse(Console.ReadLine());
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
            if (number4 >= bigest)
            {
                bigest = number4;
            }
            if (number5 >= bigest)
            {
                bigest = number5;
            }
            Console.WriteLine(bigest);
        }
    }
}
