using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devided_by_7_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a valid integer");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine((number%7)==0 && (number%5)==0 ? "True number" : "False number");
        }
    }
}
