using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formating_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("PLease enter number from 0 to 500 a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please enter number b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Please enter number c=");
            double c = double.Parse(Console.ReadLine());
            string Hex = Convert.ToString( a, 16);
            string binary = Convert.ToString(a, 2).PadLeft(10, '0');

            Console.WriteLine("{0, -10:X}|{1}|{2, 10 : 0.00}|{3, -10 : 0.000}", a, binary, b, c);
           



        }
    }
}
