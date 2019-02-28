using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_to_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Convert.ToString(-15, 2));
            Console.WriteLine("PLease enter binary number");
            string binary = Console.ReadLine();
            string negaitve_binary = ""; 
            string fliped_binary="";
            long number = 0;
            long pow = 1;
            char[] help = new char[32];

            if (binary[0] == '1' && binary.Length == 32)
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

                for (int i = 0; i < 32; i++)
                {
                    help[i] = negaitve_binary[i];
                }

                for (int i = negaitve_binary.Length -1; i > -1; i--)
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
               
                for (int i = 31; i > -1; i--)
                {
                    fliped_binary = fliped_binary + help[i];
                }

                for (int i = 0; i < 32; i++)
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
                Console.WriteLine(number*-1);
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
        }
    }
}
