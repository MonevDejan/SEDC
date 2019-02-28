using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UnicodeEncoding.UTF8;
            Console.WriteLine("Please enter number for columns, n=");

            string console = Console.ReadLine();
            int number;
            char sign = (char)169;
            
            // It should have overflow check
            if (int.TryParse(console, out number))
            {
                Console.SetCursorPosition(number - 1, 3);
                Console.Write(sign);
                for (int i = 2; i < number; i++)
                {
                    Console.SetCursorPosition(number - i, i + 2);

                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write(sign);
                        Console.SetCursorPosition(number - 2 + i, i + 2);
                    }
                    Console.Write("\n");
                }
                for (int i = 0; i < number; i++)
                {
                    Console.Write("{0} ", sign);
                }
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("PLease enter a valid posit!!");
            }
        }
    }
}
