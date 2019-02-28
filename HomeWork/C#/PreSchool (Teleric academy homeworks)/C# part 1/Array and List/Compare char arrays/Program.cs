using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_char_arrays
{
    class Program
    {
        static void Main()
        {

            /* Write a program that compares two char arrays lexicographically (letter by letter)
               1 <= size of arrays <= 128        */

            Console.WriteLine("please enter the values for the first array");
            string one = Console.ReadLine();
            Console.WriteLine("please enter the values for the second array array");
            string two = Console.ReadLine();
            int counter = 0;
            int low_count;
            bool check = true;
            
            
            if (one.Length < 128 || two.Length < 128 )
            {
                char[] first = new char[one.Length];
                char[] second = new char[two.Length];

                //Asigning the arrays
                foreach (char m in one)
                {
                    first[counter] = m;
                    counter++;
                }
                counter = 0;
                foreach (char m in two)
                {
                    second[counter] = m;
                    counter++;
                }
                //Finding the smaller array
                if (one.Length <= two.Length)
                {
                    low_count = one.Length;
                }
                else
                {
                    low_count = two.Length;
                }

                for (int i = 0; i < low_count; i++)
                {
                    if ((int)first[i] == (int)second[i])
                    {
                        continue;
                    }
                    else if ((int)first[i] < (int)second[i])
                    {
                        Console.WriteLine("<");
                        check = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine(">");
                        check = false;
                        break;
                    }
                }
                if (check == true && one.Length == second.Length)
                {
                    Console.WriteLine("=");
                }
                if (check == true && one.Length < second.Length)
                {
                    Console.WriteLine("<");
                }
                if (check == true && one.Length > second.Length)
                {
                    Console.WriteLine(">");
                }

            }
            else
            {
                Console.WriteLine("WE ARE DOOMED!!!");
            }
        }
    }
}
