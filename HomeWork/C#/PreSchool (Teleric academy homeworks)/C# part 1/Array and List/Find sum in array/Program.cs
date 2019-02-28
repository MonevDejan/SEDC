using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_sum_in_array
{
    class Program
    {
        static void Main()
        {
            /*Write a program that finds in given array of integers a sequence of given sum S (if present).*/

            Console.WriteLine("Enter the size of the array and the sum, N= , s= ");
            int N = int.Parse(Console.ReadLine());
            int S = int.Parse(Console.ReadLine());
            int sum = 0;
            bool x = true;

            if (1 <= N && N <= 1024)
            {
                int[] sequence = new int[N];
                Console.WriteLine("Enter the values in the array");
                for (int i = 0; i < N; i++)
                {
                    sequence[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < N ; i++)
                {
                    for (int j = i; j < N; j++)
                    {
                        checked
                        {
                            sum += sequence[j];
                        }
                        if (sum == S)
                        {
                            for (int z = i; z <= j; z++)
                            {
                                Console.Write("{0}, ", sequence[z]);
                            }
                            Console.WriteLine();
                            x = false;

                        }
                        if (sum > S)
                        {
                            sum = 0;
                            break;
                        }
                    }
                }
                if (x == true)
                {
                    Console.WriteLine("There is no such a sum");
                }
            }
            else
            {
                Console.WriteLine("YOU ARE DOOMED!!!");
            }
        }
    }
}
