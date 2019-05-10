using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    /*
       ### Write a program in C# to display the number and frequency of number from giving array. 
       ### Write a program in C# to display the characters and frequency of character from giving string 
       ### Write a program in C# to Accept the members of a list through the keyboard and display the members more than a specific value. 

    */
    
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[] { 5, 4, 3, 6, 5, 9, 98, 1, 11, 5, 7, 9 };
            char[] characters = new char[] { 'a', 'p', 'p', 'l', 'e', 'r', 'l' };

            Func<int[], int[]> arrayCleaner = delegate (int[] numberArray)
            {
                int[] cleen = numberArray.Distinct().ToArray();
                return cleen;
            };
        


            Action<int[], int[]> FrequencyOfNumber = delegate ( int[] numberArray, int[] cleenArray)
            {
                for (int i = 0; i < cleenArray.Length; i++)
                {
                    int number = cleenArray[i];
                    int counter = 0;
                    for (int j = 0; j < numberArray.Length; j++)
                    {
                        if (number == numberArray[j])
                            counter++;
                    }
                    Console.WriteLine("Number {0} appears {1} times", number, counter);
                }
            };

            FrequencyOfNumber(numbers, arrayCleaner(numbers));


            Console.ReadLine();

        }
    }
}
