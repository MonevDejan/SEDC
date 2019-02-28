using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larger_than_neighbours
{
    class Program
    {
        //Write a method that checks if the element at given position in given array of integers is larger than its two neighbours(when such exist). 
        // Write program that reads an array of numbers and prints how many of them are larger than their neighbours.
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
        static int CompareToNeighbours(int [] array)
        {
            int counter = 0;
            for (int i = 1; i < array.Length-1; i++)
            {
                if ((array[i] > array[i-1]) && (array[i] > array[i + 1]))
                {
                    counter++;
                }
            }
            return counter;
        }
        static void Main()
        {
            
            Console.WriteLine("Please enter the the lenght of the array");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("PLease enter the numbers");
            string numbers = Console.ReadLine();
            bool wrong_string = true;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!((numbers[i] >= '0' && numbers[i] <= '9') || (numbers[i] == '-') || (numbers[i] == ' ')))
                {
                    wrong_string = false;
                }
            }
            if (wrong_string == true)
            {
                Console.WriteLine("{0}", CompareToNeighbours(StringToArray(numbers, N)));
            }
            else
            {
                Console.WriteLine("Please enter valid numbers");
            }
            Main();

        }
    }
}
