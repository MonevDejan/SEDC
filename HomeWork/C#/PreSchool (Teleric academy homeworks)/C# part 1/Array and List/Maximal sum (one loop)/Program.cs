using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximal_sum
{
    class Program
    {
        static void Main()
        {
            /*Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.
             Can you do it with only one loop (with single scan through the elements of the array)?
             1 <= N <= 1024
             */

            Console.WriteLine("Please enter two numbers N=, K=");
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int max_value = int.MinValue;
            int index = 0;
            int sum = 0;
            int counter = 0;

            if (N >= 1 && N <= 1024 && K <= N)
            {
                int[] sequence = new int[N];
                Console.WriteLine("Enter the values in the array");
                for (int i = 0; i < N; i++)
                {
                    sequence[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < K + i && i < N; i++)
                {   
                    checked
                    {
                       sum += sequence[i];
                    }
                    index++;
                    if (index == K)
                    {
                        if (sum > max_value)
                        {
                            max_value = sum;
                        }
                        sum = 0;
                        index = 0;
                        i = counter;
                        counter++;
                    }
                }
                Console.WriteLine();
                Console.WriteLine(max_value);
            }
            else
            {
                Console.WriteLine("YOU ARE DOOMED!!!");
            }

        }
    }
}
