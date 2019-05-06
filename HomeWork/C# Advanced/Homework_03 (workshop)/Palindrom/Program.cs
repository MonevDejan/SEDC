using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAdvanced_Class4;

namespace Palindrom
{
    class Program
    {
        static void Main()
        {
            string phrase;
            phrase = "Madam, I'm Adam";
            Console.WriteLine(phrase.IsPalindrom());  //True

            phrase = "Madam, I am Adam";
            Console.WriteLine(phrase.IsPalindrom());  //False

            phrase = "Refer, refer!";
            Console.WriteLine(phrase.IsPalindrom());  //True

            double numeric;
            numeric = 123.321;
            Console.WriteLine(numeric.IsPalindrom());  //True

            double numeric1;
            numeric1 = 12345.321;
            Console.WriteLine(numeric1.IsPalindrom());  //False

            int integer;
            integer = 11211;
            Console.WriteLine(integer.IsPalindrom());  //True

            int integer1;
            integer1 = 1124311;
            Console.WriteLine(integer1.IsPalindrom());  //False

            long bigInt;
            bigInt = 12345654321;
            Console.WriteLine(bigInt.IsPalindrom());  //True

            long bigInt1;
            bigInt1 = 1112345654321;
            Console.WriteLine(bigInt1.IsPalindrom());  //False

            Console.ReadLine();
        }
    }
}
