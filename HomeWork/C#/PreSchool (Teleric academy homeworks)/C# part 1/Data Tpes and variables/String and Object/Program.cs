using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_and_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "Hello";
            string two = "World";
            object concatenation = one + " " + two;
            string three = (string)concatenation;
            Console.WriteLine(concatenation);
            Console.WriteLine(three);
            Console.WriteLine("{0} {1} and again {2}", one, two, three);

            string quotes = "we should use \',\" and \\ more often \n";
            Console.WriteLine(quotes);

            string multiline = @"This is 
                                possisble only with
                                @";
            Console.WriteLine(multiline);
        }
    }
}
