using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frequent_number
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Write a program that finds the most frequent number in an array of N elements.
             1 <= N <= 1024
             */

            Console.WriteLine("Enter the size of the array, N= ");
            int N = int.Parse(Console.ReadLine());
            int index = 0;
            int counter = 0;
            int Real_index= 0;
            int Real_counter = 0;

            if (1 <= N && N <= 1024)
            {
                int[] sequence = new int[N];
                Console.WriteLine("Enter the values in the array");
                for (int i = 0; i < N; i++)
                {
                    sequence[i] = int.Parse(Console.ReadLine());
                }

                //WE use nested "if" to avoid double for cycle
                for (int i = 0; i < N; i++)
                {
                    if (sequence[index] == sequence[i])
                    {
                        counter++;
                    }
                    if (i==N-1)
                    {
                        if (counter > Real_counter)
                        {
                            Real_counter = counter;
                            Real_index = index;
                        }
                        i = index;
                        index++;
                        counter = 0;
                    }
                }
                Console.WriteLine("{0}, {1} times", sequence[Real_index], Real_counter);
            }
            else
            {
                Console.WriteLine("YOU ARE DOOMED!!!");
            }
        }
    }
}
