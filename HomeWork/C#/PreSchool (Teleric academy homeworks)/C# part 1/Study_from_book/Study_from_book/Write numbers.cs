using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_from_book
{
    class program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please insert three numbers");
            string test1 = Console.ReadLine();
            string test2 = Console.ReadLine();
            string test3 = Console.ReadLine();

            int number1;
            int number2;
            int number3;

            int.TryParse(test1, out number1);
            int.TryParse(test2, out number2);
            int.TryParse(test3, out number3);

            Console.WriteLine("{0}", number1);
            Console.WriteLine("{0}", number2);
            Console.WriteLine("{0}", number3);

            Console.WriteLine("insert integer");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);
        }
    }
}
