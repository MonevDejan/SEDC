using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appearance_count
{
    //Write a method that counts how many times given number appears in a given array.
    //Write a test program to check if the method is working correctly.

    class Program
    {
        static int[] StringToArray(string s, int N)
        {
            bool sign = true;
            int value = 0;
            int counter = 0;
            int[] array = new int[N];
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    array[counter] = value;
                    counter++;
                    value = 0;
                    sign = true;
                }
                else
                {
                    if ((s[i] == '-'))
                    {
                        sign = false;
                        continue;
                    }
                    if (sign)
                    {
                        value = value * 10 + (s[i] - 48);
                    }
                    else
                    {
                        value = value * 10 + (s[i] - 48) * (-1);
                    }
                    if (i == s.Length - 1)
                    {
                        array[counter] = value;
                    }
                }
            }
            return array;
        }
        static int NumberOfRepit(int [] list, int number)
        {
            int counter = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if (number == list[i] )
                {
                    counter++;
                }
            }
            return counter;

        }
        static void Main()
        {
            bool wrong_string = true;
            Console.WriteLine("Please enter the the lenght of the array");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("PLease enter the numbers");
            string numbers = Console.ReadLine();
            Console.WriteLine("PLease enter the number that you want to search");
            int value = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!((numbers[i] >= '0' && numbers[i] <= '9') || (numbers[i] == '-') || (numbers[i] == ' ')))
                {
                    wrong_string = false;
                }
            }
            if (wrong_string ==  true)
            {
            Console.WriteLine("{0}", NumberOfRepit(StringToArray(numbers, N), value ));
            }
            else
            {
                Console.WriteLine("Please enter valid numbers");
            }
            Main();
        }
    }
}
