using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximal_K_sum
{
    class Program
    {
        static void Main()
        {
            /*Write a program that reads two integer numbers N and K and an array of N elements from the console. Find the maximal sum of K elements in the array.
             1 <= N <= 1024
             1 <= K <= N
             */

            Console.WriteLine("Please enter two numbers N=, K=");
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int max_value;
            int index = 0;
            int sum = 0;

            if (N >= 1 && N <= 1024 &&  K <= N)
            {

                int[] sequence = new int[N];
                Console.WriteLine("Enter the values in the array");
                for (int i = 0; i < N; i++)
                {
                    sequence[i] = int.Parse(Console.ReadLine());
                }

                max_value = sequence[0];

                for (int i = 0; i < K; i++)
                {
                    for (int j = i; j < N; j++)
                    {
                        if (sequence[j] > max_value)
                        {
                            max_value = sequence[j];
                            index = j;
                        }

                    }
                    checked
                    {
                    sum += max_value;
                    }

                    sequence[index] = sequence[i];
                    sequence[i] = max_value;
                    max_value = int.MinValue;
                }
                Console.WriteLine(sum);


            }
            else
            {
                Console.WriteLine("PLease insert numbers from 1 to 1024 for N and K<=N");
            }



        }
    }
}
