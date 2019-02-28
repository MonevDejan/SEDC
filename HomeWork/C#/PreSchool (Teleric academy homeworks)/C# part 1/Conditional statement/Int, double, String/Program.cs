using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int__double__String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("imput=");
            string imput = Console.ReadLine();
            int a;
            double b;

            if (int.TryParse(imput, out a))
            {
                Console.WriteLine(a+1);
            }
            else if (double.TryParse(imput, out b))
            {
                Console.WriteLine(b+1);
            }
            else
            {
                Console.WriteLine(imput+"*");
            }

        }
    }
}
