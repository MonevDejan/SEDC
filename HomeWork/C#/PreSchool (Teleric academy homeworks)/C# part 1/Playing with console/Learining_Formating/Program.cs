using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learining_Formating
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UnicodeEncoding.UTF8;
            double a = -312345.123456783242343429;
            int b = -2034324;

            Console.WriteLine("{0:C6}" ,a);
            Console.WriteLine("{0:d6}", b);
            Console.WriteLine("{0:E6}", a);
            Console.WriteLine("{0:F6}", a);
            Console.WriteLine("{0:G7}", a);
            Console.WriteLine("{0:N4}", a);
            Console.WriteLine("{0:P6}", a);
            Console.WriteLine("{0:R2}", a);

            int c =Console.Read();
            int d = Console.Read();
            int e = Console.Read();
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);

            ConsoleKeyInfo Readkey = Console.ReadKey();
            Console.WriteLine(Readkey.KeyChar);
            Console.WriteLine(Readkey.Modifiers);

            Console.WriteLine(@"Dejanco e ""gospodin"" ");

        }
    }
}
