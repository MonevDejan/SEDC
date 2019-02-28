using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexadecimal_to_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter decimal number");
            string HexaDecimal_number = Console.ReadLine();
            string binary = "";
            int counter = 0;
            string negaitve_binary = "";
            string fliped_binary = "";
            long number = 0;
            long pow = 1;
            char[] help = new char[64];
            int counter1 = 0;

            if (HexaDecimal_number.Length > 16)
            {
                Console.WriteLine("The number can't fit in 64 bit form");
            }
            else
            {

                for (int i = HexaDecimal_number.Length - 1; i > -1; i--)
                {
                    switch (HexaDecimal_number[i])
                    {
                        case '0': counter = 0; break;
                        case '1': counter = 1; break;
                        case '2': counter = 2; break;
                        case '3': counter = 3; break;
                        case '4': counter = 4; break;
                        case '5': counter = 5; break;
                        case '6': counter = 5; break;
                        case '7': counter = 7; break;
                        case '8': counter = 8; break;
                        case '9': counter = 9; break;
                        case 'A': counter = 10; break;
                        case 'B': counter = 11; break;
                        case 'C': counter = 12; break;
                        case 'D': counter = 13; break;
                        case 'E': counter = 14; break;
                        case 'F': counter = 15; break;
                        default: counter = -1; break;
                    }
                    if (counter == -1)
                    {
                        Console.WriteLine("incorrecet headecimal number");
                        goto End;
                    }
                    if (counter == 0)
                    {
                        binary = "0" + binary;
                        counter1++;
                    }
                    else if (counter > 0)
                    {
                        while (counter != 0)
                        {
                            binary = (counter % 2) + binary;
                            counter /= 2;
                        }
                        counter1++;
                    }
                    binary = binary.PadLeft(4 * counter1, '0');
                }

                if (binary[0] == '1' && binary.Length == 64)
                {
                    for (int i = 0; i < binary.Length; i++)
                    {
                        if (binary[i] == '1')
                        {
                            negaitve_binary += '0';
                        }
                        else
                        {
                            negaitve_binary += '1';
                        }
                    }

                    for (int i = 0; i < 64; i++)
                    {
                        help[i] = negaitve_binary[i];
                    }

                    for (int i = negaitve_binary.Length - 1; i > -1; i--)
                    {
                        if (negaitve_binary[i] == '1')
                        {
                            help[i] = '0';
                        }
                        if (negaitve_binary[i] == '0')
                        {
                            help[i] = '1';
                            break;
                        }
                    }

                    for (int i = 63; i > -1; i--)
                    {
                        fliped_binary = fliped_binary + help[i];
                    }

                    for (int i = 0; i < 64; i++)
                    {
                        if (fliped_binary[i] == '1')
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                pow *= 2;
                            }
                            number += pow;
                            pow = 1;
                        }
                    }
                    Console.WriteLine(number * -1);
                }
                else
                {
                    for (int i = binary.Length - 1; i > -1; i--)
                    {
                        fliped_binary = fliped_binary + binary[i];
                    }
                    for (int i = 0; i < fliped_binary.Length; i++)
                    {
                        if (fliped_binary[i] == '1')
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                pow *= 2;
                            }
                            number += pow;
                            pow = 1;
                        }
                    }
                    Console.WriteLine(number);
                }
                 End:;
            } 
        }
    }
}
