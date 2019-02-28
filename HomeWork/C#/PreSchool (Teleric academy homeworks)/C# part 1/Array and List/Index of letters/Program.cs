using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_of_letters
{
    class Program
    {
        static void Main()
        {
            /*Write a program that creates an array containing all letters from the alphabet (a-z). 
             * Read a word from the console and print the index of each of its letters in the array.
             1 <= word length <= 128
               Word is consisted of lowercase english letters
             */

            //creating the array
            char[] sequence = new char[26];
            for (int i = 97, j=0; i < 123; i++, j++)
            {
                sequence[j] = (char)i;
            }

            Console.WriteLine("Please enter your word in lowercase");
            string word = Console.ReadLine();

            foreach (char m in word)
            {
                Console.WriteLine((int)m - 97);
            }
        }
    }
}
