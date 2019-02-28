using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{Please enter valid integer number");
            int number = int.Parse(Console.ReadLine()) / 100;
            Console.WriteLine((number % 10)==7 ? "True number" : "False Number {0}" , (number % 10));
        }
    }
}
