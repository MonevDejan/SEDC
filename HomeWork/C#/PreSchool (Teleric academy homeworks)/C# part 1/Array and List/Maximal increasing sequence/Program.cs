using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximal_increasing_sequence
{
    class Program
    {
        static void Main()
        {

            /* Write a program that finds the length of the maximal increasing sequence in an array of N integers. 
             1 <= N <= 1024 */
            Console.WriteLine("Enter the size of the array, N= ");
            int N = int.Parse(Console.ReadLine());
            int counter = 1;
            int counter1 = 1;

            if (1 <= N && N <= 1024)
            {
                int[] sequence = new int[N];
                Console.WriteLine("Enter the values in the array");
                for (int i = 0; i < N; i++)
                {
                    sequence[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < N - 1; i++)
                {
                    if (sequence[i] < sequence[i + 1])
                    {
                        counter++;
                    }
                    else
                    {
                        if (counter1 < counter)
                        {
                            counter1 = counter;
                        }
                        counter = 1;
                    }

                }
                // IF the last element is within the sequence, we need another "if"
                if (counter1 < counter)
                {
                    counter1 = counter;
                }
                Console.WriteLine(counter1);

            }
            else
            {
                Console.WriteLine("Uhh Ohh");
            }


        }
    }
}
