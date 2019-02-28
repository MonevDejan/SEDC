using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Floating
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter two numbers to compare if thy are equal");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            if (Math.Abs(a-b)<0.000001)
            {
                Console.WriteLine("the number are equal");
            }
            else
            {
                Console.WriteLine("The numbers are not equal");
            }
        }
    }
}
