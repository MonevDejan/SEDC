using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexadecimal_try_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 254;
            string headecimal = number.ToString("X");
            Console.WriteLine(headecimal);

            int hexadecimal_number = 0XFE;
            Console.WriteLine((int)hexadecimal_number);

            string From_string_to_int = "FE";
            int int_from_string = Convert.ToInt16(From_string_to_int, 16);
            Console.WriteLine(int_from_string);

            char sign_from_unicode = '\u006B';
            Console.WriteLine(sign_from_unicode);
            Console.WriteLine((int)sign_from_unicode);
        }        
    }
}
