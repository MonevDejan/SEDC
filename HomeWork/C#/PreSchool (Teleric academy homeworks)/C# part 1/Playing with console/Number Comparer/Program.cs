using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Comparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert two numbers");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(a>=b ? a : b);
        }
    }
}
