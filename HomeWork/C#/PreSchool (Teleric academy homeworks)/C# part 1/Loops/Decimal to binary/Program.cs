using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_to_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter decimal number");
            long decimal_number = long.Parse(Console.ReadLine());
            string binary_number = "";
            char[] help = new char[32];
            string reverse = "";

            if (decimal_number == 0)
            {
                Console.WriteLine(0);
            }
            else if (decimal_number > 0)
            {
                while (decimal_number != 0)
                {
                    binary_number = (decimal_number % 2) + binary_number;
                    decimal_number /= 2; 
                }               
                Console.WriteLine(binary_number);
                //Console.WriteLine(Convert.ToString(45, 2));
            }
            else
            {
                decimal_number *= -1;
                while (decimal_number != 0)
                {
                    binary_number = (decimal_number % 2) +binary_number;
                    decimal_number /= 2;
                }                                
                binary_number = binary_number.PadLeft(32, '0');
                for (int i = 0; i < binary_number.Length; i++)
                {
                    if (binary_number[i] == '1')
                    {
                        reverse += '0';
                    }
                    else
                    {
                        reverse += '1';
                    }               
                }                        
                for(int i = 0; i < 32; i++)
                {
                    help[i] = reverse[i];
                }

                for (int i = reverse.Length - 1; i > -1; i--)
                {
                    if (reverse[i] == '1')
                    {
                        help[i] = '0';
                    }
                    if (reverse[i] == '0')
                    {
                        help[i] = '1';
                        break;
                    }
                }
                binary_number = "";
                for (int i = 0; i < 32; i++)
                {
                    binary_number += help[i];
                }
                Console.WriteLine(binary_number);
                //Console.WriteLine(Convert.ToString(45, 2));
            }
        }
    }
}
