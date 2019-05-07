using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hi there, how are you?";
            string shortenString = myString.Shorten(8);
            Console.WriteLine(myString);
            Console.WriteLine("Shroten: " + shortenString);

            string quoted = myString.Shorten(8).QuoteString();
            Console.WriteLine(quoted);

            string number = "100";
            Console.WriteLine(number.IsNumericType());
            Console.WriteLine(number.IsNotNumericType());
            Console.WriteLine(number.IsDigit());
            double epsilon = double.Epsilon;
            Console.WriteLine(epsilon.IsNumericType());
            Console.WriteLine(epsilon);

            Console.WriteLine(epsilon.GetType());
            Console.WriteLine(Type.GetTypeCode(epsilon.GetType()));
          

            Console.ReadLine();
        }
    }
}
