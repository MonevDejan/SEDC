using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_digit
{
    // Write a method that returns the last digit of given integer as an English word.
    //Write a program that reads a number and prints the result of the method.

    class Program
    {
        static string LastNumber(int number)
        {
            string last_digit = string.Empty;
            switch (number)
            {
                case 0: last_digit = "zero"; break;
                case 1: last_digit = "one"; break;
                case 2: last_digit = "two"; break;
                case 3: last_digit = "three"; break;
                case 4: last_digit = "Four"; break;
                case 5: last_digit = "Five"; break;
                case 6: last_digit = "six"; break;
                case 7: last_digit = "seven"; break;
                case 8: last_digit = "eight"; break;
                case 9: last_digit = "nine"; break;
            }
            return last_digit;
        }
        static void Main()
        {
            Console.WriteLine("Please enter some integer number");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}",LastNumber(Math.Abs(input % 10)));
            Main();
        }
    }
}
