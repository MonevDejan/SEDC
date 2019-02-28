using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_sort
{
    class Program
    {
        static void Main()
        {
            /*  Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the Selection sort algorithm: 
                Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc. 
                1 <= N <= 1024
             */

            Console.WriteLine("Please enter two numbers N=");
            int N = int.Parse(Console.ReadLine());
            int min_value;
            int index = 0;
            int sum = 0;

            if (N >= 1 && N <= 1024)
            {

                int[] sequence = new int[N];
                Console.WriteLine("Enter the values in the array");
                for (int i = 0; i < N; i++)
                {
                    sequence[i] = int.Parse(Console.ReadLine());
                }

                min_value = sequence[0];

                for (int i = 0; i < N; i++)
                {
                    for (int j = i; j < N; j++)
                    {
                        if (sequence[j] < min_value)
                        {
                            min_value = sequence[j];
                            index = j;
                        }

                    }
                    sequence[index] = sequence[i];
                    sequence[i] = min_value;
                    min_value = int.MaxValue;
                }
                foreach (int item in sequence)
                {
                    Console.WriteLine(item);
                }


            }
            else
            {
                Console.WriteLine("PLease insert numbers from 1 to 1024 for N and K<=N");
            }



        }
    }
}
