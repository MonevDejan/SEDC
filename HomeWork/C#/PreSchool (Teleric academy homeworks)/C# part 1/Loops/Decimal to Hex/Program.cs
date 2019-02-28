using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_to_Hex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter decimal number");
            //long decimal_number = long.MinValue;
            long decimal_number = long.Parse(Console.ReadLine());               
            string binary_number = "";
            char[] help = new char[64];
            string reverse = "";
            int counter = 1;
            int sum = 0;
            string hexadecimal = "";

            if (decimal_number == long.MinValue)
            {
                Console.WriteLine("8000000000000000");
                goto End;
            }
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
                for (int i = binary_number.Length - 1; i > -1; i--)
                {
                    if (binary_number[i] == '1')
                    {
                        sum += counter;
                        counter += counter;
                    }
                    else
                    {
                        counter += counter;
                    }
                    if (counter == 16)
                    {
                        if (sum > 9)
                        {
                            switch (sum)
                            {
                                case 10: hexadecimal = "A" + hexadecimal; break;
                                case 11: hexadecimal = "B" + hexadecimal; break;
                                case 12: hexadecimal = "C" + hexadecimal; break;
                                case 13: hexadecimal = "D" + hexadecimal; break;
                                case 14: hexadecimal = "E" + hexadecimal; break;
                                case 15: hexadecimal = "F" + hexadecimal; break;
                            }
                            counter = 1;
                            sum = 0;
                        }
                        else
                        {
                            hexadecimal = sum + hexadecimal;
                            counter = 1;
                            sum = 0;
                        }

                    }
                    if (i == 0)
                    {
                        hexadecimal = sum + hexadecimal;
                    }

                }
                Console.WriteLine(hexadecimal);
            }
            else
            {
                decimal_number = decimal_number * (-1);
                while (decimal_number != 0)
                {
                    binary_number = (decimal_number % 2) + binary_number;
                    decimal_number /= 2;
                }
                binary_number = binary_number.PadLeft(64, '0');               
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
                for (int i = 0; i < 64; i++)
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
                for (int i = 0; i < 64; i++)
                {
                    binary_number += help[i];
                }
                for (int i = binary_number.Length - 1; i > -1; i--)
                {
                    if (binary_number[i] == '1')
                    {
                        sum += counter;
                        counter += counter;
                    }
                    else
                    {
                        counter += counter;
                    }
                    if (counter == 16)
                    {
                        if (sum > 9)
                        {
                            switch (sum)
                            {
                                case 10: hexadecimal = "A" + hexadecimal; break;
                                case 11: hexadecimal = "B" + hexadecimal; break;
                                case 12: hexadecimal = "C" + hexadecimal; break;
                                case 13: hexadecimal = "D" + hexadecimal; break;
                                case 14: hexadecimal = "E" + hexadecimal; break;
                                case 15: hexadecimal = "F" + hexadecimal; break;
                            }
                            counter = 1;
                            sum = 0;
                        }
                        else
                        {
                            hexadecimal = sum + hexadecimal;
                            counter = 1;
                            sum = 0;
                        }
                    }
                }
                Console.WriteLine(hexadecimal);
            }
                End:;
        }
    }
}
