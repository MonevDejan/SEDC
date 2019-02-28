using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_or_Even
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please insert valid integer");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine( (number & 1) == 0 ? "Number is even " : "Number is odd");
        }
    }
}
