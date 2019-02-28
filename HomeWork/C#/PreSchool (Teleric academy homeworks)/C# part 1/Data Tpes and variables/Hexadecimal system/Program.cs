using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexadecimal_system
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 42;
            string hexadecimal = number.ToString("X");
            int inHexadecimal = 0XFC;
            string a = "FCCC";
            int b = Convert.ToInt32(a, 16);
            char d = '\u002D';
            string Unicode =number.ToString("");
            char result = Convert.ToChar(number);

            Console.WriteLine(result);
            Console.WriteLine(Unicode);
            Console.WriteLine(d);
            Console.WriteLine(b);
            Console.WriteLine(hexadecimal);
            Console.WriteLine(inHexadecimal);
            Console.WriteLine((char)42);
        }
    }
}
