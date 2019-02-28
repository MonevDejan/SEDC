using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moon_Gravity
{
    class Program
    {
        static void Main(string[] args)
        {
            double moongravity = 0.17;
            Console.WriteLine("Please enter your wight");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Your weight on mars is {0,5: 0.000 }", weight*moongravity);
        }
    }
}
