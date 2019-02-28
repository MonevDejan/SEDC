using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Numbers
{
    class Program
    {
        //Write a method that reverses the digits of a given decimal number.
        static double ReverseDigit(double number)
        {
            double reversenumber;
            string normal = Convert.ToString(number);
            string reverse = string.Empty;
            if (normal[0] != '-')
            {
                for (int i = normal.Length-1; i >= 0; i--)
                {
                    reverse += normal[i];
                }
            }
            else
            {
                reverse += '-';
                for (int i = normal.Length - 1; i > 0; i--)
                {
                    reverse += normal[i];
                }
            }
            reversenumber = Convert.ToDouble(reverse);
            return reversenumber;

        }
        static void Main()
        {
            Console.WriteLine("Please enter the number");
            double N = double.Parse(Console.ReadLine());
            Console.WriteLine(ReverseDigit(N));
            Main();

        }
    }
}
