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
    
    public class GenericArray<T>
    {
        public T[] Array { get; set; }
        public T[] CleanedArray { get; private set; }

        public GenericArray(T[] array)
        {
            Array = array;
            CleanedArray = this.Array.Distinct().ToArray();
        }

        public void FrequencyOfElement ()
        {
            for (int i = 0; i < this.CleanedArray.Length; i++)
            {
                T element = this.CleanedArray[i];
                int counter = 0;

                for (int j = 0; j < this.Array.Length; j++)
                {
                    T af = Array[j];

                    //if (element == af)
                    //    counter++;
                }
                //Console.WriteLine("Number {0} appears {1} times", number, counter);
            }
        }
    }

    class Program
    {
        static void Main()
        {

            int[] numbers = new int[] { 5, 4, 3, 6, 5, 9, 98, 1, 11, 5, 7, 9 };
            GenericArray<int> intArray = new GenericArray<int>(numbers);

            char[] characters = new char[] { 'a', 'p', 'p', 'l', 'e', 'r', 'l' };

            Console.WriteLine(typeof (intArray.GetType()));

            Console.ReadLine();

        }
    }
}
