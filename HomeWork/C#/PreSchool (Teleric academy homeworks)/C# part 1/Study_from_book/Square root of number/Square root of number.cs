using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_root_of_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Math_function();
            //Console.WriteLine("Please enter some number");
            //string number = Console.ReadLine();
            //int square_root;
            //if (int.TryParse(number, out square_root))
            //{ 
            //   // Console.WriteLine(square_root*10);
            //    Console.WriteLine("Square root of {0} is {1:0.000}",number, Math.Sqrt(square_root));
            //    Console.WriteLine(Math.);
            //}   
            //else
            //{
            //    Console.WriteLine("You did not enter number or your number is too big!!");
            //}
        }
        static void Math_function()
        {
            double x = 90;
            decimal y = 65.978698M;
            Console.WriteLine("{0}, {1}", Math.Cos(x), Math.Ceiling(y + 1));



        }
    }
}
